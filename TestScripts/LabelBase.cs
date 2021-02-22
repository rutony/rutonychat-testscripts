using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading;

namespace RutonyChat {
    public static class LabelBase {

        public static bool isTest = false;

        public class CustomLabel {
            private System.Threading.Timer _timer;
            private string _text = "";
            public bool Active = false;
            public string format = "{Result}";
            public int TimeUpdate = 1;
            public string ScriptName = "";
            public string ScriptParams = "";
            private int _interval = 1000;
        }

        public static List<CustomLabel> ListCustomLabels = new List<CustomLabel>();

        public enum LabelType {
            Viewers_Twitch,
            Viewers_Goodgame,
            Viewers_Cybergame,
            Viewers_ReallTV,
            Viewers_Youtube,
            Viewers_VIDI,
            Viewers_All,
            Followers_Last,
            Followers_Last_Day,
            Followers_Last_Week,
            Followers_Last_Month,
            Followers_Goal,
            Followers_Goal_Day,
            Followers_Goal_Week,
            Followers_Goal_Month,
            Subscriber_Last,
            Subscriber_Last_Day,
            Subscriber_Last_Week,
            Subscriber_Last_Month,
            Subscriber_Goal,
            Subscriber_Goal_Day,
            Subscriber_Goal_Week,
            Subscriber_Goal_Month,
            Donate_Last,
            Donate_Last_Day,
            Donate_Last_Week,
            Donate_Last_Month,
            Donate_Top1,
            Donate_Top1_Day,
            Donate_Top1_Week,
            Donate_Top1_Month,
            Donate_Top2,
            Donate_Top2_Day,
            Donate_Top2_Week,
            Donate_Top2_Month,
            Donate_Top3,
            Donate_Top3_Day,
            Donate_Top3_Week,
            Donate_Top3_Month,
            Donate_Top4,
            Donate_Top4_Day,
            Donate_Top4_Week,
            Donate_Top4_Month,
            Donate_Top5,
            Donate_Top5_Day,
            Donate_Top5_Week,
            Donate_Top5_Month,
            Donate_Goal,
            Donate_Goal_Day,
            Donate_Goal_Week,
            Donate_Goal_Month,
            Donate_All,
            Donate_All_Day,
            Donate_All_Week,
            Donate_All_Month,
            Counter1,
            Counter2,
            Counter3,
            Counter4,
            Counter5,
            Counter6,
            Counter7,
            Counter8,
            Counter9,
            Counter10,
            CurrentTrackVK,

            Viewers_HitBox,

            Donate_Top123,
            Donate_Top123_Day,
            Donate_Top123_Week,
            Donate_Top123_Month,

            Viewers_Odnoklassniki,
            Viewers_Vkontakte,

            CurrentTrack,
            Timer1,
            Timer2,
            Timer3,
            Timer4,
            Timer5,

            Viewers_Smashcast,

            Youtube_Like,
            Youtube_Dislike,

            Viewers_Mixer,
            Viewers_Wasd,
            Viewers_Steam,
            Viewers_Trovo

        }

        public class ValueLabel {
            public string Format;
            public Dictionary<string, string> Values = new Dictionary<string, string>();
        }

        public class LabelClass {
            public string Name;         // имя
            public string Caption;      // описание
            public string FileName;     // файл
            public string Format;       // формат
            public string BaseFormat;   // базовый формат
            public LabelType Type;      // тип
            public Dictionary<string, string> Params;
            public List<string> ListSites;
            public override string ToString() {
                return "-- " + Caption;
            }
            public string GetParam(string param, string defvalue) {
                string ret = defvalue;
                try {
                    ret = Params[param];
                } catch {
                    Params.Add(param, defvalue);
                }
                return ret;
            }

            public ValueLabel GetValue(string varSite = null) {

                Dictionary<string, string> Values = new Dictionary<string, string>();

                return new ValueLabel() { Format = Format, Values = Values };

            }
        }
    }
}
