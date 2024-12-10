using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practika_1
{
    internal class task3:Task
    {
        public override void Run()
        {
            int size = 16;
            int[] array = new int[size];
            array = random.rand(array, size);
            for (int i = 0; i < size; ++i)
            {
                Console.Write(array[i] + "  ");
            }
            int Max = array[0];
            int Min = array[0];
            foreach (int i in array)
            {

                if (Max < i)
                {
                    Max = i;
                }
                if (Min > i)
                {
                    Min = i;
                }

            }
            Console.WriteLine("\n" + "Найбільше значення: " + Max);
            Console.WriteLine("Найменьше значення: " + Min);
        }
    }
}
