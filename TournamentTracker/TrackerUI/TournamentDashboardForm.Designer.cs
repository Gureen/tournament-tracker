namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboardForm));
            tournamentDashboard = new Label();
            loadExistingTournamentDropdown = new ComboBox();
            loadExistingTournamentLabel = new Label();
            loadTournamentButton = new Button();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // tournamentDashboard
            // 
            tournamentDashboard.AutoSize = true;
            tournamentDashboard.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tournamentDashboard.ForeColor = Color.SeaGreen;
            tournamentDashboard.Location = new Point(82, 24);
            tournamentDashboard.Name = "tournamentDashboard";
            tournamentDashboard.Size = new Size(353, 45);
            tournamentDashboard.TabIndex = 12;
            tournamentDashboard.Text = "Tournament Dashboard";
            // 
            // loadExistingTournamentDropdown
            // 
            loadExistingTournamentDropdown.FormattingEnabled = true;
            loadExistingTournamentDropdown.Location = new Point(244, 110);
            loadExistingTournamentDropdown.Name = "loadExistingTournamentDropdown";
            loadExistingTournamentDropdown.Size = new Size(226, 23);
            loadExistingTournamentDropdown.TabIndex = 18;
            // 
            // loadExistingTournamentLabel
            // 
            loadExistingTournamentLabel.AutoSize = true;
            loadExistingTournamentLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loadExistingTournamentLabel.ForeColor = Color.DarkSlateBlue;
            loadExistingTournamentLabel.Location = new Point(9, 108);
            loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            loadExistingTournamentLabel.Size = new Size(229, 25);
            loadExistingTournamentLabel.TabIndex = 19;
            loadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // loadTournamentButton
            // 
            loadTournamentButton.ForeColor = Color.DarkSlateBlue;
            loadTournamentButton.Location = new Point(206, 163);
            loadTournamentButton.Name = "loadTournamentButton";
            loadTournamentButton.Size = new Size(104, 45);
            loadTournamentButton.TabIndex = 20;
            loadTournamentButton.Text = "Load Tournament";
            loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            createTournamentButton.ForeColor = Color.DarkSlateBlue;
            createTournamentButton.Location = new Point(154, 227);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(209, 66);
            createTournamentButton.TabIndex = 27;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(516, 342);
            Controls.Add(createTournamentButton);
            Controls.Add(loadTournamentButton);
            Controls.Add(loadExistingTournamentLabel);
            Controls.Add(loadExistingTournamentDropdown);
            Controls.Add(tournamentDashboard);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TournamentDashboardForm";
            Text = "Tournament Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tournamentDashboard;
        private ComboBox loadExistingTournamentDropdown;
        private Label loadExistingTournamentLabel;
        private Button loadTournamentButton;
        private Button createTournamentButton;
    }
}