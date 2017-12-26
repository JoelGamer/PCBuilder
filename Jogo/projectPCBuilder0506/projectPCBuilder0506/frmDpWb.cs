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
    public partial class frmDpWb : Form
    {
        string usr;

        public frmDpWb(string user)
        {
            InitializeComponent();
            string User = user.ToString();
            usr = User;
        }

        private void frmDpWb_Load(object sender, EventArgs e)
        {

        }

        private void btnMercNegro_Click(object sender, EventArgs e)
        {
            frmLojaAdv frm = new frmLojaAdv(usr);
            frm.Show();
        }

        private void btnServComp_Click(object sender, EventArgs e)
        {
            frmLojaServer frm = new frmLojaServer(usr);
            frm.Show();
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            frmChatGeral frm = new frmChatGeral(usr);
            frm.Show();
        }

        private void btnCampanha_Click(object sender, EventArgs e)
        {
            frmCompetidoresAdv frm = new frmCompetidoresAdv(usr);
            frm.Show();
        }

        private void btnFaccoes_Click(object sender, EventArgs e)
        {
            frmFaccoes frm = new frmFaccoes(usr);
            frm.Show();
        }
    }
}
