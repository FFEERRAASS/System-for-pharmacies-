using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace pharmacyEnd
{
    public partial class numbersHos : MetroFramework.Forms.MetroForm
    {
        public numbersHos()
        {
            InitializeComponent();
        }

        private void numbersHos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            first first = new first();
            this.Hide();
            first.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.google.com/maps/dir/31.9684608,35.9530496/%D8%A7%D9%84%D9%85%D8%B3%D8%AA%D8%B4%D9%81%D9%89+%D8%A7%D9%84%D8%AA%D8%AE%D8%B5%D8%B5%D9%8A%E2%80%AD%E2%80%AD/@32.2539684,36.3289961,10z/data=!3m1!4b1!4m9!4m8!1m1!4e1!1m5!1m1!1s0x151c76f239ac97a1:0x2efa0d63c5fff59a!2m2!1d35.8626834!2d32.5337897");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.google.com/maps/dir//%D9%85%D8%B3%D8%AA%D8%B4%D9%81%D9%89+%D8%A7%D9%84%D8%A5%D8%B3%D8%AA%D9%82%D9%84%D8%A7%D9%84%D8%8C+Istiklal+Hospital+Al%D8%8C+%D8%B4.+%D8%A7%D9%84%D8%A5%D8%B3%D8%AA%D9%82%D9%84%D8%A7%D9%84+55%D8%8C+%D8%B9%D9%85%D9%91%D8%A7%D9%86%E2%80%AD/data=!4m6!4m5!1m1!4e2!1m2!1m1!1s0x151b5ff86e710e5d:0xaa431737945ddf56?sa=X&ved=2ahUKEwiXtMTexeT3AhV4Q_EDHYZiCAgQ48ADegQIAhAW");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.google.com/maps/dir/31.9684608,35.9530496/%D8%A7%D9%84%D9%85%D8%AF%D9%8A%D9%86%D8%A9+%D8%A7%D9%84%D8%B7%D8%A8%D9%8A%D8%A9%E2%80%AD%E2%80%AD/@31.9800608,35.9621824,12z/data=!3m1!4b1!4m9!4m8!1m1!4e1!1m5!1m1!1s0x151ca18478d5b787:0x8ad1ef97aa7fce54!2m2!1d35.8312349!2d31.9789827");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.google.com/maps/dir//%D9%85%D8%B3%D8%AA%D8%B4%D9%81%D9%89+%D8%A7%D9%84%D8%AC%D8%A7%D9%85%D8%B9%D8%A9%E2%80%AD/data=!4m6!4m5!1m1!4e2!1m2!1m1!1s0x151c9f85fac773a3:0x6cd6460a4547306f?sa=X&ved=2ahUKEwiH3YKGxuT3AhVvQvEDHa9qCT4Q9Rd6BAhfEAU");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.google.com/maps/dir//%D8%B5%D9%8A%D8%AF%D9%84%D9%8A%D8%A9+%D8%A7%D9%84%D8%B1%D8%A7%D8%B2%D9%8A+%D8%A7%D9%84%D9%81%D8%B1%D8%B9+%D8%A7%D9%84%D8%B1%D8%A6%D9%8A%D8%B3%D9%8A%D8%8C+%D8%B4.+%D8%A7%D9%84%D9%87%D8%A7%D8%B4%D9%85%D9%8A%D8%8C+%D8%A5%D8%B1%D8%A8%D8%AF%E2%80%AD/data=!4m6!4m5!1m1!4e2!1m2!1m1!1s0x151c769f2198ad29:0x3e65457f78edbcea?sa=X&ved=2ahUKEwi00emdxuT3AhVQQ_EDHZy0BeEQ48ADegQIBRAL");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.google.com/maps/dir//GVJ2%2BPRP+%D8%B5%D9%8A%D8%AF%D9%84%D9%8A%D8%A9+%D9%81%D8%A7%D8%B1%D9%85%D8%B3%D9%8A+%D9%88%D9%86%D8%8C+%D8%A5%D8%B1%D8%A8%D8%AF%E2%80%AD/data=!4m6!4m5!1m1!4e2!1m2!1m1!1s0x151c76e87af26635:0xa70a3eb51b95de45?sa=X&ved=2ahUKEwjD0J-uxuT3AhU5SvEDHZmlDO4Q48ADegQIBhAL");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.google.com/maps/dir//dawacom+pharmacy/data=!4m6!4m5!1m1!4e2!1m2!1m1!1s0x151b5ffaacb64a5d:0x19300f32f5f47447?sa=X&ved=2ahUKEwjOtcfDxuT3AhUuRfEDHeZRBacQ9Rd6BAg1EAM");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.google.com/maps/dir//%D8%A7%D9%84%D8%B5%D9%8A%D8%AF%D9%84%D9%8A%D8%A9+%D8%A7%D9%84%D8%AD%D8%AF%D9%8A%D8%AB%D8%A9%D8%8C+%D8%A5%D8%B1%D8%A8%D8%AF%E2%80%AD/data=!4m6!4m5!1m1!4e2!1m2!1m1!1s0x151c7698be1cefad:0xe4005d51ee249286?sa=X&ved=2ahUKEwipj4DSxuT3AhU5SfEDHVa7Cw0Q48ADegQIAxAL");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
