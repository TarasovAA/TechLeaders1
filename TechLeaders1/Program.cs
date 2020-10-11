using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLeaders1.Figures;

namespace TechLeaders1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>();

            figures.Add(new Square(1));
            figures.Add(new Rectangle(2, 4));
            figures.Add(new Сircle(3));
            figures.Add(new Triangle(3, 4, 5));
            figures.Add(new Trapezoid(1, 3, 2, 2)); 


            double sumS = 0;
            double sumP = 0;
            foreach (var f in figures)
            {
                Console.WriteLine(f.ShowInfo());
                sumS += f.S();
                sumP += f.P();
            }
            
            Console.WriteLine("Общий периметр: {0}, Общая площадь: {1}", sumP, sumS);
            Console.ReadKey();
            Console.Clear();

            sumS = 0;
            sumP = 0;
            (figures[0] as Square).Side = 2;
            foreach (var f in figures)
            {
                Console.WriteLine(f.ShowInfo());
                sumS += f.S();
                sumP += f.P();
            }
            Console.WriteLine("Общий периметр: {0}, Общая площадь: {1}", sumP, sumS);
            Console.ReadKey();
        }
    }
}
