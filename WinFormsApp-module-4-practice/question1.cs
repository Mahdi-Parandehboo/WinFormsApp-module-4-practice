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
    public partial class question1 : Form
    {
        public question1()
        {
            InitializeComponent();
        }

        private void question1_KeyDown(object sender, KeyEventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void question1_KeyUp(object sender, KeyEventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void question1_Load(object sender, EventArgs e)
        {

        }
    }
}
