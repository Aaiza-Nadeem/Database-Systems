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
    public partial class Album_Delete : UserControl
    {
        public Album_Delete()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=AAIZA\\SQLEXPRESS;Initial Catalog=YOUTUBE_SPOTIFY_DATABASE;Integrated Security=True";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string deleteAlbum = "DELETE FROM ALBUM WHERE  album= @album and artist=@artist";
                    using (SqlCommand cmd = new SqlCommand(deleteAlbum, con))
                    {
                        cmd.Parameters.AddWithValue("@album", textBox16.Text);
                        cmd.Parameters.AddWithValue("@artist", textBox1.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Album records successfully deleted!");
                            Home hm = new Home();
                            MainControlClass.showControl(hm, panel2);
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete Album records.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Error number for unique constraint violation
                {
                    MessageBox.Show("Please ensure you have entered unique values in Album&Artist or the referenced values don't exist in the the respective table.");

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
