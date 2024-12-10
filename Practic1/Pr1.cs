using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practika_1
{
    
    public class Practic1
    {
        static void Practic()
        {

            List<Task> tasks = new List<Task>
        {
            new task1(),
            new task2(),
            new task3(),
            new task4()
        };


            foreach (var task in tasks)
            {
                task.Run();
            }
        }

    }
        
    
    
}
