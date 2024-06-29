using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMS
{

    
    public partial class Ename2 : Form
    {
        public static string nm;
        public Ename2()
        {
            InitializeComponent();
        }

        private void Ename2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nm = textBox1.Text;


            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Please enter your name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {


                Certificate2 cc = new Certificate2();
                cc.Show();
                this.Close();


            }
        }
    }
}
