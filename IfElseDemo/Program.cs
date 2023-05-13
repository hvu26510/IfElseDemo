using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, can2;
            Console.WriteLine("Nhap a : ");
            a = double.Parse(Console.ReadLine());

            if (a > 0)
            {
                // neu a>0 thi thuc hien
                can2 = Math.Sqrt(a);
                Console.WriteLine($" Can 2 cua a la: {can2} ");
            }
            else
            {
                Console.WriteLine("So nhap vao khong phai so duong");
            }

            Console.ReadLine();
        }
    }
}
