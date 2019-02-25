using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace csharp1_2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Введите число а:");
            int a;
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число b:");
            int b;
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число c:");
            int c;
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Минимальное число из трех значений:");
            Console.WriteLine(Helper.Minvalue(a, b, c));
            Console.ReadKey();


        }
    }
}

