using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Çalısan1 ogretmen=new Çalısan1("Ahmet","Karaboğa","Coğrafya"); //Çalışan1 in nesnesini ogretmen olarak alıyoruz. 



            ogretmen.bilgi();//Çalışan1 in bilgileri
            Console.WriteLine();
            ogretmen.Gorev();//abstract metodun override edilmiş hali.

            Console.WriteLine("-----------------------------------");

            Çalısan2 Myardımcı = new Çalısan2("ece","Naz","Yonetim");//Aynı şeyleri ikinci çalışan içinde yapıyoruz

            Myardımcı.Bilgi();
            Console.WriteLine();
            Myardımcı.Gorev();

            Console.ReadLine();
        }


    }
}
