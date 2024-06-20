/****************************************************************************
**					SAKARYA ÜNÝVERSÝTESÝ
**				BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ
**				    BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSÝ
**					2023-2024 BAHAR DÖNEMÝ
**	
**				ÖDEV NUMARASI..........:PROJE ÖDEVÝ
**				ÖÐRENCÝ ADI............:FURKAN ANIL ÖZDEMÝR
**				ÖÐRENCÝ NUMARASI.......:B231210063
**              DERSÝN ALINDIÐI GRUP...: 1.ÖÐRETÝM B GRUBU
****************************************************************************/
namespace NDP_PROJECT_V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            personelLogin personelLogin = new personelLogin();
            personelLogin.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            adminLogin admin = new adminLogin();
            admin.Show();
        }
    }
}
