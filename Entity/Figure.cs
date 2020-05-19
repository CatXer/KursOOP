namespace KursOOP
{
    public abstract class Figure// Базовый абстрактный класс фигуры
    {
        private string name;

        public Figure()// Конструктор без параметров
        {
            SetName("Figure");
        }

        public Figure(string name)// Конструктор с параметрами
        {
            SetName(name);
        }
        
        public string GetName()// Методы get и set для закрытого поля класса
        {
            return name;
        }
        
        public void SetName(string name)
        {
            this.name = name;
        }

        abstract public double Area();// Абстрактный метод вычисления площади фигуры
    }
}
