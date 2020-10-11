using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechLeaders1.Figures
{
    public class Сircle : Figure
    {
        double _radius;
        public double Radius
        {
            get { return _radius; }
            set
            {
                BasicExerption(value, out _radius);
            }
        }

       

        public Сircle(double radius)
        {
            Radius = radius;
        }

        public override double P()
        {
            return 2 * _radius * Math.PI;
        }

        public override double S()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        public override string ShowInfo()
        {
            return "Круг: Radius = " +Radius + ", P = " + P() + ", S = " + S() + ";";
        }
    }
}
