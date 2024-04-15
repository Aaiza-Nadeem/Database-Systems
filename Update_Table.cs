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
    public partial class Update_Table : UserControl
    {
        public Update_Table()
        {
            InitializeComponent();
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Audio_Update audu1 = new Audio_Update();
            MainControlClass.showControl(audu1, panel2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ALBUM_Update au1 = new ALBUM_Update();
            MainControlClass.showControl(au1, panel2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Track_Update tu1 = new Track_Update();
            MainControlClass.showControl(tu1, panel2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Features_Update fu1 = new Features_Update();
            MainControlClass.showControl(fu1, panel2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Channel_Update cu1 = new Channel_Update();
            MainControlClass.showControl(cu1, panel2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Video_Update vu1 = new Video_Update();
            MainControlClass.showControl(vu1, panel2);
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
