using System;

namespace KursOOP
{
    public class Rhombus : Figure // Описание класса Ромб
    {
        // Автосвойства ввода и вывода полей
        public double D1 { get; set; }
        public double D2 { get; set; }

        // Конструктор без параметров
        public Rhombus() : base("Ромб")
        {
            D1 = 10;
            D2 = 14;
        }

        // Конструктор с параметрами
        public Rhombus(double d1, double d2) : base("Ромб")
        {
            D1 = d1;
            D2 = d2;
        }

        // Определённые и переопределённые методы..
        public double Perimeter()
        {
            return 4 * Math.Sqrt((D1 * D1 + D2 * D2) / 4);
        }

        public override double Area()
        {
            return 0.5 * D1 * D2;
        }
    }
}
