using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04032025B
{
    public partial class frmSayiTahminOyunu : Form
    {
        private int tahminEdilecekSayi;
        private int hak;
        public frmSayiTahminOyunu()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            OyunuBaslat();
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtTahmin.Text);
            if (sayi > tahminEdilecekSayi)
            {
                lblSonuc.Text = "Daha küçük bir sayı giriniz.";
                hak = hak - 1; // hak--;
            }
            else if (sayi < tahminEdilecekSayi)
            {
                lblSonuc.Text = "Daha büyük bir sayı giriniz.";
                hak = hak - 1; // hak--;
            }
            else
            {
                lblSonuc.Text = "Tebrikler";
            }

            lblHak.Text = "Kalan Hak : " + hak;

            if (hak == 0)
            {
                lblSonuc.Text = "Game Over -> " + tahminEdilecekSayi;
                btnBaslat.Visible = true;
                btnTahmin.Enabled = false;
            }

        }

        private void frmSayiTahminOyunu_Load(object sender, EventArgs e)
        {
            OyunuBaslat();
        }

        private void OyunuBaslat()
        {
            Random random = new Random();
            tahminEdilecekSayi = random.Next(1, 101); // 1 ile 100 arası değerler
            lblSonuc.Text = "Oyun başladı.";
            hak = 5;
            btnBaslat.Visible = false;
            btnTahmin.Enabled = true;
            txtTahmin.Text = "";
            txtTahmin.Focus();
        }


    }
}
