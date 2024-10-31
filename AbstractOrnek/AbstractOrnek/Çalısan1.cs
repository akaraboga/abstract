using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOrnek
{
    internal class Çalısan1 : ÇalısanBilgi//ÇalısanBilgi metodunu inherit alıyoruz
    {
        

        public Çalısan1(string ad, string soyad, string bolumu) : base(ad, soyad, bolumu)//: base ile ÇalısanBilgi clasının yapıcı metodundaki parametrelere değer atayıyoruz.
        {
        }

        public void bilgi()//Burada da çalışanın bilgilerini ekrana yazdıracağımız metod.
        {
            Console.WriteLine(" Adı : {0}\n Soyadı : {1}\n Alanı : {2}",_Ad,_Soyad,_Bolumu);
        }
        public override void Gorev()//Buradaki metod  ÇalısanBilgi clasında abstract olan metod bunu override ederek içine istediğimiz değeri atıyoruz.
        {
            Console.WriteLine("Ben ögretmenim");
        }
    }
}
