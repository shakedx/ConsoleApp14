using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число:");
            int a = int.Parse(Console.ReadLine());           
            Reverse(a);
            Console.ReadKey();
        }

        static void Reverse(int chislo)
        {
            int revchislo = chislo % 10;
            Console.Write(revchislo);
            chislo /= 10;

            if (chislo > 0)
                Reverse(chislo);
        }
    }
}
