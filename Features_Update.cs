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
    public partial class Features_Update : UserControl
    {
        public Features_Update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=AAIZA\\SQLEXPRESS;Initial Catalog=YOUTUBE_SPOTIFY_DATABASE;Integrated Security=True";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string Column = comboBox1.Text;
                    string updateFeatures = "UPDATE Features SET " + Column +" = @Value WHERE Track_Name= @Track_Name";
                    using (SqlCommand cmd = new SqlCommand(updateFeatures, con))
                    {
                        cmd.Parameters.AddWithValue("@Value ", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Track_Name", textBox16.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Features record successfully updated!");
                            Home hm = new Home();
                            MainControlClass.showControl(hm, panel2);
                        }
                        else
                        {
                            MessageBox.Show("Failed to update Features record.");
                        }
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
