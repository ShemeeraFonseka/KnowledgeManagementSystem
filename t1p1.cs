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
    public partial class t1p1 : Form
    {
        string a;

        public t1p1()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Tutorial2 tt = new Tutorial2();
            tt.Show();
            this.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            T2001 tt = new T2001();
            tt.Show();
            this.Close();
        }

        private void t1p1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
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
            if (radioButton15.Checked)
            {
                Mscore = Mscore + 1;
            }
            if (radioButton9.Checked)
            {
                Mscore = Mscore + 1;
            }
            if (radioButton22.Checked)
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
