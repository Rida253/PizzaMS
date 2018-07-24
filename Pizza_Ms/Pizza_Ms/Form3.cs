using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Ms
{
    public partial class Form3 : Form
    {
        Form1 f1;
        public Form3(Form1 ff)
        {
            f1 = ff;
            InitializeComponent();
        }
        //receptionist
        private void button1_Click(object sender, EventArgs e)
        {
            panel25.Show();
        }
        //admin
        private void button41_Click(object sender, EventArgs e)
        {

        }

        private void button66_Click(object sender, EventArgs e)
        {
            if (this.textBox83.Text == "BS3A" && this.textBox84.Text == "fuuast")
            {
                Form1 f1 = new Form1();
                f1.Show();
                panel1.Show();
                panel25.Hide();
               // button2.Hide();
               // button4.Hide();
                //button6.Hide();
               // f1.button7.Hide();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            panel25.Hide();
        }

        private void button67_Click(object sender, EventArgs e)
        {

        }
    }
}
