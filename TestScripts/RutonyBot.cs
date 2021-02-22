using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RutonyChat {
    public static class RutonyBot {

        public static bool Active = false;

        public class BotMessageItem {
            public int indPreset = 0;
            public string Name = "";

            // conditions
            public bool active = false;
            public bool isAlert = false;
            public bool isTotalPause = false;
            public int repeat = 60;
            public bool onlyForAministrators = false;
            public bool onlyForSubscribers = false;
            public bool onlyStreamOnline = false;
            public bool onlyForFavorites = false;
            public bool onlyForRank = false;
            public bool onlyForRankInterval = false;
            public int onlyForRankEq = 0;
            public int onlyForRankEq2 = 0;
            public int onlyForRankPresetIndex = -1;
            public int onlyForRankPresetIndex2 = -1;
            public string onlyForRankFail = "";
            public bool isEvent = false;
            public string Event = "";
            public int EventRankEq = 0;
            public int EventRankIndex = -1;
            public int EventPoints = 0;
            public bool isWinnerRaffle = false;
            public List<ProgramProps.SiteEnum> targets;
            public bool isRequest = false;
            public bool isRequestSubstring = false;
            public string request = "";
            public bool isRequeredCredits = false;
            public int RequeredCredits = 0;
            public bool ConsiderCreditsToGoal = false;
            public string RequeredCreditsCannotMinus = "";
            public int pause = 0;
            public bool PauseIndividual = false;
            public bool AnswerIfPause = false;
            public string AnswerIfPauseText = "";
            public DateTime lastRun;
            public bool NicknameFromArgument = false;

            // results
            public bool isAnswer = false;
            public string answer = "";
            public bool isPrivate = false;
            public bool isScript = false;
            public string scriptName = "";
            public string scriptParams = "";
            public bool isListParams = false;
            public bool isRankPromote = false;
            public int rankIndex = -1;
            public bool isCreditsOperations = false;
            public int CreditsOperation = 0;
            public int CreditsCount = 0;
            public string CreditsCannotMinus = "";
            public bool isRCPreset = false;
            public int RCPresetIndex = -1;
            public bool TTSText = false;
        }

        public class ChatterCommandTimeout {
            public int indPreset = -1;
            public DateTime lastRun;
            public string username = "";
        }

        public static List<ChatterCommandTimeout> ListCommandTimeout = new List<ChatterCommandTimeout>();

        public static DateTime TotalPauseLastRun = new DateTime(1, 1, 1, 0, 0, 0);

        public static List<BotMessageItem> BotMessages;
        public static List<BotMessageItem> BotMessagesAlerts;
        public static List<string> ListAdmins = new List<string>();
        public static string SuperAdmin = "";

        public static void CheckResults(string author, string username, string textUser, BotMessageItem bmItem, List<ProgramProps.SiteEnum> targets, string donate, string currency) {
        
        }
        public static void SayToWindow(string text) {

            Console.WriteLine(string.Format(">> SayToWindow: {0}", text));

        }

        public static ConsoleColor GetConsoleColor(this Color color) {
            if (color.GetSaturation() < 0.5) {
                switch ((int)(color.GetBrightness() * 3.5)) {
                    case 0: return ConsoleColor.Black;
                    case 1: return ConsoleColor.DarkGray;
                    case 2: return ConsoleColor.Gray;
                    default: return ConsoleColor.White;
                }
            }
            int hue = (int)Math.Round(color.GetHue() / 60, MidpointRounding.AwayFromZero);
            if (color.GetBrightness() < 0.4) {
                switch (hue) {
                    case 1: return ConsoleColor.DarkYellow;
                    case 2: return ConsoleColor.DarkGreen;
                    case 3: return ConsoleColor.DarkCyan;
                    case 4: return ConsoleColor.DarkBlue;
                    case 5: return ConsoleColor.DarkMagenta;
                    default: return ConsoleColor.DarkRed;
                }
            }
            switch (hue) {
                case 1: return ConsoleColor.Yellow;
                case 2: return ConsoleColor.Green;
                case 3: return ConsoleColor.Cyan;
                case 4: return ConsoleColor.Blue;
                case 5: return ConsoleColor.Magenta;
                default: return ConsoleColor.Red;
            }
        }

        public static void SayToWindow(string text, Color color) {

            Console.ForegroundColor = GetConsoleColor(color);
            Console.WriteLine(string.Format(">>> SayToWindow: {0}", text));
            Console.ForegroundColor = ConsoleColor.Gray;

        }
        public static void BotSay(string site, string text) {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(string.Format(">>> Say: [{0}]: {1}", site, text));
            Console.ForegroundColor = ConsoleColor.Gray;

        }

        public static void SendPause() {

            Console.WriteLine(string.Format("Player: Pause"));

        }
        public static void SendPlay() {

            Console.WriteLine(string.Format("Player: Play"));

        }
        public static void SendVolume(int vol) {

            Console.WriteLine(string.Format("Player: Set volume to - " + vol.ToString()));

        }

        // username == "" - add song anyway        
        public static bool AddSongRequest(string id, string username, ProgramProps.SiteEnum site = ProgramProps.SiteEnum.rutony) {

            Console.WriteLine(string.Format("Player: Trying add song to player"));

            return true;
        }

        public static void Init() {

            Active = true;

        }

        public static void Shutdown() {


        }
    }
}
