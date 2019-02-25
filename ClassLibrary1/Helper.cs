using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Helper
    {
        static public int Minvalue(int a, int b, int c)
        {
            if (a < b && a < c)
            {
                return a;
            }
            else if (b < c)
            {
                return b;
            }
            else
            {
                return c;
            }

        }

    }

    public class Sumnumber
    {
        static public long Sum(long a)               // нерекурсивный метод
        {
            long s = 0;
            while (a > 0)                  // пока a больше нуля
            {
                s = s + a % 10;          // добавляем к сумме последнюю цифру числа а
                a = a / 10;              // отбрасываем от числа а последнюю цифру
            }
            return s;                     // возвращаем в качестве результата сумму цифр числа a
        }
    }
    public class Evennumber
    {

        static bool Odd(int a)
        {
            return a % 2 == 0;
        }
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Введите целое число.");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x + " - " + ((Odd(x)) ? "четное число" : "нечетное число"));
            Console.WriteLine("Для выхода из приложение нажмите Enter");
            Console.ReadKey();
        }

    }
}
