using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RutonyChat {
    public static class ProgramProps {

        public static string dir;

        public static string dir_alerts;
        public static string dir_alertslist;
        public static string dir_voting;
        public static string dir_progressbar;
        public static string dir_labels;
        public static string dir_data;
        public static string dir_emotes;
        public static string dir_history;
        public static string dir_scripts;
        public static string dir_backup;
        public static string dir_songrequest;
        public static string dir_temp;

        public static string dir_theme;
        public static string currentTheme;

        public static int port = 8383;

        public static string lang = "";
        public static string langName = "";

        public static string defaultCurrency = "";

        public enum SiteEnum {
            rutony, goodgame, goodgame_premium, goodgame_moderator, vidi,
            twitch, twitch_subscriber, twitch_moderator, sc2tv, youtube, cybergame,
            reall, hitbox, beam, livecoding, twitter, funstream, gipsyteam, gamerstv,
            welovegames, streambox, azubu, douyu,
            twitchalerts, donationalerts, streamtip, yandexmoney, qiwi, paypal, webmoney, other, favorite,
            vkontakte,
            streamgun, streamcube,
            aces,
            twitch_subscriber1, twitch_subscriber3, twitch_subscriber6, twitch_subscriber12, twitch_subscriber24,
            twitch_premium, twitch_turbo, twitch_ffz,
            odnoklassniki,
            bits1, bits100, bits1000, bits10000, bits100000, bits5000,
            itunes, spotify, lastfm,
            saibot, babajkov,
            donatepay, gamewisp, gamingforgood,
            youtube_moderator
        };
        
        public enum TypeAlerts {
            [System.ComponentModel.Description("None")]
            none,
            [System.ComponentModel.Description("Follower")]
            follower,
            [System.ComponentModel.Description("Any subscriber")]
            any_subscriber,
            [System.ComponentModel.Description("New subscriber")]
            new_subscriber,
            [System.ComponentModel.Description("Resub")]
            resub,
            [System.ComponentModel.Description("Donate")]
            donate,
            [System.ComponentModel.Description("Host")]
            host
        };


        public static string GetTempFilePathWithExtension(string path, string extension) {
            var fileName = Guid.NewGuid().ToString() + extension;
            return Path.Combine(path, fileName);
        }

        public static int getRand(int val) {
            return ((val * 1103515245) + 12345) & 0x7fffffff;
        }
        public static uint ColorToUInt(Color color) {
            return (uint)((color.A << 24) | (color.R << 16) | (color.G << 8) | (color.B << 0));
        }
    }
}
