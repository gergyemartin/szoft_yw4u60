namespace Kamatszamitas3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hitel = int.Parse(textBoxHitelOssz.Text);
            int torleszto = int.Parse(textBoxTorl.Text);
            int kamat = int.Parse(textBoxKamat.Text);

            int befizetett = 0;
            int hatralek = hitel;
            int honap = 0;

            List<Sor> sorok = new List<Sor>();
            while (hatralek > 0)
            {
                hatralek += kamat * (hatralek / 100);
                hatralek -= torleszto;
                befizetett += torleszto;
                honap++;


                Sor ujsor = new Sor();
                ujsor.Hatralek = hatralek;
                ujsor.Honap = honap;
                ujsor.Befizetett = befizetett;

                sorok.Add(ujsor);
                if (hatralek < 0)
                {
                    sorok.Remove(ujsor);
                }
            }
            dataGridView1.DataSource = sorok;
        }
    }
}