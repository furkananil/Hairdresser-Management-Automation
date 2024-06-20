namespace NDP_PROJECT_V1
{
    partial class Yonetici
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            btnAdd = new Button();
            brnDelete = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            txtMaas = new TextBox();
            txtYas = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(174, 9);
            label1.Name = "label1";
            label1.Size = new Size(651, 41);
            label1.TabIndex = 0;
            label1.Text = "ANIL KUAFÖR / RANDEVU SİSTEMİ (ADMIN)";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(821, 476);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(28, 61);
            label2.Name = "label2";
            label2.Size = new Size(270, 38);
            label2.TabIndex = 2;
            label2.Text = "PERSONEL VERİLERİ ";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Chartreuse;
            btnAdd.Location = new Point(3, 329);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(258, 77);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // brnDelete
            // 
            brnDelete.BackColor = Color.Red;
            brnDelete.Location = new Point(3, 434);
            brnDelete.Name = "brnDelete";
            brnDelete.Size = new Size(259, 75);
            brnDelete.TabIndex = 4;
            brnDelete.Text = "Personel Sil";
            brnDelete.UseVisualStyleBackColor = false;
            brnDelete.Click += brnDelete_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(108, 75);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(154, 27);
            txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(107, 115);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(154, 27);
            txtPassword.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 75);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 8;
            label3.Text = "Kullanıcı Adı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 118);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 9;
            label4.Text = "Şifre :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(20, 16);
            label5.Name = "label5";
            label5.Size = new Size(240, 38);
            label5.TabIndex = 10;
            label5.Text = "Yeni Personel Ekle";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(66, 159);
            label6.Name = "label6";
            label6.Size = new Size(35, 20);
            label6.TabIndex = 11;
            label6.Text = "Adı:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 198);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 12;
            label7.Text = "Soyadı:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(65, 235);
            label8.Name = "label8";
            label8.Size = new Size(37, 20);
            label8.TabIndex = 13;
            label8.Text = "Yaşı:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(50, 274);
            label9.Name = "label9";
            label9.Size = new Size(51, 20);
            label9.TabIndex = 14;
            label9.Text = "Maaşı:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.PapayaWhip;
            panel1.Controls.Add(txtMaas);
            panel1.Controls.Add(txtYas);
            panel1.Controls.Add(txtSoyad);
            panel1.Controls.Add(txtAd);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(brnDelete);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(861, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 517);
            panel1.TabIndex = 15;
            // 
            // txtMaas
            // 
            txtMaas.Location = new Point(107, 274);
            txtMaas.Name = "txtMaas";
            txtMaas.Size = new Size(153, 27);
            txtMaas.TabIndex = 18;
            // 
            // txtYas
            // 
            txtYas.Location = new Point(107, 235);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(153, 27);
            txtYas.TabIndex = 17;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(107, 195);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(154, 27);
            txtSoyad.TabIndex = 16;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(107, 156);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(154, 27);
            txtAd.TabIndex = 15;
            // 
            // Yonetici
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1139, 589);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Yonetici";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yonetici";
            Load += Yonetici_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Button btnAdd;
        private Button brnDelete;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel panel1;
        private TextBox txtMaas;
        private TextBox txtYas;
        private TextBox txtSoyad;
        private TextBox txtAd;
    }
}