using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace personalAssistant
{        
    
    public partial class alarm : Form
    {

        System.Timers.Timer timer;
        public alarm()
        {
            InitializeComponent();
        }
        SoundPlayer player = new SoundPlayer();

        private void alarm_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += timer_Elapsed; //for processing
        }
        delegate void UpdateLable(Label lbl, string value);
        void UpdateDataLable(Label lbl, string value)
        {
            labelStatus.Text = value;

        }

        public void timer_Elapsed(Object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            DateTime userTime = dateTimePicker1.Value;
            if (currentTime.Hour == userTime.Hour && currentTime.Minute == userTime.Minute && currentTime.Second == userTime.Second)
            {
                timer.Stop();

                try
                {
                    UpdateLable up = UpdateDataLable;
                    if (labelStatus.InvokeRequired)
                    {
                        Invoke(up, labelStatus, "Stop");
                    }
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = @"C:\Users\Dell\Downloads\alarm.wav";
                    player.PlayLooping();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }



            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            // player.Stop();
            labelStatus.Text = "Stop...";
            player.Stop();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
            labelStatus.Text = "Running...";
        }

    }
}
