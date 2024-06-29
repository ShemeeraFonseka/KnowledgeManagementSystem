using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMS
{
    public partial class prof11 : Form
    {
        public static string value;
        string a;
        int Mscore;
        string grade;

        public prof11()
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
            
        }

        private void prof11_Load(object sender, EventArgs e)
        {
            label12.Text = Login.value;
            value=label13.Text;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            string Exam_id = "CO2001E";

            Mscore = 0;

            if (radioButton3.Checked)
            {
                Mscore = Mscore + 10;
            }
            if (radioButton7.Checked)
            {
                Mscore = Mscore + 10;
            }
            if (radioButton12.Checked)
            {
                Mscore = Mscore + 10;
            }
            if (radioButton23.Checked)
            {
                Mscore = Mscore + 10;
            }
            if (radioButton17.Checked)
            {
                Mscore = Mscore + 10;
            }
            if (radioButton14.Checked)
            {
                Mscore = Mscore + 10;
            }
            if (radioButton35.Checked)
            {
                Mscore = Mscore + 10;
            }
            if (radioButton29.Checked)
            {
                Mscore = Mscore + 10;
            }
            if (radioButton27.Checked)
            {
                Mscore = Mscore + 10;
            }
            if (radioButton39.Checked)
            {
                Mscore = Mscore + 10;
            }

            a = Mscore.ToString();

            if (Mscore > 70)
            {
                grade = "A";
            }
            else if (Mscore > 50)
            {
                grade = "B";
            }

            else
            {
                grade = "F";
            }

            if (radioButton3.Checked && radioButton7.Checked &&
                radioButton12.Checked && radioButton23.Checked &&
                radioButton17.Checked && radioButton14.Checked &&
                radioButton35.Checked && radioButton29.Checked &&
                radioButton27.Checked && radioButton39.Checked)
            {
                Congrats cs = new Congrats();
                cs.pass(a.ToString());
                cs.Show();
                this.Close();

            }

            else
            {
                
                repeat rr = new repeat();
                rr.Show();
                
            }



            SqlConnection con;
            SqlCommand com;

            con = new SqlConnection("Server=localhost;Database=KMS;Uid=root;Pwd=;");
            con.Open();
            com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Insert into Employee_Exam values('" + label12.Text + "','" + Exam_id + "','" + DateTime.Now + "','" + Mscore + "','" + grade + "')";

            com.ExecuteNonQuery();
            con.Close();
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

