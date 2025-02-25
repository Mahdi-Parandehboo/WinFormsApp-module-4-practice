using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_module_4_practice
{
    public partial class question4 : Form
    {
        public question4()
        {
            InitializeComponent();
        }

        private void question4_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == 37)
                label1.Left -= 50;
            else if (e.KeyValue == 38)
                label1.Top -= 50;
            else if (e.KeyValue == 39)
                label1.Left += 50;
            else if (e.KeyValue == 40)
                label1.Top += 50;
        }
    }
}
