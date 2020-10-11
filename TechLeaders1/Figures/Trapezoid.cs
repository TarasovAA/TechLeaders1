using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechLeaders1.Figures
{
    public class Trapezoid : Figure
    {
        double a=0; // 1 основвание
        double b=0; // 2 основание
        double c=0; // боковая сторона
        double d=0; // боковая сторона
        //double h;
        public double AB //основание a
        {
            get { return a; }  
            set
            {
                BasicExerption(value, out a);
                ABException();
            }
        }
        public double BC
        {
            get { return c; }
            set { BasicExerption(value, out c); }
        }
        public double CD  //основание b
        {
            get { return b; }
            set
            {
                BasicExerption(value, out b);
                ABException();
            }
        }
        public double DA
        {
            get { return d; }
            set { BasicExerption(value, out d); }
        }

        private void ABException()
        {
            if(a!=0 && b!=0)
            {
                if (a==b)
                {
                    throw new Exception("Основания AB и CD не могут быть равными");
                }
            }
        }

        public Trapezoid(double a, double b, double c, double d) 
        {
            AB = a;
            CD = b;
            BC = c;
            DA = d;
            //this.h = h;
        }

        public override double P()
        {
            return a + b + c + d;
        }

        public override double S() //формула для четырёх сторон
        {
            double arg = Math.Pow(c,2) - Math.Pow((Math.Pow( (b - a) , 2) + c * c - d * d) / (2.0 * (b - a)), 2);
            double arg1 =0.5 * (a + b) * Math.Sqrt(arg);
            return 0.5 * (a + b) * Math.Sqrt(arg);
        }

        public override string ShowInfo()
        {
            return "Трапеция: AB =" + a + ", BC = " + b + ", CD =" + c + ", DA= " + d + ", P= " + P() + ", S= " + S() + ";";
        }
    }
}
