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
    public partial class admin_login : Form
    {
        public admin_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\COURSES\c#\personalAssistant\db\loginDb.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "select * from datatable where username='" + textBox1.Text.Trim() + "' and password='" + textBox2.Text.Trim() + "' and status='" + "admin" + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                this.Hide();
                admin_panel obj = new admin_panel();
                obj.Show();

            }
            else
            {
                MessageBox.Show("Wrong user name or password");
            }
        }
    }
}
