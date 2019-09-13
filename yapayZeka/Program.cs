using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Configuration;

namespace yapayZeka
{
    class Program
    {
       

        static void Main(string[] args)
        {
            caprazlama cross = new caprazlama();
            parent deneme = new parent();
            double[,] dizi = new double[20, 3];

            double[] sayilar = new double[20];
           
            for (int i = 0; i < 20; i++)
            {
                int saat = Convert.ToInt32(DateTime.Now.Hour);
                int gun = Convert.ToInt32(DateTime.Now.Day);
                int saniye = Convert.ToInt32(DateTime.Now.Second);
                int dakika = Convert.ToInt32(DateTime.Now.Minute);
                double xn = random.xdeger(saat, gun, saniye, dakika);
                double a = random.adeger(saat, gun, saniye, dakika);
                double collectValues = deneme.ata(xn, a);
               
                dizi[i, 0] = xn;
                dizi[i, 1] = a;
                dizi[i, 2] = collectValues;

                sayilar[i] = collectValues;
            }
           
                Array.Sort(sayilar);
                Console.WriteLine("birinci"+sayilar[0]+"ikinci"+sayilar[1]);
            
            for (int i = 0; i < 20; i++)
            {
                if(dizi[i,2]==sayilar[0]) {
                    Console.WriteLine("xnEniyi" + dizi[i,0] + "a" + dizi[i,1]);
                    cross.firstgenA = dizi[i, 0];
                    cross.firstgenXn = dizi[i, 1];
                }
                if(dizi[i,2]==sayilar[1]) {
                    Console.WriteLine("xnÝkinciEniyi" + dizi[i,0] + "a" + dizi[i,1]);
                    cross.secondgenA = dizi[i, 0];
                    cross.secondgenXn= dizi[i, 1];
               
                }
            }
            cross.Crossover();
            Console.ReadLine();

            

            

        }


    }



}

