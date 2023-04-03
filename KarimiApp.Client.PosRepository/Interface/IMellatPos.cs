using System.IO.Ports;

namespace KarimiApp.Client.PosRepository.Interface
{
    public interface IMellatPos
    {
        void OpenConnection(string Com, Parity parity = Parity.None, StopBits stopBits = StopBits.One, int boundRate = 115200, int dataBits = 8);
        void OpenConnection(string ip, int port, int readtimeout = 60000, int reqTimeout = 60000);
    }
}
