using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
namespace DemoLinQ
{
    delegate int Tong(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            //int[] a = { 1, 2, 3, 4, 5, 6, 7 };

            ////truy van cac phan tu le cua mang a (theo Query Syntax)
            //var b = from x in a where x % != 0 select x;

            //Console.WriteLine("Mang ket qua:" + string.Join(";", b));

            ////truy van cac phan tu le cua mang a (theo Method Syntax)
            //var c = a.Where(x => x % 2 != 0);

            //Console.WriteLine("Mang ket qua 1:" + string.Join(";", b));
            //Console.WriteLine("Mang ket qua 2:" + string.Join(";", c));

            //Console.WriteLine("Hello Word");

            //Tong sum = delegate (int a, int b)
            //{
            //    return a + b;
            //};

            Tong sum = (a,b) => { return a + b;  };
            var kq = sum(1, 2);
            Console.WriteLine("kq:" + kq);

            static int DelegateTong(int a, int b)
            {
                return a + b;
            }
        }
    }
}