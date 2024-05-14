namespace Sakktábla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int szam = 40;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button b = new Button();
                    b.Height = szam;
                    b.Width = szam;
                    b.Top = i * szam;
                    b.Left = j * szam;

                    if ((i % 2 == 0 && j % 2 == 0) || (i % 2 == 1 && j % 2 == 1))
                    {
                        Controls.Add(b);
                    }
                }
            }
        }
    }
}