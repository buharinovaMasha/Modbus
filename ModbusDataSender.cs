using System;
using System.Net.Sockets;
using NModbus;

public class ModbusDataSender
{
    private TcpClient tcpClient;
    private IModbusMaster modbusMaster;

    public ModbusDataSender(string ipAddress, int port)
    {
        tcpClient = new TcpClient(ipAddress, port);
        var factory = new ModbusFactory();
        modbusMaster = factory.CreateMaster(tcpClient);
    }

    public void SendData(ushort startAddress, ushort value)
    {
        modbusMaster.WriteSingleRegister(1, startAddress, value);
        Console.WriteLine("ModBus Data sent successfully!");
    }

    public void Disconnect()
    {
        tcpClient.Close();
    }
}