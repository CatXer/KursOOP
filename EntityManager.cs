namespace KursOOP
{
    class EntityManager
    {
        private static EntityManager instance = null;
        private Figure[] Figures;
        private int SelectedIndex = -1;

        private EntityManager()
        {

        }

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


        public int GetCount()
        {
            return Figures.Length;
        }

        public int GetFreeCount()
        {
            int freeCount = 0;
            foreach (Figure f in Figures)
                freeCount += (f is null) ? 1 : 0;
            return freeCount;
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
        public int GetSelectedIndex()
        {
            return this.SelectedIndex;
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
