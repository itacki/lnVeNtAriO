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
            PanelVisual.DataSource = funciones.ejecutable("select Principal.ID,Tipo.TipoNobre,Marca.MarcaNombre,Principal.Serial,Principal.Estado,Principal.Detalles,Principal.Ubicacion from Principal inner join Marca on   Marca.MarcaID = Principal.Marca inner join Tipo on Tipo.TipoID = Principal.Tipo inner join Ubicacion on Ubicacion.UbicacionID = Principal.Ubicacion");
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
        private void Consultar_Click(object sender, EventArgs e)
        {
            try
            {
                PanelVisual.DataSource = funciones.ejecutable("select * from " + Buscador.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Dato no Valido");
            }
           
        }

        private void PanelVisual_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Buscador.Text = PanelVisual.CurrentCell.Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("informacion no valida");
            }
            
        }

        private void Nombre_Click(object sender, EventArgs e)
        {

        }
    }
}
