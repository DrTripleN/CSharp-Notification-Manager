using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _301231884_Needham__Lab2
{
    public partial class Form2 : Form
    {
        int emailkey = 1;
        int smskey = 1;

        Dictionary<String, int> emailSubs = new Dictionary<String, int>();
        Dictionary<String, int> smsSubs = new Dictionary<String, int>();
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          notifLabel.Text = string.Empty;
          smsLabel.Text = string.Empty;   
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                bool IsValid = Subscriptions.IsValidEmail(textBox1.Text);

                if (IsValid)
                {
                    string emailAddress = textBox1.Text.ToLower();

                    if (emailSubs.ContainsKey(emailAddress))
                    {
                        notifLabel.Text = "Email Account has been unsubscribed";
                        notifLabel.ForeColor = Color.Green;
                        emailSubs.Remove(emailAddress);
                        emailkey--;
                        Console.WriteLine("Email unsubcribed:"+textBox1.Text);
                    }
                    else
                    {

                        notifLabel.Text = "Email Account Not Found";
                        notifLabel.ForeColor = Color.Red;
                      
                        foreach (var email in emailSubs)
                        {
                            Console.WriteLine($"{email.Key},{email.Value}");
                        }
                    }
                }
                else
                {
                    notifLabel.Text = "Invalid Email";
                    notifLabel.ForeColor = Color.Red;
                }
            }
            else if (checkBox2.Checked)
            {
                bool IsNumValid = Subscriptions.IsPhoneNumber(textBox2.Text);

                if (IsNumValid)
                {
                    string numbers = textBox2.Text;

                    if (smsSubs.ContainsKey(numbers))
                    {
                        smsLabel.Text = "Number has been unsubscribed";
                        smsLabel.ForeColor = Color.Green;
                        smsSubs.Remove(numbers);
                        smskey--;
                        Console.WriteLine("number unsubscribed:"+textBox2.Text);
                    }
                    else
                    {


                        smsLabel.Text = "Number Not Found";
                        smsLabel.ForeColor = Color.Red;
                       
                        foreach (var sms in smsSubs)
                        {
                            Console.WriteLine($"{sms.Key},{sms.Value}");
                        }
                    }
                }
                else
                {
                    smsLabel.Text = "Invalid Number";
                    smsLabel.ForeColor = Color.Red;
                }
            }
        }
        
      
        public void button1_Click(object sender, EventArgs e)
        {
       
            if (checkBox1.Checked)
            {
                bool IsValid = Subscriptions.IsValidEmail(textBox1.Text);

                if (IsValid)
                {
                    string emailAddress = textBox1.Text.ToLower();

                    if (emailSubs.ContainsKey(emailAddress))
                    {
                        notifLabel.Text = "Email Account has already been subscribed";
                        notifLabel.ForeColor = Color.Red;
                        Console.WriteLine("Email already created");
                    }
                    else
                    {
                        

                        // Add the new email to the dictionary
                        emailSubs[emailAddress] =emailkey ;

                        notifLabel.Text = "Email Account Subscribed";
                        notifLabel.ForeColor = Color.Lime;
                        emailkey++;
                        foreach(var email in emailSubs)
                        {
                            Console.WriteLine($"{email.Key},{email.Value}");
                        }
                    }
                }
                else
                {
                    notifLabel.Text = "Invalid Email";
                    notifLabel.ForeColor = Color.Red;
                }
            }else if (checkBox2.Checked)
            {
                bool IsNumValid = Subscriptions.IsPhoneNumber(textBox2.Text);

                if (IsNumValid)
                {
                    string numbers= textBox2.Text;

                    if (smsSubs.ContainsKey(numbers))
                    {
                        smsLabel.Text = "Number has already been subscribed";
                        smsLabel.ForeColor = Color.Red;
                        Console.WriteLine("number already subscribed");
                    }
                    else
                    {


                        // Add the new number to the dictionary
                        smsSubs[numbers] = smskey;

                        smsLabel.Text = "Number Subscribed";
                        smsLabel.ForeColor = Color.Lime;
                        smskey++;
                        foreach (var sms in smsSubs)
                        {
                            Console.WriteLine($"{sms.Key},{sms.Value}");
                        }
                    }
                }
                else
                {
                    smsLabel.Text = "Invalid Number";
                    smsLabel.ForeColor = Color.Red;
                }
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                textBox2.Enabled= false;
                notifLabel.Text = string.Empty;
                smsLabel.Text = string.Empty;
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
            }
            else
            {
                textBox2.Enabled = true;
            }
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true) 
            {

                checkBox1.Checked = false;
                textBox1.Enabled = false;
                notifLabel.Text = string.Empty;
                smsLabel.Text = string.Empty;
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;   
            }
            else
            {
                
                textBox1.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1(emailSubs, smsSubs);
            f1.Show();
        }

        private void notifLabel_Click(object sender, EventArgs e)
        {

        }

        private void smsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
