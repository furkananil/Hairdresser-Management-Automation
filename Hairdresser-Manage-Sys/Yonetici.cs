using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NDP_PROJECT_V1.Yonetici;

namespace NDP_PROJECT_V1
{
    public partial class Yonetici : Form
    {
        public List<Personeller> personel = new List<Personeller>();


        public Yonetici()
        {
            InitializeComponent();
        }
        
        public void Yonetici_Load(object sender, EventArgs e)
        {
            // TXT dosyasından verileri okuma
            string[] lines = File.ReadAllLines("personel_veri.txt");
            foreach (string line in lines)
            {
                string[] data = line.Split(':');
                if (data.Length == 6)
                {
                    personel.Add(new Personeller { KullaniciAdi = data[0],  Sifre = data[1], Ad = data[2], Soyad = data[3], Yas = int.Parse(data[4]), Maas = int.Parse(data[5]) });
                }
            }
           
            // DataGridView'e veri kaynağı olarak atama
            dataGridView1.DataSource = personel;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtUsername.Text;
            string sifre = txtPassword.Text;
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            int yas = int.Parse(txtYas.Text);
            int maas = int.Parse(txtMaas.Text);

            personel.Add(new Personeller { KullaniciAdi = kullaniciAdi, Sifre = sifre, Ad = txtAd.Text, Soyad = txtSoyad.Text, Yas = int.Parse(txtYas.Text),Maas = int.Parse(txtMaas.Text) });
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = personel;
            
            File.AppendAllText("personel_veri.txt", $"{kullaniciAdi}:{sifre}:{ad}:{soyad}:{yas}:{maas}\n");
        }

        private void brnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                string silinecekKullaniciAdi = personel[index].KullaniciAdi;
                personel.RemoveAt(index);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = personel;

                // TXT dosyasından veriyi silme
                List<string> lines = new List<string>(File.ReadAllLines("personel_veri.txt"));
                lines.RemoveAll(line => line.StartsWith(silinecekKullaniciAdi + ":"));
                File.WriteAllLines("personel_veri.txt", lines);
            }
        }
    }
    
}
