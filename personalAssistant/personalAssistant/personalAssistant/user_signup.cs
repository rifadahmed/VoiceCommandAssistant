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
    public partial class user_signup : Form
    {
        public user_signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\COURSES\c#\personalAssistant\db\loginDb.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into datatable values ('" + textBox1.Text + "','" + textBox2.Text + "','" + 0 + "') ";
            cmd.ExecuteNonQuery();
            textBox1.Text = "";
            textBox2.Text = "";

            con.Close();
            MessageBox.Show("inserted");
        }
    }
}
