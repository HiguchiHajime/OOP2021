using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml;
using System.IO;
using System.Windows.Forms;
using System.Security;

namespace SendMail {
     public class Settings {

     private static Settings instance = null;
        //  送信データ設定済みかどうか
        public static bool Set { get; set; } = true;
     public int Port { get; set; }         //ポート番号
     public string Host { get; set; }      //ホスト名
     public string MailAddr { get; set; }  //メールアドレス
     public string Pass { get; set; }      //パスワード
     public bool Ssl { get; set; }         //SSL
        // コンストラクタ
        private Settings() {

        }

        // インスタンスの取得
        public static Settings getInstance() {
            try {
                if (instance == null) {
                    instance = new Settings();
                    Settings.ReadConfig();
                }
            }
            // ファイルがない場合(初回起動時)
            catch(Exception ex) {
                Set = false;
            }
            //// セキュリティエラーが検出された場合
            //catch (SecurityException ex){

            //}



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
