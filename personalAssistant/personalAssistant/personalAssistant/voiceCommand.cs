using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace personalAssistant
{
    public partial class voiceCommand : Form
    {
        [DllImport("wininet.dll")]//net
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);//connection check



        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        public voiceCommand()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            button2.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void voiceCommand_Load(object sender, EventArgs e)
        {
            Choices command = new Choices();
            command.Add(new string[] { "open notepad", "open word", "open calculator", "open excel"
                                      , "open snipping", "open google","open youtube", "open notepad plus plus" 
                                        ,"open paint", "open powerpoint", "edit photo", "send mail" 
                                         ,"set alarm", "song","check net"});
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(command);
            Grammar grammar = new Grammar(gBuilder);
            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += recEngine_SpeechRecognized;
        }

        void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
           
               // MessageBox.Show(e.Result.Text);

            
            switch (e.Result.Text)
            {
                case "open youtube":
                    Process.Start("https://youtube.com");   
                    break;

                case "open word":
                    Process.Start("winword");

                    break;

                case "open google":
                    Process.Start("https://google.com");
                    break;

                case "open notepad":
                    Process.Start("notepad");
                    break;

                case "open calculator":
                    Process.Start("calc");
                    break;

                case "open excel":
            Process.Start("excel");
                    break;

                case "open snipping":
                 Process.Start("snippingtool");
                    break;

                case "open notepad plus plus":
            Process.Start("notepad++");
                    break;

                case "open paint":
            Process.Start("mspaint");
                    break;

                case "open powerpoint":
            Process.Start("powerpnt");
                    break;

                case "edit photo":
                    image_edit obj = new image_edit();
                    obj.Show();
                    break;

                case "send mail":
                    mail obj1 = new mail();
                    obj1.Show();
                    break;

                case "set alarm":
                    alarm obj2 = new alarm();
                    obj2.Show();
                    break;

                case "check net":
                    int Desc;
                    string a = (InternetGetConnectedState(out Desc, 0).ToString());
                    if (a == "True")
                    {
                        MessageBox.Show("INTERNET IS AVAILABLE!!!");
                    }
                    else
                        MessageBox.Show("NO INTERNET");
                    break;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();
            //button1.Enabled = false;
        }
    }
}
