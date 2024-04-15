using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Insert : UserControl
    {
        public Insert()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
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

                    // Insert into ALBUM table
                    string insertAlbum = "INSERT INTO ALBUM (artist, album, album_type) VALUES (@artist, @album, @album_type)";
                    using (SqlCommand cmd = new SqlCommand(insertAlbum, con))
                    {
                        cmd.Parameters.AddWithValue("@artist", textBox2.Text);
                        cmd.Parameters.AddWithValue("@album", textBox3.Text);
                        cmd.Parameters.AddWithValue("@album_type", comboBox1.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Album record successfully inserted!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert album record.");
                        }
                    }

                    // Insert into Audio table
                    string insertAudio = "INSERT INTO Audio (Uri, Url_Spotify, Streams) VALUES (@Uri, @Url_Spotify, @Streams)";
                    using (SqlCommand cmd = new SqlCommand(insertAudio, con))
                    {
                        cmd.Parameters.AddWithValue("@Uri", textBox5.Text);
                        cmd.Parameters.AddWithValue("@Url_Spotify", textBox6.Text);
                        cmd.Parameters.AddWithValue("@Streams", textBox7.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Audio record successfully inserted!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert Audio record.");
                        }
                    }

                    // Insert into CHANNEL table
                    string insertCHANNEL = "INSERT INTO CHANNEL VALUES (@Channel, @Url_youtube, @likes, @Licensed)";
                    using (SqlCommand cmd = new SqlCommand(insertCHANNEL, con))
                    {
                        cmd.Parameters.AddWithValue("@Channel", textBox8.Text);
                        cmd.Parameters.AddWithValue("@Url_youtube", textBox11.Text);
                        cmd.Parameters.AddWithValue("@likes", textBox10.Text);
                        cmd.Parameters.AddWithValue("@Licensed", comboBox2.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Channel record successfully inserted!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert Channel record.");
                        }
                    }

                    // Insert into Features table
                    string insertFeatures = "INSERT INTO Features (Track_Name, Energy, Speechiness, Danceability, Liveness, Loudness, Tempo, Valence, Track_Key, Acousticness, Instrumentalness) " +
                        "VALUES (@Track_Name, @Energy, @Speechiness, @Danceability, @Liveness, @Loudness, @Tempo, @Valence, @Track_Key, @Acousticness, @Instrumentalness)";
                    using (SqlCommand cmd = new SqlCommand(insertFeatures, con))
                    {
                        cmd.Parameters.AddWithValue("@Track_Name", textBox16.Text);
                        cmd.Parameters.AddWithValue("@Energy", textBox15.Text);
                        cmd.Parameters.AddWithValue("@Speechiness", textBox14.Text);
                        cmd.Parameters.AddWithValue("@Danceability", textBox13.Text);
                        cmd.Parameters.AddWithValue("@Liveness", textBox12.Text);
                        cmd.Parameters.AddWithValue("@Loudness", textBox27.Text);
                        cmd.Parameters.AddWithValue("@Tempo", textBox25.Text);
                        cmd.Parameters.AddWithValue("@Valence", textBox26.Text);
                        cmd.Parameters.AddWithValue("@Track_Key", textBox23.Text);
                        cmd.Parameters.AddWithValue("@Acousticness", textBox24.Text);
                        cmd.Parameters.AddWithValue("@Instrumentalness", textBox19.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Features record successfully inserted!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert Features record.");
                        }
                    }
                    string insertVideo = "INSERT INTO Video VALUES (@Title, @Video_Views, @Video_Description, @Comments,@official_video)";
                    using (SqlCommand cmd = new SqlCommand(insertVideo, con))
                    {
                        cmd.Parameters.AddWithValue("@Title", textBox22.Text);
                        cmd.Parameters.AddWithValue("@Video_Views", textBox21.Text);
                        cmd.Parameters.AddWithValue("@Video_Description", comboBox3.Text);
                        cmd.Parameters.AddWithValue("@Comments", textBox28.Text);
                        cmd.Parameters.AddWithValue("@official_video", textBox12.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Video record successfully inserted!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert Video record.");
                        }
                    }

                    // Insert into TRACK table
                    string insertTrack = "INSERT INTO TRACK (Track_ID, Album, Artist, Track_Name, Url_youtube, Uri, Title, Duration_ms) " +
                        "VALUES (@Track_ID, @Album, @Artist, @Track_Name, @Url_youtube, @Uri, @Title, @Duration_ms)";
                    using (SqlCommand cmd = new SqlCommand(insertTrack, con))
                    {
                        // Get the maximum Track_ID from the TRACK table and increment it by 1
                        string getMaxTrackIdQuery = "SELECT MAX(Track_ID) FROM TRACK";
                        int newTrackId;
                        using (SqlCommand getMaxTrackIdCmd = new SqlCommand(getMaxTrackIdQuery, con))
                        {
                            newTrackId = Convert.ToInt32(getMaxTrackIdCmd.ExecuteScalar()) + 1;
                        }

                        cmd.Parameters.AddWithValue("@Track_ID", newTrackId);
                        cmd.Parameters.AddWithValue("@Album", textBox3.Text);
                        cmd.Parameters.AddWithValue("@Artist", textBox2.Text);
                        cmd.Parameters.AddWithValue("@Track_Name", textBox16.Text);
                        cmd.Parameters.AddWithValue("@Url_youtube", textBox11.Text);
                        cmd.Parameters.AddWithValue("@Uri", textBox5.Text);
                        cmd.Parameters.AddWithValue("@Title", textBox22.Text);
                        cmd.Parameters.AddWithValue("@Duration_ms", textBox17.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Track record successfully inserted!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert Track record.");
                        }
                    }

                    // Clear the text boxes and combo boxes after successful insertion
                    textBox2.Clear();
                    textBox3.Clear();
                    comboBox1.SelectedIndex = -1;
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    textBox8.Clear();
                    textBox11.Clear();
                    textBox10.Clear();
                    comboBox2.SelectedIndex = -1;
                    textBox16.Clear();
                    textBox15.Clear();
                    textBox14.Clear();
                    textBox13.Clear();
                    textBox12.Clear();
                    textBox27.Clear();
                    textBox26.Clear();
                    textBox25.Clear();
                    textBox24.Clear();
                    textBox19.Clear();
                    textBox22.Clear();
                    textBox21.Clear();
                    comboBox3.SelectedIndex = -1;
                    textBox28.Clear();
                    textBox17.Clear();
                    textBox23.Clear();
                    textBox20.Clear();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Error number for unique constraint violation
                {
                    MessageBox.Show("Please ensure you have entered unique values in (Artist&Album,Title,Track_Name,Uri,URL_YOUTUBE)or the referenced Values already exists in the their respective tables.");
                }
                else
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            Home hm = new Home();
            MainControlClass.showControl(hm, panel2);
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
