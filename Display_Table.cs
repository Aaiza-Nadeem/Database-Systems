using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Display_Table : UserControl
    {
        public Display_Table()
        {
            InitializeComponent();
        }

        private void AlbumButton_Click(object sender, EventArgs e)
        {
            Album_Display ad1 = new Album_Display();
            MainControlClass.showControl(ad1, panel2);
        }

        private void AudioButton_Click(object sender, EventArgs e)
        {
            Audio_Display audd1 = new Audio_Display();
            MainControlClass.showControl(audd1, panel2);
        }

        private void ChannelButton_Click(object sender, EventArgs e)
        {
            Channel_Display cd1 = new Channel_Display();
            MainControlClass.showControl(cd1, panel2);
        }

        private void FeaturesButton_Click(object sender, EventArgs e)
        {
            Features_Display fd1 = new Features_Display();
            MainControlClass.showControl(fd1, panel2);
        }

        private void TrackButton_Click(object sender, EventArgs e)
        {
            Track_Display td1 = new Track_Display();
            MainControlClass.showControl(td1, panel2);
        }

        private void VideoButton_Click(object sender, EventArgs e)
        {
            Video_Display vd1 = new Video_Display();
            MainControlClass.showControl(vd1, panel2);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
