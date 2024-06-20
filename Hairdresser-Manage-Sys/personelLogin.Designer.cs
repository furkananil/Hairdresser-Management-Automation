namespace NDP_PROJECT_V1
{
    partial class personelLogin
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
            label2 = new Label();
            SifreTextBox = new TextBox();
            kAdiTextBox = new TextBox();
            panel1 = new Panel();
            label3 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.Location = new Point(7, 140);
            label1.Name = "label1";
            label1.Size = new Size(190, 38);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label2.Location = new Point(111, 200);
            label2.Name = "label2";
            label2.Size = new Size(86, 38);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            // 
            // SifreTextBox
            // 
            SifreTextBox.Location = new Point(203, 211);
            SifreTextBox.Name = "SifreTextBox";
            SifreTextBox.Size = new Size(304, 27);
            SifreTextBox.TabIndex = 2;
            // 
            // kAdiTextBox
            // 
            kAdiTextBox.Location = new Point(203, 140);
            kAdiTextBox.Name = "kAdiTextBox";
            kAdiTextBox.Size = new Size(304, 27);
            kAdiTextBox.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGreen;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(kAdiTextBox);
            panel1.Controls.Add(SifreTextBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(655, 466);
            panel1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(139, 40);
            label3.Name = "label3";
            label3.Size = new Size(340, 62);
            label3.TabIndex = 5;
            label3.Text = "Personel Girişi";
            // 
            // button1
            // 
            button1.Location = new Point(87, 294);
            button1.Name = "button1";
            button1.Size = new Size(463, 46);
            button1.TabIndex = 4;
            button1.Text = "GİRİŞ YAP";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // personelLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 423);
            Controls.Add(panel1);
            Name = "personelLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "personelLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox SifreTextBox;
        private TextBox kAdiTextBox;
        private Panel panel1;
        private Label label3;
        private Button button1;
    }
}