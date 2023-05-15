using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgayThang02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ngay, thang, nam = 2023;
            int dayInMonth;
            Console.WriteLine("Nhap vao ngay:");
            ngay = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao thang:");
            thang = int.Parse(Console.ReadLine());

            if (thang >0 && thang <= 12) //kiem tra thang hop le
            {
                Console.WriteLine("Thang hop le");
                dayInMonth = DateTime.DaysInMonth(nam, thang);
                Console.WriteLine($"So ngay trong thang {thang} la: {dayInMonth}");

                DateTime dt = new DateTime(nam, thang, ngay);

                if (ngay <= 0 && ngay > dayInMonth)
                {
                    Console.WriteLine($"Ngay nhap vao khong hop le");
                }
                else
                {
                    Console.WriteLine($"Ngay hop le");

                    DateTime nextDay = dt.AddDays(1); // ngay tiep theo
                    DateTime preDay = dt.AddDays(-1); // ngay truoc do

                    Console.WriteLine($"Ngay tiep theo la {nextDay.Day}/{nextDay.Month}/{nextDay.Year}");
                    Console.WriteLine($"Ngay truoc do la {preDay.Day}/{preDay.Month}/{preDay.Year}");
                }
               

            }
            else
            {
                Console.WriteLine("Thang khong hop le");
            }

           

            Console.ReadLine();
        }
    }
}
