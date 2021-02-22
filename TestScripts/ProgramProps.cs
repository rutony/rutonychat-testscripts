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
            youtube_moderator,
            smashcast,
            termimator,
            facebook,
            bits25000, bits50000, bits75000, bits200000, bits300000, bits400000, bits500000, bits600000, bits700000, bits800000, bits900000, bits1000000,
            twitch_partner,
            panda,
            youtube_subscriber,
            looch,
            hypesx,
            twitch_subscriber36, twitch_subscriber48, twitch_subscriber60, twitch_subscriber72, twitch_subscriber84, twitch_subscriber96, twitch_vip,
            yevhenii24, twitch_subscriber9,
            twitch_subscriber18, twitch_subscriber90, twitch_subscriber66, twitch_subscriber54, twitch_subscriber42, twitch_subscriber30, twitch_subscriber78,
            donatestream, twitch_founder,
            destream,
            cloudtips,
            trovo, wasd, dlive, theta,
            steam,
            discord,
            reps
        };

        public enum TypeAlerts {
            [System.ComponentModel.Description("None")]
            none,
            [System.ComponentModel.Description("Free subscriber")]
            follower,
            [System.ComponentModel.Description("Any paid subscriber")]
            any_subscriber,
            [System.ComponentModel.Description("New paid subscriber")]
            new_subscriber,
            [System.ComponentModel.Description("Paid resub")]
            resub,
            [System.ComponentModel.Description("Donate")]
            donate,
            [System.ComponentModel.Description("Host")]
            host,
            [System.ComponentModel.Description("New viewer")]
            new_viewer,
            [System.ComponentModel.Description("Rank promote")]
            rank_promote,
            [System.ComponentModel.Description("New like")]
            like,
            [System.ComponentModel.Description("New current track")]
            new_current_track,
            [System.ComponentModel.Description("Repost")]
            repost,
            [System.ComponentModel.Description("Gift")]
            gift,
            [System.ComponentModel.Description("Request")]
            request,
            [System.ComponentModel.Description("Raid")]
            raid
        };

        public enum TypeSubscriberPlan {
            [System.ComponentModel.Description("-")]
            any = 0,
            [System.ComponentModel.Description("Prime")]
            twitch_prime = 1,
            [System.ComponentModel.Description("Tear 1")]
            twitch_tear1 = 2,
            [System.ComponentModel.Description("Tear 2")]
            twitch_tear2 = 3,
            [System.ComponentModel.Description("Tear 3")]
            twitch_tear3 = 4,
        }

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
