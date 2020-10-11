using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechLeaders1.Figures
{
    public class Square : Figure
    {
        double _side;
        public double Side
        {
            get { return _side; }
            set
            {
               BasicExerption(value, out _side);
            }
        }

        public Square(double side)
        {
            Side = side;
        }

        public override double P()
        {
            return _side * 4;
        }

        public override double S()
        {
            return _side * _side;
        }

        public override string ShowInfo()
        {
            return "Квадрат: Side = " + _side + ", P = " + P() + ", S = " + S() + ";";
        }
    }
}
