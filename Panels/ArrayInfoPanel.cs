using System.Windows.Forms;

namespace KursOOP
{
    public partial class ArrayInfoPanel : Form, IContentPanel
    {
        private Control.ControlCollection root; // Панель-контейнер из главной формы

        private ArrayInfoPanel() { /* Don`t call without root Panel */ }

        // Конструктор панели
        public ArrayInfoPanel(Control.ControlCollection root)
        {
            InitializeComponent();
            this.root = root;
        }

        // Реализация метода прикрепления
        public void Attach()
        {
            // Получение экземпляра репозитория
            EntityManager manager = EntityManager.GetInstance();
            // Получение готовых параметров репозитория и заготовка нескольких
            // переменных для дальнейших расчётов...
            int freeCount = manager.GetFreeCount();
            int totalCount = manager.GetCount();
            int triangleCount = 0;
            int rhombusCount = 0;
            int circleCount = 0;

            // Цикл для расчёта колличества объектов каждого типа
            for (int i = 0; i < manager.GetCount(); i++)
            {
                Figure figure = manager.Get(i);
                switch (figure)
                {
                    case Circle _:
                        circleCount++;
                        break;
                    case Rhombus _:
                        rhombusCount++;
                        break;
                    case Triangle _:
                        triangleCount++;
                        break;
                }
            }

            // Вывод информации в поля панели.. 
            BusyCount.Text = (totalCount - freeCount).ToString();
            FreeCount.Text = freeCount.ToString();
            TotalCount.Text = totalCount.ToString();
            TriangleCount.Text = triangleCount.ToString();
            RhombusCount.Text = rhombusCount.ToString();
            CircleCount.Text = circleCount.ToString();

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
