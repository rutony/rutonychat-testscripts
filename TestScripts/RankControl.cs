using System;
using System.Collections.Generic;

namespace RutonyChat {
    public static class RankControl {

        public class RankCondition {
            public int Id { get; set; }
            public int IndCondition { get; set; } = 0;
            public bool Active { get; set; } = false;

            public string Rank { get; set; } = "";
            public int RankOrder { get; set; } = -1;
            public string RankImage { get; set; } = "";
            public string RankImagePreview { get; set; } = "";
            public bool AllowColor { get; set; } = false;
            public string RankColor { get; set; } = "";
            public bool CondMessage { get; set; } = false;
            public int MessageQty { get; set; } = 0;
            public bool CondSubscribe { get; set; } = false;
            public int SubscribeQty { get; set; } = 0;
            public bool CondDonate { get; set; } = false;
            public float DonateQty { get; set; } = 0;
            public bool CondCredits { get; set; } = false;
            public float CreditsQty { get; set; } = 0;
            public bool CondTime { get; set; } = false;
            public float TimeQty { get; set; } = 0;
            public bool GiveCredits { get; set; } = false;
            public float GiveCreditsQty { get; set; } = 0f;
            public bool AllowShowImage { get; set; } = false;
        }

        public static List<RankCondition> ListConditions;

        public class ChatterRank {

            public int Id { get; set; }
            public string Uid { get; set; } = "";
            public string Nickname { get; set; } = "";
            public string DisplayName { get; set; } = "";
            public string Rank { get; set; } = "";
            public int RankOrder { get; set; } = -1;
            public string RankImage { get; set; } = "";
            public string RankColor { get; set; } = "";
            public int MessageQty { get; set; } = 0;
            public int SubscribeQty { get; set; } = 0;
            public float DonateQty { get; set; } = 0;
            public int IndCondition { get; set; } = 0;
            public int CreditsQty { get; set; } = 0;
            public bool CondTime { get; set; } = false;
            public int TimeQty { get; set; } = 0;
            public int TimeToCredits { get; set; } = 0;
            public int MessagesToCredits { get; set; } = 0;
            public float DonateToCredits { get; set; } = 0;
            public bool RankProtect { get; set; } = false;

            public static implicit operator ChatterRank(List<ChatterRank> v) {
                if (v != null && v.Count > 0) {
                    return v[0];
                }
                return null;
            }
        }

        public static void Dispose() {
            

        }

        public static void Init() {

        }

        public static List<ChatterRank> ListChatters;
        public static List<ChatterRank> ListUpdateSQL;

        public static ChatterRank CheckRank(string var_nickname, string var_displaynickname,
            bool var_isMessage = false, bool var_isSubscribe = false, bool var_isDonate = false, bool var_isCredits = false, bool var_isTime = false,
            float var_summDonate = 0, int var_credits = 0, int var_time = 0, bool var_isSub = false) {

            return new ChatterRank();
        }

    }
}
