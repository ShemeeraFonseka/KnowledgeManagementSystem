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
    public partial class Tutorials : Form
    {

        public Tutorials()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tutorial2 t = new Tutorial2();
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
            PractiseExam pe = new PractiseExam();
            pe.Show();
            this.Close();
        }

        private void Tutorials_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
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
