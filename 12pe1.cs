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
    public partial class _12pe1 : Form
    {
        string a;

        public _12pe1()
        {
            InitializeComponent();
        }

        private void _12pe1_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            T2001 tt = new T2001();
            tt.Show();
            this.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            _12tu2 tt = new _12tu2();
            tt.Show();
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int Mscore;
            Mscore = 0;

            if (radioButton1.Checked)
            {
                Mscore = Mscore + 1;
            }
            if (radioButton5.Checked)
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
            if (radioButton20.Checked)
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
