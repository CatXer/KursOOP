using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KursOOP
{

    public partial class RootForm : Form
    {
        private enum Panels //Перечисление для переключения между панелям
        {
            elementInfo,
            edit,
            insert,
            arrayInfo
        }

        // Словарь с соответствиями Элемент перечисления - объект, реализующий интерфейс IContentPanel
        private IDictionary<Panels, IContentPanel> panels;
        // Контейнер для хранения объекта текущей панели
        private IContentPanel active;

        // Конструктор для инициализации..
        public RootForm()
        {
            InitializeComponent();
            // Создание и инициализация объекта словаря
            panels = new Dictionary<Panels, IContentPanel>()
            {
                {Panels.elementInfo, new ElementInfoPanel(ContentPanel.Controls)},
                {Panels.edit, new InsertPanel(this, ContentPanel.Controls, true)},
                {Panels.insert, new InsertPanel(this, ContentPanel.Controls, false)},
                {Panels.arrayInfo, new ArrayInfoPanel(ContentPanel.Controls)}
            };
        }

        internal void UpdateUI()// метод для обновления элементов пользовательского интерфейса 
        {
            int selected = MainList.SelectedIndex;
            MainList.Items.Clear();
            // Вызов Singleton объекта Менеджера фигур
            EntityManager manager = EntityManager.GetInstance();
            for (int i = 0; i < manager.GetCount(); i++)
            {
                Figure figure = manager.Get(i);

                // Дифференциация объектов по типу..
                string element = ":    -";
                switch (figure)
                {
                    case Circle _:
                        element = ":    +    3";
                        break;
                    case Rhombus _:
                        element = ":    +    2";
                        break;
                    case Triangle _:
                        element = ":    +    1";
                        break;
                }
                // Добавление строки в список
                MainList.Items.Add(i + element);
            }
            // Если ранее был выбран элемент, необходимо сохранить на нём фокус
            MainList.SetSelected((selected > 0) ? selected : 0, true);
        }

        private void Navigate(Panels type) // Метод, который выполняет процедуру навигации между панелями
        {
            // Если есть неоткреплённая панель, её необходимо откремить от панели-контейнера
            if (active != null && ContentPanel.Controls.Contains(active.GetMainPanel()))
            {
                active.Dettach();
            }
            // Приклепление новой панели к контейнеру
            active = panels[type];
            active.Attach();
        }

        private void BtCreateArray_Click(object sender, EventArgs e) // Обработка нажатия на кнопку "Задать Массив"
        {
            try
            {
                // Проверка на пустое поле ввода числа элементов
                if (!InpItemCount.Text.Equals(""))
                {
                    int count = Convert.ToInt32(InpItemCount.Text);
                    // Если число отрицательное или равно 0, то вывод ошибки...
                    if (count <= 0) throw new FormatException();
                    // Инициализация Singleton объекта-репозитория объетов фигур
                    EntityManager.GetInstance(count);

                    // Активация всего интерфейса (Всё корректно и ошибок нет)
                    InpItemCount.Enabled = false;
                    BtCreateArray.Enabled = false;
                    BtArrayInfo.Enabled = true;
                    InpIndex.Enabled = true;
                    // Вызов детального обновления интерфейса (MainList)
                    UpdateUI();
                }
                else // Вывод предупреждения
                {
                    MessageBox.Show("Вы не ввели длину массива..", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException) // Если внутри Try произошла ошибка конвертации
            {
                MessageBox.Show("Длинна должна быть только из одного числа [0-9]!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                InpItemCount.Text = "";
                InpItemCount.Focus();
            }
        }

        private void BtArrayInfo_Click(object sender, EventArgs e) // Обработка нажатия на кнопку "Информация о массиве"
        {
            // Вызов метода навигации на соответствующий экран информации..
            Navigate(Panels.arrayInfo);
        }

        private void BtShowInfo_Click(object sender, EventArgs e) // Обработка нажатия на кнопку "Информация об элементе"
        {
            Navigate(Panels.elementInfo);
        }

        private void BtChangeObject_Click(object sender, EventArgs e) // Обработка нажатия на кнопку "Изменить объект"
        {
            Navigate(Panels.edit);
        }

        private void BtAddObject_Click(object sender, EventArgs e) // Обработка нажатия на кнопку "Добавить элемент"
        {
            Navigate(Panels.insert);
        }

        private void MainList_SelectedIndexChanged(object sender, EventArgs e) // Обработка смены выбранного элемента в списке
        {

            EntityManager manager = EntityManager.GetInstance();
            // Даём информацию о выбранном индексе в репозиторий..
            manager.SetSelectedIndex(MainList.SelectedIndex);

            if (!manager.IsSelected())// Редкое событие (потеря фокуса -> индекс -1)
            {
                // Всё управляющие элементы деактивируются
                InpIndex.Text = "";
                BtAddObject.Enabled = false;
                BtChangeObject.Enabled = false;
                BtShowInfo.Enabled = false;
            }
            else if (manager.GetSelected() is null) // Вариант при выборе вакантной ячейки
            {
                InpIndex.Text = MainList.SelectedIndex.ToString();
                BtAddObject.Enabled = true;
                BtChangeObject.Enabled = false;
                BtShowInfo.Enabled = false;
            }
            else // Вариант при выборе занятой ячейки
            {
                InpIndex.Text = MainList.SelectedIndex.ToString();
                BtAddObject.Enabled = false;
                BtChangeObject.Enabled = true;
                BtShowInfo.Enabled = true;
            }

        }

        // Метод, вызывающийся при изменении текста в TextBox InpIndex, который нужен для ввода индексов
        private void InpIndex_TextChanged(object sender, EventArgs e)
        {
            int index = -1;
            try
            {
                // Проверка на пустой ввод
                if (!InpIndex.Text.Equals(""))
                {
                    // Конвертация из строки TextBox в int
                    index = Convert.ToInt32(InpIndex.Text);
                    if (index < 0) // При отрицательном вводе
                    {
                        throw new IndexOutOfRangeException();
                    }
                    else if (index >= MainList.Items.Count) // При вводе несуществубщих индексов
                    {
                        throw new IndexOutOfRangeException();
                    }
                    else
                    {
                        // Успешный выбор элемента
                        MainList.SetSelected(index, true);
                    }
                }
                else
                {
                    // При вводе пустой строки список снимает выделение с элемента
                    MainList.ClearSelected();
                }
            }
            catch (FormatException)// Ошибка конвертации
            {
                MainList.ClearSelected();
                MessageBox.Show("Допускается вводить только натуральные числа или 0!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                InpIndex.Text = "";
                InpIndex.Focus();
            }
            catch (IndexOutOfRangeException)// Ошибка выхода за рамки массива (несуществующая ячейка)
            {
                MainList.ClearSelected();
                MessageBox.Show("Элемента с индексом = [" + index.ToString() + "] не существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                InpIndex.Text = "";
                InpIndex.Focus();
            }
        }
    }
}
