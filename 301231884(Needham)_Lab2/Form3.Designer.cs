namespace _301231884_Needham__Lab2
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.publishNotifButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.notifTextBox = new System.Windows.Forms.TextBox();
            this.notifLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // publishNotifButton
            // 
            this.publishNotifButton.Location = new System.Drawing.Point(74, 114);
            this.publishNotifButton.Name = "publishNotifButton";
            this.publishNotifButton.Size = new System.Drawing.Size(127, 43);
            this.publishNotifButton.TabIndex = 0;
            this.publishNotifButton.Text = "Publish";
            this.publishNotifButton.UseVisualStyleBackColor = true;
            this.publishNotifButton.Click += new System.EventHandler(this.publishNotifButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(269, 114);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(127, 43);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Notification Content";
            // 
            // notifTextBox
            // 
            this.notifTextBox.Location = new System.Drawing.Point(169, 52);
            this.notifTextBox.Name = "notifTextBox";
            this.notifTextBox.Size = new System.Drawing.Size(259, 22);
            this.notifTextBox.TabIndex = 5;
            // 
            // notifLabel
            // 
            this.notifLabel.AutoSize = true;
            this.notifLabel.Location = new System.Drawing.Point(156, 81);
            this.notifLabel.Name = "notifLabel";
            this.notifLabel.Size = new System.Drawing.Size(44, 16);
            this.notifLabel.TabIndex = 6;
            this.notifLabel.Text = "label2";
            this.notifLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 198);
            this.Controls.Add(this.notifLabel);
            this.Controls.Add(this.notifTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.publishNotifButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Publish Notification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button publishNotifButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox notifTextBox;
        private System.Windows.Forms.Label notifLabel;
    }
}