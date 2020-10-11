using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechLeaders1.Figures
{
    public class Rectangle : Figure
    {
        double _height;
        double _width;

        public double Height
        {
            get { return _height; }
            set { BasicExerption(value, out _height); }
        }
        public double Width
        {
            get { return _width; }
            set { BasicExerption(value, out _width); }
        }

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public override double P()
        {
            return 2 * (_height + _width);
        }

        public override double S()
        {
            return _height * _width;
        }

        public override string ShowInfo()
        {
            return "Прямоугольник: Height =" + Height + ", Width = " + Width + ", P = " + P() + ", S = " + S() +";";
        }
    }
}
