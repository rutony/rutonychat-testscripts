using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RutonyChat {
    public static class ProgramSettings {


        public static class general {
            public static string PrivateMessage = "";

            public static string Theme = "default";
            public static bool theme_workshop = false;

            public static bool ShowDiffOnline = false;
            public static int DiffOnlineUpdate = 5;

            public static bool ShowRandomAlerts = false;
            public static bool ShowAlertsInChat = true;
            public static bool ShowDonate = true;
            public static string FormatSumDonate = "G";
            public static bool ShowFollowers = true;
            public static bool ShowSubscribers = true;
            public static bool ShowHost = true;
            public static bool ShowRaids = true;
            public static bool ShowRequests = true;
            public static bool ShowNewViewer = false;
            public static bool ShowRankPromote = false;
            public static string RankPromoteFormat = "$name get new rank $rank";
            public static bool ShowLikes = false;
            public static bool ShowRepost = false;
            public static bool ShowGift = false;

            public static bool UseShowFavorites = true;
            public static bool UseIgnoreList = true;
            public static bool IgnoreDonateFromIgnoreList = true;

            public static bool UseCensorList = false;

            // ranks
            public static bool Ranks = true;

            public static bool RankCreditsForTime = true;
            public static int RankTimeForTransfer = 60;
            public static int RankCreditsPerTransfer = 10;
            public static int RankCreditsPerTransferSubs = 10;

            public static bool RankCreditsForMessages = true;
            public static int RankMessagesForTransfer = 10;
            public static int RankCreditsForMessagesPerTransfer = 1;
            public static int RankCreditsForMessagesPerTransferSubs = 0;

            public static bool RankCredisForDonate = false;
            public static int RankCreditsForDonatePerTransfer = 1;
            public static int RankDonateForTransfer = 1;

            public static int RankTypePromote = 0;
            public static bool RanksAllowCreditsOnlyWhileStreamOnline = false;

            //

            public static bool ActiveLabels = false;
            public static bool RemoteControl = true;
            public static string RemoteProfile = "1";

            public static string BotProfile = "1";

            public static bool CustomEmotes = true;
            public static bool ShowImagesInChat = false;
            public static bool SaveHistory = false;
            public static bool AlwaysTop = true;
            public static bool DontCollapseBotLinks = false;
            public static string DontCollapseBotLinksNicknames = "rutonybot,moobot,NightBot";
            public static bool SetHTMLBackColor = true;
            public static string HTMLBackColor = "#000";
            public static bool EffectSnow = false;
            public static bool IgnoreAlertsQueue = false;


            public static string StatisticType = "0";
            public static string ZoomFactor = "0";
            public static bool ShowTrackSwitch = false;
            public static bool DonateRemoveLinks = true;

            public static string StatsShowStatsTargetIndex = "1";

            public static bool FillHelpCommandAuto = true;
            public static string HelpCommandList = "";
            public static bool FillUpCommandAuto = true;
            public static string UpCommandList = "";
            public static int TotalPauseForBot = 30;
            public static string TotalPauseForBotText = "";

            public static string BotRepeatAlerts = "60";
            public static DateTime ProgressBarStarDateTime;

            public static bool SpeechText = false;
            public static string SpeechVoice = "";
            public static bool SpeechRandomVoice = false;
            public static int SpeechRate = 0;
            public static bool SpeechRandomRate = false;
            public static int SpeechVolume = 100;
            public static string SpeechPhrase = "$text";
            public static bool SpeechOnlyPrivate = false;
            public static bool SpeechOnlySub = false;
            public static string SpeechOnlySubContainsText = "";
            public static bool SpeechOnlyFavorite = false;
            public static string SpeechOnlyFavoriteContainsText = "";
            public static bool SpeechForRank = false;
            public static int SpeechForRankEq = 0;
            public static int SpeechForRankPresetIndex = -1;
            public static bool SpeechOnlySpecialMessages = false;
            public static bool SpeechOnlyAdministrator = false;
            public static string SpeechOnlyAdministratorContainsText = "";

            public static bool GPUAcceleration = false;

            public static bool DLC1_ShowStats = false;

            public static int UpdateVersion = 0;

            public static bool WebDebug = false;
        }

        public static class songrequest {
            public static bool Active = false;

            public static int Volume = 50;
            public static bool RequestsPerUserActive = false;
            public static int RequestsPerUser = 1;
            public static bool MaxRequestsActive = false;
            public static int MaxRequests = 20;
            public static bool SkipVotesActive = false;
            public static int SkipVotes = 5;
            public static bool OnlySubs = false;
            public static bool OnlyRank = false;
            public static int OnlyRankInd = -1;
            public static int OnlyRankEq = 1;
            public static bool RemoveCreditsActive = false;
            public static int RemoveCredits = 5;
            public static bool SkipForCreditsActive = false;
            public static int SkipForCredits = 5;
            public static bool SongMaxLengthActive = false;
            public static DateTime SongMaxLength = new DateTime(1753, 1, 1, 0, 7, 0);
            public static bool RatesActive = false;
            public static int Rates = 80;
            public static bool VideoPreviewsActive = false;
            public static int VideoPreviews = 30000;
            public static bool PauseWhileAlertOnPause = true;
            public static bool ForceRequest = false;
            public static int ForceRequestCredits = 5;
            public static bool BackgroundImage = false;
            public static string BackgroundImagePath = "";

            public static string BotCommandRequestAdd = "!sr,!songrequest";
            public static string BotCommandForceRequest = "!fr,!forcerequest";
            public static string BotCommandRequestsList = "!sl,!srl,!requestlist";
            public static string BotCommandRequestSkip = "!skip";
            public static string BotCommandRequestForceSkip = "!fs,!forceskip";
            public static string BotCommandRequestCurrentSong = "!cs,!song";
            public static string BotCommandRequestRemoveRequest = "!rr,!removerequest";

        }

        public static class quize {
            public static string word = "";
            public static string question = "";
        }

        public static class twitch {
            public static bool Active = false;
            public static string Channel = "";
            public static bool ColorNick = true;
            public static bool TwitchSubs = true;
            public static bool TwitchFollower = true;
            public static bool TwitchHost = true;
            public static bool ShowMods = true;
            public static bool ShowPremiums = true;
            public static bool ShowTurbo = true;
            public static bool ShowFFZ = false;
            public static bool ShowBits = true;
            public static bool ShowHost = true;
            public static bool ShowGift = true;
            public static bool GiftTotal = false;
            public static bool ShowNewViewer = false;
            public static bool ShowRaid = true;

            public static bool SubscribersFromDB = false;

            public static bool Donate = false;

            public static string Token = "";
            public static string TwitchAlertsToken = "";
            public static string TwitchServer = "";

            public static bool BotActive = false;
            public static string TwitchBotToken = "";

            public static string CustomServer = "";
            public static string Protocol = "irc";
        }

        public static class sc2tv {
            public static bool Active = false;
            public static string Channel = "";
            public static bool ColorNick = true;
            public static bool MainStream = false;
            public static bool Donate = false;
            public static string DonateLogin = "";
        }

        public static class goodgame {
            public static bool Active = false;
            public static string Channel = "";
            public static bool ColorNick = true;
            public static bool ShowIcons = true;
            public static bool GoodgameSubs = true;
            public static bool GoodgameFollower = true;
            public static bool GoodgameDonate = true;
            public static string Login = "";
            public static string Password = "";

            public static bool ShowNewViewer = false;
            public static bool ShowGift = true;
            public static bool ShowRequest = true;

            public static bool BotActive = false;
            public static string BotLogin = "";
            public static string BotPassword = "";
            public static string CustomStreamKey = "";
        }

        public static class Reall {
            public static bool Active = false;
            public static string Channel = "";
        }

        public static class Welovegames {
            public static bool Active = false;
            public static string Channel = "";
        }

        public static class VIDI {
            public static bool Active = false;
            public static string Channel = "";
        }

        public static class Beam {
            public static bool Active = false;
            public static string Channel = "";
        }

        public static class StreamBox {
            public static bool Active = false;
            public static string Channel = "";
        }
        public static class streamcube {
            public static bool Active = false;
            public static string Channel = "";
        }
        public static class cybergame {
            public static bool Active = false;
            public static string Channel = "";
        }
        public static class gtv {
            public static bool Active = false;
            public static string Channel = "";
        }
        public static class aces {
            public static bool Active = false;
            public static string Channel = "";
        }
        public static class douyu {
            public static bool Active = false;
            public static string Channel = "";
        }
        public static class azubu {
            public static bool Active = false;
            public static string Channel = "";
            public static string Login = "";
            public static string Password = "";
        }
        public static class gipsyteam {
            public static bool Active = false;
            public static string Channel = "";
        }
        public static class youtube {
            public static bool Active = false;
            public static string Token = "";
            public static string TokenSecret = "";
            public static string RefreshToken = "";
            public static string TypeConnect = "0"; // 0 - first, 1 - selected, 2 - url
            public static DateTime DateTime;
            public static string liveChatId = "";
            public static string Id = "";
            public static string title = "";
            public static string YoutubeUrl = "";
            public static bool YoutubeFollower = false;
            public static bool YoutubeSubs = false;
            public static bool YoutubeDonate = false;
            public static bool ShowMods = true;
            public static bool BotActive = false;
            public static string BotToken = "";
            public static string BotRefreshToken = "";
            public static bool ColorNick = true;
            public static string Cookie = "";
        }
        public static class smashcast {
            public static bool Active = false;
            public static string Channel = "";
        }
        public static class odnoklassniki {
            public static bool Active = false;
            public static string Channel = "";
            public static string Token = "";
            public static string TokenSecret = "";
            public static string RefreshToken = "";
        }
        public static class vkontakte {
            public static bool Active = false;
            public static string TypeConnect = "0";
            public static string Channel = "";
            public static string GroupId = "";
            public static string GroupTitle = "";
            public static string Token = "";
            public static string TokenSecret = "";
            public static bool TrackFromStatus = true;
            public static bool BotActive = false;
            public static bool BotAsGroup = true;
            public static string BotToken = "";
            public static bool Likes = false;
            public static bool VkontakteFollower = false;
            public static bool ShowRepost = true;
            public static string SetTitle = "";
            public static string SetDesc = "";
        }
        public static class facebook {
            public static bool Active = false;
            public static string Channel = "";
            public static string Token = "";
            public static string AccessToken = "";

            public static string TypeConnect = "0";
        }
        public static class panda {
            public static bool Active = false;
            public static string Channel = "";
        }
        public static class looch {
            public static bool Active = false;
            public static string Channel = "";
        }
        public static class twitter {
            public static bool Active = false;
            public static string Channel = "";
            public static string Token = "";
            public static string TokenSecret = "";
            public static string tag = "#rutony";
        }
        public static class StreamGun {
            public static bool Active = false;
            public static string AccessToken = "";
        }
        public static class DonationAlerts {
            public static bool Active = false;
            public static string ApiKey = "";
        }
        public static class TwitchAlerts {
            public static bool Active = false;
            public static string Token = "";
        }
        public static class StreamTip {
            public static bool Active = false;
            public static string AccessToken = "";
            public static string ClientId = "";
        }
        public static class itunes {
            public static bool Active = false;
        }
        public static class lastfm {
            public static bool Active = false;
            public static string Channel = "";
        }
        public static class spotify {
            public static bool Active = false;
        }
        public static class DonatePay {
            public static bool Active = false;
            public static string AccessToken = "";
        }
        public static class GameWisp {
            public static bool ActiveSubs = false;
            public static bool ActiveDonate = false;
            public static string AccessToken = "";
            public static string RefreshToken = "";
        }
        public static class QIWI {
            public static bool Active = false;
            public static string Token = "";
            public static string TelNumber = "";
        }
        public static class DonateStream {
            public static bool Active = false;
            public static string Token = "";
        }
        public static class mailboxalerts {
            public static bool active = false;
            public static string Port = "995";
            public static string POP3Server = "pop.gmail.com";
            public static string Mailbox = "";
            public static string Password = "";
            public static bool UseSSL = true;
            public static bool QIWIVoucher = false;
            public static bool YandexMoney = false;
            public static bool PayPal = false;
            public static bool WebMoney = false;
        }
        public static class hypesx {
            public static bool Active = false;
            public static string Channel = "";
        }

        public static class destream {
            public static bool Active = false;
            public static string Token = "";
        }

        private static Dictionary<string, Dictionary<string, string>> defValuesDict = null;



    }
}
