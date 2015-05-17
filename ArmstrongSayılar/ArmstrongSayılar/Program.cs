using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongSayılar
{
    class Program
    {
        static void Main(string[] args)
        {
            double onlar, yuzler, birler;
            double toplam;

            Console.Write("3 Basamaklı Armstrong Sayılar:");
            Console.Read();
            for (int i = 100; i <= 999; i++) {

                yuzler = i / 100;
                onlar = i / 10 - (yuzler * 10);
                birler = i - (yuzler * 100)-(onlar*10);
                toplam=Math.Pow(yuzler,3) + Math.Pow(onlar,3) + Math.Pow(birler,3);

                if (toplam == i) { 
                  Console.WriteLine(i);
                  Console.Read();
                }
            }
        }
    }
}
