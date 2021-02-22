using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Threading;


namespace RutonyChat {

    public static class ChatDB {

        public static bool Inited = false;

        public class FollowerClass {
            public int Index;
            public DateTime DT;
            public ProgramProps.SiteEnum Site;
            public string Name;
            public bool isTest = false;
        }
        public class SubscriberClass {
            public int Index;
            public DateTime DT;
            public ProgramProps.SiteEnum Site;
            public string Name;
            public string Text = "";
            public bool isTest = false;
        }
        public class DonateClass {
            public int Index;
            public DateTime DT;
            public ProgramProps.SiteEnum Site;
            public string Name;
            public float Sum;
            public string Currency;
            public string Text;
            public bool isTest = false;
        }
        public class DonateSumClass {
            public int Index;
            public ProgramProps.SiteEnum Site;
            public string Name;
            public float Sum;
            public string Currency;
            public bool isTest = false;
        }

        public class ChatDataClass {

            public List<FollowerClass> ListFollowers = new List<FollowerClass>();
            public List<SubscriberClass> ListSubscribers = new List<SubscriberClass>();
            public List<DonateClass> ListDonates = new List<DonateClass>();

            public List<DonateSumClass> ListDonateSum = new List<DonateSumClass>();

            public Dictionary<LabelBase.LabelType, int> ListCounters = new Dictionary<LabelBase.LabelType, int>();
        }

        public static ChatDataClass ChatData = new ChatDataClass();
        
    }
}
