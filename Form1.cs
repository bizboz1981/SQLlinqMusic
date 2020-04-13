using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlS
{
    public partial class frmAlbum : Form
    {
        public frmAlbum()
        {
            InitializeComponent();
        }
        SqlConnection cnn;
        public string connectionString = @"Data Source = ISS-6H038555H\BILLSQLSERVER; Initial Catalog = Bill_Music; Integrated Security = True;";
        SqlCommand command;
        string sql = "";
        string Output = "";
        DataTable table = new DataTable();
        int pos;
        SqlDataAdapter adapter = new SqlDataAdapter();



        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlDataReader datareader;
            sql = "SELECT Albumid, AlbumTitle, Artist, Price FROM Album";
            command = new SqlCommand(sql, cnn);
            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                Output = Output + datareader.GetValue(0) + " - " + datareader.GetValue(1) + " - " + datareader.GetValue(2) + " - " + datareader.GetValue(3) + "\n";
            }
            MessageBox.Show(Output);
            datareader.Close();
            command.Dispose();
            cnn.Close();
        }

        private void BtnInsertData_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            cnn.Open();
            sql = "INSERT into Album(Albumid, AlbumTitle, Genre, Price, Artist) values('" + txtAlbumID.Text + "','" + txtAlbumTitle.Text + "','" + txtGenre.Text + "','" + txtPrice.Text + "','" + txtArtist.Text + "')";
            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();
        }

        private void btnAmend_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            cnn.Open();
            sql = "UPDATE Album SET AlbumTitle = '" + txtAlbumTitle.Text + "', Artist = '" + txtArtist.Text + "', " + "Genre = '" + txtGenre.Text + "', Price = '" + txtPrice.Text + "' WHERE AlbumID = '" + txtAlbumID.Text + "'";
            command = new SqlCommand(sql, cnn);
            adapter.UpdateCommand = new SqlCommand(sql, cnn);
            adapter.UpdateCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Really?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                cnn.Open();
                sql = "DELETE Album WHERE AlbumID = ('" + txtAlbumID.Text + "')";
                command = new SqlCommand(sql, cnn);
                adapter.DeleteCommand = new SqlCommand(sql, cnn);
                adapter.DeleteCommand.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();
            } 
            
        }

        private void frmAlbum_Load(object sender, EventArgs e)
        {
            //connectionString = (@"Data Source = ISS-6H038555H\BILLSQLSERVER; Initial Catalog = Bill_Music; Integrated Security = True;");
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            MessageBox.Show("You have successfully connected to the Bill Music Database!");
            btnDisplay.Visible = true;
            btnInsertData.Visible = true;
            cnn.Close();
            adapter = new SqlDataAdapter("SELECT * FROM Album", cnn);
            adapter.Fill(table);

        }

        public void ShowData(int index)
        {
            txtAlbumID.Text = table.Rows[index][0].ToString();
            txtAlbumTitle.Text = table.Rows[index][1].ToString();
            txtArtist.Text = table.Rows[index][2].ToString();
            txtGenre.Text = table.Rows[index][3].ToString();
            txtPrice.Text = table.Rows[index][4].ToString();
        }

        private void btnFirstRec_Click(object sender, EventArgs e)
        {
            pos = 0;
            ShowData(pos);
            lblRecordCount.Text = $"Record {(pos + 1).ToString()} of {table.Rows.Count}.";
        }

        private void btnNextRec_Click(object sender, EventArgs e)
        {
            pos++;
            if (pos < table.Rows.Count)
            {
                ShowData(pos);
                lblRecordCount.Text = $"Record {(pos + 1).ToString()} of {table.Rows.Count}.";
            }
            else
            {
                MessageBox.Show("End of records");
                pos = (table.Rows.Count - 1);
            }
        }

        private void btnPrevRec_Click(object sender, EventArgs e)
        {
            pos--;
            if (pos >= 0)
            {
                ShowData(pos);
                lblRecordCount.Text = $"Record {(pos + 1).ToString()} of {table.Rows.Count}.";
            }
            else
            {
                MessageBox.Show("End of records");
                pos = (0);
            }
        }

        private void btnLastRec_Click(object sender, EventArgs e)
        {
            pos = table.Rows.Count - 1;
            ShowData(pos);
            lblRecordCount.Text = $"Record {(pos + 1).ToString()} of {table.Rows.Count}.";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var srchFrm = new SearchForm();
            srchFrm.Show();
            //cnn.Open();
            //SqlDataReader datareader;
            //sql = $"SELECT Albumid, AlbumTitle, Artist, Price FROM Album WHERE Artist = '{txtArtist.Text}' OR AlbumID = '{txtAlbumID.Text}' OR AlbumTitle = '{txtAlbumTitle.Text}'";
            //command = new SqlCommand(sql, cnn);
            //datareader = command.ExecuteReader();
            //while (datareader.Read())
            //{
            //    Output = Output + datareader.GetValue(0) + " - " + datareader.GetValue(1) + " - " + datareader.GetValue(2) + " - " + datareader.GetValue(3) + "\n";
            //}

            //MessageBox.Show(Output);
            //datareader.Close();
            //command.Dispose();
            //cnn.Close();
        }

        private void btnSQL_Click(object sender, EventArgs e)
        {
            var frmTest = new frmTest();
            frmTest.Show();
        }
    }
}
