using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoHotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Mininizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel_Contenedor.Controls.Clear();
            Reservacion Frm = new Reservacion();
            Frm.TopLevel = false;
            Frm.Show();
            panel_Contenedor.Controls.Add(Frm);
            
        }

        private void panel_MenuV_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Habitaciones_Click(object sender, EventArgs e)
        {
            this.panel_Contenedor.Controls.Clear();
            Habitaciones Frm = new Habitaciones();
            Frm.TopLevel = false;
            Frm.Show();
            panel_Contenedor.Controls.Add(Frm);
          
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            this.panel_Contenedor.Controls.Clear();
            Cliente Frm = new Cliente();
            Frm.TopLevel = false;
            Frm.Show();
            panel_Contenedor.Controls.Add(Frm);
          
        }

        private void btn_Paquetes_Click(object sender, EventArgs e)
        {
            this.panel_Contenedor.Controls.Clear();
            Paquete Frm = new Paquete();
            Frm.TopLevel = false;
            Frm.Show();
            panel_Contenedor.Controls.Add(Frm);
           
        }

        private void btn_Ubicacion_Click(object sender, EventArgs e)
        {
            this.panel_Contenedor.Controls.Clear();
            Ubicacion Frm = new Ubicacion();
            Frm.TopLevel = false;
            Frm.Show();
            panel_Contenedor.Controls.Add(Frm);
            
        }

        private void btn_Logo_Click(object sender, EventArgs e)
        {
            this.panel_Contenedor.Controls.Clear();
           Inicio Frm = new Inicio();
            Frm.TopLevel = false;
            Frm.Show();
            panel_Contenedor.Controls.Add(Frm);
        }

        private void panel_Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
