using System;

namespace CiftToplam
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1, top = 0;
            Console.WriteLine("Sayı giriniz = ");
            s1 = Convert.ToInt32(Console.ReadLine());

            if (s1 % 2 == 0)
            {
                for (int i = s1; i <= 20; i += 2)
                {
                    top = top + i;
                }
                Console.WriteLine("Toplam = " + top);
            }
            else
            {
                for (int i = s1; i <= 20; i += 2)
                {
                    top = top + i;
                }
                Console.WriteLine("Toplam = " + top);
            }

            Console.ReadKey();
        }
    }
}
