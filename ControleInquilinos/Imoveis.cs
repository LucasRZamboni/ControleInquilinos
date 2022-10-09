using System;
using System.Drawing;
using System.Windows.Forms;

namespace ControleInquilinos
{
    public partial class Imoveis : Form
    {
        public Imoveis()
        {
            InitializeComponent();
        }
        private void Imoveis_Load(object sender, EventArgs e)
        {
            
        }
        private void btnSair_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var menu = new Menu();
            this.Hide();
            menu.ShowDialog();
        }
    }
}
