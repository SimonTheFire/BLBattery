using System;
using Salar.BluetoothLE;
using System.Diagnostics;
using System.Management;
using System.IO.Ports;

class PortDataReceived
{
    public static void Main()
    {
        SerialPort mySerialPort = new SerialPort("COM3");

        //mySerialPort.
        mySerialPort.Parity = Parity.None;
    }
}