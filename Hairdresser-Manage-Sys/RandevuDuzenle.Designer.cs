namespace NDP_PROJECT_V1
{
    partial class RandevuDuzenle
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
            dataGridView1 = new DataGridView();
            SilButton = new Button();
            panel1 = new Panel();
            DuzenleButton = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.CadetBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 149);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1200, 607);
            dataGridView1.TabIndex = 0;
            // 
            // SilButton
            // 
            SilButton.BackColor = Color.Red;
            SilButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            SilButton.Location = new Point(14, 127);
            SilButton.Name = "SilButton";
            SilButton.Size = new Size(246, 73);
            SilButton.TabIndex = 2;
            SilButton.Text = "Randevu İptal Et";
            SilButton.UseVisualStyleBackColor = false;
            SilButton.Click += SilButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(DuzenleButton);
            panel1.Controls.Add(SilButton);
            panel1.Location = new Point(1218, 149);
            panel1.Name = "panel1";
            panel1.Size = new Size(271, 607);
            panel1.TabIndex = 13;
            // 
            // DuzenleButton
            // 
            DuzenleButton.BackColor = Color.WhiteSmoke;
            DuzenleButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            DuzenleButton.Location = new Point(14, 28);
            DuzenleButton.Name = "DuzenleButton";
            DuzenleButton.Size = new Size(246, 69);
            DuzenleButton.TabIndex = 13;
            DuzenleButton.Text = "Randevu Düzenle";
            DuzenleButton.UseVisualStyleBackColor = false;
            DuzenleButton.Click += DuzenleButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(279, 9);
            label5.Name = "label5";
            label5.Size = new Size(701, 41);
            label5.TabIndex = 14;
            label5.Text = "ANIL KUAFÖR / RANDEVU DÜZENLEME SİSTEMİ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.Aquamarine;
            label6.Location = new Point(1207, 112);
            label6.Name = "label6";
            label6.Size = new Size(282, 28);
            label6.TabIndex = 15;
            label6.Text = "RANDEVULARI DÜZENLE/SİL";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.Aquamarine;
            label7.Location = new Point(12, 92);
            label7.Name = "label7";
            label7.Size = new Size(369, 54);
            label7.TabIndex = 16;
            label7.Text = "MÜŞTERİ VERİLERİ";
            // 
            // RandevuDuzenle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1501, 768);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "RandevuDuzenle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RandevuDuzenle";
            Load += RandevuDuzenle_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button SilButton;
        private Panel panel1;
        private Label label5;
        private Label label6;
        private Button DuzenleButton;
        private Label label7;
    }
}