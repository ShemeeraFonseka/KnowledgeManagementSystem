﻿using System;
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
    public partial class enrollCourse : Form
    {
        
        

        public enrollCourse()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            courseContent c = new courseContent();
            c.Show();
            this.Close();
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void enrollCourse_Load(object sender, EventArgs e)
        {
            
        }

        private void button14_Click(object sender, EventArgs e)
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
