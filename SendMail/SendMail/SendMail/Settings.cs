using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace SendMail {
     public class Settings {

        private static Settings instance = null;

     public int Port { get; set; }         //ポート番号
     public string Host { get; set; }      //ホスト名
     public string MailAddr { get; set; }  //メールアドレス
     public string Pass { get; set; }      //パスワード
     public bool Ssl { get; set; }         //SSL
     public bool setting_flag { get; set; }     //XMLがあるかどうか
        // コンストラクタ
        private Settings() {

        }

        // インスタンスの取得
        public static Settings getInstance() {
            
            if(instance == null) {
                instance = new Settings();
                if (File.Exists("Settings.xml")) {
                    Settings.ReadConfig();
                    instance.setting_flag = true;
                }
                else {

                    instance.setting_flag = false;
                }
            }
            return instance;

        }

        //初期値
        public string sHost() {
            return "smtp.gmail.com";
        }

        //初期値
        public string sPort() {
            return 587.ToString();
        }

        //初期値
        public string sMailAddr() {
            return "ojsinfosys01@gmail.com";
        }

        //初期値
        public string sPass() {
            return "Infosys2021";
        }

        public bool sSsl() {
            return true;
        }

        public void ConfigXml() {
            var set = getInstance();
            var settings = new XmlWriterSettings
            {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };
            using (var writer = XmlWriter.Create("Settings.xml",settings)) {
                var serializer = new DataContractSerializer(set.GetType());
                serializer.WriteObject(writer,set);
            }
        }

        public static void ReadConfig() {
            using (var reader = XmlReader.Create("Settings.xml")) {
                var serializer = new DataContractSerializer(typeof(Settings));
                instance = (Settings)serializer.ReadObject(reader);
            }
            
        }

        public void setSendConfig(string host, int port, string mailAddr, string pass, bool ssl) {
            Host = host;
            Port = port;
            MailAddr = mailAddr;
            Pass = pass;
            Ssl = ssl;

            ConfigXml();
        }


        
    }
  
}
