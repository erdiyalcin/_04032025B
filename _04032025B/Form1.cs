namespace _04032025B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.numara = 100;
            ogrenci.ad = "Erdi";
            ogrenci.soyad = "YALÇIN";

            MessageBox.Show("Numara : " + ogrenci.numara + "\n"
                           + "Ad : " + ogrenci.ad + "\n"
                           + "Soyad : " + ogrenci.soyad);

            MessageBox.Show(ogrenci.Yaz());

            Ogrenci ali = new Ogrenci();
            ali.numara = 200;
            ali.ad = "Ali";
            ali.soyad = "AL";


            MessageBox.Show(ali.Yaz());


            //int deger = Topla(3, 5);
            //MessageBox.Show("Toplam : " + deger);
        }

        public int Topla(int sayi1,int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }
    }
}
