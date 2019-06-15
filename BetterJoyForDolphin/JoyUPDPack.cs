using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Configuration;

namespace BetterJoyForDolphin
{
    public class JoyUPDPack
    {
        private String serverIP;
        private IPAddress ip;
        private int serverPort;
        private byte[] sendBuffer;
        private int[] invertArray;
        private bool active;
        private Socket udpSock;
        private IPEndPoint clientEP;
        private int sleepTime = 3; //3;
        private int force = 10;
        private Thread PollThreadObj;
        private Joycon parent;
        string csv_file;
        float[] manual_fit = new float[] {0,0,0};
        

        public JoyUPDPack(Joycon parent, int port, String ip = "127.0.0.1", bool active = true, int force = 10, int[] invertArray = null) {

            this.parent = parent;
            if (SetPort(port)) {
                //SetActive(active);
                SetActive(true);
                SetIP(ip);
                sendBuffer = new byte[27];
                StartSock();

                this.force = force;

                if (invertArray == null)
                {
                    this.invertArray = new int[] { 1, 1, 1 };
                }
                else
                {
                    this.invertArray = invertArray;
                }
            }
        }

        public void SetForce(int f) {
            force = f;
            Console.WriteLine("New force: " + f);
        }

        public int GetForce()
        {
            return force;
        }

        public void SetInverted(int x, int y, int z) {
            invertArray[0] = x;
            invertArray[1] = y;
            invertArray[2] = z;
        }

        public int[] GetInverted() {
            return invertArray;
        }

        public void CloseSock() {

            udpSock.Close();
            udpSock = null;
        }

        public void SwitchPort(int np) {
            bool state = GetActive();
            CloseSock();
            SetPort(np);
            StartSock();
            SetActive(state);
        }

        public void StartSock() {
            if (udpSock != null)
            {
                CloseSock();
            }

            udpSock = new Socket(AddressFamily.InterNetwork, 
                                SocketType.Dgram, 
                                ProtocolType.Udp);

            ip = IPAddress.Parse(serverIP);
            try {
                Console.WriteLine("Started point: " + serverIP + ":" + serverPort);

                if (PollThreadObj == null)
                {
                    PollThreadObj = new Thread(new ThreadStart(SendThreadPack));
                    PollThreadObj.IsBackground = true;
                    PollThreadObj.Start();
                }
            }

            catch (SocketException ex)
            {
                Console.WriteLine("Error making connection to socket");
                CloseSock();
            }

        }

        public void SendPack() {
            try
            {
                IPEndPoint clientEP = new IPEndPoint(ip, serverPort);
                udpSock.SendTo(sendBuffer, clientEP);
                //Console.WriteLine("Successfully send to: " + clientEP.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("My error:" + e.Message);
            }
        }


        public void SendThreadPack()
        {
            while (active) {
                GetPack(parent.GetAccel());
                SendPack();
                Thread.Sleep(sleepTime);
            }
        }

        public void SetActive(bool active)
        {
            this.active = active;
        }

        public bool GetActive()
        {
            return active;
        }

        public void SetIP(String ip) {
            serverIP = ip;
        }

        public String GetIP()
        {
            return serverIP;
        }

        public bool SetPort(int port) {

            bool success = false;

            if (port > -1)
            {
                serverPort = port;
                success = true;
            }

            return success;
        }

        public int GetPort()
        {
            return serverPort;
        }

        public void CleanBuffer()
        {
            Array.Clear(sendBuffer, 0, sendBuffer.Length);
        }

        public float[] VectorToFloat(Vector3 input, bool flipped = false)
        {

            float[] array = new float[3];

            if (invertArray.Count() == 3) { 

            int offset = 0;
            if (flipped) offset = 1;

            array[(0 + offset) % 2] = input.X * invertArray[0] + manual_fit[0] + (parent.isLeft ? 0 : manual_fit[0]);
            array[(1 + offset) % 2] = input.Y * invertArray[0] + manual_fit[1] + (parent.isLeft ? 0 : manual_fit[1]); //parent.isLeft ? input.Y : input.Y * -1;
            array[2] = input.Z * invertArray[2] + (parent.isLeft ? 0 : manual_fit[2]);

            }
            return array;
        }

        public byte[] GetPack(Vector3 rawAccel)
        {
            if (!active) {
                CleanBuffer();
                return null;
            }

            //Console.WriteLine("The raw info is: " + rawAccel.ToString());

            bool flip = parent.other == null ? true : false;
            float[] Accel = VectorToFloat(rawAccel, false);
            int offset = 3;

            sendBuffer[0] = (byte)0xde; // Pack initilization 
            sendBuffer[2] = (byte)0x7;

            // For each axis
            for (int i = 0; i < 3; i++)
            {
                
                // Calculate the Acceleremoter axis value affected by gravity
                int b = (int)((Accel[i] / 9.80665f) * 1024.0f * 1024.0f) * force; 

                sendBuffer[offset + 3] = (byte)(b & 0xff);
                sendBuffer[offset + 2] = (byte)((b >> 8) & 0xff);
                sendBuffer[offset + 1] = (byte)((b >> 16) & 0xff);
                sendBuffer[offset] = (byte)((b >> 24) & 0xff);

                offset += 4;
            }
            return sendBuffer;
        }

    }
}
