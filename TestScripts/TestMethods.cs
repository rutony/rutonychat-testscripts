using RutonyChat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScripts {
    public class TestMethods {

        public static Script _script;                

        public static void NewMessage(string site, string name, string text, bool system = false, Dictionary<string, string> Params = null) {

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"<<< MESSAGE [{site}] {name}: {text}");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.BackgroundColor = ConsoleColor.Black;

            _script.NewMessageEx(site, name, text, system, Params);
        }

        public static void NewFollower(string site, string name) {

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"<<< EVENT: FOLLOWER [{site}] {name}");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.BackgroundColor = ConsoleColor.Black;

            _script.NewAlert(site, "follower", "", name, "", 0f, "", 0);

        }

        public static void NewAnySubscriber(string site, string name, int period = 12) {

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"<<< EVENT: ANY SUBSCRIBER [{site}] {name} / {period}");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.BackgroundColor = ConsoleColor.Black;

            _script.NewAlert(site, "any_subscriber", "", name, "", period, "", 0);

        }

        public static void NewNewSubscriber(string site, string name) {

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"<<< EVENT: NEW SUBSCRIBER [{site}] {name}");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.BackgroundColor = ConsoleColor.Black;

            _script.NewAlert(site, "new_subscriber", "", name, "", 0f, "", 0);

        }

        public static void NewResub(string site, string name, int period = 12, string text = "hello text") {

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"<<< EVENT: RESUB [{site}] {name}: {text} / {period}");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.BackgroundColor = ConsoleColor.Black;

            _script.NewAlert(site, "resub", "", name, text, period, "", 0);

        }
        public static void NewHost(string site, string name, int qty = 12) {

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"<<< EVENT: HOST [{site}] {name} / {qty}");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.BackgroundColor = ConsoleColor.Black;

            _script.NewAlert(site, "host", "", name, "", qty, "", 0);

        }
        public static void NewRaid(string site, string name, int qty = 12) {

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"<<< EVENT: RAID [{site}] {name} / {qty}");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.BackgroundColor = ConsoleColor.Black;

            _script.NewAlert(site, "raid", "", name, "", qty, "", 0);

        }
        public static void NewNewViewer(string site, string name) {

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"<<< EVENT: NEW VIEWER [{site}] {name}");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.BackgroundColor = ConsoleColor.Black;

            _script.NewAlert(site, "new_viewer", "", name, "", 0f, "", 0);

        }
        public static void NewRepost(string site, string name) {

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"<<< EVENT: REPOST [{site}] {name}");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.BackgroundColor = ConsoleColor.Black;

            _script.NewAlert(site, "new_viewer", "", name, "", 0f, "", 0);

        }
        public static void NewGift(string site, string donor = "test_donor", string name = "test_user") {

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"<<< EVENT: GIFT [{site}] {donor} -> {name}");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.BackgroundColor = ConsoleColor.Black;

            _script.NewAlert(site, "new_viewer", "", name, "", 0f, "", 0);

        }
        public static void NewLike(string site, string name) {

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"<<< EVENT: LIKE [{site}] {name}");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.BackgroundColor = ConsoleColor.Black;

            _script.NewAlert(site, "new_viewer", "", name, "", 0f, "", 0);

        }
        public static void NewRankPromote(string site, string name) {

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"<<< EVENT: RANK PROMOTE [{site}] {name}");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.BackgroundColor = ConsoleColor.Black;

            _script.NewAlert(site, "rank_promote", "", name, "", 0f, "", 0);

        }
        public static void NewDonate(string site = "donationalerts", string name = "test_user", string text = "test text", float amount = 123.45f, string currency = "RUB") {

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"<<< EVENT: DONATE [{site}] {name}: {text} / {currency}{amount}");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.BackgroundColor = ConsoleColor.Black;

            _script.NewAlert(site, "donate", "", name, text, amount, currency, 0);

        }

        public static void NewTwitchPoints(string name = "test_user", string text = "test text", int amount = 500) {

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"<<< EVENT: TWITCH POINTS {name}: {text} / {amount}");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.BackgroundColor = ConsoleColor.Black;

            _script.NewAlert("twitch", "TwitchPoints", "", name, text, amount, "", 0);

        }
    }
}
