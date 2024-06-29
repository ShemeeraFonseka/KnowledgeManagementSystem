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
    public partial class Congrats2 : Form
    {
        string b;
        public Congrats2()
        {
            InitializeComponent();
        }

        private void Congrats2_Load(object sender, EventArgs e)
        {
            label2.Text = "Your Score is " + b;
            label3.Text = Login.value;
        }

        public void pass(string a)
        {
            b = a.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            courseContent2 cc = new courseContent2();
            cc.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cerId = "CO2002CER";

            SqlConnection con;
            SqlCommand com;

            con = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=KMS;Integrated Security=True");

            SqlCommand cmd2 = new SqlCommand("SELECT E_id,Cer_id from Employee_Certificate where E_id='" + label3.Text + "'AND Cer_id='" + cerId + "'", con);
            con.Open();
            SqlDataReader myreader = cmd2.ExecuteReader();
            if (myreader.Read())
            {
                MessageBox.Show("You have already claimed your certificate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }

            else
            {
                con.Close();

                com = con.CreateCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "Insert into Employee_Certificate values('" + label3.Text + "','" + cerId + "','" + DateTime.Now + "')";
                con.Open();
                com.ExecuteNonQuery();
                con.Close();

                

                Ename2 cc = new Ename2();
                cc.Show();
                this.Close();
            }
        }
    }
}
