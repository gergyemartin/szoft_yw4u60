namespace Pascal2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Button b = new Button();
                    b.Text = (i * j).ToString();
                    b.Top = i * 40;
                    b.Left = (j * 40) - (i * (40 / 2)) + 300;
                    b.Height = 40;
                    b.Width = 40;
                    int a = Faktorialis(i) / (Faktorialis(j) * Faktorialis(i - j));
                    b.Text = a.ToString();
                    Controls.Add(b);
                }
            }
        }
        public int Faktorialis(int n)
        {
            int eredmeny = 1;
            for (int i = 1; i <=n; i++)
            {
                eredmeny *= i;
            }
            return eredmeny;
        }
    }
}