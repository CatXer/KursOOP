namespace KursOOP
{
    public abstract class Figure// Базовый абстрактный класс фигуры
    {
        public string Name { get; set; } // Автосвойства ввода и вывода полей

        public Figure()// Конструктор без параметров
        {
            Name = "Figure";
        }

        public Figure(string name)// Конструктор с параметрами
        {
            Name = name;
        }

        abstract public double Area();// Абстрактный метод вычисления площади фигуры
    }
}
