﻿namespace fifa_project_gokker
{
    partial class MainForm
    {
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
            if (disposing && (components != null))
            {
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
            this.teamsListBox = new System.Windows.Forms.ListBox();
            this.makeBetGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WedstrijdIDComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.makeBetButton = new System.Windows.Forms.Button();
            this.endScoreTeam2Numeric = new System.Windows.Forms.NumericUpDown();
            this.endScoreTeam1Numeric = new System.Windows.Forms.NumericUpDown();
            this.endScoreLabel = new System.Windows.Forms.Label();
            this.winningTeamComboBox = new System.Windows.Forms.ComboBox();
            this.winningTeam = new System.Windows.Forms.Label();
            this.amountNumeric = new System.Windows.Forms.NumericUpDown();
            this.amountLabel = new System.Windows.Forms.Label();
            this.typeBetComboBox = new System.Windows.Forms.ComboBox();
            this.typeBetLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadTeamListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tournamentsListBox = new System.Windows.Forms.ListBox();
            this.betsListBox = new System.Windows.Forms.ListBox();
            this.gokkerNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.MakeAGokkerGroupBox = new System.Windows.Forms.GroupBox();
            this.useExistingGokkerButton = new System.Windows.Forms.Button();
            this.existingGokkerComboBox = new System.Windows.Forms.ComboBox();
            this.gokkerLabel = new System.Windows.Forms.Label();
            this.payoutGroupBox = new System.Windows.Forms.GroupBox();
            this.betspergokkerListBox = new System.Windows.Forms.ListBox();
            this.avaliblecomboBox = new System.Windows.Forms.ComboBox();
            this.payoutButton = new System.Windows.Forms.Button();
            this.makeBetGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endScoreTeam2Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endScoreTeam1Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumeric)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.MakeAGokkerGroupBox.SuspendLayout();
            this.payoutGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamsListBox
            // 
            this.teamsListBox.FormattingEnabled = true;
            this.teamsListBox.Location = new System.Drawing.Point(13, 28);
            this.teamsListBox.Name = "teamsListBox";
            this.teamsListBox.Size = new System.Drawing.Size(206, 225);
            this.teamsListBox.TabIndex = 1;
            // 
            // makeBetGroupBox
            // 
            this.makeBetGroupBox.Controls.Add(this.label3);
            this.makeBetGroupBox.Controls.Add(this.WedstrijdIDComboBox);
            this.makeBetGroupBox.Controls.Add(this.label2);
            this.makeBetGroupBox.Controls.Add(this.moneyLabel);
            this.makeBetGroupBox.Controls.Add(this.makeBetButton);
            this.makeBetGroupBox.Controls.Add(this.endScoreTeam2Numeric);
            this.makeBetGroupBox.Controls.Add(this.endScoreTeam1Numeric);
            this.makeBetGroupBox.Controls.Add(this.endScoreLabel);
            this.makeBetGroupBox.Controls.Add(this.winningTeamComboBox);
            this.makeBetGroupBox.Controls.Add(this.winningTeam);
            this.makeBetGroupBox.Controls.Add(this.amountNumeric);
            this.makeBetGroupBox.Controls.Add(this.amountLabel);
            this.makeBetGroupBox.Controls.Add(this.typeBetComboBox);
            this.makeBetGroupBox.Controls.Add(this.typeBetLabel);
            this.makeBetGroupBox.Controls.Add(this.nameLabel);
            this.makeBetGroupBox.Enabled = false;
            this.makeBetGroupBox.Location = new System.Drawing.Point(13, 313);
            this.makeBetGroupBox.Name = "makeBetGroupBox";
            this.makeBetGroupBox.Size = new System.Drawing.Size(775, 100);
            this.makeBetGroupBox.TabIndex = 3;
            this.makeBetGroupBox.TabStop = false;
            this.makeBetGroupBox.Text = "Maak een Weddenschap";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Wedstrijd ID:";
            // 
            // WedstrijdIDComboBox
            // 
            this.WedstrijdIDComboBox.FormattingEnabled = true;
            this.WedstrijdIDComboBox.Location = new System.Drawing.Point(373, 66);
            this.WedstrijdIDComboBox.Name = "WedstrijdIDComboBox";
            this.WedstrijdIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.WedstrijdIDComboBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "$";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Location = new System.Drawing.Point(103, 20);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(0, 13);
            this.moneyLabel.TabIndex = 11;
            // 
            // makeBetButton
            // 
            this.makeBetButton.Location = new System.Drawing.Point(619, 71);
            this.makeBetButton.Name = "makeBetButton";
            this.makeBetButton.Size = new System.Drawing.Size(150, 23);
            this.makeBetButton.TabIndex = 10;
            this.makeBetButton.Text = "Maak Weddenschap";
            this.makeBetButton.UseVisualStyleBackColor = true;
            this.makeBetButton.Click += new System.EventHandler(this.makeBetButton_Click);
            // 
            // endScoreTeam2Numeric
            // 
            this.endScoreTeam2Numeric.Location = new System.Drawing.Point(629, 39);
            this.endScoreTeam2Numeric.Name = "endScoreTeam2Numeric";
            this.endScoreTeam2Numeric.Size = new System.Drawing.Size(60, 20);
            this.endScoreTeam2Numeric.TabIndex = 9;
            // 
            // endScoreTeam1Numeric
            // 
            this.endScoreTeam1Numeric.Location = new System.Drawing.Point(563, 39);
            this.endScoreTeam1Numeric.Name = "endScoreTeam1Numeric";
            this.endScoreTeam1Numeric.Size = new System.Drawing.Size(60, 20);
            this.endScoreTeam1Numeric.TabIndex = 8;
            // 
            // endScoreLabel
            // 
            this.endScoreLabel.AutoSize = true;
            this.endScoreLabel.Location = new System.Drawing.Point(500, 42);
            this.endScoreLabel.Name = "endScoreLabel";
            this.endScoreLabel.Size = new System.Drawing.Size(57, 13);
            this.endScoreLabel.TabIndex = 7;
            this.endScoreLabel.Text = "Eindscore:";
            // 
            // winningTeamComboBox
            // 
            this.winningTeamComboBox.FormattingEnabled = true;
            this.winningTeamComboBox.Location = new System.Drawing.Point(373, 39);
            this.winningTeamComboBox.Name = "winningTeamComboBox";
            this.winningTeamComboBox.Size = new System.Drawing.Size(121, 21);
            this.winningTeamComboBox.TabIndex = 6;
            // 
            // winningTeam
            // 
            this.winningTeam.AutoSize = true;
            this.winningTeam.Location = new System.Drawing.Point(278, 42);
            this.winningTeam.Name = "winningTeam";
            this.winningTeam.Size = new System.Drawing.Size(89, 13);
            this.winningTeam.TabIndex = 5;
            this.winningTeam.Text = "Winnende Team:";
            // 
            // amountNumeric
            // 
            this.amountNumeric.Location = new System.Drawing.Point(212, 39);
            this.amountNumeric.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.amountNumeric.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.amountNumeric.Name = "amountNumeric";
            this.amountNumeric.Size = new System.Drawing.Size(60, 20);
            this.amountNumeric.TabIndex = 4;
            this.amountNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(173, 42);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(33, 13);
            this.amountLabel.TabIndex = 3;
            this.amountLabel.Text = "Inzet:";
            // 
            // typeBetComboBox
            // 
            this.typeBetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeBetComboBox.FormattingEnabled = true;
            this.typeBetComboBox.Location = new System.Drawing.Point(46, 39);
            this.typeBetComboBox.Name = "typeBetComboBox";
            this.typeBetComboBox.Size = new System.Drawing.Size(121, 21);
            this.typeBetComboBox.TabIndex = 2;
            this.typeBetComboBox.SelectedIndexChanged += new System.EventHandler(this.typeBetComboBox_SelectedIndexChanged);
            this.typeBetComboBox.Enter += new System.EventHandler(this.typeBetComboBox_Enter);
            // 
            // typeBetLabel
            // 
            this.typeBetLabel.AutoSize = true;
            this.typeBetLabel.Location = new System.Drawing.Point(6, 42);
            this.typeBetLabel.Name = "typeBetLabel";
            this.typeBetLabel.Size = new System.Drawing.Size(34, 13);
            this.typeBetLabel.TabIndex = 1;
            this.typeBetLabel.Text = "Type:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(7, 20);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(41, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "(Naam)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.teamsToolStripMenuItem,
            this.loginToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1085, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.sluitenToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // sluitenToolStripMenuItem
            // 
            this.sluitenToolStripMenuItem.Name = "sluitenToolStripMenuItem";
            this.sluitenToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.sluitenToolStripMenuItem.Text = "Sluiten";
            this.sluitenToolStripMenuItem.Click += new System.EventHandler(this.sluitenToolStripMenuItem_Click);
            // 
            // teamsToolStripMenuItem
            // 
            this.teamsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadTeamListToolStripMenuItem});
            this.teamsToolStripMenuItem.Name = "teamsToolStripMenuItem";
            this.teamsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.teamsToolStripMenuItem.Text = "Teams";
            // 
            // reloadTeamListToolStripMenuItem
            // 
            this.reloadTeamListToolStripMenuItem.Name = "reloadTeamListToolStripMenuItem";
            this.reloadTeamListToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.reloadTeamListToolStripMenuItem.Text = "reload team list";
            this.reloadTeamListToolStripMenuItem.Click += new System.EventHandler(this.reloadTeamListToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem1
            // 
            this.loginToolStripMenuItem1.Name = "loginToolStripMenuItem1";
            this.loginToolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.loginToolStripMenuItem1.Text = "Log-in";
            this.loginToolStripMenuItem1.Click += new System.EventHandler(this.loginToolStripMenuItem1_Click);
            // 
            // tournamentsListBox
            // 
            this.tournamentsListBox.FormattingEnabled = true;
            this.tournamentsListBox.Location = new System.Drawing.Point(229, 28);
            this.tournamentsListBox.Name = "tournamentsListBox";
            this.tournamentsListBox.Size = new System.Drawing.Size(229, 225);
            this.tournamentsListBox.TabIndex = 5;
            // 
            // betsListBox
            // 
            this.betsListBox.FormattingEnabled = true;
            this.betsListBox.Location = new System.Drawing.Point(464, 28);
            this.betsListBox.Name = "betsListBox";
            this.betsListBox.Size = new System.Drawing.Size(324, 225);
            this.betsListBox.TabIndex = 6;
            // 
            // gokkerNameTextBox
            // 
            this.gokkerNameTextBox.Location = new System.Drawing.Point(106, 16);
            this.gokkerNameTextBox.Name = "gokkerNameTextBox";
            this.gokkerNameTextBox.Size = new System.Drawing.Size(195, 20);
            this.gokkerNameTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Gokker username:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Maak Gokker aan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MakeAGokkerGroupBox
            // 
            this.MakeAGokkerGroupBox.Controls.Add(this.useExistingGokkerButton);
            this.MakeAGokkerGroupBox.Controls.Add(this.existingGokkerComboBox);
            this.MakeAGokkerGroupBox.Controls.Add(this.gokkerLabel);
            this.MakeAGokkerGroupBox.Controls.Add(this.button1);
            this.MakeAGokkerGroupBox.Controls.Add(this.gokkerNameTextBox);
            this.MakeAGokkerGroupBox.Controls.Add(this.label1);
            this.MakeAGokkerGroupBox.Enabled = false;
            this.MakeAGokkerGroupBox.Location = new System.Drawing.Point(13, 259);
            this.MakeAGokkerGroupBox.Name = "MakeAGokkerGroupBox";
            this.MakeAGokkerGroupBox.Size = new System.Drawing.Size(775, 48);
            this.MakeAGokkerGroupBox.TabIndex = 10;
            this.MakeAGokkerGroupBox.TabStop = false;
            this.MakeAGokkerGroupBox.Text = "Maak een gokker aan";
            // 
            // useExistingGokkerButton
            // 
            this.useExistingGokkerButton.Location = new System.Drawing.Point(670, 14);
            this.useExistingGokkerButton.Name = "useExistingGokkerButton";
            this.useExistingGokkerButton.Size = new System.Drawing.Size(75, 23);
            this.useExistingGokkerButton.TabIndex = 13;
            this.useExistingGokkerButton.Text = "Use";
            this.useExistingGokkerButton.UseVisualStyleBackColor = true;
            this.useExistingGokkerButton.Click += new System.EventHandler(this.useExistingGokkerButton_Click);
            // 
            // existingGokkerComboBox
            // 
            this.existingGokkerComboBox.FormattingEnabled = true;
            this.existingGokkerComboBox.Location = new System.Drawing.Point(542, 16);
            this.existingGokkerComboBox.Name = "existingGokkerComboBox";
            this.existingGokkerComboBox.Size = new System.Drawing.Size(121, 21);
            this.existingGokkerComboBox.TabIndex = 12;
            // 
            // gokkerLabel
            // 
            this.gokkerLabel.AutoSize = true;
            this.gokkerLabel.Location = new System.Drawing.Point(438, 19);
            this.gokkerLabel.Name = "gokkerLabel";
            this.gokkerLabel.Size = new System.Drawing.Size(98, 13);
            this.gokkerLabel.TabIndex = 11;
            this.gokkerLabel.Text = "use existing gokker";
            // 
            // payoutGroupBox
            // 
            this.payoutGroupBox.Controls.Add(this.betspergokkerListBox);
            this.payoutGroupBox.Controls.Add(this.avaliblecomboBox);
            this.payoutGroupBox.Controls.Add(this.payoutButton);
            this.payoutGroupBox.Location = new System.Drawing.Point(795, 27);
            this.payoutGroupBox.Name = "payoutGroupBox";
            this.payoutGroupBox.Size = new System.Drawing.Size(279, 386);
            this.payoutGroupBox.TabIndex = 11;
            this.payoutGroupBox.TabStop = false;
            this.payoutGroupBox.Text = "Payout box";
            // 
            // betspergokkerListBox
            // 
            this.betspergokkerListBox.FormattingEnabled = true;
            this.betspergokkerListBox.Location = new System.Drawing.Point(9, 47);
            this.betspergokkerListBox.Name = "betspergokkerListBox";
            this.betspergokkerListBox.Size = new System.Drawing.Size(264, 303);
            this.betspergokkerListBox.TabIndex = 12;
            // 
            // avaliblecomboBox
            // 
            this.avaliblecomboBox.FormattingEnabled = true;
            this.avaliblecomboBox.Location = new System.Drawing.Point(9, 20);
            this.avaliblecomboBox.Name = "avaliblecomboBox";
            this.avaliblecomboBox.Size = new System.Drawing.Size(264, 21);
            this.avaliblecomboBox.TabIndex = 3;
            this.avaliblecomboBox.SelectedIndexChanged += new System.EventHandler(this.avaliblecomboBox_SelectedIndexChanged);
            // 
            // payoutButton
            // 
            this.payoutButton.Location = new System.Drawing.Point(7, 355);
            this.payoutButton.Name = "payoutButton";
            this.payoutButton.Size = new System.Drawing.Size(266, 25);
            this.payoutButton.TabIndex = 1;
            this.payoutButton.Text = "Payout selected bets";
            this.payoutButton.UseVisualStyleBackColor = true;
            this.payoutButton.Click += new System.EventHandler(this.payoutButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 429);
            this.ControlBox = false;
            this.Controls.Add(this.payoutGroupBox);
            this.Controls.Add(this.MakeAGokkerGroupBox);
            this.Controls.Add(this.betsListBox);
            this.Controls.Add(this.tournamentsListBox);
            this.Controls.Add(this.makeBetGroupBox);
            this.Controls.Add(this.teamsListBox);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.makeBetGroupBox.ResumeLayout(false);
            this.makeBetGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endScoreTeam2Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endScoreTeam1Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumeric)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MakeAGokkerGroupBox.ResumeLayout(false);
            this.MakeAGokkerGroupBox.PerformLayout();
            this.payoutGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox teamsListBox;
        private System.Windows.Forms.GroupBox makeBetGroupBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sluitenToolStripMenuItem;
        private System.Windows.Forms.Button makeBetButton;
        private System.Windows.Forms.NumericUpDown endScoreTeam2Numeric;
        private System.Windows.Forms.NumericUpDown endScoreTeam1Numeric;
        private System.Windows.Forms.Label endScoreLabel;
        private System.Windows.Forms.ComboBox winningTeamComboBox;
        private System.Windows.Forms.Label winningTeam;
        private System.Windows.Forms.NumericUpDown amountNumeric;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.ComboBox typeBetComboBox;
        private System.Windows.Forms.Label typeBetLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ToolStripMenuItem teamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadTeamListToolStripMenuItem;
        private System.Windows.Forms.ListBox tournamentsListBox;
        private System.Windows.Forms.ListBox betsListBox;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem1;
        private System.Windows.Forms.TextBox gokkerNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox MakeAGokkerGroupBox;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button useExistingGokkerButton;
        private System.Windows.Forms.ComboBox existingGokkerComboBox;
        private System.Windows.Forms.Label gokkerLabel;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.GroupBox payoutGroupBox;
        private System.Windows.Forms.ComboBox avaliblecomboBox;
        private System.Windows.Forms.Button payoutButton;
        private System.Windows.Forms.ListBox betspergokkerListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox WedstrijdIDComboBox;
    }
}

