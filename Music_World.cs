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

namespace WindowsFormsApp1
{
    public partial class Music_World : Form
    {
        public Music_World()
        {
            InitializeComponent();
            Home hm = new Home();
            MainControlClass.showControl(hm, panel2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Options uc1 = new Options();
            MainControlClass.showControl(uc1, panel2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            MainControlClass.showControl(hm, panel2);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

   }
}
