using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net.Mail;
using System.Net.Mime;
using System.Runtime.InteropServices;

using Outlook = Microsoft.Office.Interop.Outlook;
namespace personalAssistant
{
    public partial class mail : Form
    {
        [DllImport("wininet.dll")]//net
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);//

        public mail()
        {
            InitializeComponent();
           // password.PasswordChar = '@';
            
        }

        private void send_Click(object sender, EventArgs e)
        {
            int Desc;
            string a = (InternetGetConnectedState(out Desc, 0).ToString());
            if (a == "True")
            {
                Outlook._Application _app = new Outlook.Application();
                Outlook.MailItem mail = (Outlook.MailItem)_app.CreateItem(Outlook.OlItemType.olMailItem);
                mail.To = to.Text;
                mail.Body = body.Text;
                mail.Subject = subject.Text;
                mail.Importance = Outlook.OlImportance.olImportanceNormal;
                ((Outlook.MailItem)mail).Send();
                MessageBox.Show("YOUR MAIL HAS SUCCESSFULLY SENT ");
            }
            else
                MessageBox.Show("FAILED! PLEASE CHECK NET CONNECTION.");
       

            //try
            //{
            //    SmtpClient client = new SmtpClient("smtp.gmail.com",587);
            //    client.EnableSsl = true;
            //    client.Timeout = 10000;
            //    client.DeliveryMethod = SmtpDeliveryMethod.Network;
            //    client.UseDefaultCredentials = false;
            //    client.Credentials=new NetworkCrediential()

            //}

            //catch(Exception e)
            //{
            //    MessageBox.Show(e.Message);
            //}
            //MailMessage mail = new MailMessage(from.Text, to.Text, subject.Text, body.Text);
            //client.Port = 587;

            //client.Credentials = new System.Net.NetworkCredential(username.Text, password.Text);
            //client.Send(mail);
           
            //MessageBox.Show("done");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
