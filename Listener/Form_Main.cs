using Global;
using MSSQLDB;
namespace Listener
{
    public partial class FormMain : Form
    {
        public static Server MainServer;
        public static Server ManagementServer;
        Global.Global.Config_XML config_xml;
        System.Threading.Timer timer;

        #region FormMain
        public FormMain()
        {
            InitializeComponent();
        }
        #endregion

        #region FormMain_Load
        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                Class_Atc_Cihaz_Tipi atc_cihaz_tipi = new Class_Atc_Cihaz_Tipi();
                atc_cihaz_tipi.Isim = "yeniden";
                MSSQLDB.MSSQLHelper.Cihaz_Tipi_Add(atc_cihaz_tipi);

                config_xml = Global.Global.Config_XML.Create();
                Thread clientThread = new Thread(() => ServerBaslat("MainServer"));
                clientThread.Start();
                Thread client_MAThread = new Thread(() => ServerBaslat("ManagementServer"));
                client_MAThread.Start();
                timer = new System.Threading.Timer(TimerCallback, null, 0, 10);
            }
            catch (Exception ex) { }
        }
        #endregion

        #region FormMain_FormClosing
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
        #endregion

        #region ServerBaslat
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
        #endregion

        #region TimerCallback
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
        #endregion

        #region button_send_data_Click
        private void button_send_data_Click(object sender, EventArgs e)
        {
            MainServer.Send_data(textBox_send_data.Text.Trim(), true, null);
        }
        #endregion
    }
}
