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
    public partial class Delete_Table : UserControl
    {
        public Delete_Table()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VideoButton_Click(object sender, EventArgs e)
        {
            Video_Delete vd3 = new Video_Delete();
            MainControlClass.showControl(vd3, panel2);
        }

        private void FeaturesButton_Click(object sender, EventArgs e)
        {
            Features_Delete fd3 = new Features_Delete();
            MainControlClass.showControl(fd3, panel2);
        }

        private void ChannelButton_Click(object sender, EventArgs e)
        {
            Channel_Delete cd3 = new Channel_Delete();
            MainControlClass.showControl(cd3, panel2);
        }

        private void AlbumButton_Click(object sender, EventArgs e)
        {
            Album_Delete abd3 = new Album_Delete();
            MainControlClass.showControl(abd3, panel2);
        }

        private void AudioButton_Click(object sender, EventArgs e)
        {
            Audio_Delete add3 = new Audio_Delete();
            MainControlClass.showControl(add3, panel2);
        }
    }
}
