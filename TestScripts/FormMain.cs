using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RutonyChat {
    public partial class FormMain : Form {

        public List<string> privList;
        public List<string> ListFavorites;
        public List<string> IgnoreList;

        public static FormMain _instance;

        public FormMain() {
            InitializeComponent();
        }
    }
}
