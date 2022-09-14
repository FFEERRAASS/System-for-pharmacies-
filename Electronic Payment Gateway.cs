using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechLib;

namespace pharmacyEnd
{
    public partial class Electronic_Payment_Gateway : MetroFramework.Forms.MetroForm
    {
        public Electronic_Payment_Gateway()
        {
            InitializeComponent();
        }

        private void Electronic_Payment_Gateway_Load(object sender, EventArgs e)
        {
            
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Substring(0, 4) == "4444" || (textBox1.Text.Substring(0, 4) == "5555") || (textBox1.Text.Substring(0, 4) == "6666"))
                {
                MessageBox.Show("You are using a Visa card, continue the process");
                }
            else if (textBox1.Text.Substring(0, 4) == "2222" || (textBox1.Text.Substring(0, 4) == "3333") || (textBox1.Text.Substring(0, 4) == "7777"))
            {
                MessageBox.Show("You are using a Mastercard, continue the process");
            }
            else
            {
                MessageBox.Show("Check the card number");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            SpVoice read = new SpVoice();
            read.Speak("CARD NUMBER" + textBox1.Text,SpeechVoiceSpeakFlags.SVSFDefault);
            read.Speak("CVV" + textBox2.Text, SpeechVoiceSpeakFlags.SVSFDefault);
            read.Speak("Full name" + textBox3.Text, SpeechVoiceSpeakFlags.SVSFDefault);
            var xy = MessageBox.Show("Card Number : " + textBox1.Text + ", CVV : " + textBox2.Text + ", Expiry date : " 
                + dateTimePicker1.Text + ", Full name : " + textBox3.Text + "\n"
                + "The card has been debited, the product will be delivered to you as soon as possible");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            first ff = new first();
            this.Hide();
            ff.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            canRate rere = new canRate();
            this.Hide();
            rere.ShowDialog();
        }
    }
}
