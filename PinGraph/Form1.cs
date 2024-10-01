namespace PinGraph
{
    public partial class Form1 : Form
    {
        private int i = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // use async method to do ping.
            Thread.Sleep(1000);
            lblGraph.Text = $"{i}";
            i++;
        }
    }
}
