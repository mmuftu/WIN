using System.Net.Sockets;
using System.Text;

namespace ATC_Management
{
    public partial class FormMain : Form
    {
        public static Global.Global.Config_XML config_xml;

        #region FormMain
        public FormMain()
        {
            InitializeComponent();
        }
        #endregion

        #region FormMain_Load
        private void FormMain_Load(object sender, EventArgs e)
        {
            config_xml = Global.Global.Config_XML.Create();

        }
        #endregion

        #region Gonder
        static void Gonder(string mesaj)
        {
            try
            {
                TcpClient client = new TcpClient(config_xml.ServerIP_MA, int.Parse(config_xml.ServerPort_MA));
                NetworkStream stream = client.GetStream();
                string message = mesaj;
                byte[] data = Encoding.ASCII.GetBytes(message);
                stream.Write(data, 0, data.Length);

                byte[] data_close = Encoding.ASCII.GetBytes("#Close");
                stream.Write(data_close, 0, data_close.Length);
                stream.Flush();
                stream.Close();
                stream.Dispose();
                client.Close();
                client.Dispose();
            }
            catch { }
        }
        #endregion

        #region toolStripMenuItem_CihazBilgileriSorgula_Click
        private void toolStripMenuItem_CihazBilgileriSorgula_Click(object sender, EventArgs e)
        {
            Gonder("#DU!");
        }
        #endregion

        #region �PPortSorgulaToolStripMenuItem_Click
        private void �PPortSorgulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gonder("#OX;?;0!");
        }
        #endregion

        #region sunucuSifreBilgileriG�nderToolStripMenuItem_Click
        private void sunucuSifreBilgileriG�nderToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Gonder("#OX;1234;0;188.119.59.151;6000;" + Global.Global.RandomRequestID(8));
        }
        #endregion

        #region apnAyariGonderToolStripMenuItem_Click
        private void apnAyariGonderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gonder("#AP;1234;telsim;telsim;telsim;" + Global.Global.RandomRequestID(8));
        }
        #endregion
    }
}
