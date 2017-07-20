using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaserScannerGUI
{
    public class LEDStripController
    {
        SerialPort port;

        public LEDStripController(string spName)
        {
            port = new SerialPort(spName, 115200, Parity.None, 8, StopBits.One);
            port.NewLine = "\n";
            port.DataReceived += port_DataReceived;
        }

        void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            port.DiscardInBuffer();
        }

        public void connect()
        {
            if (port != null)
            {
                port.Open();
            }
        }

        public void disconnect()
        {
            if (port != null)
            {
                port.Close();
            }
        }

        public void setLEDColor(int ledID, byte r, byte g, byte b)
        {
            if (port != null && port.IsOpen)
            {
                port.WriteLine(String.Format("{0},{0},{1},{2},{3}", ledID, r, g, b));
            }
        }

        public void setLEDColor(int startLedID, int endLedID, byte r, byte g, byte b)
        {
            if (port != null && port.IsOpen)
            {
                port.WriteLine(String.Format("{0},{1},{2},{3},{4}", startLedID, endLedID, r, g, b));
            }
        }
    }
}
