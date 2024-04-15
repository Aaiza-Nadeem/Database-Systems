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
    public partial class Features_Display : UserControl
    {
        public Features_Display()
        {
            string connectionString = "Data Source=AAIZA\\SQLEXPRESS;Initial Catalog=YOUTUBE_SPOTIFY_DATABASE;Integrated Security=True";
            InitializeComponent();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string selectQuery = "SELECT * FROM Features";
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
