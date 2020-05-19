using System;

namespace KursOOP
{
    public class Triangle : Figure // Описание класса Треугольник
    {
        // Приватные поля..
        private double Base, height;

        // Конструктор без параметров
        public Triangle() : base("Треугольник")
        {
            Base = 6;
            height = 8;
        }

        // Конструктор с параметрами
        public Triangle(double Base, double height) : base("Треугольник")
        {
            this.Base = Base;
            this.height = height;
        }

        // Геттеры и Сеттеры для приватных полей
        public double GetBase()
        {
            return Base;
        }

        public double GetHeight()
        {
            return height;
        }

        public void SetBase(double Base)
        {
            this.Base = Base;
        }

        public void SetHeight(double height)
        {
            this.height = height;
        }

        // Определённые и переопределённые методы..
        public override double Area()
        {
            return Base * height / 2;
        }

        public double Perimeter()
        {
            return Math.Sqrt(Math.Pow(Base / 2.0, 2) + height * height) + height + Base;
        }
    }
}
