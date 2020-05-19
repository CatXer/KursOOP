using System;

namespace KursOOP
{
    public class Circle : Figure // Описание класса Окружность
    {
        // Приватные поля..
        private double radius;

        // Конструктор без параметров
        public Circle() : base("Окружность")
        {
            radius = 5;
        }

        // Конструктор с параметрами
        public Circle(double radius) : base("Окружность")
        {
            this.radius = radius;
        }

        // Геттеры и Сеттеры для приватных полей
        public double GetRadius()
        {
            return radius;
        }

        public void SetRadius(double radius)
        {
            this.radius = radius;
        }

        // Определённые и переопределённые методы..
        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        public double Diametre()
        {
            return radius * 2;
        }
    }
}
