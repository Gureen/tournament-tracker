namespace TrackerUI
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            label1 = new Label();
            tournamentNameValue = new TextBox();
            tournamentNameLabel = new Label();
            entryFeeLabel = new Label();
            entryFeeValue = new TextBox();
            selectTeamDropdown = new ComboBox();
            selectTeamLabel = new Label();
            createNewTeamButton = new LinkLabel();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            tournamentPlayersListBox = new ListBox();
            label2 = new Label();
            deleteSelectedTeamButton = new Button();
            label3 = new Label();
            prizesListBox = new ListBox();
            deleteSelectedPrizeButton = new Button();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(174, 9);
            label1.Name = "label1";
            label1.Size = new Size(430, 65);
            label1.TabIndex = 1;
            label1.Text = "Create Tournament";
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.BorderStyle = BorderStyle.FixedSingle;
            tournamentNameValue.Location = new Point(189, 103);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(225, 23);
            tournamentNameValue.TabIndex = 8;
            tournamentNameValue.TextChanged += textBox1_TextChanged;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tournamentNameLabel.ForeColor = Color.DarkSlateBlue;
            tournamentNameLabel.Location = new Point(15, 97);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(168, 25);
            tournamentNameLabel.TabIndex = 9;
            tournamentNameLabel.Text = "Tournament Name";
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entryFeeLabel.ForeColor = Color.DarkSlateBlue;
            entryFeeLabel.Location = new Point(88, 153);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(86, 25);
            entryFeeLabel.TabIndex = 10;
            entryFeeLabel.Text = "Entry fee";
            // 
            // entryFeeValue
            // 
            entryFeeValue.BorderStyle = BorderStyle.FixedSingle;
            entryFeeValue.Location = new Point(189, 153);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(225, 23);
            entryFeeValue.TabIndex = 11;
            entryFeeValue.Text = "0";
            // 
            // selectTeamDropdown
            // 
            selectTeamDropdown.FormattingEnabled = true;
            selectTeamDropdown.Location = new Point(189, 198);
            selectTeamDropdown.Name = "selectTeamDropdown";
            selectTeamDropdown.Size = new Size(226, 23);
            selectTeamDropdown.TabIndex = 13;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectTeamLabel.ForeColor = Color.DarkSlateBlue;
            selectTeamLabel.Location = new Point(63, 198);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(111, 25);
            selectTeamLabel.TabIndex = 14;
            selectTeamLabel.Text = "Select Team";
            // 
            // createNewTeamButton
            // 
            createNewTeamButton.AutoSize = true;
            createNewTeamButton.Location = new Point(421, 201);
            createNewTeamButton.Name = "createNewTeamButton";
            createNewTeamButton.Size = new Size(96, 15);
            createNewTeamButton.TabIndex = 15;
            createNewTeamButton.TabStop = true;
            createNewTeamButton.Text = "Create new team";
            // 
            // addTeamButton
            // 
            addTeamButton.ForeColor = Color.DarkSlateBlue;
            addTeamButton.Location = new Point(189, 261);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(104, 45);
            addTeamButton.TabIndex = 16;
            addTeamButton.Text = "Add team";
            addTeamButton.UseVisualStyleBackColor = true;
            // 
            // createPrizeButton
            // 
            createPrizeButton.ForeColor = Color.DarkSlateBlue;
            createPrizeButton.Location = new Point(310, 261);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(104, 45);
            createPrizeButton.TabIndex = 17;
            createPrizeButton.Text = "Create prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayersListBox
            // 
            tournamentPlayersListBox.FormattingEnabled = true;
            tournamentPlayersListBox.ItemHeight = 15;
            tournamentPlayersListBox.Location = new Point(553, 121);
            tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            tournamentPlayersListBox.Size = new Size(226, 94);
            tournamentPlayersListBox.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateBlue;
            label2.Location = new Point(543, 84);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 19;
            label2.Text = "Teams / Players";
            label2.Click += label2_Click;
            // 
            // deleteSelectedTeamButton
            // 
            deleteSelectedTeamButton.ForeColor = Color.DarkSlateBlue;
            deleteSelectedTeamButton.Location = new Point(666, 401);
            deleteSelectedTeamButton.Name = "deleteSelectedTeamButton";
            deleteSelectedTeamButton.Size = new Size(113, 29);
            deleteSelectedTeamButton.TabIndex = 23;
            deleteSelectedTeamButton.Text = "Delete Selected";
            deleteSelectedTeamButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateBlue;
            label3.Location = new Point(543, 264);
            label3.Name = "label3";
            label3.Size = new Size(141, 25);
            label3.TabIndex = 22;
            label3.Text = "Teams / Players";
            // 
            // prizesListBox
            // 
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 15;
            prizesListBox.Location = new Point(553, 301);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(226, 94);
            prizesListBox.TabIndex = 21;
            // 
            // deleteSelectedPrizeButton
            // 
            deleteSelectedPrizeButton.ForeColor = Color.DarkSlateBlue;
            deleteSelectedPrizeButton.Location = new Point(666, 221);
            deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            deleteSelectedPrizeButton.Size = new Size(113, 29);
            deleteSelectedPrizeButton.TabIndex = 24;
            deleteSelectedPrizeButton.Text = "Delete Selected";
            deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            createTournamentButton.ForeColor = Color.DarkSlateBlue;
            createTournamentButton.Location = new Point(310, 421);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(192, 51);
            createTournamentButton.TabIndex = 25;
            createTournamentButton.Text = "Create tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(816, 500);
            Controls.Add(createTournamentButton);
            Controls.Add(deleteSelectedPrizeButton);
            Controls.Add(deleteSelectedTeamButton);
            Controls.Add(label3);
            Controls.Add(prizesListBox);
            Controls.Add(label2);
            Controls.Add(tournamentPlayersListBox);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createNewTeamButton);
            Controls.Add(selectTeamLabel);
            Controls.Add(selectTeamDropdown);
            Controls.Add(entryFeeValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameLabel);
            Controls.Add(tournamentNameValue);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateTournamentForm";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tournamentNameValue;
        private Label tournamentNameLabel;
        private Label entryFeeLabel;
        private TextBox entryFeeValue;
        private ComboBox selectTeamDropdown;
        private Label selectTeamLabel;
        private LinkLabel createNewTeamButton;
        private Button addTeamButton;
        private Button createPrizeButton;
        private ListBox tournamentPlayersListBox;
        private Label label2;
        private Button deleteSelectedTeamButton;
        private Label label3;
        private ListBox prizesListBox;
        private Button deleteSelectedPrizeButton;
        private Button createTournamentButton;

    }
}