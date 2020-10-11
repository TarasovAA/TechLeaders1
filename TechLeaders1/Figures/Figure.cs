using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechLeaders1.Figures
{
    public abstract class Figure
    {
        public abstract double S();

        public abstract double P();

        protected void BasicExerption(double value, out double _radius)
        {
            if (value > 0)
            {
                _radius = value;
            }
            else
            {
                throw new Exception("Число не может быть отрицательным");
            }        
        }

        public virtual string ShowInfo()
        {
            return "О данной фишуре нету никакой информации";
        }
    }
}
