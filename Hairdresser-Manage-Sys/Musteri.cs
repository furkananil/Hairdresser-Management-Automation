using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2023-2024 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:PROJE ÖDEVİ
**				ÖĞRENCİ ADI............:FURKAN ANIL ÖZDEMİR
**				ÖĞRENCİ NUMARASI.......:B231210063
**              DERSİN ALINDIĞI GRUP...: 1.ÖĞRETİM B GRUBU
****************************************************************************/

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP_PROJECT_V1
{
    public partial class Musteri : Form
    {
        Fiyatlar fiyat = new Fiyatlar();
        List<string> hizmetler = new List<string>();
        List<string> Tiraslar = new List<string>();
        public Musteri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            HizmetlerKontrol();

            DateTime seciliTarih = dateTimePicker1.Value;
            string tarihMetni = seciliTarih.ToString("dd.MM.yyyy");
            string ad = adTextBox.Text;
            string soyad = soyadTextBox.Text;
            string telefon = TelefonTextBox.Text;
            string eposta = PostaTextBox.Text;

            // Verileri dosyaya yaz
            string dosyaYolu = "musteri_veri.txt";
            using (StreamWriter writer = new StreamWriter(dosyaYolu, true))
            {
                string hizmetlerMetni = string.Join(",", hizmetler);
                string tiraslarMetni = string.Join(",", Tiraslar);
                writer.WriteLine($"{ad}:{soyad}:{telefon}:{eposta}:{ToplamFiyat}:{tiraslarMetni}:{hizmetlerMetni}:{tarihMetni}");
            }

            MessageBox.Show("Randevunuz Alınmıştır!");
        }

        int ToplamFiyat = 0;
        private void TutarGuncelle(CheckBox checkBox, int Tutar)
        {
            if (checkBox.Checked)
            {
                ToplamFiyat += Tutar;
            }
            else
            {
                ToplamFiyat -= Tutar;
            }
            label5.Text = ToplamFiyat.ToString() + " TL";
        }

        public void HizmetlerKontrol()
        {
            if (SakalBiyikCheckBox.Checked)
            {
                hizmetler.Add("Sakal Bıyık Düzeltme");
            }
            if (SacBakimCheckBox.Checked)
            {
                hizmetler.Add("Saç Bakım");
            }
            if (YuzBakimCheckBox.Checked)
            {
                hizmetler.Add("Yüz Bakım");
            }
            if (TirnakCheckBox.Checked)
            {
                hizmetler.Add("Tırnak Bakım");
            }
            if (FonCheckBox.Checked)
            {
                hizmetler.Add("Fön Çekimi");
            }
            if (JoleCheckBox.Checked)
            {
                hizmetler.Add("Jöle Uygulama");
            }
            if (YikamaCheckBox.Checked)
            {
                hizmetler.Add("Saç Yıkama");
            }
            if (BoyamaCheckBox.Checked)
            {
                hizmetler.Add("Saç Boyama");
            }


            if(subayRadioButton.Checked)
            {
                Tiraslar.Add("Subay Tıraşı");
            }
            if (AmerikanRadioButton.Checked)
            {
                Tiraslar.Add("Amerikan Tıraşı");
            }
            if (UcRadioButton.Checked)
            {
                Tiraslar.Add("Üç numara");
            }
            if (ustlerKalsinRadioButton.Checked)
            {
                Tiraslar.Add("Yanları al üstler kalsın");
            }
            if (FadeRadioButton.Checked)
            {
                Tiraslar.Add("Fade Kesim");
            }
            if (BuzzRadioButton.Checked)
            {
                Tiraslar.Add("Buzz Kesim");
            }
            if (UnderRadioButton.Checked)
            {
                Tiraslar.Add("Under Kesim");
            }

        }

        private void SakalBiyikCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            TutarGuncelle(SakalBiyikCheckBox, fiyat.SakalBiyikDuzeltme);

            
        }

        private void BoyamaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            TutarGuncelle(BoyamaCheckBox, fiyat.SacBoyama);
        }

        private void YuzBakimCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            TutarGuncelle(YuzBakimCheckBox, fiyat.YuzBakimi);
        }

        private void TirnakCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            TutarGuncelle(TirnakCheckBox, fiyat.TirnakBakimi);
        }

        private void YikamaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            TutarGuncelle(YikamaCheckBox, fiyat.SacYikama);
        }

        private void SacBakimCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            TutarGuncelle(SacBakimCheckBox, fiyat.SacBakimi);
        }

        private void FonCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            TutarGuncelle(FonCheckBox, fiyat.FonCekimi);
        }

        private void JoleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            TutarGuncelle(JoleCheckBox, fiyat.JoleUygulama);
        }


        public void rTutarGuncelle(RadioButton radioButton, int Tutar)
        {
            if (radioButton.Checked)
            {
                ToplamFiyat += Tutar;
            }
            else
            {
                ToplamFiyat -= Tutar;
            }
            label5.Text = ToplamFiyat.ToString() + " TL";
        }

        private void subayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            rTutarGuncelle(subayRadioButton, fiyat.SubayTirasi);
        }

        private void AmerikanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            rTutarGuncelle(AmerikanRadioButton, fiyat.AmerikanTirasi);
        }

        private void UcRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            rTutarGuncelle(UcRadioButton,fiyat.UcNumara);
        }

        private void ustlerKalsinRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            rTutarGuncelle(ustlerKalsinRadioButton,fiyat.YanlariAlUstlerKalsin);
        }

        private void FadeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            rTutarGuncelle(FadeRadioButton,fiyat.FadeKesim);
        }

        private void BuzzRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            rTutarGuncelle(BuzzRadioButton,fiyat.BuzzcutKesim);
        }

        private void UnderRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            rTutarGuncelle(UnderRadioButton,fiyat.UndercutKesim);
        }
    }
}
