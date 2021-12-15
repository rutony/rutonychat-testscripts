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

            public static bool ShowDiffOnline = false;
            public static int DiffOnlineUpdate = 5;

            public static bool ShowRandomAlerts = false;
            public static bool ShowAlertsInChat = true;
            public static bool ShowDonate = true;
            public static string DotateChatFormat = ""; // "$name " + ProgramLang.ChatDonateText + " $sum";
            public static string DotateChatWithTextFormat = ""; // "$name " + ProgramLang.ChatDonateText + " $sum $text";
            public static bool ShowFollowers = true;
            public static string FollowerChatFormat = ""; // "$name " + ProgramLang.ChatNowFollower;
            public static bool ShowSubscribers = true;
            public static string SubscriberChatFormat = ""; // ProgramLang.ChatNowSubscriber;
            public static string ReSubscriberChatFormat = ""; // ProgramLang.ChatNowReSubscriber;
            public static bool ShowHost = true;
            public static string HostChatFormat = ""; // ProgramLang.ChatNowHost;
            public static string HostChatFormatAutohost = ""; // ProgramLang.ChatNowHostAutohost;
            public static bool ShowRaids = true;
            public static string RaidsChatFormat = ""; // ProgramLang.ChatNowRaid;
            public static bool ShowRequests = true;
            public static string RequestsChatFormat = ""; // ProgramLang.ChatNowRequest;
            public static bool ShowNewViewer = false;
            public static string NewViewerChatFormat = ""; // ProgramLang.ChatNowNewViewer;
            public static bool ShowRankPromote = false;
            public static string RankPromoteFormat = "$name get new rank $rank";
            public static bool ShowLikes = false;
            public static string LikeChatFormat = ""; // ProgramLang.ChatNowLike;
            public static bool ShowRepost = false;
            public static string RepostChatFormat = ""; // ProgramLang.ChatRepost;
            public static bool ShowGift = true;
            public static string GiftChatFormat = ""; // ProgramLang.ChatGift;

            public static bool UseShowFavorites = true;
            public static bool UseIgnoreList = true;
            public static bool IgnoreDonateFromIgnoreList = true;

            public static bool UseCensorList = false;
            public static string CensorText = ""; // ProgramLang.CensorText;

            // ranks
            public static bool Ranks = false;

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

            public static string Theme = "default";
            public static bool theme_workshop = false;
            public static string ThemeOnStream = "default";
            public static bool ThemeOnStreame_Workshop = false;
            public static bool SetHTMLBackColor = true;
            public static string HTMLBackColor = "#000";
            public static bool EffectSnow = false;
            public static bool ThemeOnStream_SystemAlerts = false;
            public static bool ThemeOnStream_AlertsInChat = false;
            public static bool IgnoreAlertsQueue = true;

            public static string MessageDeleted = ""; // ProgramLang.ChatMessageDeleted;
            public static bool ChatInput = false;

            public static string SelectedPollSites = "";

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
            public static bool SpeechSimpleText = false;
            public static string SpeechPhrase = "$text";
            public static bool SpeechOnlyPrivate = false;
            public static bool SpeechOnlySub = false;
            public static bool SpeechOnlySub_OnlyPrivate = false;
            public static string SpeechOnlySubContainsText = "";
            public static bool SpeechOnlyFavorite = false;
            public static bool SpeechOnlyFavorite_OnlyPrivate = false;
            public static string SpeechOnlyFavoriteContainsText = "";
            public static bool SpeechForRank = false;
            public static int SpeechForRankEq = 0;
            public static int SpeechForRankPresetIndex = -1;
            public static bool SpeechOnlySpecialMessages = false;
            public static bool SpeechOnlyTwitchRewards = false;
            public static bool SpeechOnlyTwitchRewards_OnlyWithText = false;
            public static bool SpeechOnlyAdministrator = false;
            public static bool SpeechOnlyAdministrator_OnlyPrivate = false;
            public static string SpeechOnlyAdministratorContainsText = "";

            public static bool GPUAcceleration = false;

            public static bool DLC1_ShowStats = false;

            public static int UpdateVersion = 0;

            public static bool WebDebug = false;
            public static int OutputDevice = -1;
        }

        public static class Currency {
            public static string BaseCurrencyUid = "";
            public static string FormatSum = "G";
            public static string FormatDonate = "$sum $currency";
            public static bool Update = true;
            public static DateTime LastUpdate = new DateTime(1, 1, 1, 0, 0, 0);
        }

        public static class songrequest {

            public static int CurrentDevice = 0;

            public static string Keywords = "!sr,!songrequest";
            public static string Keywords_Success = ""; // ProgramLang.SR_Keywords_Success;
            public static string Keywords_Error = ""; // ProgramLang.SR_Keywords_Error;

            public static bool OnlySubs = false;

            public static bool OnlyRanks = false;
            public static int OnlyRanksEq = 0;
            public static int OnlyRanks_Rank = -1;
            public static string OnlyRanks_Error = ""; // ProgramLang.SR_OnlyRanks_Error;

            public static bool MaxRequests = false;
            public static int MaxRequests_Value = 20;
            public static string MaxRequests_Error = ""; // ProgramLang.SR_MaxRequest_Error;

            public static bool RequestsPerUser = false;
            public static int RequestsPerUser_Value = 1;
            public static string RequestsPerUser_Error = ""; // ProgramLang.SR_RequestsPerUser_Error;

            public static bool PauseWhileAlertOnPause = true;

            public static bool RemoveCredits = false;
            public static int RemoveCredits_Value = 5;
            public static string RemoveCredits_Error = ""; // ProgramLang.SR_RemoveCredits_Error;

            public static bool ForceRequest = false;
            public static int ForceRequest_Value = 15;
            public static string ForceRequest_Keywords = "!fr,!forcerequest";
            public static string ForceRequest_Error = ""; // ProgramLang.SR_ForceRequest_Error;

            public static bool VotesForSkip = false;
            public static int VotesForSkip_Value = 5;
            public static string VotesForSkip_Keywords = "!skip";
            public static string VotesForSkip_Accept = ""; // ProgramLang.SR_VotesForSkip_Accept;
            public static string VotesForSkip_Error = ""; // ProgramLang.SR_VotesForSkip_Error;

            public static bool SkipForCredits = false;
            public static int SkipForCredits_Value = 10;
            public static string SkipForCredits_Keywords = "!fs,!forceskip";
            public static string SkipForCredits_Error = ""; // ProgramLang.SR_SkipForCredits_Error;

            public static bool SongMaxLength = false;
            public static int SongMaxLength_Value = 210;
            public static string SongMaxLength_Error = ""; // ProgramLang.SR_SongMaxLength_Error;

            public static bool SongMaxRate = false;
            public static int SongMaxRate_Value = 30;
            public static string SongMaxRate_Error = ""; // ProgramLang.SR_SongMaxRate_Error;

        }

        public static class quize {
            public static string word = "";
            public static string question = "";
        }

        public static class twitch {
            public static bool Active = false;
            public static string Channel = "";
            public static bool ColorNick = true;
            public static bool TwitchSubs = false;
            public static bool TwitchFollower = false;
            public static bool TwitchHost = false;
            public static bool ShowMods = true;
            public static bool ShowPremiums = true;
            public static bool ShowTurbo = true;
            public static bool ShowFFZ = false;
            public static bool ShowBits = false;
            public static bool ShowHost = false;
            public static bool ShowGift = false;
            public static bool GiftTotal = false;
            public static bool ShowNewViewer = false;
            public static bool ShowRaid = false;

            public static bool SubscribersFromDB = true;

            public static bool Donate = false;

            public static string Token = "";
            public static string TwitchAlertsToken = "";
            public static string TwitchServer = "";

            public static bool BotActive = false;
            public static string TwitchBotToken = "";

            public static string CustomServer = "";
            public static string Protocol = "irc";

            public static bool TwitchPoints = false;

            public static string TwitchPointsChatFormat = ""; // ProgramLang.TextTwitchPoints;
            public static string TwitchPointsWTextChatFormat = ""; // ProgramLang.TextTwitchPointsWithText;
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
            public static string TypeConnect = "0"; // 0 - first, 1 - url

            public static DateTime DateTime;
            public static string shortId = ""; // chat page id, for 1
            public static string liveCha1tId = "";

            public static string ListVideo_shortId = "";
            public static string ListVideo_LiveChatId = "";
            public static DateTime ListVideo_DateTime;
            public static string ListVideo_Title = "";

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
            public static string GroupId = "";
            public static string GroupTitle = "";
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
            public static string Token = "";
            public static string RefreshToken = "";
            public static string APIKey = "Ybax9r2vJp0eb6AvvP2z";
        }
        public static class Discord {
            public static bool Active = false;
            public static string Token = "";
            public static string RefreshToken = "";
        }
        public static class Donatty {
            public static bool Active = false;
            public static string Token = "";
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
            public static string Token = "";
            public static string RefreshToken = "";
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
        public static class CloudTips {
            public static bool Active = false;
            public static string Token = "";
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
        public static class trovo {
            public static bool Active = false;
            public static string Token = "";
            public static string RefreshToken = "";
            public static bool BotActive = false;
            public static string BotToken = "";
            public static string BotRefreshToken = "";
            public static bool Followers = true;
            public static bool Subscribers = true;
            public static bool Raids = true;
            public static bool NewViewers = false;
            public static bool Gifts = true;
        }
        public static class wasd {
            public static bool Active = false;
            public static string Channel = "";

            public static bool ShowStickers = true;
            public static int StickersSize = 1;
        }
        public static class steam {
            public static bool Active = false;
            public static string ChannelID = "";
        }
        public static class reps {
            public static bool Active = false;
        }



    }
}
