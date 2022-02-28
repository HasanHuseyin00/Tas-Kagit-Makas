using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
        a:
            Console.Clear();
            Console.WriteLine("1-Tas");
            Console.WriteLine("2-Kagıt");
            Console.WriteLine("3-Makas");
            Console.Write("Birini Seciniz:");
            int x = Convert.ToInt32((Console.ReadLine()));
            Random rndm = new Random();
            int y = rndm.Next(1, 4);
            Console.WriteLine("Bilgisayar Secimi:" + y);
            if (x == 1 && y == 1)
                Console.WriteLine("Berabere!");
            else if (x == 1 && y == 2)
                Console.WriteLine("Yenildiniz!");
            else if (x == 1 && y == 3)
                Console.WriteLine("Kazandınız!");
            else if (x == 2 && y == 1)
                Console.WriteLine("Kazandınız!");
            else if (x == 2 && y == 2)
                Console.WriteLine("Berabere!");
            else if (x == 2 && y == 3)
                Console.WriteLine("Yenildiniz!");
            else if (x == 3 && y == 1)
                Console.WriteLine("Yenildiniz!");
            else if (x == 3 && y == 2)
                Console.WriteLine("Kazandınız!");
            else
                Console.WriteLine("Berabere!");
            Console.ReadKey();
            goto a;



        }
    }
}
