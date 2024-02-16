using Global;

namespace Listener
{
    public partial class FormMain : Form
    {
        public static Server MainServer;
        public static Server ManagementServer;
        Global.Global.Config_XML config_xml;
        System.Threading.Timer timer;

        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            config_xml = Global.Global.Config_XML.Create();
            Thread clientThread = new Thread(() => ServerBaslat("MainServer"));
            clientThread.Start();
            Thread client_MAThread = new Thread(() => ServerBaslat("ManagementServer"));
            client_MAThread.Start();
            timer = new System.Threading.Timer(TimerCallback, null, 0, 10);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                timer.Dispose();
                if (MainServer != null)
                {
                    MainServer.Close();

                }
                if (ManagementServer != null)
                {
                    ManagementServer.Close();

                }

            }
            catch (Exception ex)
            {

            }
        }


        void ServerBaslat(String tur)
        {
            try
            {


                if (tur == "MainServer")
                {
                    textBox_data.Invoke((MethodInvoker)delegate
                    {
                        textBox_data.Text = textBox_data.Text + " Sunucu Baþlatýldý " + "IP > " + config_xml.ServerIP + " Port > " + config_xml.ServerPort;
                    });

                    MainServer = new Server(config_xml.ServerIP, config_xml.ServerPort);
                    MainServer.Start();
                }
                else if (tur == "ManagementServer")
                {
                    textBox_data.Invoke((MethodInvoker)delegate
                    {
                    });
                    ManagementServer = new Server(config_xml.ServerIP_MA, config_xml.ServerPort_MA);
                    ManagementServer.Start();
                }



            }
            catch (Exception ex)
            {

            }
        }


        private void TimerCallback(object state)
        {
            try
            {
                label_device.Invoke((MethodInvoker)delegate
                {
                    label_device.Text = "Baðlý Cihaz Sayýsý " + Server.clientThreads.Count.ToString();

                });
            }
            catch (System.Exception ex) { }
        }

        private void button_send_data_Click(object sender, EventArgs e)
        {
            MainServer.Send_data(textBox_send_data.Text.Trim(), true, null);
        }
    }
}
