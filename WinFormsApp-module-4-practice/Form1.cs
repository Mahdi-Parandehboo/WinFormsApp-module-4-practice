using System.Diagnostics;

namespace WinFormsApp_module_4_practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form_Loader(object form)
        {
            if (this.main.Controls.Count > 0)
                this.main.Controls.Clear();
            Form f = form as Form;
            f.TopLevel = true;               //it should br false
            f.Dock = DockStyle.Fill;
            //this.main.Controls.Add(f);
            f.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Loader(new question1());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Loader(new question2());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Loader(new question3());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_Loader(new question4());
        }
    }
}
