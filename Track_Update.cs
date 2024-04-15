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
    public partial class Track_Update : UserControl
    {
        public Track_Update()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=AAIZA\\SQLEXPRESS;Initial Catalog=YOUTUBE_SPOTIFY_DATABASE;Integrated Security=True";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string updateTRACK = "UPDATE TRACK SET Duration_ms = @duration_ms WHERE Track_ID = @track_id";
            using (SqlCommand cmd = new SqlCommand(updateTRACK, con))
            {
                cmd.Parameters.AddWithValue("@duration_ms", textBox1.Text);
                cmd.Parameters.AddWithValue("@track_id", textBox16.Text);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Track record successfully updated!");
                    label1.SendToBack();
                    Home hm = new Home();
                    MainControlClass.showControl(hm, panel2);
                }
                else
                {
                    MessageBox.Show("Failed to update Track record.");
                }
            }
        }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Error number for unique constraint violation
                {
                    MessageBox.Show("Please ensure you have entered unique values in Track_ID or the referenced value doesnt exist in the the respective table.");
                }
                else
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
