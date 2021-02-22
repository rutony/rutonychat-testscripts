namespace TestScripts {
    partial class FormControl {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenVote = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWin = new System.Windows.Forms.Button();
            this.btnLose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listMembers = new System.Windows.Forms.ListView();
            this.colUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbMembers = new System.Windows.Forms.Label();
            this.lbSum = new System.Windows.Forms.Label();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnOpenVote
            // 
            this.btnOpenVote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenVote.Location = new System.Drawing.Point(15, 282);
            this.btnOpenVote.Name = "btnOpenVote";
            this.btnOpenVote.Size = new System.Drawing.Size(231, 23);
            this.btnOpenVote.TabIndex = 0;
            this.btnOpenVote.Text = "Открыть/Закрыть голосование";
            this.btnOpenVote.UseVisualStyleBackColor = true;
            this.btnOpenVote.Click += new System.EventHandler(this.btnOpenVote_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStatus.AutoSize = true;
            this.lbStatus.ForeColor = System.Drawing.Color.Red;
            this.lbStatus.Location = new System.Drawing.Point(62, 258);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(51, 13);
            this.lbStatus.TabIndex = 1;
            this.lbStatus.Text = "Закрыто";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Статус:";
            // 
            // btnWin
            // 
            this.btnWin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWin.BackColor = System.Drawing.Color.YellowGreen;
            this.btnWin.Location = new System.Drawing.Point(15, 311);
            this.btnWin.Name = "btnWin";
            this.btnWin.Size = new System.Drawing.Size(98, 33);
            this.btnWin.TabIndex = 3;
            this.btnWin.Text = "Победа";
            this.btnWin.UseVisualStyleBackColor = false;
            this.btnWin.Click += new System.EventHandler(this.btnWin_Click);
            // 
            // btnLose
            // 
            this.btnLose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLose.BackColor = System.Drawing.Color.LightCoral;
            this.btnLose.Location = new System.Drawing.Point(147, 311);
            this.btnLose.Name = "btnLose";
            this.btnLose.Size = new System.Drawing.Size(99, 33);
            this.btnLose.TabIndex = 4;
            this.btnLose.Text = "Проигрыш";
            this.btnLose.UseVisualStyleBackColor = false;
            this.btnLose.Click += new System.EventHandler(this.btnLose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Сумма ставок:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Участников:";
            // 
            // listMembers
            // 
            this.listMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listMembers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUser,
            this.colSum,
            this.colId});
            this.listMembers.FullRowSelect = true;
            this.listMembers.GridLines = true;
            this.listMembers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listMembers.Location = new System.Drawing.Point(15, 36);
            this.listMembers.MultiSelect = false;
            this.listMembers.Name = "listMembers";
            this.listMembers.Size = new System.Drawing.Size(231, 216);
            this.listMembers.TabIndex = 9;
            this.listMembers.UseCompatibleStateImageBehavior = false;
            this.listMembers.View = System.Windows.Forms.View.Details;
            this.listMembers.DoubleClick += new System.EventHandler(this.listMembers_DoubleClick);
            // 
            // colUser
            // 
            this.colUser.Text = "Участник";
            this.colUser.Width = 150;
            // 
            // colSum
            // 
            this.colSum.Text = "Сумма";
            this.colSum.Width = 75;
            // 
            // lbMembers
            // 
            this.lbMembers.AutoSize = true;
            this.lbMembers.Location = new System.Drawing.Point(88, 9);
            this.lbMembers.Name = "lbMembers";
            this.lbMembers.Size = new System.Drawing.Size(13, 13);
            this.lbMembers.TabIndex = 10;
            this.lbMembers.Text = "0";
            // 
            // lbSum
            // 
            this.lbSum.AutoSize = true;
            this.lbSum.Location = new System.Drawing.Point(209, 9);
            this.lbSum.Name = "lbSum";
            this.lbSum.Size = new System.Drawing.Size(13, 13);
            this.lbSum.TabIndex = 11;
            this.lbSum.Text = "0";
            // 
            // colId
            // 
            this.colId.Width = 0;
            // 
            // FormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 354);
            this.Controls.Add(this.lbSum);
            this.Controls.Add(this.lbMembers);
            this.Controls.Add(this.listMembers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLose);
            this.Controls.Add(this.btnWin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnOpenVote);
            this.Name = "FormControl";
            this.Text = "Ставки";
            this.Load += new System.EventHandler(this.FormControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenVote;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWin;
        private System.Windows.Forms.Button btnLose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listMembers;
        private System.Windows.Forms.ColumnHeader colUser;
        private System.Windows.Forms.ColumnHeader colSum;
        private System.Windows.Forms.Label lbMembers;
        private System.Windows.Forms.Label lbSum;
        private System.Windows.Forms.ColumnHeader colId;
    }
}