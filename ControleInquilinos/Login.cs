using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleInquilinos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnDEV_Click(object sender, EventArgs e)
        {
            var dev = new DEV();
            this.Hide();
            dev.ShowDialog(); 
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVerSenha_Click(object sender, EventArgs e)
        {
            pNVerSenha.Visible = false;
            pVerSenha.Visible = true;

            tbSenha.UseSystemPasswordChar = false;
        }
        private void btVerSenha_Click(object sender, EventArgs e)
        {
            pNVerSenha.Visible = true;
            pVerSenha.Visible = false;

            tbSenha.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var menu = new Menu();
            this.Hide();
            menu.ShowDialog();
        }
    }
}
