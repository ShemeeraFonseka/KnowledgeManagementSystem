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
    public partial class PractiseExam : Form
    {
        string a;

        public PractiseExam()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tutorial2 tu = new Tutorial2();
            tu.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Tutorials cc = new Tutorials();
            cc.Show();
            this.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
           Tutorial2 pe = new Tutorial2();
            pe.Show();
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
             int Mscore;
            Mscore = 0;

                if (radioButton3.Checked)
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
                if (radioButton10.Checked)
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

        private void PractiseExam_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ff = new Form2();
            ff.Show();
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            CourseNames cc = new CourseNames();
            cc.Show();
            this.Close();
        }
    }
}
