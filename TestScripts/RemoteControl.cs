using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RutonyChat {
    public static class RemoteControl {

        public static bool isActive = false;

        public enum TypeAlert { Follower, Subscriber, Donate, Text, HotKey, Host, NewViewer, RankPromote, Like, Repost, Gift, Raid, Request, TwitchPoints };
        public enum TypeCondMessage { chance, qty };

        [Flags]
        public enum ModifierKeys : uint {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            Win = 8
        }

        public class RemotePreset {
            // ==== conditions ====
            public int IndPreset = 0;
            public bool Active = false;
            public string Name = "";

            // alert
            public bool isAlertCond = false; // флаг, алерт, в том числе донат
            public TypeAlert Type = TypeAlert.Follower;
            public int ViewerQty = 0;

            public bool isDonate = false;
            public float MinValue = 0;
            public float MaxValue = 0;

            // text
            public bool ConditionText = false;  // флаг, текст
            public bool OnlySubscriber = false;
            public string ChatText = "";
            public TypeCondMessage CondMessage = TypeCondMessage.chance;
            public int Chance = 100;
            public int TextQty = 5;

            // hotkey
            public bool isHotkey = false; // флаг, нажата клавиша
            public ModifierKeys alt1 = ModifierKeys.None;
            public ModifierKeys alt2 = ModifierKeys.None;
            public System.Windows.Forms.Keys KeyHotKey = System.Windows.Forms.Keys.None;

            // Twitch Points
            public bool isTwitchPoints = false;
            public int TwitchPointsValue = 0;

            // ==== result ====
            // key
            public bool ConditionKey = false;
            public string WindowName = "";
            public bool StayPressed = false;
            public ModifierKeys alt = ModifierKeys.None;
            public System.Windows.Forms.Keys Key = System.Windows.Forms.Keys.F1;
            // script
            public bool isScript = false;
            public string Script = "";
            public string ScriptArguments = "";
            // sound
            public bool isSoundFile = false;
            public string SoundFile = "";
            public int SoundVolume = 100;
            // alert
            public bool isAlert = false;
            public string AlertID = "";
            public string AlertName = "";
            // counter
            public bool isCounter = false;
            public int CounterAction = 0;
            public int CounterNumber = 0;
            // run script
            public bool isRunScript = false;
            public string RunScriptName = "";
            public string RunScriptParams = "";
            // run bot command
            public bool isRunBotCommand = false;
            public int IndRunBotCommand = -1;
            // timers
            public bool isTimer = false;
            public int TimerOper = 0;
            public int TimerIndex = 0;
            public DateTime TimerEstimate = new DateTime();
            public bool TimerRunRCPreset = false;
            public int TimerRCPreset = -1;

            // ==== param =======
            public int saveQty = 0;
        }

        public static List<RemotePreset> ListPresets;

        public static void CheckPresets(RemotePreset preset, string var_nickname = "", string var_text = "", float var_value = 0) { }

        public static void RunProgram(RemotePreset preset, string var_nickname = "", string var_text = "", float var_value = 0, string var_donor = "") { }

        public static void PressKey(RemotePreset preset) { }
        public static void PlaySound(RemotePreset preset) { }

        public static void ShowCustomAlert(RemotePreset preset, string var_nick, string var_donate = "", string var_text = "") { }

        public static void UpdateCounter(int vnumber, int vvalue) { }

        public static void RunTimerOper(RemotePreset preset) { }

        public static void RunBotCommand(RemotePreset preset, string var_username, float var_value) { }

        public static void RunScript(RemotePreset preset, string var_username, float var_value = 0) { }
     
    }
}
