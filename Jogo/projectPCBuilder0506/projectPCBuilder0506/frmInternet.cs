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
    public partial class frmInternet : Form
    {
        string usr;
        public frmInternet()
        {
            InitializeComponent();
        }

        public frmInternet(string user)
        {
            InitializeComponent();
            string User = user.ToString();
            usr = User;
        }

        private void frmInternet_Load(object sender, EventArgs e)
        {

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            frmInventario frm = new frmInventario(usr);
            frm.Show();
        }

        private void btnCampanha_Click(object sender, EventArgs e)
        {
            frmCompetidores frm = new frmCompetidores(usr);
            frm.Show();
        }

        private void btnBitcoin_Click(object sender, EventArgs e)
        {
            frmBit frm = new frmBit(usr);
            frm.Show();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 3),
                                     this.DisplayRectangle);
        }

        private void btnMusica_Click(object sender, EventArgs e)
        {
            frmMusica frm = new frmMusica();
            frm.Show();
        }
    }
}
