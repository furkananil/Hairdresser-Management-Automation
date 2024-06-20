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
    public partial class adminLogin : Form
    {
        public adminLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(kAdiTextBox.Text=="admin" && SifreTextBox.Text=="admin")
            {
                MessageBox.Show("Giriş yapıldı, Hoşgeldiniz", "Hoşgeldiniz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Yonetici yonetici = new Yonetici();
                yonetici.Show();
             
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya Şifre yanlış lütfen tekrar deneyiniz!", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
