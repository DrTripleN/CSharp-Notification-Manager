using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _301231884_Needham__Lab2
{
    public partial class Form3 : Form
    {
        private NotificationManager notificationManager;
        public Form3()
        {
            InitializeComponent();
            InitializeNotificationManager();
            notifLabel.Text = string.Empty; 
        }
        
        private void InitializeNotificationManager()
        {
            notificationManager = new NotificationManager();
            notificationManager.NotificationPublished += OnNotificationPublished;
        }

        private void OnNotificationPublished(string message)
        {
            // Handle the notification (e.g., display it in a label)
            notifLabel.Text = message;
            notifLabel.ForeColor = Color.Chocolate;
            notifLabel.Text.ToUpper();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void publishNotifButton_Click(object sender, EventArgs e)
        {

            // Get the notification message from user input or other source
            string message = notifTextBox.Text;

            // Publish the notification
            notificationManager.PublishNotification(message);
            Console.WriteLine(message);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
