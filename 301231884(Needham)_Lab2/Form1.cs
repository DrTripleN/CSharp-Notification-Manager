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
    public partial class Form1 : Form
    {
        private Dictionary<string, int> emailSubs;
        private Dictionary<string, int> smsSubs;
        public Form1(Dictionary<string, int> emailSubs, Dictionary<string, int> smsSubs)
        {
            InitializeComponent();
            this.emailSubs = emailSubs;
            this.smsSubs = smsSubs;
            UpdatePublishButtonState();
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UpdatePublishButtonState()
        {
            publishNotifButton.Enabled = (emailSubs.Count > 0 || smsSubs.Count > 0);
        }

        private void manageSubButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void publishNotifButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
