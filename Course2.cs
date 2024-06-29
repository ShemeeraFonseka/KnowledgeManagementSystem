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
    public partial class Course2 : Form
    {
        public Course2()
        {
            InitializeComponent();
        }

        private void Course2_Load(object sender, EventArgs e)
        {
            label1.Text = Login.value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string courseId = "CO2002";
            SqlConnection con;
            SqlCommand com;

            con = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=KMS;Integrated Security=True");

            SqlCommand cmd2 = new SqlCommand("SELECT E_id,C_id from Employee_Course where E_id='" + label1.Text + "'AND C_id='" + courseId + "'", con);
            con.Open();
            SqlDataReader myreader = cmd2.ExecuteReader();
            if (myreader.Read())
            {
                MessageBox.Show("You have already enrolled in this Course", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }

            else
            {
                con.Close();

                com = con.CreateCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "Insert into Employee_Course values('" + label1.Text + "','" + courseId + "','" + DateTime.Now + "')";
                con.Open();
                com.ExecuteNonQuery();
                con.Close();

                enrollCourse2 ec = new enrollCourse2();
                ec.Show();
                this.Close();
            }
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
