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
    public partial class score : Form
    {

        string b;
        public score()
        {
            InitializeComponent();
        }

        private void score_Load(object sender, EventArgs e)
        {
            label1.Text = "Your Score is "+b;
        }

        public void pass(string a)
        {
            b = a.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
