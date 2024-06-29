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
    public partial class Tutorial2 : Form
    {
        public Tutorial2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tutorials t = new Tutorials();
            t.Show();
            this.Close();
        }

       

        private void button16_Click(object sender, EventArgs e)
        {
            courseContent cc = new courseContent();
            cc.Show();
            this.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            t1p1 tt = new t1p1();
            tt.Show();

            this.Close();
        }

        private void Tutorial2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
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
