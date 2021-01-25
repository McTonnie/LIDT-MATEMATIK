using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIDT_MATEMATIK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Intast det første tal");
            double tal1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Intast det andet tal");
            double tal2 = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine(tal1 + "+" + tal2 + " = " + (tal1 + tal2));
            Console.WriteLine();
            Console.WriteLine(tal1 + "/" + tal2 + " = " + (tal1 / tal2));
            Console.WriteLine();
            Console.WriteLine(tal1 + "^" + tal2 + " = " + Math.Pow(tal1, tal2));






            Console.ReadLine();

        }
    }
}
