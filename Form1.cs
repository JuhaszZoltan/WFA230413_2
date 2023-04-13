namespace WFA230413_2
{
    public partial class Form1 : Form
    {
        static Random rnd = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKoszonj_Click(object sender, EventArgs e)
        {
            lblSzoveg.Text = "Szia Zoli!";

            int r = rnd.Next(256);
            int g = rnd.Next(256);
            int b = rnd.Next(256);

            lblSzoveg.BackColor = Color.FromArgb(r, g, b);
        }
    }
}