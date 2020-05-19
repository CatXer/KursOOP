using System;

namespace KursOOP
{
    public class Circle : Figure // Описание класса Окружность
    {
        //Автосвойства ввода и вывода полей
        public double Radius { get; set; }

        // Конструктор без параметров
        public Circle() : base("Окружность")
        {
            Radius = 5;
        }

        // Конструктор с параметрами
        public Circle(double radius) : base("Окружность")
        {
            this.Radius = radius;
        }

        // Определённые и переопределённые методы..
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public double Diametre()
        {
            return Radius * 2;
        }
    }
}
