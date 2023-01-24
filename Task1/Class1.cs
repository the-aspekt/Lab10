using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Angle
    {
        int gradus, min, sec;

        public int Gradus
        { 
            get 
            { 
                return gradus; 
            }
            set 
            {
                
                gradus = value % 360;
            }
        }
        public int Min
        {
            get 
            { 
                return min;
            }
            set 
            {
                Gradus += Math.Sign(gradus)*value / 60;
                min = value % 60;
            }
        } 
        public int Sec
        { 
            get 
            {
                return sec;
            } 
            set
            {
                Min += Math.Sign(gradus) * value / 60;
                sec = value%60;
            }
        }

       /* public Angle (int gradus, int min, int sec)
        {
            this.gradus = gradus;
            this.min = min;
            this.sec = sec;
        }*/

        public void ToRadians()
        {
            double rad;
            rad = (gradus + Math.Sign(gradus) * min /60.0 + Math.Sign(gradus) * sec /3600.0)/180*Math.PI;
            Console.WriteLine("Угол равен {0} радианам",rad);
        }
        double ReturnInRadians()
        {
            double rad;
            rad = (gradus + Math.Sign(gradus) * min / 60.0 + Math.Sign(gradus) * sec / 3600.0) / 180 * Math.PI;
            return rad;
        }
        public void Print()
        {
            Console.WriteLine(@"Задан угол {0}°{1}'{2}''", gradus, min, sec);
        }
    }
}
