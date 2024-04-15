using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Channel_Search : UserControl
    {
        public Channel_Search()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=AAIZA\\SQLEXPRESS;Initial Catalog=YOUTUBE_SPOTIFY_DATABASE;Integrated Security=True";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string selectedItem = comboBox2.SelectedItem.ToString();
                    string Column = comboBox3.Text;
                    char condition;
                    if (!string.IsNullOrEmpty(selectedItem))
                    {
                        condition = selectedItem[0]; // Assuming the first character is the one you want to assign
                    }
                    else
                    {
                        MessageBox.Show("Please select a condition");
                        condition = '0';
                    }
                    string search_Audio1 = "SELECT * FROM CHANNEL where " + Column + " " + condition + " @Value";
                    using (SqlCommand cmd = new SqlCommand(search_Audio1, con))
                    {
                        cmd.Parameters.AddWithValue("@Value", textBox1.Text);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Error number for unique constraint violation
                {
                    MessageBox.Show("Please ensure you have entered unique values in Track_Name or the referenced value doesnt exist in the the respective table.");

                }
                else
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
