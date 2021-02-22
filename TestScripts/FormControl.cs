using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestScripts {
    public partial class FormControl : Form {

        public delegate void DelegateButton();
        public delegate void DelegateOpenClose(bool state);
        public event DelegateOpenClose EventBetsOpen;
        public event DelegateButton EventWin;
        public event DelegateButton EventLose;

        public bool VoteIsOpen = false;

        public class ChatterClass {
            public string site;
            public string name;
            public string userId;
            public int credits;
        }

        public void UpdateTop20(List<ChatterClass> top20)
        {



        }

        public void UpdateLabels(int qty, int sum)
        {

            lbMembers.Text = qty.ToString();
            lbSum.Text = sum.ToString();

        }

        public FormControl()
        {
            InitializeComponent();
        }

        private void FormControl_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> pa;
        }

        private void btnOpenVote_Click(object sender, EventArgs e)
        {

        }

        private void btnWin_Click(object sender, EventArgs e)
        {

        }

        private void btnLose_Click(object sender, EventArgs e)
        {

        }

        private void listMembers_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
