using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //右側對齊星形三角形
            for (int i = 4; i >= 0; i--)
            {
                string value = new string(' ', i) + new string('*', 5 - i);
                Console.WriteLine(value);
            }
            ////右側對齊星形三角形2
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = i + 1; j <= 5; j++)
            //    {
            //        Console.Write(' ');
            //    }
            //    for (int j = i + 4; j >= 5; j--)
            //    {
            //        Console.Write('*');
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
