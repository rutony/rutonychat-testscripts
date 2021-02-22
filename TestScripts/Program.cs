using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RutonyChat {
    class Program {

        public static Script script = new Script();

        public static void WriteToChat(string site, string name, string text, bool system, Dictionary<string, string> Params) {
            
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"<<< [{site}] {name}: {text}");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.BackgroundColor = ConsoleColor.Black;

            script.NewMessageEx(site, name, text, system, Params);
        }

        static void Main(string[] args) {

            script.NewAlert("twitch", "donate", "", "test", "123", 200, "RUB", 0);

            Console.ReadKey();

            script.NewMessage("twitch", "rutony", "!reset_sum", false);

            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(">> END <<");

            script.Closing();

            Console.ReadKey();

        }
    }
}
