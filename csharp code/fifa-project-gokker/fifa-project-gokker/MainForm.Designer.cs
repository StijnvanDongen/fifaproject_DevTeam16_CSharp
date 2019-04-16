namespace fifa_project_gokker
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
            this.sluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadTeamListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tournamentsListBox = new System.Windows.Forms.ListBox();
            this.betsListBox = new System.Windows.Forms.ListBox();
            this.makeBetGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endScoreTeam2Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endScoreTeam1Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumeric)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamsListBox
            // 
            this.teamsListBox.FormattingEnabled = true;
            this.teamsListBox.Location = new System.Drawing.Point(13, 28);
            this.teamsListBox.Name = "teamsListBox";
            this.teamsListBox.Size = new System.Drawing.Size(150, 225);
            this.teamsListBox.TabIndex = 1;
            // 
            // makeBetGroupBox
            // 
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
            this.makeBetGroupBox.Location = new System.Drawing.Point(13, 260);
            this.makeBetGroupBox.Name = "makeBetGroupBox";
            this.makeBetGroupBox.Size = new System.Drawing.Size(775, 100);
            this.makeBetGroupBox.TabIndex = 3;
            this.makeBetGroupBox.TabStop = false;
            this.makeBetGroupBox.Text = "Maak een Weddenschap";
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
            this.amountNumeric.Name = "amountNumeric";
            this.amountNumeric.Size = new System.Drawing.Size(60, 20);
            this.amountNumeric.TabIndex = 4;
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
            this.teamsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sluitenToolStripMenuItem,
            this.logInToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // sluitenToolStripMenuItem
            // 
            this.sluitenToolStripMenuItem.Name = "sluitenToolStripMenuItem";
            this.sluitenToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.sluitenToolStripMenuItem.Text = "Sluiten";
            this.sluitenToolStripMenuItem.Click += new System.EventHandler(this.sluitenToolStripMenuItem_Click);
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.logInToolStripMenuItem.Text = "Log In";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
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
            // tournamentsListBox
            // 
            this.tournamentsListBox.FormattingEnabled = true;
            this.tournamentsListBox.Location = new System.Drawing.Point(169, 28);
            this.tournamentsListBox.Name = "tournamentsListBox";
            this.tournamentsListBox.Size = new System.Drawing.Size(150, 225);
            this.tournamentsListBox.TabIndex = 5;
            // 
            // betsListBox
            // 
            this.betsListBox.FormattingEnabled = true;
            this.betsListBox.Location = new System.Drawing.Point(325, 28);
            this.betsListBox.Name = "betsListBox";
            this.betsListBox.Size = new System.Drawing.Size(463, 225);
            this.betsListBox.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 369);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox teamsListBox;
        private System.Windows.Forms.GroupBox makeBetGroupBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sluitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
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
    }
}

