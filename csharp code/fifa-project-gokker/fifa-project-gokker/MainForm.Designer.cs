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
            this.BetsGroupBox = new System.Windows.Forms.GroupBox();
            this.makeBetGroupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameLabel = new System.Windows.Forms.Label();
            this.typeBetLabel = new System.Windows.Forms.Label();
            this.typeBetComboBox = new System.Windows.Forms.ComboBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountNumeric = new System.Windows.Forms.NumericUpDown();
            this.winningTeam = new System.Windows.Forms.Label();
            this.winningTeamComboBox = new System.Windows.Forms.ComboBox();
            this.endScoreLabel = new System.Windows.Forms.Label();
            this.endScoreTeam1Numeric = new System.Windows.Forms.NumericUpDown();
            this.endScoreTeam2Numeric = new System.Windows.Forms.NumericUpDown();
            this.makeBetButton = new System.Windows.Forms.Button();
            this.makeBetGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endScoreTeam1Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endScoreTeam2Numeric)).BeginInit();
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
            // BetsGroupBox
            // 
            this.BetsGroupBox.Location = new System.Drawing.Point(170, 28);
            this.BetsGroupBox.Name = "BetsGroupBox";
            this.BetsGroupBox.Size = new System.Drawing.Size(618, 225);
            this.BetsGroupBox.TabIndex = 2;
            this.BetsGroupBox.TabStop = false;
            this.BetsGroupBox.Text = "Gemaakte Weddenschappen";
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
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
            this.sluitenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sluitenToolStripMenuItem.Text = "Sluiten";
            this.sluitenToolStripMenuItem.Click += new System.EventHandler(this.sluitenToolStripMenuItem_Click);
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logInToolStripMenuItem.Text = "Log In";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
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
            // typeBetLabel
            // 
            this.typeBetLabel.AutoSize = true;
            this.typeBetLabel.Location = new System.Drawing.Point(6, 42);
            this.typeBetLabel.Name = "typeBetLabel";
            this.typeBetLabel.Size = new System.Drawing.Size(34, 13);
            this.typeBetLabel.TabIndex = 1;
            this.typeBetLabel.Text = "Type:";
            // 
            // typeBetComboBox
            // 
            this.typeBetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeBetComboBox.FormattingEnabled = true;
            this.typeBetComboBox.Location = new System.Drawing.Point(46, 39);
            this.typeBetComboBox.Name = "typeBetComboBox";
            this.typeBetComboBox.Size = new System.Drawing.Size(121, 21);
            this.typeBetComboBox.TabIndex = 2;
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
            // amountNumeric
            // 
            this.amountNumeric.Location = new System.Drawing.Point(212, 39);
            this.amountNumeric.Name = "amountNumeric";
            this.amountNumeric.Size = new System.Drawing.Size(60, 20);
            this.amountNumeric.TabIndex = 4;
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
            // winningTeamComboBox
            // 
            this.winningTeamComboBox.FormattingEnabled = true;
            this.winningTeamComboBox.Location = new System.Drawing.Point(373, 39);
            this.winningTeamComboBox.Name = "winningTeamComboBox";
            this.winningTeamComboBox.Size = new System.Drawing.Size(121, 21);
            this.winningTeamComboBox.TabIndex = 6;
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
            // endScoreTeam1Numeric
            // 
            this.endScoreTeam1Numeric.Location = new System.Drawing.Point(563, 39);
            this.endScoreTeam1Numeric.Name = "endScoreTeam1Numeric";
            this.endScoreTeam1Numeric.Size = new System.Drawing.Size(60, 20);
            this.endScoreTeam1Numeric.TabIndex = 8;
            // 
            // endScoreTeam2Numeric
            // 
            this.endScoreTeam2Numeric.Location = new System.Drawing.Point(629, 39);
            this.endScoreTeam2Numeric.Name = "endScoreTeam2Numeric";
            this.endScoreTeam2Numeric.Size = new System.Drawing.Size(60, 20);
            this.endScoreTeam2Numeric.TabIndex = 9;
            // 
            // makeBetButton
            // 
            this.makeBetButton.Location = new System.Drawing.Point(619, 71);
            this.makeBetButton.Name = "makeBetButton";
            this.makeBetButton.Size = new System.Drawing.Size(150, 23);
            this.makeBetButton.TabIndex = 10;
            this.makeBetButton.Text = "Maak Weddenschap";
            this.makeBetButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 369);
            this.Controls.Add(this.makeBetGroupBox);
            this.Controls.Add(this.BetsGroupBox);
            this.Controls.Add(this.teamsListBox);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.makeBetGroupBox.ResumeLayout(false);
            this.makeBetGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endScoreTeam1Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endScoreTeam2Numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox teamsListBox;
        private System.Windows.Forms.GroupBox BetsGroupBox;
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
    }
}

