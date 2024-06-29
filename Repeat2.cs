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
    public partial class Repeat2 : Form
    {
        public Repeat2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prof22 pp = new prof22();
            pp.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            courseContent2 cc = new courseContent2();
            cc.Show();
            this.Close();
        }
    }
}
