﻿namespace EFT_Launcher_12
{
    partial class MainWindow
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
            this.startButton = new System.Windows.Forms.Button();
            this.profilesListBox = new System.Windows.Forms.ComboBox();
            this.gamePathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.profileEditButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.Control;
            this.startButton.Location = new System.Drawing.Point(461, 132);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(158, 49);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // profilesListBox
            // 
            this.profilesListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.profilesListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.profilesListBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profilesListBox.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilesListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.profilesListBox.FormattingEnabled = true;
            this.profilesListBox.Items.AddRange(new object[] {
            "Select a Profile !"});
            this.profilesListBox.Location = new System.Drawing.Point(461, 13);
            this.profilesListBox.Name = "profilesListBox";
            this.profilesListBox.Size = new System.Drawing.Size(160, 26);
            this.profilesListBox.TabIndex = 1;
            this.profilesListBox.SelectedIndexChanged += new System.EventHandler(this.profilesListBox_SelectedIndexChanged);
            // 
            // gamePathTextBox
            // 
            this.gamePathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.gamePathTextBox.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamePathTextBox.ForeColor = System.Drawing.Color.White;
            this.gamePathTextBox.Location = new System.Drawing.Point(185, 155);
            this.gamePathTextBox.Name = "gamePathTextBox";
            this.gamePathTextBox.Size = new System.Drawing.Size(270, 26);
            this.gamePathTextBox.TabIndex = 2;
            this.gamePathTextBox.TextChanged += new System.EventHandler(this.gamePathTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Specifiy Game Location ->";
            // 
            // profileEditButton
            // 
            this.profileEditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.profileEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileEditButton.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileEditButton.ForeColor = System.Drawing.SystemColors.Control;
            this.profileEditButton.Location = new System.Drawing.Point(461, 45);
            this.profileEditButton.Name = "profileEditButton";
            this.profileEditButton.Size = new System.Drawing.Size(158, 26);
            this.profileEditButton.TabIndex = 6;
            this.profileEditButton.Text = "Edit Profile";
            this.profileEditButton.UseVisualStyleBackColor = false;
            this.profileEditButton.Click += new System.EventHandler(this.profileEditButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(630, 194);
            this.Controls.Add(this.profileEditButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gamePathTextBox);
            this.Controls.Add(this.profilesListBox);
            this.Controls.Add(this.startButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainWindow";
            this.Text = "EmuTarkov Launcher";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ComboBox profilesListBox;
        private System.Windows.Forms.TextBox gamePathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button profileEditButton;
    }
}
