namespace NDP_PROJECT_V1
{
    partial class Musteri
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
            adTextBox = new TextBox();
            adLabel = new Label();
            panel1 = new Panel();
            TelefonTextBox = new MaskedTextBox();
            button1 = new Button();
            label2 = new Label();
            epostaLabel = new Label();
            telefonLabel = new Label();
            PostaTextBox = new TextBox();
            soyadTextBox = new TextBox();
            soyadLabel = new Label();
            panel2 = new Panel();
            JoleCheckBox = new CheckBox();
            TirnakCheckBox = new CheckBox();
            FonCheckBox = new CheckBox();
            YuzBakimCheckBox = new CheckBox();
            SacBakimCheckBox = new CheckBox();
            BoyamaCheckBox = new CheckBox();
            YikamaCheckBox = new CheckBox();
            SakalBiyikCheckBox = new CheckBox();
            subayRadioButton = new RadioButton();
            FadeRadioButton = new RadioButton();
            AmerikanRadioButton = new RadioButton();
            BuzzRadioButton = new RadioButton();
            UcRadioButton = new RadioButton();
            UnderRadioButton = new RadioButton();
            ustlerKalsinRadioButton = new RadioButton();
            panel3 = new Panel();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            tutarLabel = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // adTextBox
            // 
            adTextBox.Location = new Point(100, 69);
            adTextBox.Name = "adTextBox";
            adTextBox.Size = new Size(194, 27);
            adTextBox.TabIndex = 0;
            // 
            // adLabel
            // 
            adLabel.AutoSize = true;
            adLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            adLabel.Location = new Point(23, 69);
            adLabel.Name = "adLabel";
            adLabel.Size = new Size(41, 25);
            adLabel.TabIndex = 1;
            adLabel.Text = "Ad:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(TelefonTextBox);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(epostaLabel);
            panel1.Controls.Add(telefonLabel);
            panel1.Controls.Add(PostaTextBox);
            panel1.Controls.Add(soyadTextBox);
            panel1.Controls.Add(soyadLabel);
            panel1.Controls.Add(adTextBox);
            panel1.Controls.Add(adLabel);
            panel1.Location = new Point(12, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(491, 536);
            panel1.TabIndex = 2;
            // 
            // TelefonTextBox
            // 
            TelefonTextBox.Location = new Point(100, 181);
            TelefonTextBox.Mask = "(999) 000-0000";
            TelefonTextBox.Name = "TelefonTextBox";
            TelefonTextBox.Size = new Size(194, 27);
            TelefonTextBox.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCyan;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(20, 466);
            button1.Name = "button1";
            button1.Size = new Size(455, 58);
            button1.TabIndex = 9;
            button1.Text = "Randevu Al";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(113, 12);
            label2.Name = "label2";
            label2.Size = new Size(248, 38);
            label2.TabIndex = 8;
            label2.Text = "İletişim Bilgileri:";
            // 
            // epostaLabel
            // 
            epostaLabel.AutoSize = true;
            epostaLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            epostaLabel.Location = new Point(20, 236);
            epostaLabel.Name = "epostaLabel";
            epostaLabel.Size = new Size(81, 25);
            epostaLabel.TabIndex = 7;
            epostaLabel.Text = "E-posta:";
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            telefonLabel.Location = new Point(20, 183);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new Size(80, 25);
            telefonLabel.TabIndex = 6;
            telefonLabel.Text = "Telefon:";
            // 
            // PostaTextBox
            // 
            PostaTextBox.Location = new Point(100, 236);
            PostaTextBox.Name = "PostaTextBox";
            PostaTextBox.Size = new Size(194, 27);
            PostaTextBox.TabIndex = 5;
            // 
            // soyadTextBox
            // 
            soyadTextBox.Location = new Point(100, 123);
            soyadTextBox.Name = "soyadTextBox";
            soyadTextBox.Size = new Size(194, 27);
            soyadTextBox.TabIndex = 3;
            // 
            // soyadLabel
            // 
            soyadLabel.AutoSize = true;
            soyadLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            soyadLabel.Location = new Point(20, 123);
            soyadLabel.Name = "soyadLabel";
            soyadLabel.Size = new Size(69, 25);
            soyadLabel.TabIndex = 2;
            soyadLabel.Text = "Soyad:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(JoleCheckBox);
            panel2.Controls.Add(TirnakCheckBox);
            panel2.Controls.Add(FonCheckBox);
            panel2.Controls.Add(YuzBakimCheckBox);
            panel2.Controls.Add(SacBakimCheckBox);
            panel2.Controls.Add(BoyamaCheckBox);
            panel2.Controls.Add(YikamaCheckBox);
            panel2.Controls.Add(SakalBiyikCheckBox);
            panel2.Location = new Point(581, 377);
            panel2.Name = "panel2";
            panel2.Size = new Size(599, 230);
            panel2.TabIndex = 3;
            // 
            // JoleCheckBox
            // 
            JoleCheckBox.AutoSize = true;
            JoleCheckBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            JoleCheckBox.Location = new Point(397, 159);
            JoleCheckBox.Name = "JoleCheckBox";
            JoleCheckBox.Size = new Size(187, 60);
            JoleCheckBox.TabIndex = 15;
            JoleCheckBox.Text = "Jöle          - 30TL\r\nuygulama";
            JoleCheckBox.UseVisualStyleBackColor = true;
            JoleCheckBox.CheckedChanged += JoleCheckBox_CheckedChanged;
            // 
            // TirnakCheckBox
            // 
            TirnakCheckBox.AutoSize = true;
            TirnakCheckBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            TirnakCheckBox.Location = new Point(21, 169);
            TirnakCheckBox.Name = "TirnakCheckBox";
            TirnakCheckBox.Size = new Size(220, 32);
            TirnakCheckBox.TabIndex = 14;
            TirnakCheckBox.Text = "Tırnak Bakımı - 50TL";
            TirnakCheckBox.UseVisualStyleBackColor = true;
            TirnakCheckBox.CheckedChanged += TirnakCheckBox_CheckedChanged;
            // 
            // FonCheckBox
            // 
            FonCheckBox.AutoSize = true;
            FonCheckBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            FonCheckBox.Location = new Point(397, 121);
            FonCheckBox.Name = "FonCheckBox";
            FonCheckBox.Size = new Size(199, 32);
            FonCheckBox.TabIndex = 13;
            FonCheckBox.Text = "Fön Çekimi - 30TL";
            FonCheckBox.UseVisualStyleBackColor = true;
            FonCheckBox.CheckedChanged += FonCheckBox_CheckedChanged;
            // 
            // YuzBakimCheckBox
            // 
            YuzBakimCheckBox.AutoSize = true;
            YuzBakimCheckBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            YuzBakimCheckBox.Location = new Point(21, 121);
            YuzBakimCheckBox.Name = "YuzBakimCheckBox";
            YuzBakimCheckBox.Size = new Size(196, 32);
            YuzBakimCheckBox.TabIndex = 12;
            YuzBakimCheckBox.Text = "Yüz Bakımı - 75TL";
            YuzBakimCheckBox.UseVisualStyleBackColor = true;
            YuzBakimCheckBox.CheckedChanged += YuzBakimCheckBox_CheckedChanged;
            // 
            // SacBakimCheckBox
            // 
            SacBakimCheckBox.AutoSize = true;
            SacBakimCheckBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            SacBakimCheckBox.Location = new Point(397, 71);
            SacBakimCheckBox.Name = "SacBakimCheckBox";
            SacBakimCheckBox.Size = new Size(194, 32);
            SacBakimCheckBox.TabIndex = 11;
            SacBakimCheckBox.Text = "Saç Bakımı - 75TL";
            SacBakimCheckBox.UseVisualStyleBackColor = true;
            SacBakimCheckBox.CheckedChanged += SacBakimCheckBox_CheckedChanged;
            // 
            // BoyamaCheckBox
            // 
            BoyamaCheckBox.AutoSize = true;
            BoyamaCheckBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            BoyamaCheckBox.Location = new Point(21, 71);
            BoyamaCheckBox.Name = "BoyamaCheckBox";
            BoyamaCheckBox.Size = new Size(213, 32);
            BoyamaCheckBox.TabIndex = 10;
            BoyamaCheckBox.Text = "Saç Boyama - 150TL";
            BoyamaCheckBox.UseVisualStyleBackColor = true;
            BoyamaCheckBox.CheckedChanged += BoyamaCheckBox_CheckedChanged;
            // 
            // YikamaCheckBox
            // 
            YikamaCheckBox.AutoSize = true;
            YikamaCheckBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            YikamaCheckBox.Location = new Point(397, 21);
            YikamaCheckBox.Name = "YikamaCheckBox";
            YikamaCheckBox.Size = new Size(199, 32);
            YikamaCheckBox.TabIndex = 9;
            YikamaCheckBox.Text = "Saç Yıkama - 30TL";
            YikamaCheckBox.UseVisualStyleBackColor = true;
            YikamaCheckBox.CheckedChanged += YikamaCheckBox_CheckedChanged;
            // 
            // SakalBiyikCheckBox
            // 
            SakalBiyikCheckBox.AutoSize = true;
            SakalBiyikCheckBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            SakalBiyikCheckBox.Location = new Point(21, 21);
            SakalBiyikCheckBox.Name = "SakalBiyikCheckBox";
            SakalBiyikCheckBox.Size = new Size(371, 32);
            SakalBiyikCheckBox.TabIndex = 8;
            SakalBiyikCheckBox.Text = "Sakal bıyık kesim ve düzeltme - 75TL";
            SakalBiyikCheckBox.UseVisualStyleBackColor = true;
            SakalBiyikCheckBox.CheckedChanged += SakalBiyikCheckBox_CheckedChanged;
            // 
            // subayRadioButton
            // 
            subayRadioButton.AutoSize = true;
            subayRadioButton.Font = new Font("Trebuchet MS", 13.8F);
            subayRadioButton.Location = new Point(16, 62);
            subayRadioButton.Name = "subayRadioButton";
            subayRadioButton.Size = new Size(240, 32);
            subayRadioButton.TabIndex = 0;
            subayRadioButton.Text = "Subay Tıraşı - 175TL";
            subayRadioButton.UseVisualStyleBackColor = true;
            subayRadioButton.CheckedChanged += subayRadioButton_CheckedChanged;
            // 
            // FadeRadioButton
            // 
            FadeRadioButton.AutoSize = true;
            FadeRadioButton.Font = new Font("Trebuchet MS", 13.8F);
            FadeRadioButton.Location = new Point(297, 62);
            FadeRadioButton.Name = "FadeRadioButton";
            FadeRadioButton.Size = new Size(233, 32);
            FadeRadioButton.TabIndex = 1;
            FadeRadioButton.Text = "Fade Kesim - 200TL";
            FadeRadioButton.UseVisualStyleBackColor = true;
            FadeRadioButton.CheckedChanged += FadeRadioButton_CheckedChanged;
            // 
            // AmerikanRadioButton
            // 
            AmerikanRadioButton.AutoSize = true;
            AmerikanRadioButton.Font = new Font("Trebuchet MS", 13.8F);
            AmerikanRadioButton.Location = new Point(16, 109);
            AmerikanRadioButton.Name = "AmerikanRadioButton";
            AmerikanRadioButton.Size = new Size(279, 32);
            AmerikanRadioButton.TabIndex = 2;
            AmerikanRadioButton.Text = "Amerikan Tıraşı - 150TL";
            AmerikanRadioButton.UseVisualStyleBackColor = true;
            AmerikanRadioButton.CheckedChanged += AmerikanRadioButton_CheckedChanged;
            // 
            // BuzzRadioButton
            // 
            BuzzRadioButton.AutoSize = true;
            BuzzRadioButton.Font = new Font("Trebuchet MS", 13.8F);
            BuzzRadioButton.Location = new Point(297, 109);
            BuzzRadioButton.Name = "BuzzRadioButton";
            BuzzRadioButton.Size = new Size(264, 32);
            BuzzRadioButton.TabIndex = 3;
            BuzzRadioButton.Text = "Buzzcut Kesim - 250TL";
            BuzzRadioButton.UseVisualStyleBackColor = true;
            BuzzRadioButton.CheckedChanged += BuzzRadioButton_CheckedChanged;
            // 
            // UcRadioButton
            // 
            UcRadioButton.AutoSize = true;
            UcRadioButton.Font = new Font("Trebuchet MS", 13.8F);
            UcRadioButton.Location = new Point(16, 163);
            UcRadioButton.Name = "UcRadioButton";
            UcRadioButton.Size = new Size(229, 32);
            UcRadioButton.TabIndex = 4;
            UcRadioButton.Text = "Üç Numara - 100TL";
            UcRadioButton.UseVisualStyleBackColor = true;
            UcRadioButton.CheckedChanged += UcRadioButton_CheckedChanged;
            // 
            // UnderRadioButton
            // 
            UnderRadioButton.AutoSize = true;
            UnderRadioButton.Font = new Font("Trebuchet MS", 13.8F);
            UnderRadioButton.Location = new Point(297, 163);
            UnderRadioButton.Name = "UnderRadioButton";
            UnderRadioButton.Size = new Size(279, 32);
            UnderRadioButton.TabIndex = 5;
            UnderRadioButton.Text = "Undercut Kesim - 200TL";
            UnderRadioButton.UseVisualStyleBackColor = true;
            UnderRadioButton.CheckedChanged += UnderRadioButton_CheckedChanged;
            // 
            // ustlerKalsinRadioButton
            // 
            ustlerKalsinRadioButton.AutoSize = true;
            ustlerKalsinRadioButton.Font = new Font("Trebuchet MS", 13.8F);
            ustlerKalsinRadioButton.Location = new Point(114, 217);
            ustlerKalsinRadioButton.Name = "ustlerKalsinRadioButton";
            ustlerKalsinRadioButton.Size = new Size(347, 32);
            ustlerKalsinRadioButton.TabIndex = 6;
            ustlerKalsinRadioButton.Text = "Yanları al üstler kalsın - 125TL";
            ustlerKalsinRadioButton.UseVisualStyleBackColor = true;
            ustlerKalsinRadioButton.CheckedChanged += ustlerKalsinRadioButton_CheckedChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSkyBlue;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(AmerikanRadioButton);
            panel3.Controls.Add(UnderRadioButton);
            panel3.Controls.Add(UcRadioButton);
            panel3.Controls.Add(subayRadioButton);
            panel3.Controls.Add(ustlerKalsinRadioButton);
            panel3.Controls.Add(FadeRadioButton);
            panel3.Controls.Add(BuzzRadioButton);
            panel3.Location = new Point(581, 80);
            panel3.Name = "panel3";
            panel3.Size = new Size(599, 280);
            panel3.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(214, 9);
            label1.Name = "label1";
            label1.Size = new Size(165, 41);
            label1.TabIndex = 7;
            label1.Text = "Tıraşlar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(240, 19);
            label3.Name = "label3";
            label3.Size = new Size(734, 46);
            label3.TabIndex = 9;
            label3.Text = "ANIL KUAFÖR / RANDEVU SİSTEMİ (MÜŞTERİ)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold);
            label4.Location = new Point(708, 641);
            label4.Name = "label4";
            label4.Size = new Size(237, 38);
            label4.TabIndex = 10;
            label4.Text = "Toplam Tutar :";
            // 
            // tutarLabel
            // 
            tutarLabel.AutoSize = true;
            tutarLabel.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold);
            tutarLabel.Location = new Point(989, 641);
            tutarLabel.Name = "tutarLabel";
            tutarLabel.Size = new Size(0, 38);
            tutarLabel.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(1011, 635);
            label5.Name = "label5";
            label5.Size = new Size(86, 46);
            label5.TabIndex = 12;
            label5.Text = "0 TL";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(100, 297);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(23, 297);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 12;
            label6.Text = "Tarih:";
            // 
            // Musteri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1192, 712);
            Controls.Add(label5);
            Controls.Add(tutarLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Musteri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Musteri";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox adTextBox;
        private Label adLabel;
        private Panel panel1;
        private TextBox soyadTextBox;
        private Label soyadLabel;
        private Label epostaLabel;
        private Label telefonLabel;
        private TextBox PostaTextBox;
        private Panel panel2;
        private CheckBox YuzBakimCheckBox;
        private CheckBox SacBakimCheckBox;
        private CheckBox BoyamaCheckBox;
        private CheckBox YikamaCheckBox;
        private CheckBox SakalBiyikCheckBox;
        private RadioButton subayRadioButton;
        private RadioButton FadeRadioButton;
        private RadioButton AmerikanRadioButton;
        private RadioButton BuzzRadioButton;
        private RadioButton UcRadioButton;
        private RadioButton UnderRadioButton;
        private RadioButton ustlerKalsinRadioButton;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private CheckBox JoleCheckBox;
        private CheckBox TirnakCheckBox;
        private CheckBox FonCheckBox;
        private Label label3;
        private Button button1;
        private Label label4;
        private Label tutarLabel;
        private MaskedTextBox TelefonTextBox;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker1;
    }
}