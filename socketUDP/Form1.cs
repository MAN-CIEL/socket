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
                if (SSockUDP != null)
                {
                    textBoxReception.AppendText("Socket déjà créé.\n");
                    return;
                }

                SSockUDP = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                IPedR = new IPEndPoint(IPAddress.Parse(textBoxIpReception.Text), int.Parse(textBoxPortReception.Text));
                SSockUDP.Bind(IPedR);
                SSockUDP.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, 10000);

                textBoxReception.AppendText("Socket UDP créé et lié.\n");
            }
            catch (SocketException se)
            {
                textBoxReception.AppendText("Erreur socket : " + se.Message + "\n");
            }
            catch (Exception ex)
            {
                textBoxReception.AppendText("Erreur générale : " + ex.Message + "\n");
            }
        }


        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (SSockUDP == null)
                {
                    textBoxReception.AppendText("Erreur : socket non créé.\n");
                    return;
                }

                var msg = Encoding.ASCII.GetBytes(textBoxMessage.Text);
                IPedD = new IPEndPoint(IPAddress.Parse(textBoxIpDestination.Text), int.Parse(textBoxPortDestination.Text));
                SSockUDP.SendTo(msg, IPedD);

                textBoxReception.AppendText("Message envoyé.\n");
            }
            catch (SocketException se)
            {
                textBoxReception.AppendText("Erreur socket : " + se.Message + "\n");
            }
            catch (Exception ex)
            {
                textBoxReception.AppendText("Erreur générale : " + ex.Message + "\n");
            }
        }


        private void buttonReceive_Click(object sender, EventArgs e)
        {
            try
            {
                if (SSockUDP == null)
                {
                    textBoxReception.AppendText("Erreur : socket non créé.\n");
                    return;
                }

                var buffer = new byte[1024];
                EndPoint epFrom = new IPEndPoint(IPAddress.Any, 0);
                int bytes = SSockUDP.ReceiveFrom(buffer, ref epFrom);

                textBoxReception.AppendText("Message reçu : " + Encoding.ASCII.GetString(buffer, 0, bytes) + "\n");
            }
            catch (SocketException se)
            {
                textBoxReception.AppendText("Erreur socket : " + se.Message + "\n");
            }
            catch (Exception ex)
            {
                textBoxReception.AppendText("Erreur générale : " + ex.Message + "\n");
            }
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (SSockUDP == null)
                {
                    textBoxReception.AppendText("Erreur : socket déjà fermé.\n");
                    return;
                }

                SSockUDP.Close();
                SSockUDP = null;
                textBoxReception.AppendText("Socket fermé.\n");
            }
            catch (SocketException se)
            {
                textBoxReception.AppendText("Erreur socket : " + se.Message + "\n");
            }
            catch (Exception ex)
            {
                textBoxReception.AppendText("Erreur générale : " + ex.Message + "\n");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxIpReception.Text = "127.0.0.1";
            textBoxPortReception.Text = "50000";
            textBoxIpDestination.Text = "127.0.0.1";
            textBoxPortDestination.Text = "50000";
        }

        private void textBoxMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (SSockUDP != null && SSockUDP.Available > 0)
            {
                var buffer = new byte[1024];
                EndPoint epFrom = new IPEndPoint(IPAddress.Any, 0);
                int bytes = SSockUDP.ReceiveFrom(buffer, ref epFrom);
                textBoxReception.AppendText(Encoding.ASCII.GetString(buffer, 0, bytes) + "\n");
            }
        }
    }
}
