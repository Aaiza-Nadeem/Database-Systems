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
    public partial class Options : UserControl
    {
        public Options()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Insert uc2 = new Insert();
            MainControlClass.showControl(uc2, panel2);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Update_Table uc3 = new Update_Table();
            MainControlClass.showControl(uc3, panel2);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Display_Table dt1 = new Display_Table();
            MainControlClass.showControl(dt1, panel2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Search_Table st1 = new Search_Table();
            MainControlClass.showControl(st1, panel2);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Delete_Table dlt1 = new Delete_Table();
            MainControlClass.showControl(dlt1, panel2);
        }
    }
}
