﻿namespace COMP1004_MidTerm_200264388
{
    partial class RaceForm
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
            this.CharacterPictureBox = new System.Windows.Forms.PictureBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.RacialBonusLabel = new System.Windows.Forms.Label();
            this.RacialBonusTextBox = new System.Windows.Forms.TextBox();
            this.raceGroupBox = new System.Windows.Forms.GroupBox();
            this.halflingRadioButton = new System.Windows.Forms.RadioButton();
            this.elfRadioButton = new System.Windows.Forms.RadioButton();
            this.dwarfRadioButton = new System.Windows.Forms.RadioButton();
            this.humanRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterPictureBox)).BeginInit();
            this.raceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CharacterPictureBox
            // 
            this.CharacterPictureBox.Location = new System.Drawing.Point(335, 84);
            this.CharacterPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.CharacterPictureBox.Name = "CharacterPictureBox";
            this.CharacterPictureBox.Size = new System.Drawing.Size(290, 262);
            this.CharacterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CharacterPictureBox.TabIndex = 5;
            this.CharacterPictureBox.TabStop = false;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(525, 465);
            this.NextButton.Margin = new System.Windows.Forms.Padding(4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(100, 28);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // RacialBonusLabel
            // 
            this.RacialBonusLabel.AutoSize = true;
            this.RacialBonusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RacialBonusLabel.Location = new System.Drawing.Point(12, 358);
            this.RacialBonusLabel.Name = "RacialBonusLabel";
            this.RacialBonusLabel.Size = new System.Drawing.Size(166, 29);
            this.RacialBonusLabel.TabIndex = 6;
            this.RacialBonusLabel.Text = "Racial Bonus";
            // 
            // RacialBonusTextBox
            // 
            this.RacialBonusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RacialBonusTextBox.Location = new System.Drawing.Point(11, 390);
            this.RacialBonusTextBox.Multiline = true;
            this.RacialBonusTextBox.Name = "RacialBonusTextBox";
            this.RacialBonusTextBox.Size = new System.Drawing.Size(613, 58);
            this.RacialBonusTextBox.TabIndex = 7;
            // 
            // raceGroupBox
            // 
            this.raceGroupBox.Controls.Add(this.halflingRadioButton);
            this.raceGroupBox.Controls.Add(this.elfRadioButton);
            this.raceGroupBox.Controls.Add(this.dwarfRadioButton);
            this.raceGroupBox.Controls.Add(this.humanRadioButton);
            this.raceGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceGroupBox.Location = new System.Drawing.Point(11, 84);
            this.raceGroupBox.Name = "raceGroupBox";
            this.raceGroupBox.Size = new System.Drawing.Size(220, 262);
            this.raceGroupBox.TabIndex = 8;
            this.raceGroupBox.TabStop = false;
            this.raceGroupBox.Text = "Race";
            // 
            // halflingRadioButton
            // 
            this.halflingRadioButton.AutoSize = true;
            this.halflingRadioButton.Location = new System.Drawing.Point(19, 215);
            this.halflingRadioButton.Name = "halflingRadioButton";
            this.halflingRadioButton.Size = new System.Drawing.Size(119, 33);
            this.halflingRadioButton.TabIndex = 3;
            this.halflingRadioButton.TabStop = true;
            this.halflingRadioButton.Text = "Halfling";
            this.halflingRadioButton.UseVisualStyleBackColor = true;
            this.halflingRadioButton.CheckedChanged += new System.EventHandler(this.halflingRadioButton_CheckedChanged);
            // 
            // elfRadioButton
            // 
            this.elfRadioButton.AutoSize = true;
            this.elfRadioButton.Location = new System.Drawing.Point(19, 163);
            this.elfRadioButton.Name = "elfRadioButton";
            this.elfRadioButton.Size = new System.Drawing.Size(66, 33);
            this.elfRadioButton.TabIndex = 2;
            this.elfRadioButton.TabStop = true;
            this.elfRadioButton.Text = "Elf";
            this.elfRadioButton.UseVisualStyleBackColor = true;
            this.elfRadioButton.CheckedChanged += new System.EventHandler(this.elfRadioButton_CheckedChanged);
            // 
            // dwarfRadioButton
            // 
            this.dwarfRadioButton.AutoSize = true;
            this.dwarfRadioButton.Location = new System.Drawing.Point(19, 101);
            this.dwarfRadioButton.Name = "dwarfRadioButton";
            this.dwarfRadioButton.Size = new System.Drawing.Size(100, 33);
            this.dwarfRadioButton.TabIndex = 1;
            this.dwarfRadioButton.TabStop = true;
            this.dwarfRadioButton.Text = "Dwarf";
            this.dwarfRadioButton.UseVisualStyleBackColor = true;
            this.dwarfRadioButton.CheckedChanged += new System.EventHandler(this.dwarfRadioButton_CheckedChanged);
            // 
            // humanRadioButton
            // 
            this.humanRadioButton.AutoSize = true;
            this.humanRadioButton.Location = new System.Drawing.Point(19, 45);
            this.humanRadioButton.Name = "humanRadioButton";
            this.humanRadioButton.Size = new System.Drawing.Size(114, 33);
            this.humanRadioButton.TabIndex = 0;
            this.humanRadioButton.TabStop = true;
            this.humanRadioButton.Text = "Human";
            this.humanRadioButton.UseVisualStyleBackColor = true;
            this.humanRadioButton.CheckedChanged += new System.EventHandler(this.humanRadioButton_CheckedChanged);
            // 
            // RaceForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(641, 508);
            this.Controls.Add(this.raceGroupBox);
            this.Controls.Add(this.RacialBonusTextBox);
            this.Controls.Add(this.RacialBonusLabel);
            this.Controls.Add(this.CharacterPictureBox);
            this.Controls.Add(this.NextButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "RaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Character Race";
            ((System.ComponentModel.ISupportInitialize)(this.CharacterPictureBox)).EndInit();
            this.raceGroupBox.ResumeLayout(false);
            this.raceGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox CharacterPictureBox;
        internal System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label RacialBonusLabel;
        private System.Windows.Forms.TextBox RacialBonusTextBox;
        private System.Windows.Forms.GroupBox raceGroupBox;
        private System.Windows.Forms.RadioButton halflingRadioButton;
        private System.Windows.Forms.RadioButton elfRadioButton;
        private System.Windows.Forms.RadioButton dwarfRadioButton;
        private System.Windows.Forms.RadioButton humanRadioButton;
    }
}