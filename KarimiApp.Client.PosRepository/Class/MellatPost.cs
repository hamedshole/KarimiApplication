using KarimiApp.Client.PosRepository.Interface;
using System.IO.Ports;

namespace KarimiApp.Client.PosRepository.Class
{
    internal class MellatPos : IMellatPos
    {
        //  Transaction.Connection Connect = new Transaction.Connection();
        // Result retCode = new Result();
        /// <summary>
        /// step one - open serial connection
        /// </summary>
        /// <param name="Com"></param>
        /// <param name="parity"></param>
        /// <param name="stopBits"></param>
        /// <param name="boundRate"></param>
        /// <param name="dataBits"></param>
        public void OpenConnection(string Com, Parity parity = Parity.None, StopBits stopBits = StopBits.One, int boundRate = 115200, int dataBits = 8)
        {
            //this.Connect.CommunicationType = "SERIAL";
            //this.Connect.PC_PORT_Name = Com;
            //this.Connect.PC_PORT_BaudRate = boundRate;
            //this.Connect.PC_PORT_DataBits = dataBits;
            //this.Connect.PC_PORT_Parity = parity;
            //this.Connect.PC_PORT_StopBits = stopBits;

        }

        /// <summary>
        /// step one - open lan connection
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="port"></param>
        /// <param name="readtimeout"></param>
        /// <param name="reqTimeout"></param>
        public void OpenConnection(string ip, int port, int readtimeout = 60000, int reqTimeout = 60000)
        {
            //this.Connect.CommunicationType = "TCP/IP";
            //this.Connect.PC_PORT_ReadTimeout = readtimeout;
            //Connect.POSPC_TCPCOMMU_SocketRecTimeout = reqTimeout;
            //Connect.POS_PORTtcp = port;
            //Connect.POS_IP = ip;
        }

        /// <summary>
        /// step two - payment request
        /// </summary>
        /// <param name="pcId"></param>
        /// <param name="amount"></param>
        /// <param name="payerId"></param>
        /// <param name="accountId"></param>
        /// <param name="merchantAdittionalData"></param>
        /// <returns></returns>
        //public Result PayTransaction(string pcId, string amount, string payerId, string accountId, string merchantAdittionalData)
        //{
        //    Transaction transaction = new Transaction(this.Connect);
        //    Result res = transaction.Payment(pcId, amount, payerId, accountId, merchantAdittionalData);
        //    return res;
        //}


    }
}
