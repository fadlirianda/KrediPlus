using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            TukarNilai(a, b);

            int[] x = { 20, 10, 50, 46, 26, 87, 25, 5, 97, 24 };
            SortingArray(x);

        }

        public static void TukarNilai(int a, int b)
        {
            Console.WriteLine("Nilai a awal  = " + a);
            Console.WriteLine("Nilai b awal  = " + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Nilai a sekarang = " + a);
            Console.WriteLine("Nilai b sekarang = " + b);
        }

        public static void SortingArray(int[] x)
        {
            int temp = 0;

            for (int i = 0; i <= x.Length - 1; i++)
            {
                for (int j = i + 1; j < x.Length; j++)
                {
                    if (x[i] > x[j])
                    {
                        temp = x[i];
                        x[i] = x[j];
                        x[j] = temp;
                    }
                }
            }
            Console.WriteLine("Urutan nilai kecil ke besar : ");
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }
        }
    }
}
