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
    public partial class Form4 : MetroFramework.Forms.MetroForm
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'workTimeDataSet.time' table. You can move, or remove it, as needed.
            this.timeTableAdapter.Fill(this.workTimeDataSet.time);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timeTableAdapter.Update(this.workTimeDataSet.time);
            MessageBox.Show("DATA UPDATE DONE");
        }
    }
}
