using System;
using System.Collections.Generic;
using System.Threading;

namespace RutonyChat {
    public class Script {

        public void InitParams(string param) {
            RutonyBot.SayToWindow("Test script connected");
        }

        public void Closing() {
            RutonyBot.SayToWindow("Test script disconnected");
        }

        public void NewMessage(string site, string name, string text, bool system) {
            RutonyBot.SayToWindow(string.Format("site={0}, name={1}, text={2}", site, name, text));
        }
        public void NewMessageEx(string site, string name, string text, bool system, Dictionary<string, string> Params) {

            if (name == "rutony") {
                RutonyBot.BotSay(site, name + ", hello!");
            }

        }

        public void NewAlert(string site, string typeEvent, string subplan, string name, string text, float donate, string currency, int qty) {
            
            if (typeEvent == "donate") {
                RutonyBot.BotSay(site, name + " поддержал на " + donate.ToString() + currency);
            }

            if (typeEvent == "TwitchPoints") {
                RutonyBot.BotSay(site, name + " активировал награду за " + donate.ToString());
            }

        }
    }
}