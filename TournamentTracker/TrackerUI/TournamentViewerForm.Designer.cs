namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            tournamentLabel = new Label();
            roundLabel = new Label();
            roundDropdown = new ComboBox();
            unplayedOnlyCheckBox = new CheckBox();
            matchupListBox = new ListBox();
            teamOneLabel = new Label();
            teamOneScoreValue = new TextBox();
            teamTwoScoreValue = new TextBox();
            teamTwoLabel = new Label();
            vsLabel = new Label();
            scoreButton = new Button();
            scoreLabel = new Label();
            SuspendLayout();
            // 
            // tournamentLabel
            // 
            tournamentLabel.AutoSize = true;
            tournamentLabel.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tournamentLabel.ForeColor = Color.SeaGreen;
            tournamentLabel.Location = new Point(277, 9);
            tournamentLabel.Name = "tournamentLabel";
            tournamentLabel.Size = new Size(280, 65);
            tournamentLabel.TabIndex = 0;
            tournamentLabel.Text = "Tournament";
            tournamentLabel.Click += label1_Click;
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundLabel.ForeColor = Color.DarkSlateBlue;
            roundLabel.Location = new Point(281, 108);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(88, 32);
            roundLabel.TabIndex = 1;
            roundLabel.Text = "Round:";
            // 
            // roundDropdown
            // 
            roundDropdown.FormattingEnabled = true;
            roundDropdown.Location = new Point(375, 117);
            roundDropdown.Name = "roundDropdown";
            roundDropdown.Size = new Size(184, 23);
            roundDropdown.TabIndex = 2;
            // 
            // unplayedOnlyCheckBox
            // 
            unplayedOnlyCheckBox.AutoSize = true;
            unplayedOnlyCheckBox.FlatAppearance.CheckedBackColor = Color.DarkSlateBlue;
            unplayedOnlyCheckBox.Location = new Point(574, 119);
            unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            unplayedOnlyCheckBox.Size = new Size(104, 19);
            unplayedOnlyCheckBox.TabIndex = 3;
            unplayedOnlyCheckBox.Text = "Unplayed Only";
            unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 15;
            matchupListBox.Location = new Point(22, 107);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(232, 304);
            matchupListBox.TabIndex = 4;
            // 
            // teamOneLabel
            // 
            teamOneLabel.AutoSize = true;
            teamOneLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamOneLabel.ForeColor = Color.DarkSlateBlue;
            teamOneLabel.Location = new Point(272, 301);
            teamOneLabel.Name = "teamOneLabel";
            teamOneLabel.Size = new Size(97, 21);
            teamOneLabel.TabIndex = 5;
            teamOneLabel.Text = "<team one>";
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.BorderStyle = BorderStyle.FixedSingle;
            teamOneScoreValue.Location = new Point(375, 301);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(55, 23);
            teamOneScoreValue.TabIndex = 7;
            // 
            // teamTwoScoreValue
            // 
            teamTwoScoreValue.BorderStyle = BorderStyle.FixedSingle;
            teamTwoScoreValue.Location = new Point(492, 301);
            teamTwoScoreValue.Name = "teamTwoScoreValue";
            teamTwoScoreValue.Size = new Size(55, 23);
            teamTwoScoreValue.TabIndex = 10;
            // 
            // teamTwoLabel
            // 
            teamTwoLabel.AutoSize = true;
            teamTwoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamTwoLabel.ForeColor = Color.DarkSlateBlue;
            teamTwoLabel.Location = new Point(566, 301);
            teamTwoLabel.Name = "teamTwoLabel";
            teamTwoLabel.Size = new Size(97, 21);
            teamTwoLabel.TabIndex = 8;
            teamTwoLabel.Text = "<team two>";
            // 
            // vsLabel
            // 
            vsLabel.AutoSize = true;
            vsLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vsLabel.ForeColor = Color.DarkSlateBlue;
            vsLabel.Location = new Point(436, 301);
            vsLabel.Name = "vsLabel";
            vsLabel.Size = new Size(50, 25);
            vsLabel.TabIndex = 11;
            vsLabel.Text = "-VS-";
            // 
            // scoreButton
            // 
            scoreButton.ForeColor = Color.DarkSlateBlue;
            scoreButton.Location = new Point(413, 356);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(104, 45);
            scoreButton.TabIndex = 13;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scoreLabel.ForeColor = Color.DarkSlateBlue;
            scoreLabel.Location = new Point(427, 254);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(59, 25);
            scoreLabel.TabIndex = 14;
            scoreLabel.Text = "Score";
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(scoreLabel);
            Controls.Add(scoreButton);
            Controls.Add(vsLabel);
            Controls.Add(teamTwoScoreValue);
            Controls.Add(teamTwoLabel);
            Controls.Add(teamOneScoreValue);
            Controls.Add(teamOneLabel);
            Controls.Add(matchupListBox);
            Controls.Add(unplayedOnlyCheckBox);
            Controls.Add(roundDropdown);
            Controls.Add(roundLabel);
            Controls.Add(tournamentLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tournamentLabel;
        private Label roundLabel;
        private ComboBox roundDropdown;
        private CheckBox unplayedOnlyCheckBox;
        private ListBox matchupListBox;
        private Label teamOneLabel;
        private TextBox teamOneScoreValue;
        private TextBox teamTwoScoreValue;
        private Label teamTwoLabel;
        private Label vsLabel;
        private Button scoreButton;
        private Label scoreLabel;
    }
}
