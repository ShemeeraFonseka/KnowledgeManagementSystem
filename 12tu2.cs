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
    public partial class _12tu2 : Form
    {
        public _12tu2()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            courseContent cc = new courseContent();
            cc.Show();
            this.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            e1 pe = new e1();
            pe.Show();
            this.Close();
        }

        private void _12tu2_Load(object sender, EventArgs e)
        {

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
