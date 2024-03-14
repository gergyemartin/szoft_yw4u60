namespace Hajosteszt
{
    public partial class Form1 : Form
    {
        List<Kerdes> OsszesKerdes;
        List<Kerdes> AktualisKerdesek;
        int MegjelenitettKerdesSzama = 5;
        public Form1()
        {
            InitializeComponent();
        }
        void KerdesMegjelenites(Kerdes kerdes)
        {
            label1.Text = kerdes.KerdesSzoveg;
            textBox1.Text = kerdes.Válasz1;
            textBox2.Text = kerdes.Válasz2;
            textBox3.Text = kerdes.Válasz3;

            if (!string.IsNullOrEmpty(kerdes.URL))
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + kerdes.URL);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            OsszesKerdes = KerdesekBetoltse();
            AktualisKerdesek = new List<Kerdes>();

            for (int i = 0; i < 7; i++)
            {
                AktualisKerdesek.Add(OsszesKerdes[0]);
                OsszesKerdes.RemoveAt(0);
            }
            dataGridView1.DataSource = AktualisKerdesek;
            KerdesMegjelenites(AktualisKerdesek[MegjelenitettKerdesSzama]);
        }
        List<Kerdes> KerdesekBetoltse()
        {
            List<Kerdes> kerdesek = new List<Kerdes>();
            StreamReader sr = new StreamReader("hajos.txt", true);
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] sorok = sor.Split("\t");
                Kerdes k = new Kerdes();
                k.KerdesSzoveg = sorok[1];
                k.Válasz1 = sorok[2].Trim('"');
                k.Válasz2 = sorok[3].Trim('"');
                k.Válasz3 = sorok[4].Trim('"');
                k.URL = sorok[5];
                int x = 0;
                int.TryParse(sorok[6], out x);
                k.HelyesValasz = x;
                kerdesek.Add(k);
            }
            sr.Close();
            return kerdesek;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MegjelenitettKerdesSzama++;
            if (MegjelenitettKerdesSzama == AktualisKerdesek.Count)
            {
                MegjelenitettKerdesSzama = 0;
            }
            KerdesMegjelenites(AktualisKerdesek[MegjelenitettKerdesSzama]);
        }
    }
}