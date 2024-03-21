namespace Snakeű
{
    public partial class Form1 : Form
    {
        int fej_x = 100;
        int fej_y = 100;
        int irány_x = 1;
        int irány_y = 0;
        int lepesszam;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<KigyoElem> kigyo = new List<KigyoElem>();
            fej_x += irány_x * KigyoElem.Meret;
            fej_y += irány_y * KigyoElem.Meret;
            KigyoElem ke = new KigyoElem();
            int hossz = ke.Hossz;
            if (kigyo.Count > hossz)
            {
                KigyoElem levágandó = kigyo[0];
                kigyo.RemoveAt(0);
                Controls.Remove(levágandó);
            }
            kigyo.Add(ke);

            Controls.Add(ke);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lepesszam++;

            fej_x += irány_x * KigyoElem.Meret;
            fej_y += irány_y * KigyoElem.Meret;
            foreach (KigyoElem item in Controls)
            {
                if (item.Top == fej_y && item.Left == fej_x)
                {
                    timer1.Enabled = false;
                    return;
                }
            }

            KigyoElem ke = new KigyoElem();
            int hossz = ke.Hossz;
            ke.Top = fej_y;
            ke.Left = fej_x;

            if (Controls.Count > hossz)
            {
                //KigyoElem levagando = ke[0];
                Controls.RemoveAt(0);
            }

            if (lepesszam % 2 == 0)
            {
                ke.BackColor = Color.Yellow;
                hossz++;
            }
            Controls.Add(ke);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                irány_y = -1;
                irány_x = 0;
            }
            if (e.KeyCode == Keys.Down)
            {
                irány_y = 1;
                irány_x = 0;
            }
            if (e.KeyCode == Keys.Right)
            {
                irány_y = 0;
                irány_x = 1;
            }
            if (e.KeyCode == Keys.Left)
            {
                irány_y = 0;
                irány_x = -1;
            }
        }
    }
}