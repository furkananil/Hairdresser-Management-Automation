/****************************************************************************
**					SAKARYA �N�VERS�TES�
**				B�LG�SAYAR VE B�L���M B�L�MLER� FAK�LTES�
**				    B�LG�SAYAR M�HEND�SL��� B�L�M�
**				   NESNEYE DAYALI PROGRAMLAMA DERS�
**					2023-2024 BAHAR D�NEM�
**	
**				�DEV NUMARASI..........:PROJE �DEV�
**				��RENC� ADI............:FURKAN ANIL �ZDEM�R
**				��RENC� NUMARASI.......:B231210063
**              DERS�N ALINDI�I GRUP...: 1.��RET�M B GRUBU
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
