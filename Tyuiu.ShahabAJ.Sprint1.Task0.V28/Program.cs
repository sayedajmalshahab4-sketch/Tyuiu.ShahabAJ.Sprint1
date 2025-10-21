using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShahabAJ.Sprint1.Task0.V28.Lib;

namespace Tyuiu.ShahabAJ.Sprint1.Task0.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* 48 / 12 - 48 / 6 / 4                                                   *");
            Console.WriteLine("*************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("*************************");
            Console.WriteLine("* " + ds.Calculate() + "                                                                 *");
            Console.WriteLine("*************************");
            Console.ReadKey();
        }
    }
}