namespace _04032025B
{
    partial class frmSayiTahminOyunu
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
            lblHak = new Label();
            lblSonuc = new Label();
            btnTahmin = new Button();
            txtTahmin = new TextBox();
            btnBaslat = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblHak
            // 
            lblHak.AutoSize = true;
            lblHak.Font = new Font("Segoe UI", 10F);
            lblHak.Location = new Point(180, 638);
            lblHak.Name = "lblHak";
            lblHak.Size = new Size(251, 54);
            lblHak.TabIndex = 11;
            lblHak.Text = "Kalan Hak : 5";
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Font = new Font("Segoe UI", 10F);
            lblSonuc.Location = new Point(180, 545);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(297, 54);
            lblSonuc.TabIndex = 10;
            lblSonuc.Text = "Oyun bekliyor...";
            // 
            // btnTahmin
            // 
            btnTahmin.BackColor = Color.Teal;
            btnTahmin.FlatStyle = FlatStyle.Flat;
            btnTahmin.Font = new Font("Segoe UI", 12F);
            btnTahmin.ForeColor = SystemColors.ControlLightLight;
            btnTahmin.Location = new Point(700, 419);
            btnTahmin.Name = "btnTahmin";
            btnTahmin.Size = new Size(300, 82);
            btnTahmin.TabIndex = 9;
            btnTahmin.Text = "Tahmin Et";
            btnTahmin.UseVisualStyleBackColor = false;
            btnTahmin.Click += btnTahmin_Click;
            // 
            // txtTahmin
            // 
            txtTahmin.Font = new Font("Segoe UI", 14F);
            txtTahmin.Location = new Point(180, 419);
            txtTahmin.Name = "txtTahmin";
            txtTahmin.Size = new Size(493, 82);
            txtTahmin.TabIndex = 8;
            // 
            // btnBaslat
            // 
            btnBaslat.Font = new Font("Segoe UI", 12F);
            btnBaslat.ForeColor = Color.Teal;
            btnBaslat.Location = new Point(320, 248);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(491, 98);
            btnBaslat.TabIndex = 7;
            btnBaslat.Text = "Oyunu Başlat";
            btnBaslat.UseVisualStyleBackColor = true;
            btnBaslat.Click += btnBaslat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(255, 106);
            label1.Name = "label1";
            label1.Size = new Size(647, 96);
            label1.TabIndex = 6;
            label1.Text = "Sayı Tahmin Oyunu";
            // 
            // frmSayiTahminOyunu
            // 
            AcceptButton = btnTahmin;
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1168, 807);
            Controls.Add(lblHak);
            Controls.Add(lblSonuc);
            Controls.Add(btnTahmin);
            Controls.Add(txtTahmin);
            Controls.Add(btnBaslat);
            Controls.Add(label1);
            Name = "frmSayiTahminOyunu";
            Text = "frmSayiTahminOyunu";
            Load += frmSayiTahminOyunu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHak;
        private Label lblSonuc;
        private Button btnTahmin;
        private TextBox txtTahmin;
        private Button btnBaslat;
        private Label label1;
    }
}