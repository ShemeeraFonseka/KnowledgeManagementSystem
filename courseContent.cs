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
    public partial class courseContent : Form
    {
        

        public courseContent()
        {
            InitializeComponent();

           

            
        }

        

        private void label3_Click(object sender, EventArgs e)
        {
            Tutorials t = new Tutorials();
            t.Show();
            this.Close();


        }

        private void courseContent_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            PractiseExam pe = new PractiseExam();
            pe.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Tutorial2 tt = new Tutorial2();
            tt.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            t1p1 tt = new t1p1();
            tt.Show();
            this.Close();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            T2001 tt = new T2001();
            tt.Show();
            this.Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            _12pe1 pe = new _12pe1();
            pe.Show();
            this.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            _12tu2 tu = new _12tu2();
            tu.Show();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            e1 ee = new e1();
            ee.Show();
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            courseContent2 cc = new courseContent2();
            cc.Show();
            this.Close();
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
