
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace RutonyChat {
    public static class RenameControl {

        public enum ResultStatus { ok, offline, error }

        public class SiteTitleInfo {
            public ProgramProps.SiteEnum site = ProgramProps.SiteEnum.rutony;
            public string title = "";
            public string game = "";
            public string desc = "";
            public List<string> tags = new List<string>();
            public string categoryId = "";
        }

        public class ResultRequest {
            public ResultStatus status;
            public string desc = "";
            public SiteTitleInfo info = new SiteTitleInfo();
            public List<string> videos = new List<string>();
        }
        public class GameSearchItem {
            public string name = "";
            public string id = "";
        }


        public static ResultRequest Rename(ProgramProps.SiteEnum site, string title, string game, string desc = "", string category = "", string tags = "") {

            return new ResultRequest();

        }


        public static ResultRequest GetTitleInfo(ProgramProps.SiteEnum site) {
            
            return new ResultRequest();

        }

        public static List<GameSearchItem> SearchGame(ProgramProps.SiteEnum site, string query) {

            return new List<GameSearchItem>();

        }


    }
}
