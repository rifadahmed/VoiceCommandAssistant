using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace personalAssistant
{
    public partial class user_login : Form
    {
        
        public user_login()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


          

         }

        private void button4_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\COURSES\c#\personalAssistant\db\loginDb.mdf;Integrated Security=True;Connect Timeout=30");
            //SqlDataAdapter sda = new SqlDataAdapter("select count(*) from datatable where username='" + textBox3.Text + "' and password='" + textBox4.Text + "'  ", con);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //if (dt.Rows[0][0].ToString() == "1")
            //{
            //    this.Hide();
            //    keyPress obj = new keyPress();
            //    obj.Show();

            //}
            //else
            //{
            //    MessageBox.Show("fail");
            //}

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\COURSES\c#\personalAssistant\db\loginDb.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "select * from datatable where username='" + textBox3.Text.Trim() + "' and password='" + textBox4.Text.Trim() + "' and status='"+"yes"+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count== 1)
            {
                this.Hide();
                chooseInterface obj = new chooseInterface ();
                obj.Show();

            }
            else
            {
                MessageBox.Show("username or password doesnt match");
            }




        }

        private void button5_Click(object sender, EventArgs e)
        {
            user_signup obj = new user_signup();
            obj.Show();
            this.Hide();
        }




        }

}

