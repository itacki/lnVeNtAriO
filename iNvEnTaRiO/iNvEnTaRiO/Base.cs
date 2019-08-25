using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuNcIoNeSPY;

namespace iNvEnTaRiO
{
    public partial class Base : Form
    {

        int posX = 0;
        int posY = 0;
        funciones Herramientas = new funciones();
        public Base()
        {
            InitializeComponent();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Base_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                this.Left = this.Left + (e.X - posX); this.Top = this.Top + (e.Y - posY);
            }
        }
        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            
        }
        private void Maximo_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Maximo.Visible = false;
            Regreso.Visible = true;
        }
        private void Regreso_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Maximo.Visible = true;
            Regreso.Visible = false;
        }
    }
}
