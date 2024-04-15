using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Channel_Update : UserControl
    {
        public Channel_Update()
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
                    string updateChannel = "UPDATE CHANNEL SET " + Column + " = @Values WHERE Url_youtube = @Url_youtube";
                    using (SqlCommand cmd = new SqlCommand(updateChannel, con))
                    {
                        cmd.Parameters.AddWithValue("@Values", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Url_youtube", textBox16.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Channel record successfully updated!");
                            Home hm = new Home();
                            MainControlClass.showControl(hm, panel2);
                        }
                        else
                        {
                            MessageBox.Show("Failed to update channel record.");
                        }
                    }





                }

            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Error number for unique constraint violation
                {
                    MessageBox.Show("Please ensure you have entered unique values in Youtube_URL or the referenced value doesnt exist in the the respective table.");

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
