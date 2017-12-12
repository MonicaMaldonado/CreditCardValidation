using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidationCredictCard
{
    public partial class TarjetaCredito : Form
    {
        public TarjetaCredito()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validacion validar = new Validacion();
            if (validar.validar(textBox1.ToString()))
                MessageBox.Show("Credit Card " + textBox1.Text + " is valid.", "Information", MessageBoxButtons.OK, MessageBoxIcon.None);
            else
                MessageBox.Show("Credit Card " + textBox1.Text + " is not valid.", "Information", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
