namespace NDP_PROJECT_V1
{
    partial class Personel
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
            label3 = new Label();
            RandevuAlButton = new Button();
            RandevuDuzenleButton = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(214, 25);
            label3.Name = "label3";
            label3.Size = new Size(757, 46);
            label3.TabIndex = 15;
            label3.Text = "ANIL KUAFÖR / RANDEVU SİSTEMİ (PERSONEL)";
            // 
            // RandevuAlButton
            // 
            RandevuAlButton.BackColor = Color.LightCyan;
            RandevuAlButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            RandevuAlButton.Location = new Point(610, 153);
            RandevuAlButton.Name = "RandevuAlButton";
            RandevuAlButton.Size = new Size(455, 164);
            RandevuAlButton.TabIndex = 9;
            RandevuAlButton.Text = "Randevu Al";
            RandevuAlButton.UseVisualStyleBackColor = false;
            RandevuAlButton.Click += RandevuAlButton_Click;
            // 
            // RandevuDuzenleButton
            // 
            RandevuDuzenleButton.BackColor = Color.Gold;
            RandevuDuzenleButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            RandevuDuzenleButton.Location = new Point(55, 153);
            RandevuDuzenleButton.Name = "RandevuDuzenleButton";
            RandevuDuzenleButton.Size = new Size(491, 164);
            RandevuDuzenleButton.TabIndex = 18;
            RandevuDuzenleButton.Text = "Randevuları Düzenle";
            RandevuDuzenleButton.UseVisualStyleBackColor = false;
            RandevuDuzenleButton.Click += RandevuDuzenleButton_Click;
            // 
            // Personel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1158, 375);
            Controls.Add(RandevuDuzenleButton);
            Controls.Add(RandevuAlButton);
            Controls.Add(label3);
            Name = "Personel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personel";
            Load += Personel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Button RandevuAlButton;
        private Button RandevuDuzenleButton;
    }
}