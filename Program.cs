using OPC.Models;

var randomValue = DataGenerator.GenerateRandomNumber(1, 100);
Console.WriteLine($"Generated Random Value: {randomValue}");

var modbusDataSender = new ModbusDataSender("127.0.0.1", 502);
modbusDataSender.SendData(0, (ushort)randomValue);
modbusDataSender.Disconnect();