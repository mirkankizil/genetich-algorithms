using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Diagnostics.Contracts;
namespace yapayZeka
{
    public class random
    {
        public static double adeger(int saat, int gun, int saniye, int dakika)
        {
            Random rnd = new Random();
            double doubleRnd = rnd.NextDouble();
            double ekle = doubleRnd + 3;
            int k = (saat + 1) * gun * (saniye + 1) * (1 + dakika);
            double x = Convert.ToDouble(k);
            
            double b = 4 - 3.5;
            double a = b / 2678400;
            a =( a * x)+ ekle;
            if (a > 3.5 && a < 4)
                return a;
            else if (a <= 3.5)
            {
                a = Math.Abs(3.5 - a) + (a*x);
                return a;
            }
            else
            {
                a = a - Math.Abs(4 - a);
                return a;
            }
        }
        public static double xdeger(int saat, int gun, int saniye, int dakika)
        {
            Random rnd = new Random();
            double doubleRnd = rnd.NextDouble();
            double ekle = doubleRnd;
            int k = (saat + 1) * gun * (saniye + 1) * (1 + dakika);
            double x = Convert.ToDouble(k);
            double b = 1;
            double a = b / 2678400;
            a = (a * x)+ ekle;
            if (a > 0 && a < 1)
                return a;
            else if (a <= 0)
            {
                a = Math.Abs(0 - a) + a + 0.1;
                return a;
            }
            else
            {
                a = a - Math.Abs(1 - a) - 0.1;
                return a;
            }
        }

        //    public static double deneme()
        //    {

        //        double i = Convert.ToDouble(DateTime.Now.Minute+1);
        //        double deger = i * i;
        //        double k = Convert.ToDouble(DateTime.Now.Day);
        //        double l = Convert.ToDouble(DateTime.Now.Second+1);
        //        deger = k * l / deger * i;
        //        if (deger < 1 && deger > 0)
        //        {
        //            Console.WriteLine("istenilen degergirildi" + deger);
        //            return deger;
        //        }
        //        else
        //            return deneme();
        //    }
        //}
    }
}