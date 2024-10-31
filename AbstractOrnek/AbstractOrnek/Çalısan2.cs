using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOrnek
{
    internal class Çalısan2 : ÇalısanBilgi//Çalışan1 classında yaptıklarımızı buradada yapıyoruz
    {
        public Çalısan2(string ad, string soyad, string bolumu) : base(ad, soyad, bolumu)
        {
        }

        public void Bilgi()
        {
            Console.WriteLine(" Adı : {0}\n Soyadı : {1}\n Alanı : {2}", _Ad, _Soyad, _Bolumu);
        }

        public override void Gorev()
        {
            Console.WriteLine("Ben müdür yardımcısıyım");
        }
    }
}
