using System;

namespace KursOOP
{
    public class Circle : Figure
    {
        private double radius;

        public Circle() : base("Circle")
        {
            radius = 5;
        }

        public Circle(double radius) : base("Circle")
        {
            this.radius = radius;
        }

        public double getRadius()
        {
            return radius;
        }

        public void setRadius(double s)
        {
            radius = s;
        }

       
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
