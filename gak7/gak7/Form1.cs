using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace gak7
{
    public partial class Form1 : Form
    {
        BindingList<CountryData> countryList = new BindingList<CountryData>();
        public Form1()
        {
            InitializeComponent();

            countryDataBindingSource.DataSource = countryList;
            dataGridView1.DataSource = countryDataBindingSource;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("european_countries.csv");
            var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
            var tomb = csv.GetRecords<CountryData>();
            foreach (var item in tomb)
            {
                countryList.Add(item);
            }
        }

        private void buttonTorles_Click(object sender, EventArgs e)
        {
            countryDataBindingSource.RemoveCurrent();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Form1 fce = new Form1();
            fce.countryDataBindingSource = countryDataBindingSource.Current as CountryData;
            fce.Show();
        }
    }
}