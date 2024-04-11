using System.ComponentModel;
using System.Formats.Asn1;
using System.Globalization;

namespace urlap1
{
    public partial class Form1 : Form
    {
        public CountryData CountryData;
        public Form1()
        {
            InitializeComponent();

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = CountryData;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            {
                using (var writer = new StreamWriter("countries.csv"))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(countryList);
                };
            }
        }
    }
}