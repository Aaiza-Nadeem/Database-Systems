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
    public partial class Search_Table : UserControl
    {
        public Search_Table()
        {
            InitializeComponent();
        }

        private void AlbumButton_Click(object sender, EventArgs e)
        {
            Album_Search as1 = new Album_Search();
            MainControlClass.showControl(as1, panel2);
        }

        private void AudioButton_Click(object sender, EventArgs e)
        {
            Audio_Search aus1 = new Audio_Search();
            MainControlClass.showControl(aus1, panel2);
        }

        private void ChannelButton_Click(object sender, EventArgs e)
        {
            Channel_Search chs1 = new Channel_Search();
            MainControlClass.showControl(chs1, panel2);
        }

        private void FeaturesButton_Click(object sender, EventArgs e)
        {
            Features_Search fs1 = new Features_Search();
            MainControlClass.showControl(fs1, panel2);
        }

        private void TrackButton_Click(object sender, EventArgs e)
        {
            Track_Search ts1 = new Track_Search();
            MainControlClass.showControl(ts1, panel2);
        }

        private void VideoButton_Click(object sender, EventArgs e)
        {
            Video_Search vs1 = new Video_Search();
            MainControlClass.showControl(vs1, panel2);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
