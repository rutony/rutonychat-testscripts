using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace RutonyChat {
    public class Script {

        private string FileName = @"e:\1.txt";

        private string Keyword_Reset = "!reset_sum";
        private string Nickname_Administrator = "rutony";
        private float intValue = 0.0f;
        private float maxValue = 0.0f;

        public void InitParams(Dictionary<string, string> param) {

            if (param.ContainsKey("maxValue")) {
                try {
                    maxValue = float.Parse(param["maxValue"], CultureInfo.InvariantCulture.NumberFormat);
                } catch { }
            }
            if (param.ContainsKey("Keyword_Reset")) {
                try {
                    Keyword_Reset = param["Keyword_Reset"];
                } catch { }
            }
            if (param.ContainsKey("FileName")) {
                try {
                    FileName = param["FileName"];
                } catch { }
            }
            if (param.ContainsKey("Nickname_Administrator")) {
                try {
                    Keyword_Reset = param["Nickname_Administrator"];
                } catch { }
            }

            //

            if (File.Exists(FileName)) {

                string strLine = "";

                try { 
                     strLine = RutonyBotFunctions.FileStringAt(FileName, 0);
                } catch { }

                float.TryParse(strLine, out intValue);

            }

            RutonyBot.SayToWindow("Скрипт Автосумирования включен!", Color.Yellow);

        }

        public void NewMessageEx(string site, string name, string text, bool system, Dictionary<string, string> Params) {
            
        }

        public void Closing() {
            RutonyBot.SayToWindow("Скрипт Автосумирования выключен!", Color.Yellow);
        }

        public void RewriteFile(string line) {
            StreamWriter sw = null;
            try {
                sw = new StreamWriter(FileName, false);
                sw.WriteLine(line);
            } catch (FileNotFoundException) {
                RutonyBot.SayToWindow("Не удалось очистить файл " + FileName + ", неизвестная ошибка");
            } catch (IOException) {
                RutonyBot.SayToWindow("Не удалось очистить файл " + FileName + ", ошибка чтения");
            } catch (Exception ex) {
                RutonyBot.SayToWindow("Не удалось очистить файл " + FileName + ", " + ex.Message);
            } finally {
                if (sw != null)
                    sw.Close();
            }
        }
        public void NewMessage(string site, string name, string text, bool system) {

            if (name == Nickname_Administrator) {

                if (text.ToLower() == Keyword_Reset.ToLower()) {

                    RewriteFile("0");

                    RutonyBot.SayToWindow("Файл очистен!", Color.Red);

                }
            }
        }


        public void ShowAlert(string name, float sum, string text) {

        }



        public void NewAlert(string site, string typeEvent, string subplan, string name, string text, float donate, string currency, int qty) {

            if (typeEvent == "donate") { 
                intValue = intValue + donate;
                RewriteFile(intValue.ToString());
            }

        }
    }
}