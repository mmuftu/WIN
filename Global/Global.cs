using System.Text;
using System.Xml;

namespace Global
{
    public class Global
    {
        public class Config_XML
        {
            public string ServerIP = "";
            public string ServerPort = "";
            public string ServerIP_MA = "";
            public string ServerPort_MA = "";

            public Config_XML(string serverIP, string serverPort, string serverIP_MA, string serverPort_MA)
            {
                ServerIP = serverIP;
                ServerPort = serverPort;
                ServerIP_MA = serverIP_MA;
                ServerPort_MA = serverPort_MA;
            }
            public Config_XML()
            {

            }
            public static Config_XML Create()
            {
                Config_XML config_xml = null;

                try
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load("config.xml");

                    // XML dosyasındaki düğümleri seç ve dolaş
                    XmlNodeList nodes = doc.SelectNodes("/config/settings");
                    string _ServerIP = "";
                    string _ServerPort = "";
                    string _ServerIP_MA = "";
                    string _ServerPort_MA = "";
                    foreach (XmlNode node in nodes)
                    {
                        String key = node.SelectSingleNode("key").InnerText;
                        String value = node.SelectSingleNode("value").InnerText;

                        if (key == "ServerIP")
                        {
                            _ServerIP = value;
                        }
                        else if (key == "Port")
                        {
                            _ServerPort = value;
                        }
                        else if (key == "ServerIP_MA")
                        {
                            _ServerIP_MA = value;
                        }
                        else if (key == "Port_MA")
                        {
                            _ServerPort_MA = value;
                        }
                    }

                    config_xml = new Config_XML(_ServerIP, _ServerPort, _ServerIP_MA, _ServerPort_MA);


                }
                catch (Exception ex)
                {

                }

                return config_xml;
            }
        }

        public static string RandomRequestID(int uzunluk)
        {
            // Rastgele ID oluşturmak için bir rastgele sayı üreteci oluşturuyoruz
            Random random = new Random();

            // Alfanumerik karakterler
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            // Oluşturulan ID'yi depolamak için bir StringBuilder kullanıyoruz
            StringBuilder idBuilder = new StringBuilder();

            // ID'yi oluştur
            for (int i = 0; i < uzunluk; i++)
            {
                // Karakterleri rastgele seçiyoruz
                char randomChar = chars[random.Next(chars.Length)];
                idBuilder.Append(randomChar);
            }

            // Oluşturulan ID'yi yazdır
            string generatedId = idBuilder.ToString();
            return generatedId;
        }
    }
}
