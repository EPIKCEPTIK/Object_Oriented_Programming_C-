using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practika_1
{
    public class task1:Task
    {
        public override void Run()
        {

            int size = 3;
            int[] numbers = new int[size];
            random.rand(numbers, size);


            foreach (int i in numbers)
            {
                if (i >= 1 && i <= 16)
                    Console.WriteLine(i);
            }
        }
    }
}
