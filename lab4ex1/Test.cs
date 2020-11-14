using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4ex1
{
    class Utils 
    {
        public static int Greater(int a, int b )
        {
            if (a > b)
              return a;          
            else
              return b;
        }
    }
    class Test
    {
        static void Main()
        {
            Console.WriteLine("ВВеди х");
            string x1 = Console.ReadLine();
            int x = int.Parse(x1);
            Console.WriteLine("Введи у");
            int y = int.Parse(Console.ReadLine());
            int greater;
            greater = Utils.Greater(x,y);
            Console.WriteLine("Большее из двух чисел "+greater);
            Console.ReadKey();
        }
    }
}
