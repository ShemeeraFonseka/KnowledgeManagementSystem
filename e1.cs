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
    public partial class e1 : Form
    {
        string a;

        public e1()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            _12tu2 tt = new _12tu2();
            tt.Show();
            this.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            prof11 pp = new prof11();
            pp.Show();
            this.Close();
        }

        private void e1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            int Mscore;
            Mscore = 0;

            if (radioButton3.Checked)
            {
                Mscore = Mscore + 1;
            }
            if (radioButton6.Checked)
            {
                Mscore = Mscore + 1;
            }
            if (radioButton16.Checked)
            {
                Mscore = Mscore + 1;
            }
            if (radioButton11.Checked)
            {
                Mscore = Mscore + 1;
            }
            if (radioButton18.Checked)
            {
                Mscore = Mscore + 1;
            }



            a = Mscore.ToString();
            score cs = new score();
            cs.pass(a.ToString());
            cs.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ff = new Form2();
            ff.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CourseNames cc = new CourseNames();
            cc.Show();
            this.Close();
        }
    }
}
