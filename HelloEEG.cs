using System;
using System.IO.Ports;
using System.Threading;
using NeuroSky.ThinkGear;
using NeuroSky.ThinkGear.Algorithms;

namespace EEGToArduino
{
    class Program
    {
        static Connector connector;
        static SerialPort arduinoPort;

        static void Main(string[] args)
        {
            // Inisialisasi konektor untuk Mindwave
            connector = new Connector();
            connector.DeviceConnected += OnDeviceConnected;
            connector.DeviceConnectFail += OnDeviceFail;
            connector.DeviceValidating += OnDeviceValidating;

            connector.ConnectScan("COM..."); // Mindwave di COM (silahkan sesuaikan)
            connector.setBlinkDetectionEnabled(true);

            arduinoPort = new SerialPort("COM...", 115200); // Arduino di COM & serial monitor (silahkan sesuaikan)
            arduinoPort.Open();

            Console.WriteLine("Menunggu data... Tekan Ctrl+C untuk keluar.");

            while (true)
            {
                Thread.Sleep(1000);
            }
        }

        static void OnDeviceConnected(object sender, EventArgs e)
        {
            Console.WriteLine("Mindwave terhubung.");
            Device device = ((Connector.DeviceEventArgs)e).Device;
            device.DataReceived += OnDataReceived;
        }

        static void OnDeviceFail(object sender, EventArgs e)
        {
            Console.WriteLine("Gagal menghubungkan Mindwave.");
        }

        static void OnDeviceValidating(object sender, EventArgs e)
        {
            Console.WriteLine("Memvalidasi Mindwave.");
        }

        static void OnDataReceived(object sender, EventArgs e)
        {
            Device.DataEventArgs de = (Device.DataEventArgs)e;
            TGParser tgParser = new TGParser();
            tgParser.Read(de.DataRowArray);

            foreach (var data in tgParser.ParsedData)
            {
                if (data.ContainsKey("Meditation"))
                {
                    int meditationValue = (int)data["Meditation"];
                    Console.WriteLine("Meditation Value: " + meditationValue);
                    arduinoPort.WriteLine(meditationValue + ";");
                }
            }
        }
    }
}
