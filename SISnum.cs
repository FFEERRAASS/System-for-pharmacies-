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
    public partial class SISnum : MetroFramework.Forms.MetroForm
    {
        public SISnum()
        {
            InitializeComponent();
        }

        private void SISnum_Load(object sender, EventArgs e)
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

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hot line : 6340012");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hot line : 6345912");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hot line : 9340012");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hot line : 6346122");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hot line : +9627891234567");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hot line : +9627791234567");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hot line : +9627771234567");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hot line : +9627791234567");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
