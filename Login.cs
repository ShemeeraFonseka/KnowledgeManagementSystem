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
    public partial class Login : Form
    {
        public static string value;

        public Login()
        {
            InitializeComponent();
            
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            value = textBox1.Text;
           

            String E_id, Password;

            E_id = textBox1.Text;
            Password = textBox2.Text;

            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Employee ID cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Please Enter your Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                SqlConnection con;
                SqlCommand com;

                con = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=KMS;Integrated Security=True");

                con.Open();

                



                com = con.CreateCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "SELECT Password FROM Employee where E_id='" + textBox1.Text + "' AND Password='" + textBox2.Text + "'";
                com.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(dt);

                

                if (dt.Rows.Count > 0)

                {
                    E_id = textBox1.Text;
                    Password = textBox2.Text;

                    Form2 ff = new Form2();
                    ff.Show();
                    
                }

                else

                {
                    MessageBox.Show("Login Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }

            

            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
