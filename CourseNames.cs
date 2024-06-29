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
    public partial class CourseNames : Form
    {
        public CourseNames()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string cid = "CO2001";

            SqlConnection con;
            

            con = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=KMS;Integrated Security=True");

            SqlCommand cmd2 = new SqlCommand("SELECT E_id,C_id from Employee_Course where E_id='" + label2.Text + "'AND C_id='" + cid + "'", con);
            con.Open();
            SqlDataReader myreader = cmd2.ExecuteReader();
            if (myreader.Read())
            {
                courseContent cc = new courseContent();
                cc.Show();
                this.Close();
                con.Close();
            }

            else
            {
                con.Close();

                Course cc = new Course();
                cc.Show();
                this.Close();

            }



        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string cid = "CO2002";

            SqlConnection con;


            con = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=KMS;Integrated Security=True");

            SqlCommand cmd2 = new SqlCommand("SELECT E_id,C_id from Employee_Course where E_id='" + label2.Text + "'AND C_id='" + cid + "'", con);
            con.Open();
            SqlDataReader myreader = cmd2.ExecuteReader();
            if (myreader.Read())
            {
                courseContent2 cc = new courseContent2();
                cc.Show();
                this.Close();
                con.Close();
            }

            else
            {
                con.Close();

                Course2 cc = new Course2();
                cc.Show();
                this.Close();

            }

        }

        private void CourseNames_Load(object sender, EventArgs e)
        {
            label2.Text = Login.value;
            
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

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
