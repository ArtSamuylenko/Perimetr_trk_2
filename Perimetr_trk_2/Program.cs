using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimetr_Treugolnika_n2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)

            {
                Console.WriteLine("Введите 2 катета и гипотенузу треугольника: ");
                int storona_1 = int.Parse(Console.ReadLine());
                int storona_2 = int.Parse(Console.ReadLine());
                int storona_3 = int.Parse(Console.ReadLine());
                Perimetr(storona_1, storona_2, storona_3);
            }
        }
        static void Perimetr(int a, int b, int c)
        {

            int perimetr = a + b + c;
            Console.WriteLine($"Периметр = {perimetr}");
            Console.ReadLine();
        }

    }
}