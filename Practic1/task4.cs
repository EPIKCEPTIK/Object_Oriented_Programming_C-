using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practika_1
{
    internal class task4:Task
    {
        public override void Run()
        {
            int size = 16;
            int[] arrayA = new int[size];
            arrayA = random.rand(arrayA, size);
            List<int> arrayB = new List<int>();
            Console.WriteLine("Введіть M:");
            int M = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < size; ++i)
            {
                if (Math.Abs(arrayA[i]) > M)
                {
                    arrayB.Add(arrayA[i]);
                }
            }
            Console.WriteLine("Масив А: ");
            for (int i = 0; i < size; ++i)
            {
                Console.Write(arrayA[i] + "  ");
            }
            Console.WriteLine("\n" + "Масив B: ");
            for (int i = 0; i < arrayB.Count; ++i)
            {
                Console.Write(arrayB[i] + "  ");
            }
            Console.WriteLine("\n" + "Число М: " + M);
        }
    }
}
