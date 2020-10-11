using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechLeaders1.Figures
{
    public class Triangle : Figure
    {
        double a=0;
        double b=0;
        double c=0;

        public double AB
        {
            get { return a; }
            set
            {
                BasicExerption(value, out a);
                isTriamgle();
            }
        }

        protected void isTriamgle()
        {
            if (a != 0 && b != 0 && c != 0)
               if(a+b<=c || a+c<=b || c+b<=a)
                {
                    throw new Exception("Введённые числа не являются треугольником");
                }
           
        }

        public double BC
        {
            get { return b; }
            set
            {
                BasicExerption(value, out b);
                isTriamgle();
            }
        }

        public double CA
        {
            get { return c; }
            set
            {
                BasicExerption(value, out c);
                isTriamgle();
            }
        }

        public Triangle(int a, int b, int c)
        {
            AB = a;
            BC = b;
            CA = c;
        }

        public override double P()
        {
            return a + b + c;
        }

        public override double S()
        {
            double p = P() / 2.0;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }

        public override string ShowInfo()
        {
            return "Трапеция: AB =" + a + ", BC = " + b + ", CA =" + c  + ", P = " + P() + ", S = " + S() +";";
        }
    }
}
