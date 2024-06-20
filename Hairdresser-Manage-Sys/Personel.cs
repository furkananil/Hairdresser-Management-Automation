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
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace NDP_PROJECT_V1
{
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }

        private void RandevuDuzenleButton_Click(object sender, EventArgs e)
        {
            RandevuDuzenle rd = new RandevuDuzenle();
            rd.Show();
        }

        private void RandevuAlButton_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.Show();
        }

        private void Personel_Load(object sender, EventArgs e)
        {

        }
    }
}
