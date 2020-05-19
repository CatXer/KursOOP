using System;

namespace KursOOP
{
    public class Rhombus : Figure // Описание класса Ромб
    {
        // Приватные поля..
        private double d1, d2;

        // Конструктор без параметров
        public Rhombus() : base("Ромб")
        {
            d1 = 10;
            d2 = 14;
        }

        // Конструктор с параметрами
        public Rhombus(double d1, double d2) : base("Ромб")
        {
            this.d1 = d1;
            this.d2 = d2;
        }

        // Геттеры и Сеттеры для приватных полей
        public double GetD1()
        {
            return d1;
        }

        public double GetD2()
        {
            return d2;
        }

        public void SetD1(double d1)
        {
            this.d1 = d1;
        }

        public void SetD2(double d2)
        {
            this.d2 = d2;
        }

        // Определённые и переопределённые методы..
        public double Perimeter()
        {
            return 4 * Math.Sqrt((d1 * d1 + d2 * d2) / 4);
        }

        public override double Area()
        {
            return 0.5 * d1 * d2;
        }
    }
}
