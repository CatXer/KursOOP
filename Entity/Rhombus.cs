using System;

namespace KursOOP
{
    public class Rhombus : Figure
    {
        private double d1, d2;


        public Rhombus() : base("Rhombus")
        {
            d1 = 10;
            d2 = 14;
        }

        public Rhombus(double d1, double d2) : base("Rhombus")
        {
            this.d1 = d1;
            this.d2 = d2;
        }


        public double getD1()
        {
            return d1;
        }

        public double getD2()
        {
            return d2;
        }


        public void setD1(double d1)
        {
            this.d1 = d1;
        }

        public void setD2(double d2)
        {
            this.d2 = d2;
        }


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
