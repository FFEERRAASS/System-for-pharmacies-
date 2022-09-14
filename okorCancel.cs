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
    public partial class okorCancel : MetroFramework.Forms.MetroForm
    {
        public okorCancel()
        {
            InitializeComponent();
        }

        private void okorCancel_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            prescription pro = new prescription();
            this.Hide();
            pro.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Electronic_Payment_Gateway eel = new Electronic_Payment_Gateway();
            this.Hide();
            eel.ShowDialog();
        }
    }
}
