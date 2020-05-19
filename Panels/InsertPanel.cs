using System;
using System.Windows.Forms;

namespace KursOOP
{
    public partial class InsertPanel : Form, IContentPanel
    {
        private Control.ControlCollection root; // Панель-контейнер из главной формы
        private RootForm form; // Поле главной формы для возможности обновления её интерфейса
        private Figure NewFigure; // Ссылка на выбранный/активный объект фигуры
        private bool EditAvailable; // Флаг режима работы панели (Добавление/редактирование)

        private InsertPanel() { /* Don`t call without root Panel */ }

        // Конструктор панели
        public InsertPanel(RootForm form, Control.ControlCollection root, bool editAvailable)
        {
            InitializeComponent();
            this.form = form;
            this.root = root;
            this.EditAvailable = editAvailable;
        }

        // Реализация метода прикрепления
        public void Attach()
        {
            // Получение активного элемента из репозитория
            NewFigure = EntityManager.GetInstance().GetSelected();
            // Установка начального состояния всех визуальных элементов
            LabelType.Text = "Выберите тип объекта";
            RbCircle.Checked = false;
            RbRhombus.Checked = false;
            RbTriangle.Checked = false;
            Param1.Hide();
            Param2.Hide();
            InpParam1.Hide();
            InpParam2.Hide();
            BtSave.Enabled = false;
            // Если объкт был с флагом редактирования, то происходит  
            // выбор cоответствующего CheckBox
            if (EditAvailable && NewFigure != null)
            {
                switch (NewFigure)
                {
                    case Circle _:
                        RbCircle.Checked = true;
                        break;
                    case Rhombus _:
                        RbRhombus.Checked = true;
                        break;
                    case Triangle _:
                        RbTriangle.Checked = true;
                        break;
                }
            }
            // Добавление главной панели в контейнер
            root.Add(MainPanel);
        }

        // Реализация метода открепления
        public void Dettach()
        {
            // Удаление главной панели из контейнера
            root.Remove(MainPanel);
        }

        // Реализация метода получения контента фрейма (Controil)
        public Control GetMainPanel()
        {
            return MainPanel;
        }

        // Обработка изменения состояния чекбокса - "Треугольник"
        private void RbTriangle_CheckedChanged(object sender, System.EventArgs e)
        {
            // Если именно выбран..
            if (RbTriangle.Checked)
            {
                // Подготовка элеметов интерфейса под объект типа Triangle
                BtSave.Enabled = true;

                Param1.Show();
                Param2.Show();
                InpParam1.Show();
                InpParam2.Show();

                // Label переименовываются под данные Triangle
                Param1.Text = "Основание";
                Param2.Text = "Высота";
                InpParam1.Enabled = true;
                InpParam2.Enabled = true;

                // Если фигура не была Triangle
                if (NewFigure is null || NewFigure.GetType() != typeof(Triangle))
                    NewFigure = new Triangle();// То создаётся новый объект
                LabelType.Text = NewFigure.GetName();
                InpParam1.Text = ((Triangle)NewFigure).GetBase().ToString();//и в поле заносится сторона треугольника
                InpParam2.Text = ((Triangle)NewFigure).GetHeight().ToString();
            }
        }

        // Обработка изменения состояния чекбокса - "Ромб"
        private void RbRhombus_CheckedChanged(object sender, System.EventArgs e)
        {
            if (RbRhombus.Checked)
            {
                BtSave.Enabled = true;

                Param1.Show();
                Param2.Show();
                InpParam1.Show();
                InpParam2.Show();

                Param1.Text = "Первая диагональ";
                Param2.Text = "Вторая диагональ";
                InpParam1.Enabled = true;
                InpParam2.Enabled = true;

                if (NewFigure is null || NewFigure.GetType() != typeof(Rhombus))
                    NewFigure = new Rhombus();
                LabelType.Text = NewFigure.GetName();
                InpParam1.Text = ((Rhombus)NewFigure).GetD1().ToString();
                InpParam2.Text = ((Rhombus)NewFigure).GetD2().ToString();
            }
        }

        // Обработка изменения состояния чекбокса - "Окружность"
        private void RbCircle_CheckedChanged(object sender, System.EventArgs e)
        {
            if (RbCircle.Checked)
            {
                BtSave.Enabled = true;

                Param1.Show();
                Param2.Hide();
                InpParam1.Show();
                InpParam2.Hide();

                Param1.Text = "Радиус";
                InpParam1.Enabled = true;

                if (NewFigure is null || NewFigure.GetType() != typeof(Circle))
                    NewFigure = new Circle();
                LabelType.Text = NewFigure.GetName();
                InpParam1.Text = ((Circle)NewFigure).GetRadius().ToString();
            }
        }

        // Обработка нажатия на кнопку "Сохранить"
        private void BtSave_Click(object sender, System.EventArgs e)
        {
            EntityManager manager = EntityManager.GetInstance();

            try
            {
                if (manager.IsSelected())
                {



                    if (EditAvailable && manager.GetSelected() is null)
                    {
                        MessageBox.Show("Не удалось обновить объект, ячейка пуста!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!EditAvailable && manager.GetSelected() != null)
                    {
                        MessageBox.Show("Не удалось разместить объект, ячейка занята!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        switch (NewFigure)
                        {
                            case Circle c:
                                {
                                    c.SetRadius(Convert.ToDouble(InpParam1.Text));
                                }
                                break;
                            case Rhombus r:
                                {
                                    r.SetD1(Convert.ToDouble(InpParam1.Text));
                                    r.SetD2(Convert.ToDouble(InpParam2.Text));
                                }
                                break;
                            case Triangle t:
                                {
                                    t.SetBase(Convert.ToDouble(InpParam1.Text));
                                    t.SetHeight(Convert.ToDouble(InpParam2.Text));
                                }
                                break;
                            default:
                                break;
                        }
                        manager.InsertIntoSelected(NewFigure);
                    }
                }
                else
                {
                    MessageBox.Show("Вы не выбрали элемент..", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Вы ввели некорректные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            form.UpdateUI();
            Dettach();
        }
    }
}
