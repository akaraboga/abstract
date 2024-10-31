using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOrnek
{
    internal abstract class ÇalısanBilgi//Kalıtım yapacaımız clasımızı abstract olarak tanımlıyoruz.
    {

        public string _Ad { get; set; }//Propertylerimizi giriyoruz.
        public string _Soyad { get; set; }
        public string _Bolumu { get; set; }

        protected ÇalısanBilgi(string ad, string soyad, string bolumu)//Parametre alan Construcator ile propertylerimize değer atayacağız.
        {
            _Ad = ad;
            _Soyad = soyad;
            _Bolumu = bolumu;
        }


        public abstract void Gorev();//Bu da abstract metodumuz ÇalısanBilgi classını inherit eden claslar override ile metodu istediği şekilde duzenleyebilecek.

    }
}
