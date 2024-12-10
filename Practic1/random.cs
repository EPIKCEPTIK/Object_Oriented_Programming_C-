using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practika_1
{
    internal class random
    {
        static public int[] rand(int[] array, int size)
        {
            Random rand = new Random();


            for (int i = 0; i < size; i++)
            {
                int number = rand.Next(30);
                array[i] = number;
            }
            return array;
        }
    }
}
