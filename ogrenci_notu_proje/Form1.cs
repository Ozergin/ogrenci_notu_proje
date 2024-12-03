namespace ogrenci_notu_proje
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            int sýnav1, sýnav2;
            double ortalama;
            string ad, soyad;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            sýnav1 = Convert.ToInt32(textBox3.Text);
            sýnav2 = Convert.ToInt32(textBox4.Text);
            ortalama = (sýnav1 + sýnav2) / 2;
            listBox1.Items.Add(ad + " " + soyad + " " + ortalama + " ");


        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
