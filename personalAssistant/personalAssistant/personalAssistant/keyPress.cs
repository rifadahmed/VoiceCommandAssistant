using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;


namespace personalAssistant
{
    public partial class keyPress : Form
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);
        public keyPress()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("notepad");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Process.Start("notepad++");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("winword");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("snippingtool");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint");

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Process.Start("powerpnt");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process.Start("https://google.com");

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process.Start("https://youtube.com");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("excel");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            mail obj=new mail();
            obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            image_edit obj = new image_edit();
            obj.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {


            int Desc;
            string a = (InternetGetConnectedState(out Desc, 0).ToString());
            if (a == "True")
            {
                MessageBox.Show("INTERNET IS AVAILABLE!!!");
            }
            else
                MessageBox.Show("NO INTERNET");
            /* netConnectionCheck obj = new netConnectionCheck();
             obj.Show();*/
        }

        private void button13_Click(object sender, EventArgs e)
        {
            alarm obj = new alarm();
            obj.Show();
        }
    }
}
