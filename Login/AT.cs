using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class AT : Form
    {
        public AT()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnmaxim_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Maximized;
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.TxtDmaj.Text))
            {
                MessageBox.Show("Digite la diagonal mayor", "Notificación");
                this.TxtDmaj.Focus();
            }
            else
            {
                if (String.IsNullOrEmpty(this.TxtDmin.Text))

                {
                    MessageBox.Show("Digite la diagonal menor", "Notificación");
                    this.TxtDmin.Focus();
                }

                else
                {
                    this.TxtArea.Text = ((Convert.ToDecimal(this.TxtDmaj.Text) * Convert.ToDecimal(this.TxtDmin.Text)) / 2).ToString();
                }


            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            this.TxtDmaj.Text = String.Empty;
            this.TxtDmin.Text = String.Empty;
            this.TxtArea.Text = String.Empty;

            this.TxtDmaj.Focus();
        }

        private void Btnlimpiar_Click_1(object sender, EventArgs e)
        {
            this.TxtDmaj.Text = String.Empty;
            this.TxtDmin.Text = String.Empty;
            this.TxtArea.Text = String.Empty;

            this.TxtDmaj.Focus();
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtDmaj_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
            // Esta línea de código controla que no se pongan letras.
        }

        private void TxtDmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
            // Esta línea de código controla que no se pongan letras.
        }
    }
}
