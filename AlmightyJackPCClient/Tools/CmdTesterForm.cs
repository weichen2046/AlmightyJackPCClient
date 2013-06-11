using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace AlmightyJackPCClient.Tools
{
    public partial class CmdTesterForm : Form
    {
        public CmdTesterForm()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            int cmd;
            if (!int.TryParse(txbCmd.Text, out cmd))
            {
                MessageBox.Show("命令ID必须是整数！");
                txbCmd.Focus();
                return;
            }

            ExcuteCmd(cmd);
        }

        private byte[] ExcuteCmd(int cmd)
        {
            TcpClient client = null;
            NetworkStream nstream = null;

            try
            {
                IPEndPoint endP = new IPEndPoint(
                    IPAddress.Parse("127.0.0.1"),
                    Properties.Settings.Default.PCPort);

                client = new TcpClient();
                client.Connect(endP);

                nstream = client.GetStream();
                bool connectStatus = GetResponseStatus(nstream);
                AppendTextToResultBox(
                    string.Format("Connection {0}", ((connectStatus)?RESPONSE_OK:RESPONSE_ERROR)));

                if (connectStatus)
                {
                    // send cmd
                    SendCmd(nstream, cmd);
                    // read send response status
                    connectStatus = GetResponseStatus(nstream);
                    if (connectStatus)
                    {
                        // read cmd result
                        byte[] datas = GetDatas(nstream);
                        AppendTextToResultBox(Encoding.UTF8.GetString(datas));
                    }
                    else
                    {
                        AppendTextToResultBox("Send cmd, but response error.");
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            finally
            {
                if (nstream != null)
                    nstream.Close();
                if (client != null)
                    client.Close();
            }
            return null;
        }

        private bool SendCmd(NetworkStream nstream, int cmd)
        {
            bool sendSuccessfully = false;
            if (nstream == null)
                return false;

            if (BitConverter.IsLittleEndian)
            {
                cmd = IPAddress.HostToNetworkOrder(cmd);
            }

            try
            {
                byte[] cmdBuf = BitConverter.GetBytes(cmd);
                nstream.Write(cmdBuf, 0, cmdBuf.Length);
                nstream.Flush();
                sendSuccessfully = true;
            } catch(Exception ex)
            {
                // TODO
            }
            return sendSuccessfully;
        }

        private bool GetResponseStatus(NetworkStream nstream)
        {
            if (nstream == null)
                return false;

            byte[] datas = new byte[4096];
            byte[] dataLenBytes = new byte[8];
            long dataLen = 0;

            try
            {
                // read data length
                nstream.Read(dataLenBytes, 0, 8);
                dataLen = BitConverter.ToInt64(dataLenBytes, 0);
                if (BitConverter.IsLittleEndian)
                {
                    dataLen = IPAddress.NetworkToHostOrder(dataLen);
                }

                nstream.Read(datas, 0, (int)dataLen);
                String status = Encoding.UTF8.GetString(datas, 0, (int)dataLen);
                if (RESPONSE_OK.Equals(status))
                    return true;
            }
            catch (Exception ex)
            { 
            }
            return false;
        }

        private byte[] GetDatas(NetworkStream nstream)
        {
            if (nstream == null)
                return null;

            List<byte> bytesRet = new List<byte>();
            byte[] datas = new byte[4096];
            byte[] dataLenBytes = new byte[8];
            long dataLen = 0;

            int totalReaded = 0;
            int readOnce = 0;

            try
            {
                // read data length
                nstream.Read(dataLenBytes, 0, 8);
                dataLen = BitConverter.ToInt64(dataLenBytes, 0);
                if (BitConverter.IsLittleEndian)
                {
                    dataLen = IPAddress.NetworkToHostOrder(dataLen);
                }

                while (totalReaded < dataLen)
                {
                    int goingToRead = (int)((dataLen - (long)totalReaded > 4096) ? 4096 : (dataLen - (long)totalReaded));
                    readOnce = nstream.Read(datas, 0, (int)dataLen);
                    if (readOnce > 0)
                    {
                        totalReaded += readOnce;
                        for (int i = 0; i < readOnce; i++)
                        {
                            bytesRet.Add(datas[i]);
                        }
                    }
                }

                return bytesRet.ToArray();
            }
            catch (Exception ex)
            {
            }

            return null;
        }

        private void AppendTextToResultBox(string text)
        {
            txbResult.Text += string.Format("{0}\r\n", text);
        }

        private const string RESPONSE_OK = "OK";
        private const string RESPONSE_ERROR = "ERROR";
    }
}
