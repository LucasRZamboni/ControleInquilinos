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
    public partial class DEV : Form
    {
        public DEV()
        {
            InitializeComponent();
        }
        private void DEV_Load(object sender, EventArgs e)
        {
            Size = new Size(800, 545);

        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
