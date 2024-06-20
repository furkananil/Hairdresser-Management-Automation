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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP_PROJECT_V1
{
    public partial class personelLogin : Form
    {
        public personelLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var veriler = File.ReadAllLines("personel_veri.txt");
            bool girisBasarili = false;

            if (veriler.Length > 0)
            {
                foreach (var line in veriler)
                {
                    var parts = line.Split(':');
                    if (parts.Length == 6)
                    {
                        var username = parts[0];
                        var password = parts[1];

                        // Kullanıcı adı ve şifreyi kullanarak giriş işlemini doğrula
                        if (kAdiTextBox.Text == username && SifreTextBox.Text == password)
                        {
                            // Başarılı giriş
                            MessageBox.Show("Giriş yapıldı, Hoşgeldiniz", "Hoşgeldiniz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            girisBasarili = true;

                            Personel personel = new Personel();
                            personel.Show();

                            break;
                        }
                    }
                    else
                    {
                        // Geçersiz satır formatı
                        MessageBox.Show("Geçersiz satır formatı!");
                    }
                }

                if (!girisBasarili)
                {
                    // Başarısız giriş
                    MessageBox.Show("Kullanıcı adı veya Şifre yanlış, lütfen tekrar deneyiniz!", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Dosya boş
                MessageBox.Show("Dosya boş!");
            }
        }
    }
}
