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
using static System.Windows.Forms.LinkLabel;

namespace NDP_PROJECT_V1
{
    public partial class RandevuDuzenle : Form
    {
        public RandevuDuzenle()
        {
            InitializeComponent();
        }

        private void RandevuDuzenle_Load(object sender, EventArgs e)
        {
            var dosyaYolu = "musteri_veri.txt";

            dataGridView1.Columns.Add("Ad", "Ad");
            dataGridView1.Columns.Add("Soyad", "Soyad");
            dataGridView1.Columns.Add("Telefon", "Telefon");
            dataGridView1.Columns.Add("Eposta", "Eposta");
            dataGridView1.Columns.Add("Tutar", "Tutar");
            dataGridView1.Columns.Add("Tıraş", "Tıraş");
            dataGridView1.Columns.Add("Diğer Hizmetler", "Diğer Hizmetler");
            dataGridView1.Columns.Add("Tarih", "Tarih");

            string[] satirlar = File.ReadAllLines(dosyaYolu);
            foreach (string satir in satirlar)
            {
                string[] veriler = satir.Split(':');
                if (veriler.Length == 8)
                {
                    dataGridView1.Rows.Add(veriler[0], veriler[1], veriler[2], veriler[3], veriler[4], veriler[5], veriler[6], veriler[7]);
                }
            }

        }

        private void SilButton_Click(object sender, EventArgs e)
        {
            string dosyaYolu = "musteri_veri.txt";
            List<string> satirlar = new List<string>(File.ReadAllLines(dosyaYolu));

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                if (index >= 0 && index < satirlar.Count)
                {
                    satirlar.RemoveAt(index);
        // Seçili satırı listeden kaldırın
                    File.WriteAllLines(dosyaYolu, satirlar); // Güncellenmiş veriyi dosyaya yazın
                    MessageBox.Show("Randevu başarıyla iptal edildi.");
                }
                else
                {
                    MessageBox.Show("Geçerli bir satır seçin.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.");
            }


        }

        private void DuzenleButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;

                // Yeni verileri alın
                string yeniAd = dataGridView1.Rows[index].Cells["Ad"].Value.ToString();
                string yeniSoyad = dataGridView1.Rows[index].Cells["Soyad"].Value.ToString();
                string tel = dataGridView1.Rows[index].Cells["Telefon"].Value.ToString();
                string posta = dataGridView1.Rows[index].Cells["Eposta"].Value.ToString();
                string tutar = dataGridView1.Rows[index].Cells["Tutar"].Value.ToString();
                string tıraş = dataGridView1.Rows[index].Cells["Tıraş"].Value.ToString();
                string hizmetler = dataGridView1.Rows[index].Cells["Diğer Hizmetler"].Value.ToString();
                string tarih = dataGridView1.Rows[index].Cells["Tarih"].Value.ToString();

                // Diğer verileri de benzer şekilde alın

                // Veriyi txt dosyasına yazın
                List<string> satirlar = new List<string>();
                foreach (DataGridViewRow satir in dataGridView1.Rows)
                {
                    string veri = $"{satir.Cells["Ad"].Value}:{satir.Cells["Soyad"].Value}:{satir.Cells["Telefon"].Value}:{satir.Cells["Eposta"].Value}:{satir.Cells["Tutar"].Value}:{satir.Cells["Tıraş"].Value}:{satir.Cells["Diğer Hizmetler"].Value}:{satir.Cells["Tarih"].Value}";
                    satirlar.Add(veri);
                }
                File.WriteAllLines("musteri_veri.txt", satirlar);

                MessageBox.Show("Veri başarıyla güncellendi ve dosyaya yazıldı.");
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.");
            }
        }


    }
}
