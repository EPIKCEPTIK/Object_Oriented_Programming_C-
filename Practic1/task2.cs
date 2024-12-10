using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practika_1
{
    internal class task2:Task
    {
        public int Triange(int triangle)
        {
            int temp = (int)Math.Pow(triangle, 2);
            return temp;
        }
        public double SquareTriangle(int[] triangle, double p)
        {
            double s = 1;
            foreach (double i in triangle)
            {
                s *= (p - i);

            }
            s = Math.Sqrt(p * s);
            return s;
        }
        public override void Run() 
        {

            int size = 3;
            int[] triange = new int[size];
            triange = random.rand(triange, size);

            foreach (int i in triange)
            {
                Console.WriteLine(i);

            }
            int temp = 0;
            for (int i = 0; i < 3; ++i)
            {
                temp += Triange(triange[i]);
            }
            if (temp - Math.Pow(triange[2], 2) > Math.Pow(triange[2], 2) && temp - Math.Pow(triange[1], 2) > Math.Pow(triange[1], 2) && temp - Math.Pow(triange[0], 2) > Math.Pow(triange[0], 2))
            {
                Console.WriteLine("Такий трикутник існує");
                double per = 0;
                foreach (int i in triange)
                {
                    Console.WriteLine(i);
                    per += i;
                }

                double p = per / 2;
                double s = SquareTriangle(triange, p);

                Console.WriteLine("Площа трикутника: " + s);
                Console.WriteLine("Периметр трикутника: " + per);
                if (triange[0] == triange[1] && triange[1] == triange[2])
                {
                    Console.WriteLine("Цей трикутник - рівносторонній");

                }
                if (triange[0] != triange[1] && triange[1] != triange[2])
                {
                    Console.WriteLine("Цей трикутник - різносторонній");
                }
                else
                {
                    Console.WriteLine("Цей трикутник - рівнобедреннний");
                }
            }
            else
            {
                Console.WriteLine("Такий трикутник не існує");
            }
        }
    }
}
