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
            
        }

        public static void TukarNilai(int a, int b) {
            Console.WriteLine("Nilai a awal  = "+a);
            Console.WriteLine("Nilai b awal  = " + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Nilai a sekarang = "+a);
            Console.WriteLine("Nilai b sekarang = " + b);
        }
    }
}
