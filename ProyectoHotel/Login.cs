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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txt_User_Enter(object sender, EventArgs e)
        {
            if (txt_User.Text == "USUARIO")
            {
                txt_User.Text = "";
                txt_User.ForeColor = Color.Chocolate;
            }
        }

        private void txt_User_Leave(object sender, EventArgs e)
        {
            if (txt_User.Text == "")
            {
                txt_User.Text = "USUARIO";
                txt_User.ForeColor = Color.Sienna;
            }
        }

        private void txt_Pass_Enter(object sender, EventArgs e)
        {
            if (txt_Pass.Text == "CONTRASEÑA")
            {
                txt_Pass.Text = "";
                txt_Pass.ForeColor = Color.Chocolate;
                txt_Pass.UseSystemPasswordChar = true;
            }
        }
        private void txt_Pass_Leave(object sender, EventArgs e)
        {
            if (txt_Pass.Text == "")
            {
                txt_Pass.Text = "CONTRASEÑA";
                txt_Pass.ForeColor = Color.Sienna;
                txt_Pass.UseSystemPasswordChar = false;

            }
        }

        private void btn_Acc_Click(object sender, EventArgs e)
        {
            if (txt_User.Text == "Recepcionista"){
                if (txt_Pass.Text == "1234")
                {
                    this.Hide();
                    Form1 frm = new Form1();
                    frm.Show();
                }

            }
            else
            {
                MessageBox.Show("El Usuario o la Contraseña son Incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
