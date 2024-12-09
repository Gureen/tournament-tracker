namespace TrackerUI
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            teamNameLabel = new Label();
            teamNameValue = new TextBox();
            createTeamLabel = new Label();
            addMemberButton = new Button();
            selectTeamMemberLabel = new Label();
            selectTeamMemberDropdown = new ComboBox();
            addNewMemberGroupBox = new GroupBox();
            cellphoneLabel = new Label();
            cellphoneValue = new TextBox();
            emailLabel = new Label();
            emailValue = new TextBox();
            lastNameLabel = new Label();
            lastNameValue = new TextBox();
            firstNameLabel = new Label();
            firstNameValue = new TextBox();
            createMemberButton = new Button();
            teamMembersListBox = new ListBox();
            deleteSelectedMemberButton = new Button();
            createTeamButton = new Button();
            addNewMemberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamNameLabel.ForeColor = Color.DarkSlateBlue;
            teamNameLabel.Location = new Point(29, 87);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(111, 25);
            teamNameLabel.TabIndex = 12;
            teamNameLabel.Text = "Team Name";
            // 
            // teamNameValue
            // 
            teamNameValue.BorderStyle = BorderStyle.FixedSingle;
            teamNameValue.Location = new Point(146, 89);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(225, 23);
            teamNameValue.TabIndex = 11;
            // 
            // createTeamLabel
            // 
            createTeamLabel.AutoSize = true;
            createTeamLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createTeamLabel.ForeColor = Color.SeaGreen;
            createTeamLabel.Location = new Point(29, 28);
            createTeamLabel.Name = "createTeamLabel";
            createTeamLabel.Size = new Size(196, 45);
            createTeamLabel.TabIndex = 10;
            createTeamLabel.Text = "Create Team";
            // 
            // addMemberButton
            // 
            addMemberButton.ForeColor = Color.DarkSlateBlue;
            addMemberButton.Location = new Point(267, 202);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(104, 45);
            addMemberButton.TabIndex = 19;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectTeamMemberLabel.ForeColor = Color.DarkSlateBlue;
            selectTeamMemberLabel.Location = new Point(29, 137);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(111, 25);
            selectTeamMemberLabel.TabIndex = 18;
            selectTeamMemberLabel.Text = "Select Team";
            // 
            // selectTeamMemberDropdown
            // 
            selectTeamMemberDropdown.FormattingEnabled = true;
            selectTeamMemberDropdown.Location = new Point(146, 139);
            selectTeamMemberDropdown.Name = "selectTeamMemberDropdown";
            selectTeamMemberDropdown.Size = new Size(226, 23);
            selectTeamMemberDropdown.TabIndex = 17;
            // 
            // addNewMemberGroupBox
            // 
            addNewMemberGroupBox.Controls.Add(cellphoneLabel);
            addNewMemberGroupBox.Controls.Add(cellphoneValue);
            addNewMemberGroupBox.Controls.Add(emailLabel);
            addNewMemberGroupBox.Controls.Add(emailValue);
            addNewMemberGroupBox.Controls.Add(lastNameLabel);
            addNewMemberGroupBox.Controls.Add(lastNameValue);
            addNewMemberGroupBox.Controls.Add(firstNameLabel);
            addNewMemberGroupBox.Controls.Add(firstNameValue);
            addNewMemberGroupBox.Location = new Point(43, 272);
            addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            addNewMemberGroupBox.Size = new Size(329, 234);
            addNewMemberGroupBox.TabIndex = 20;
            addNewMemberGroupBox.TabStop = false;
            addNewMemberGroupBox.Text = "Add New Member";
            addNewMemberGroupBox.Enter += groupBox1_Enter;
            // 
            // cellphoneLabel
            // 
            cellphoneLabel.AutoSize = true;
            cellphoneLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cellphoneLabel.ForeColor = Color.DarkSlateBlue;
            cellphoneLabel.Location = new Point(15, 155);
            cellphoneLabel.Name = "cellphoneLabel";
            cellphoneLabel.Size = new Size(98, 25);
            cellphoneLabel.TabIndex = 21;
            cellphoneLabel.Text = "Cellphone";
            // 
            // cellphoneValue
            // 
            cellphoneValue.BorderStyle = BorderStyle.FixedSingle;
            cellphoneValue.Location = new Point(123, 157);
            cellphoneValue.Name = "cellphoneValue";
            cellphoneValue.Size = new Size(154, 23);
            cellphoneValue.TabIndex = 20;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.ForeColor = Color.DarkSlateBlue;
            emailLabel.Location = new Point(15, 116);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(58, 25);
            emailLabel.TabIndex = 19;
            emailLabel.Text = "Email";
            // 
            // emailValue
            // 
            emailValue.BorderStyle = BorderStyle.FixedSingle;
            emailValue.Location = new Point(123, 118);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(154, 23);
            emailValue.TabIndex = 18;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameLabel.ForeColor = Color.DarkSlateBlue;
            lastNameLabel.Location = new Point(15, 74);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(100, 25);
            lastNameLabel.TabIndex = 17;
            lastNameLabel.Text = "Last Name";
            // 
            // lastNameValue
            // 
            lastNameValue.BorderStyle = BorderStyle.FixedSingle;
            lastNameValue.Location = new Point(123, 76);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(154, 23);
            lastNameValue.TabIndex = 16;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameLabel.ForeColor = Color.DarkSlateBlue;
            firstNameLabel.Location = new Point(15, 35);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(102, 25);
            firstNameLabel.TabIndex = 15;
            firstNameLabel.Text = "First Name";
            // 
            // firstNameValue
            // 
            firstNameValue.BorderStyle = BorderStyle.FixedSingle;
            firstNameValue.Location = new Point(123, 37);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(154, 23);
            firstNameValue.TabIndex = 8;
            firstNameValue.TextChanged += textBox1_TextChanged;
            // 
            // createMemberButton
            // 
            createMemberButton.ForeColor = Color.DarkSlateBlue;
            createMemberButton.Location = new Point(268, 528);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(104, 45);
            createMemberButton.TabIndex = 21;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 15;
            teamMembersListBox.Location = new Point(404, 82);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(282, 424);
            teamMembersListBox.TabIndex = 22;
            // 
            // deleteSelectedMemberButton
            // 
            deleteSelectedMemberButton.ForeColor = Color.DarkSlateBlue;
            deleteSelectedMemberButton.Location = new Point(731, 272);
            deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            deleteSelectedMemberButton.Size = new Size(113, 44);
            deleteSelectedMemberButton.TabIndex = 25;
            deleteSelectedMemberButton.Text = "Delete Selected";
            deleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            createTeamButton.ForeColor = Color.DarkSlateBlue;
            createTeamButton.Location = new Point(315, 629);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(209, 66);
            createTeamButton.TabIndex = 26;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(864, 691);
            Controls.Add(createTeamButton);
            Controls.Add(deleteSelectedMemberButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(createMemberButton);
            Controls.Add(addNewMemberGroupBox);
            Controls.Add(addMemberButton);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(selectTeamMemberDropdown);
            Controls.Add(teamNameLabel);
            Controls.Add(teamNameValue);
            Controls.Add(createTeamLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateTeamForm";
            Text = "Create Team";
            addNewMemberGroupBox.ResumeLayout(false);
            addNewMemberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label teamNameLabel;
        private TextBox teamNameValue;
        private Label createTeamLabel;
        private Button addMemberButton;
        private Label selectTeamMemberLabel;
        private ComboBox selectTeamMemberDropdown;
        private GroupBox addNewMemberGroupBox;
        private TextBox firstNameValue;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private TextBox lastNameValue;
        private Label cellphoneLabel;
        private TextBox cellphoneValue;
        private Label emailLabel;
        private TextBox emailValue;
        private Button createMemberButton;
        private ListBox teamMembersListBox;
        private Button deleteSelectedMemberButton;
        private Button createTeamButton;
    }
}