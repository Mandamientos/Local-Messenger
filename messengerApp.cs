using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Local_Messenger
{
    public partial class messengerApp : Form
    {
        private Int32 allocatedPort;
        private Int32 targetPort;

        public messengerApp(Int32 allocatedPort, Int32 targetPort)
        {
            InitializeComponent();
            this.allocatedPort = allocatedPort;
            this.targetPort = targetPort;
            infoLabel.Text = $"Estás comunicandote con el puerto {targetPort}";
        }

        private void messenger_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void SendButton_Click(object sender, EventArgs e)
        {
            string myMsg = entryMsg.Text;
            if (myMsg != "" && !(string.IsNullOrWhiteSpace(myMsg)))
            {
                string log = $"[{DateTime.Now}] Yo : {myMsg}\n";
                msgLog.AppendText(log);
                entryMsg.Text = "";
            }
        }



    }
}
