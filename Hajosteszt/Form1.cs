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

        private void Form1_Load(object sender, EventArgs e)
        {
            OsszesKerdes = new List<Kerdes>();

        }
        List<Kerdes> KerdesekBetoltse()
        {
            List<Kerdes> kerdesek = new List<Kerdes>();
            OsszesKerdes = KerdesekBetoltse();
            StreamReader sr = new StreamReader("hajos.txt",true);
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] sorok = sor.Split("\t");
                Kerdes k = new Kerdes();
                k.KerdesSzoveg = sorok[1];
                k.V�lasz1 = sorok[2];
                k.V�lasz2 = sorok[3];
                k.V�lasz3 = sorok[4];
                k.URL = sorok[5];
                int x = 0;
                int.TryParse(sorok[6], out x);
                k.HelyesValasz = x;
                kerdesek.Add(k);
            }
            sr.Close();

            return kerdesek;
        }
    }
}