using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace SmartDeviceTcpSocketClient
{
    public partial class Form1 : Form
    {
        private Label conStatus;
        private ListBox results;

        private Socket client;
        private byte[] data = new byte[1024];
        private int size = 1024;
        private String ipString = "10.0.2.15";
        private int port = 100;

        // Create delegates for the different return types needed.
        private delegate void VoidDelegate();


        public Form1()
        {
            InitializeComponent();

            conStatus = lblConStatus;
            results = listBoxRespuesta;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            //conStatus.Text = "Connecting...";
            setLblConStatus("Connecting...");
            Socket newsock = new Socket(AddressFamily.InterNetwork,
                                  SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(ipString), port);
            newsock.BeginConnect(iep, new AsyncCallback(Connected), newsock);
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                if (client.Connected)
                {
                    // Se envia exit al servidor para desconectar el cliente
                    byte[] message = Encoding.ASCII.GetBytes("exit");
                    client.BeginSend(message, 0, message.Length, SocketFlags.None,
                                 new AsyncCallback(SendData), client);
                }
            }

            //client.Close();
            // Limpiar listBox
            clearlistBoxRespuesta();


            setLblConStatus("Disconnected");
            
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            byte[] message = Encoding.ASCII.GetBytes(txtBoxMensaje.Text);
            txtBoxMensaje.Text = "";
            client.BeginSend(message, 0, message.Length, SocketFlags.None,
                         new AsyncCallback(SendData), client);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                if (client.Connected)
                {
                    // Se envia exit al servidor para desconectar el cliente
                    byte[] message = Encoding.ASCII.GetBytes("exit");
                    client.BeginSend(message, 0, message.Length, SocketFlags.None,
                                 new AsyncCallback(SendData), client);
                }
            }

            Application.Exit();

        }

        void Connected(IAsyncResult iar)
        {
            client = (Socket)iar.AsyncState;
            try
            {
                client.EndConnect(iar);
                setLblConStatus("Connected to: " + client.RemoteEndPoint.ToString());
                client.BeginReceive(data, 0, size, SocketFlags.None,
                              new AsyncCallback(ReceiveData), client);
            }
            catch (SocketException)
            {
                //conStatus.Text = "Error connecting";
                setLblConStatus("Error connecting");
            }
            
        }

        void ReceiveData(IAsyncResult iar)
        {
            try
            {
                Socket remote = (Socket)iar.AsyncState;
                int recv = remote.EndReceive(iar);
                string stringData = Encoding.ASCII.GetString(data, 0, recv);
                setlistBoxRespuesta(stringData);
            }
            catch (SocketException)
            {
                setLblConStatus("Error recibiendo");
            }
        }

        void SendData(IAsyncResult iar)
        {
            try
            {
                Socket remote = (Socket)iar.AsyncState;
                int sent = remote.EndSend(iar);
                remote.BeginReceive(data, 0, size, SocketFlags.None,
                              new AsyncCallback(ReceiveData), remote);
            }
            catch(SocketException)
            {
                setLblConStatus("Error enviando");
            }
        }

        // Here a case where there's no value returned:
        public void setLblConStatus(string status)
        {
            conStatus.Invoke(new VoidDelegate(delegate()
            {
                conStatus.Text = status;
            }));
        }

        public void setlistBoxRespuesta(string response)
        {
            results.Invoke(new VoidDelegate(delegate()
            {
                results.Items.Add(response);
            }));
        }

        public void clearlistBoxRespuesta() {
            results.Invoke(new VoidDelegate(delegate()
            {
                results.Items.Clear();
            }));
        }




        /*
         * 
         *  // Create delegates for the different return types needed.
            private delegate void VoidDelegate();
            private delegate Boolean ReturnBooleanDelegate();
            private delegate Hashtable ReturnHashtableDelegate();

            // Now use the delegates and the delegate() keyword to create 
            // an anonymous method as required

            // Here a case where there's no value returned:
            public void SetTitle(string title)
            {
                myWindow.Invoke(new VoidDelegate(delegate()
                {
                    myWindow.Text = title;
                }));
            }

            // Here's an example of a value being returned
            public Hashtable CurrentlyLoadedDocs()
            {
                return (Hashtable)myWindow.Invoke(new ReturnHashtableDelegate(delegate()
                {
                    return myWindow.CurrentlyLoadedDocs;
                }));
            }

        */


    }
}