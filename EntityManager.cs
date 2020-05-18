namespace KursOOP
{
    class EntityManager
    {
        private static EntityManager instance = null;
        private Figure[] Figures;
        private int SelectedIndex = -1;

        private EntityManager(int count)
        {
            Figures = new Figure[count];
        }

        public static EntityManager GetInstance(int count)
        {
            if (instance == null)
            {
                instance = new EntityManager(count);
            }
            return GetInstance();
        }

        public static EntityManager GetInstance()
        {
            return instance;
        }


        public int GetLength()
        {
            return Figures.Length;
        }

        public Figure Get(int i)
        {
            return Figures[i];
        }

        public void InsertIntoSelected(Figure figure)
        {
            Figures[SelectedIndex] = figure;
        }

        public void SetSelectedIndex(int index)
        {
            this.SelectedIndex = index;
        }

        public bool IsSelected()
        {
            return SelectedIndex > -1;
        }

        public Figure GetSelected()
        {
            return Get(SelectedIndex);
        }
    }
}
