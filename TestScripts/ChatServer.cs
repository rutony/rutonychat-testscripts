using System;
using System.Collections.Generic;

namespace RutonyChat {
    public class ChatServer {
        public static List<string> GetListViewers(ProgramProps.SiteEnum site)
        {
            return new List<string>();
        }

        public static int GetYoutubeLikeCount() {

            Random rnd = new Random();
            return rnd.Next(0, 1000);

        }
    }
}