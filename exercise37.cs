using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("daj stringa");
            string a = Console.ReadLine();

            Console.WriteLine(metoda(a));

            Console.ReadKey();
        }
        public static string metoda(string a)
        {
            string result = string.Empty;
            string result2 = string.Empty;
            string result3 = string.Empty;


            for (int i = 0; i < a.Length; i += 4)
            {
                result += a[i];

            }
            for (int j = 1; j < a.Length; j += 4)
            {
                result2 += a[j];
            }


            for (int k = 0; k < result.Length; k++)
            {
                result3 += result[k];
                result3 += result2[k];

            }
            return result3;

        }

    }
}
