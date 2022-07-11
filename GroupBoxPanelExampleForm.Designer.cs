
namespace GroupBoxPanelExample
{
    partial class GroupBoxPanelExampleForm
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
            this.messageLabel = new System.Windows.Forms.Label();
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.hiButton = new System.Windows.Forms.Button();
            this.byeButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.mainGroupBox.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.messageLabel.Location = new System.Drawing.Point(231, 388);
            this.messageLabel.MaximumSize = new System.Drawing.Size(314, 23);
            this.messageLabel.MinimumSize = new System.Drawing.Size(314, 23);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(314, 23);
            this.messageLabel.TabIndex = 0;
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.Controls.Add(this.byeButton);
            this.mainGroupBox.Controls.Add(this.hiButton);
            this.mainGroupBox.Location = new System.Drawing.Point(231, 89);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Size = new System.Drawing.Size(314, 100);
            this.mainGroupBox.TabIndex = 1;
            this.mainGroupBox.TabStop = false;
            this.mainGroupBox.Text = "Main GroupBox";
            // 
            // hiButton
            // 
            this.hiButton.Location = new System.Drawing.Point(36, 41);
            this.hiButton.Name = "hiButton";
            this.hiButton.Size = new System.Drawing.Size(75, 23);
            this.hiButton.TabIndex = 0;
            this.hiButton.Text = "Hi";
            this.hiButton.UseVisualStyleBackColor = true;
            this.hiButton.Click += new System.EventHandler(this.hiButton_Click);
            // 
            // byeButton
            // 
            this.byeButton.Location = new System.Drawing.Point(191, 41);
            this.byeButton.Name = "byeButton";
            this.byeButton.Size = new System.Drawing.Size(75, 23);
            this.byeButton.TabIndex = 1;
            this.byeButton.Text = "Bye";
            this.byeButton.UseVisualStyleBackColor = true;
            this.hiButton.Click += new System.EventHandler(this.byeButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Controls.Add(this.rightButton);
            this.mainPanel.Controls.Add(this.leftButton);
            this.mainPanel.Location = new System.Drawing.Point(231, 254);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(314, 100);
            this.mainPanel.TabIndex = 2;
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(36, 34);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(75, 23);
            this.leftButton.TabIndex = 0;
            this.leftButton.Text = "Far Left";
            this.leftButton.UseVisualStyleBackColor = true;
            this.hiButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(190, 34);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(75, 23);
            this.rightButton.TabIndex = 1;
            this.rightButton.Text = "Far Right";
            this.rightButton.UseVisualStyleBackColor = true;
            this.hiButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.mainGroupBox);
            this.Controls.Add(this.messageLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainGroupBox.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.Button byeButton;
        private System.Windows.Forms.Button hiButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button leftButton;
    }
}

