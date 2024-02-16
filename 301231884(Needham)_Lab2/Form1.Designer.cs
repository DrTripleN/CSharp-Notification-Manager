namespace _301231884_Needham__Lab2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.manageSubButton = new System.Windows.Forms.Button();
            this.publishNotifButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manageSubButton
            // 
            this.manageSubButton.Location = new System.Drawing.Point(58, 62);
            this.manageSubButton.Name = "manageSubButton";
            this.manageSubButton.Size = new System.Drawing.Size(127, 43);
            this.manageSubButton.TabIndex = 0;
            this.manageSubButton.Text = "Manage Subscription";
            this.manageSubButton.UseVisualStyleBackColor = true;
            this.manageSubButton.Click += new System.EventHandler(this.manageSubButton_Click);
            // 
            // publishNotifButton
            // 
            this.publishNotifButton.Location = new System.Drawing.Point(217, 62);
            this.publishNotifButton.Name = "publishNotifButton";
            this.publishNotifButton.Size = new System.Drawing.Size(127, 43);
            this.publishNotifButton.TabIndex = 1;
            this.publishNotifButton.Text = "Publish Notifications";
            this.publishNotifButton.UseVisualStyleBackColor = true;
            this.publishNotifButton.Click += new System.EventHandler(this.publishNotifButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(376, 62);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(127, 43);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 163);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.publishNotifButton);
            this.Controls.Add(this.manageSubButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Notification Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manageSubButton;
        private System.Windows.Forms.Button publishNotifButton;
        private System.Windows.Forms.Button exitButton;
    }
}

