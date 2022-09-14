using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacyEnd
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblUSERNAME_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txtPassword.Focus();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnLogin.PerformClick();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text) || String.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Please enter E-mail or Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            try
            {
                dbtestDataSetTableAdapters.UsersTableAdapter user = new dbtestDataSetTableAdapters.UsersTableAdapter();
                dbtestDataSet.UsersDataTable dt = user.GetDataByUsernamePassword(txtUsername.Text, txtPassword.Text);
                if(dt.Rows.Count > 0)
                {
                    MessageBox.Show("You are logged in successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    first f1 = new first();
                    this.Hide();
                    f1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("There is an error in the username or password", "Message",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact customer support");
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact via the following email : F.information.t@gamil.com ");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program is developed by student Firas and student Walid, under the auspices of Dr. Rami Al-Malkawi.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    txtPassword.UseSystemPasswordChar = false;
                }
                else
                {
                    txtPassword.UseSystemPasswordChar = true;
                }
                i++;
            }
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A program that shows you the types of medicines, their classification and general information about them");
        }
    }
}
