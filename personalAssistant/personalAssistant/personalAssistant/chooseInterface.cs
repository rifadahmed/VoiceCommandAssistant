using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personalAssistant
{
    public partial class chooseInterface : Form
    {
        public chooseInterface()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            keyPress obj = new keyPress();
            obj.Show();
        }

        private void chooseInterface_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            voiceCommand obj = new voiceCommand();
            obj.Show();
        }
    }
}
