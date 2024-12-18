﻿namespace TrackerUI
{
    partial class CreatePrizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeForm));
            createPrize = new Label();
            placeNumberLabel = new Label();
            placeNumberValue = new TextBox();
            prizeAmountLabel = new Label();
            prizeAmountValue = new TextBox();
            placeNameLabel = new Label();
            placeNameValue = new TextBox();
            prizePercentageLabel = new Label();
            prizePercentageValue = new TextBox();
            orLabel = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // createPrize
            // 
            createPrize.AutoSize = true;
            createPrize.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createPrize.ForeColor = Color.SeaGreen;
            createPrize.Location = new Point(12, 9);
            createPrize.Name = "createPrize";
            createPrize.Size = new Size(189, 45);
            createPrize.TabIndex = 11;
            createPrize.Text = "Create Prize";
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            placeNumberLabel.ForeColor = Color.DarkSlateBlue;
            placeNumberLabel.Location = new Point(24, 74);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(131, 25);
            placeNumberLabel.TabIndex = 17;
            placeNumberLabel.Text = "Place Number";
            // 
            // placeNumberValue
            // 
            placeNumberValue.BorderStyle = BorderStyle.FixedSingle;
            placeNumberValue.Location = new Point(183, 74);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(154, 23);
            placeNumberValue.TabIndex = 16;
            placeNumberValue.TextChanged += firstNameValue_TextChanged;
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prizeAmountLabel.ForeColor = Color.DarkSlateBlue;
            prizeAmountLabel.ImageAlign = ContentAlignment.BottomLeft;
            prizeAmountLabel.Location = new Point(24, 170);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(126, 25);
            prizeAmountLabel.TabIndex = 19;
            prizeAmountLabel.Text = "Prize Amount";
            prizeAmountLabel.Click += prizeValueLabel_Click;
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.BorderStyle = BorderStyle.FixedSingle;
            prizeAmountValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prizeAmountValue.Location = new Point(183, 170);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(154, 27);
            prizeAmountValue.TabIndex = 18;
            prizeAmountValue.Text = "0";
            prizeAmountValue.TextChanged += prizeAmountValue_TextChanged;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            placeNameLabel.ForeColor = Color.DarkSlateBlue;
            placeNameLabel.Location = new Point(24, 122);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(112, 25);
            placeNameLabel.TabIndex = 21;
            placeNameLabel.Text = "Place Name";
            placeNameLabel.Click += placeNameLabel_Click;
            // 
            // placeNameValue
            // 
            placeNameValue.BorderStyle = BorderStyle.FixedSingle;
            placeNameValue.Location = new Point(183, 122);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(154, 23);
            placeNameValue.TabIndex = 20;
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prizePercentageLabel.ForeColor = Color.DarkSlateBlue;
            prizePercentageLabel.Location = new Point(24, 247);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(153, 25);
            prizePercentageLabel.TabIndex = 23;
            prizePercentageLabel.Text = "Prize Percentage";
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.BorderStyle = BorderStyle.FixedSingle;
            prizePercentageValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prizePercentageValue.Location = new Point(183, 247);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(154, 27);
            prizePercentageValue.TabIndex = 22;
            prizePercentageValue.Text = "0";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orLabel.ForeColor = Color.DarkSlateBlue;
            orLabel.Location = new Point(151, 207);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(46, 25);
            orLabel.TabIndex = 25;
            orLabel.Text = "-or-";
            // 
            // createPrizeButton
            // 
            createPrizeButton.ForeColor = Color.DarkSlateBlue;
            createPrizeButton.Location = new Point(101, 310);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(154, 42);
            createPrizeButton.TabIndex = 27;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(356, 389);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(prizePercentageLabel);
            Controls.Add(prizePercentageValue);
            Controls.Add(placeNameLabel);
            Controls.Add(placeNameValue);
            Controls.Add(prizeAmountLabel);
            Controls.Add(prizeAmountValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(createPrize);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createPrize;
        private Label placeNumberLabel;
        private TextBox placeNumberValue;
        private Label prizeAmountLabel;
        private TextBox prizeAmountValue;
        private Label placeNameLabel;
        private TextBox placeNameValue;
        private Label prizePercentageLabel;
        private TextBox prizePercentageValue;
        private Label orLabel;
        private Button createPrizeButton;
    }
}