using System;

namespace KursOOP
{
    public class Triangle : Figure // Описание класса Треугольник
    {

        // Автосвойства ввода и вывода полей
        public double Base { get; set; }
        public double Height { get; set; }

        // Конструктор без параметров
        public Triangle() : base("Треугольник")
        {
            Base = 6;
            Height = 8;
        }

        // Конструктор с параметрами
        public Triangle(double Base, double height) : base("Треугольник")
        {
            this.Base = Base;
            this.Height = height;
        }

        // Определённые и переопределённые методы..
        public override double Area()
        {
            return Base * Height / 2;
        }

        public double Perimeter()
        {
            return Math.Sqrt(Math.Pow(Base / 2.0, 2) + Height * Height) + Height + Base;
        }
    }
}
