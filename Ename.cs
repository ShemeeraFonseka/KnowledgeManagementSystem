using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMS
{
    public partial class Ename : Form
    {

        public static string nm;

        public Ename()
        {
            InitializeComponent();
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
                Certificate cc = new Certificate();
                cc.Show();
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Ename_Load(object sender, EventArgs e)
        {
            
        }
    }
}
