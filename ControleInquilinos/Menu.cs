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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInquilinos_Click(object sender, EventArgs e)
        {
            var inqui = new Inquilinos();
            this.Hide();
            inqui.ShowDialog();
        }

        private void btnImoveis_Click(object sender, EventArgs e)
        {
            var imov = new Imoveis();
            this.Hide();
            imov.ShowDialog();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var login = new Login();
            this.Hide();
            login.ShowDialog();
        }
    }
}
