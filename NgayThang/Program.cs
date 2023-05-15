using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgayThang
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

            switch (thang)
            {
                case 1: dayInMonth = 31; break;
                case 2: dayInMonth = 28; break;
                case 3: dayInMonth = 31; break;
                case 4: dayInMonth = 30; break;
                case 5: dayInMonth = 31; break;
                case 6: dayInMonth = 30; break;
                case 7: dayInMonth = 31; break;
                case 8: dayInMonth = 31; break;
                case 9: dayInMonth = 30; break;
                case 10: dayInMonth = 31; break;
                case 11: dayInMonth = 30; break;
                case 12: dayInMonth = 31; break;

                default: { dayInMonth = 0;
                        Console.WriteLine("Thang khong hop le");
                        break; }

            }

            if (dayInMonth != 0) {
                Console.WriteLine($"So ngay trong thang {thang} la: {dayInMonth}");
            }

            if (ngay <= 0 && ngay > dayInMonth)
            {
                Console.WriteLine($"Ngay nhap vao khong hop le");
            } else if(ngay < dayInMonth)
            {
                Console.WriteLine($"Ngay tiep theo la {ngay + 1}/{thang}");
            } else if(ngay == dayInMonth && thang < 12)
            {
                Console.WriteLine($"Ngay tiep theo la {1}/{thang + 1}");
            }else if(ngay == dayInMonth && thang == 12)
            {
                Console.WriteLine($"Ngay tiep theo la {1}/{1}/ {nam +1}");
            }
            Console.ReadLine();
        }
    }
}
