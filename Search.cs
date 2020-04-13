using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlS
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        public string connectionString = (@"Data Source = ISS-6H038555H\BILLSQLSERVER; Initial Catalog = Bill_Music; Integrated Security = True;");
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        SqlDataReader dataReader;
        string sql = "", output = "";

        private void SearchForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            sqlConnection.Close();
            FillComboBox();
        }

        private void FillComboBox()
        {

        }
    } 
} 
// TODO: This line of code loads data into the 'bill_MusicDataSet.Album' table. You can move, or remove it, as needed.
        // this.albumTableAdapter.Fill(this.bill_MusicDataSet.Album);