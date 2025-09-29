using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace socketUDP
{
    public partial class Form1 : Form
    {
        // Variables UDP
        private Socket SSockUDP;
        private IPEndPoint IPedD;   // Destination
        private IPEndPoint IPedR;   // Réception
        private IPEndPoint IPedFrom; // Émetteur
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                SSockUDP = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                IPedR = new IPEndPoint(IPAddress.Parse(textBoxIpReception.Text), int.Parse(textBoxPortReception.Text));
                SSockUDP.Bind(IPedR);
                textBoxReception.AppendText("Socket UDP créé et lié.\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur création socket : " + ex.Message);
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            var msg = Encoding.ASCII.GetBytes(textBoxMessage.Text);
            IPedD = new IPEndPoint(IPAddress.Parse(textBoxIpDestination.Text), int.Parse(textBoxPortDestination.Text));
            SSockUDP.SendTo(msg, IPedD);
        }

        private void buttonReceive_Click(object sender, EventArgs e)
        {
            var buffer = new byte[1024];
            EndPoint epFrom = new IPEndPoint(IPAddress.Any, 0);
            int bytes = SSockUDP.ReceiveFrom(buffer, ref epFrom);
            textBoxReception.AppendText(Encoding.ASCII.GetString(buffer, 0, bytes) + "\n");
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            SSockUDP.Close();
            textBoxReception.AppendText("Socket fermé.\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxMessage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
