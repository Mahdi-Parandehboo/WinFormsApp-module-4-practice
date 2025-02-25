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
    public partial class question3 : Form
    {
        public question3()
        {
            InitializeComponent();
        }

        private void question3_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void question3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 37)
                button1.Left -= 50;
            else if (e.KeyValue == 38)
                button1.Top -= 50;
            else if (e.KeyValue == 39)
                button1.Left += 50;
            else if (e.KeyValue == 40)
                button1.Top += 50;
        }
    }
}
