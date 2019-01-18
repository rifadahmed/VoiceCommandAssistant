using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;
using System.Runtime.InteropServices;
namespace personalAssistant
{
    public partial class netConnectionCheck : Form
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);
 
        public netConnectionCheck()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Desc;
            string a= (InternetGetConnectedState(out Desc, 0).ToString());
            if(a=="True")
            {
            MessageBox.Show("INTERNET IS AVAILABLE!!!");
            }
            else
                MessageBox.Show("NO INTERNET");
           
            
   

        }
    }
}
