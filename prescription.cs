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
    public partial class prescription : MetroFramework.Forms.MetroForm
    {
        public prescription()
        {
            InitializeComponent();
        }

        private void prescription_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            first first = new first();
            this.Hide();
            first.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            okorCancel okey = new okorCancel();
            this.Hide();
            okey.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            okorCancel okey = new okorCancel();
            this.Hide();
            okey.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            okorCancel okey = new okorCancel();
            this.Hide();
            okey.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            okorCancel okey = new okorCancel();
            this.Hide();
            okey.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            okorCancel okey = new okorCancel();
            this.Hide();
            okey.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            okorCancel okey = new okorCancel();
            this.Hide();
            okey.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            okorCancel okey = new okorCancel();
            this.Hide();
            okey.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            okorCancel okey = new okorCancel();
            this.Hide();
            okey.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
