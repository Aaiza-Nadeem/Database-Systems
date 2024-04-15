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
    public partial class Channel_Display : UserControl
    {
        public Channel_Display()
        {
            string connectionString = "Data Source=AAIZA\\SQLEXPRESS;Initial Catalog=YOUTUBE_SPOTIFY_DATABASE;Integrated Security=True";
            InitializeComponent();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string selectQuery = "SELECT * FROM CHANNEL";
                using (SqlCommand cmd = new SqlCommand(selectQuery, con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Display the results in a DataGridView or any other desired UI element
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
