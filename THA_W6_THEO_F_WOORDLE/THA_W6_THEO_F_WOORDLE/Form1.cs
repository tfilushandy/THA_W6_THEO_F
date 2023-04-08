using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace THA_W6_THEO_F_WOORDLE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            Form2.input = Convert.ToInt32(txtinput.Text);
            if(Form2.input <= 3)
            {
                MessageBox.Show("Nyawa harus lebih dari 3","ERORRR");
            }
            else
            {
                Form2 baru = new Form2();
                baru.Show();
            }
        }

        private void txtinput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtinput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
