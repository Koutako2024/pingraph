using System.Diagnostics;
using System.Text.RegularExpressions;

namespace PinGraph
{
    public partial class Form1 : Form
    {
        public static string pingCommand = "ping";
        public static string pingArg = "google.com";


        private int pingResult = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // ping
            ProcessStartInfo processStartInfo = new ProcessStartInfo(pingCommand, pingArg) ;
            processStartInfo.RedirectStandardOutput = true ;
            processStartInfo.CreateNoWindow = true;
            var process = Process.Start(processStartInfo);
            string processOutput= process?.StandardOutput.ReadToEnd() ?? "null";

            string pingRawResult= new Regex(@"\d+").Matches(processOutput)[^1].Value;
            LblDebug.Text = pingRawResult;

            pingResult=int.Parse(pingRawResult);

            // draw
            BoxMeter.Size = new Size(BoxMeter.Size.Width, pingResult);


        }

        private static async Task GetPingResult()
        {
            // use async method to do ping.
        }
    }
}
