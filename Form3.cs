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
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phDataSet.emp' table. You can move, or remove it, as needed.
            this.empTableAdapter.Fill(this.phDataSet.emp);
            // TODO: This line of code loads data into the 'database11DataSet.emplo' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the '_EmployeesC_1DataSet.Employee' table. You can move, or remove it, as needed.


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.empTableAdapter.Update(this.phDataSet.emp);
            MessageBox.Show("DATA UPDATE IS SUCCESSFUL");        }
    }
}
