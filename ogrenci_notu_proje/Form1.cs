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
            int s�nav1, s�nav2;
            double ortalama;
            string ad, soyad;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            s�nav1 = Convert.ToInt32(textBox3.Text);
            s�nav2 = Convert.ToInt32(textBox4.Text);
            ortalama = (s�nav1 + s�nav2) / 2;
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
