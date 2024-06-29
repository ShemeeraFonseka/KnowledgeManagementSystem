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
    public partial class repeat : Form
    {
        public repeat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prof11 pp = new prof11();
            pp.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            courseContent cc = new courseContent();
            cc.Show();
            this.Close();
        }

        private void repeat_Load(object sender, EventArgs e)
        {

        }
    }
}
