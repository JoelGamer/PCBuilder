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
    public partial class frmVirtual : Form
    {
        string usr;
        int clk;
        int Lixo;
       
        public frmVirtual(string user)
        {
            InitializeComponent();
            string User = user.ToString();
            usr = User;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseja sair do jogo ou somente do PC virtual?", "Sair", MessageBoxButtons.YesNo);
            if (sair == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (sair == DialogResult.No)
            {
                Close();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (clk == 1)
            {
                btnSair.Visible = false;
                btnPDF.Visible = false;
                btnCriadores.Visible = false;
                gpbPDF.Visible = false;
                Application.DoEvents();
                clk = 0;
            }
            else
            {
                btnSair.Visible = true;
                btnPDF.Visible = true;
                btnCriadores.Visible = true;
                Application.DoEvents();
                clk = 1;
            }
        }

        private void btnCriadores_Click(object sender, EventArgs e)
        {
            frmCriadores frm = new frmCriadores();
            frm.Show();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (gpbPDF.Visible == true)
            {
                gpbPDF.Visible = false;
            }
            else
            {
                gpbPDF.Visible = true;
            }
        }

        private void btnLix_Click(object sender, EventArgs e)
        {
            if(Lixo == 0)
            {
                MessageBox.Show("Novamente, tem nada aqui", "Lixeira", MessageBoxButtons.OK);
                Lixo++;
            }
            else if(Lixo == 1)
            {
                MessageBox.Show("Cara, já falei que tem nada aqui", "Lixeira", MessageBoxButtons.OK);
                Lixo++;
            }
            else if(Lixo == 2)
            {
                MessageBox.Show("Caramba, você é persistente", "Lixeira", MessageBoxButtons.OK);
                Lixo++;
            }
            else if(Lixo == 3)
            {
                MessageBox.Show("Aaaaaaaaaaa, pare de clickar aqui!!", "Lixeira", MessageBoxButtons.OK);
                Lixo++;
            }
            else
            {
                Lixeira();
                Lixo++;
            }
        }

        void Lixeira()
        {
            MessageBox.Show("-__-", "Lixeira", MessageBoxButtons.OK);
        }

        private void btnDpWb_Click(object sender, EventArgs e)
        {
            frmDpWb frm = new frmDpWb(usr);
            frm.Show();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            frmPerfilAdv frm = new frmPerfilAdv(usr);
            frm.Show();
        }

        private void btnMusicas_Click(object sender, EventArgs e)
        {
            frmMusicasAdv frm = new frmMusicasAdv();
            frm.Show();
        }

        private void btnConquistas_Click(object sender, EventArgs e)
        {
            frmConquistasAdv frm = new frmConquistasAdv(usr);
            frm.Show();
        }
    }
}
