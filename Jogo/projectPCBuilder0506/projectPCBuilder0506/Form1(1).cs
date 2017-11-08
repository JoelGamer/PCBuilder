using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectPCBuilder0506
{
    public partial class frmStartup : Form
    {
        public frmStartup()
        {
            InitializeComponent();
        }

        private void tsmSair_Click(object sender, EventArgs e)
        {
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            int valor = pgbStartup.Value;
            valor += 1;
            if (valor > 100)
            {
                tmrBar.Enabled = false;
                frmPrincipal novoform = new frmPrincipal();
                this.Hide();
                novoform.Show();

            }
            else
                pgbStartup.Value = valor;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            tmrBar.Enabled = true;
        }
    }
}
