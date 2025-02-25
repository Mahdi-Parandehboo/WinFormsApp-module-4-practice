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
    public partial class question2 : Form
    {
        public question2()
        {
            InitializeComponent();
        }

        private void question2_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void question2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 72)
                button1.Visible = false;
            else if (e.KeyValue == 68)
                button1.Visible = true;
            //   or
            /*button1.Text = e.KeyValue.ToString();
            if(e.KeyCode == Keys.H) 
                button1.Visible = true;
            else if (e.KeyCode == Keys.D)
                button1.Visible= true;*/
        }
    }
}
