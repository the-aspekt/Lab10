using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Angle angle = new Angle();
            Console.WriteLine("Данная программа переведет введенный угол в радианы.");
            try
            {
                Console.WriteLine("Введите градусы");
                angle.Gradus = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите минуты");
                angle.Min = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите секунды");
                angle.Sec = Convert.ToInt32(Console.ReadLine());
                angle.ToRadians();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message) ;
            }

            Console.ReadKey();
        }
    }
}
