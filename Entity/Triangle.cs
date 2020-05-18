using System;

namespace KursOOP
{
    public class Triangle : Figure
    {

        private double Base, height;

        public Triangle() : base("Треугольник")
        {
            Base = 6;
            height = 8;
        }

        public Triangle(double Base, double height) : base("Triangle")
        {
            this.Base = Base;
            this.height = height;
        }

        public double getBase()
        {
            return Base;
        }

        public double getHeight()
        {
            return height;
        }

        public void setBase(double s)
        {
            Base = s;
        }

        public void setHeight(double s)
        {
            height = s;
        }

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
