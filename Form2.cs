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
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 fer = new Form3();
            this.Hide();
            fer.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 fera = new Form4();
            this.Hide();
            fera.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            first fers = new first();
            this.Hide();
            fers.ShowDialog();
        }
    }
}
