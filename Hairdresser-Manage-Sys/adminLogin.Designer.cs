namespace NDP_PROJECT_V1
{
    partial class adminLogin
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
            panel1 = new Panel();
            label3 = new Label();
            button1 = new Button();
            kAdiTextBox = new TextBox();
            SifreTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
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
            panel1.Size = new Size(659, 454);
            panel1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(150, 49);
            label3.Name = "label3";
            label3.Size = new Size(323, 54);
            label3.TabIndex = 5;
            label3.Text = "Yönetici Girişi";
            // 
            // button1
            // 
            button1.Location = new Point(105, 288);
            button1.Name = "button1";
            button1.Size = new Size(431, 46);
            button1.TabIndex = 4;
            button1.Text = "GİRİŞ YAP";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // kAdiTextBox
            // 
            kAdiTextBox.Location = new Point(197, 141);
            kAdiTextBox.Name = "kAdiTextBox";
            kAdiTextBox.Size = new Size(297, 27);
            kAdiTextBox.TabIndex = 3;
            // 
            // SifreTextBox
            // 
            SifreTextBox.Location = new Point(197, 204);
            SifreTextBox.Name = "SifreTextBox";
            SifreTextBox.Size = new Size(297, 27);
            SifreTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            label1.Location = new Point(26, 141);
            label1.Name = "label1";
            label1.Size = new Size(165, 29);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            label2.Location = new Point(105, 200);
            label2.Name = "label2";
            label2.Size = new Size(75, 29);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            // 
            // adminLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 403);
            Controls.Add(panel1);
            Name = "adminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "adminLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Button button1;
        private TextBox kAdiTextBox;
        private TextBox SifreTextBox;
        private Label label1;
        private Label label2;
    }
}