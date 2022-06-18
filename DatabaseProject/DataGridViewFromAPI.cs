using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DatabaseProject
{
    public partial class DataGridViewFromAPI : Form
    {

        localhost.WebService1 proxy = new localhost.WebService1();

        public DataGridViewFromAPI()
        {
            InitializeComponent();
        }



        

        private void DataGridViewFromAPI_Load(object sender, EventArgs e)
        {
            string CountriesJason = proxy.Countries();

            DataTable dtCountrieGrid = JsonConvert.DeserializeObject<DataTable>(CountriesJason);

            dataGridViewAPI.DataSource = dtCountrieGrid;
            //            dataGridViewAPI.DataSource = dtCountrieGrid;

        }
    }
}
