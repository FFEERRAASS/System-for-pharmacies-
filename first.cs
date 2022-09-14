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
    public partial class first : MetroFramework.Forms.MetroForm
    {
        public first()
        {
            InitializeComponent();
        }

        private void first_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            
        }
        


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            firstAid firstAid = new firstAid();
            this.Hide();
            firstAid.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
           without without =new without();
            this.Hide();
            without.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            prescription prescription = new prescription();
            this.Hide();
            prescription.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            medicalneedles medicalneedles = new medicalneedles();
            this.Hide();
            medicalneedles.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numbersHos numbersHos = new numbersHos();
            this.Hide();
            numbersHos.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SISnum sISnum = new SISnum();
            this.Hide();
            sISnum.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            barcodeScanning barcodeScanning   = new barcodeScanning();
            this.Hide();
            barcodeScanning.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hair hair = new hair();
            this.Hide();
            hair.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("E-mail : F.information.T@gmail.com ");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Call Now : +962770755853 ");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            canRate rere = new canRate();
            this.Hide();
            rere.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 feras = new Form2();
            this.Hide();
            feras.ShowDialog();
        }
    }
}
