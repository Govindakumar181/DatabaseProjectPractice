using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class DataGridView : Form
    {
        DBAccess objDbAccess = new DBAccess();
        DataTable dtTable = new DataTable();

        public DataGridView()
        {
            InitializeComponent();
        }

        private void DataGridView_Load(object sender, EventArgs e)
        {
            string query = "Select * from Users";
            objDbAccess.readDatathroughAdapter(query, dtTable);

            dataGridViewUsers.DataSource = dtTable;
            objDbAccess.closeConn();

        }

        private void btnPerformOperation_Click(object sender, EventArgs e)
        {
            string query = "select * from Users";
            int changes = objDbAccess.executeDataAdapter(dtTable,query);

            MessageBox.Show("count = " + changes);
        }
    }
}
