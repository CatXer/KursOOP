using System.Windows.Forms;

namespace KursOOP
{
    public partial class ElementInfoPanel : Form, IContentPanel
    {
        private Control.ControlCollection root; // Панель-контейнер из главной формы

        private ElementInfoPanel() { /* Don`t call without root Panel */ }
       
        // Конструктор панели
        public ElementInfoPanel(Control.ControlCollection root)
        {
            InitializeComponent();
            this.root = root;
        }
       
        // Реализация метода прикрепления
        public void Attach()
        {
            // Получение экземпляра репозитория
            EntityManager manager = EntityManager.GetInstance();
            // Получение выбраной фигуры
            Figure selected = manager.GetSelected();



            // Предварительно скрываем остальные поля
            // для дальнейшего выборочного заполнения
            Param1.Hide();
            Param2.Hide();
            ValParam1.Hide();
            ValParam2.Hide();
            Area.Hide();
            ValArea.Hide();
            Addition.Hide();
            ValAddition.Hide();

            // Установка общих свединий в TextBox`ы (на уровне Figure без Upcast)
            Index.Text = manager.GetSelectedIndex().ToString();
            ElementName.Text = selected.GetName();
            LabelType.Text = selected.GetName();
            // Площадь так-же расчитывается на уровне Figure
            Area.Show();
            Area.Text = "Площадь: ";
            ValArea.Show();
            ValArea.Text = string.Format("{0:0.000}", selected.Area());


            // Стандартный switch для поиска соответствия типа
            switch (selected)
            {
                case Circle c:
                    {
                        // Показываются необходимые поля для окружности 
                        Param2.Show();
                        // Заносятся уже специфичные значения полей объекта (только для Cicle)
                        Param2.Text = "Радиус: ";
                        ValParam2.Show();
                        // Во избежание поехавших строк за frame width используется общее фоматирование
                        ValParam2.Text = string.Format("{0:0.000}", c.GetRadius().ToString());
                        // Аналогично, только с результатами методов...
                        Addition.Show();
                        Addition.Text = "Диаметр: ";
                        ValAddition.Show();
                        ValAddition.Text = string.Format("{0:0.000}", c.Diametre().ToString());
                    }
                    break;
                case Rhombus r:
                    {
                        Param1.Show();
                        Param1.Text = "Первая диагональ: ";
                        Param2.Show();
                        Param2.Text = "Вторая диагональ: ";
                        ValParam1.Show();
                        ValParam1.Text = string.Format("{0:0.000}", r.GetD1());
                        ValParam2.Show();
                        ValParam2.Text = string.Format("{0:0.000}", r.GetD2());


                        Addition.Show();
                        Addition.Text = "Периметр: ";
                        ValAddition.Show();
                        ValAddition.Text = string.Format("{0:0.000}", r.Perimeter());
                    }
                    break;
                case Triangle t:
                    {
                        Param1.Show();
                        Param1.Text = "Основание: ";
                        Param2.Show();
                        Param2.Text = "Высота: ";
                        ValParam1.Show();
                        ValParam1.Text = string.Format("{0:0.000}", t.GetBase());
                        ValParam2.Show();
                        ValParam2.Text = string.Format("{0:0.000}", t.GetHeight());

                        Addition.Show();
                        Addition.Text = "Периметр: ";
                        ValAddition.Show();
                        ValAddition.Text = string.Format("{0:0.000}", t.Perimeter());
                    }
                    break;
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
    }
}
