namespace KursOOP
{
    public abstract class Figure//базовый абстрактный класс фигуры
    {
        private string name;
        public Figure()//конструктор без параметров
        {
            setName("Figure");
        }
        public Figure(string name)//конструктор с параметрами
        {
            setName(name);
        }
        public string getName()//методы get и set для закрытого поля класса
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        abstract public double Area();//абстрактный метод вычисления площади фигуры
    }
}
