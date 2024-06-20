using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_PROJECT_V1
{
    public class Fiyatlar
    {
        //TIRAŞLAR
        public int SubayTirasi { get; set; } = 175;
        public int FadeKesim { get; set; } = 200;
        public int AmerikanTirasi { get; set; } = 150;
        public int BuzzcutKesim { get; set; } = 250;
        public int UcNumara { get; set; } = 100;
        public int UndercutKesim { get; set; } = 200;
        public int YanlariAlUstlerKalsin { get; set; } = 125;

        //DİĞER
        public int SakalBiyikDuzeltme { get; set; } = 75;
        public int SacBoyama { get; set; } = 150;
        public int YuzBakimi { get; set; } = 75;
        public int TirnakBakimi { get; set; } = 50;
        public int SacYikama { get; set; } = 30;
        public int SacBakimi { get; set; } = 75;
        public int FonCekimi { get; set; } = 30;
        public int JoleUygulama { get; set; } = 30;
    }

    public class Kisi
    {
       
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }


    public partial class Personeller:Kisi
    {
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public int Yas { get; set; }
        public int Maas { get; set; }
    }

    public partial class Musteriler:Kisi
    {
        public int Telefon { get; set; }
        public string Eposta { get; set; }
        public int Tutar { get; set; }
        public string TirasAdi { get; set; }
        public string DigerHizmetler { get; set; }
        
    }

}
