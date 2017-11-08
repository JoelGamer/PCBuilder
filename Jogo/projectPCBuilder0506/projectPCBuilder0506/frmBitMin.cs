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
    public partial class frmBitMin : Form
    {
        string usr;
        int ElementoComputadorXX = 0;
        int ElementoComputadorYY = 0;
        int ElementoComputadorZZ = 0;
        int Upg;
        int FBit;

        public frmBitMin(string user, int upg)
        {
            InitializeComponent();
            string User = user.ToString();
            Upg = upg;
            usr = User;
        }

        public void variaveis()
        {
            Random ElementoComputadorX;
            Random ElementoComputadorY;

            ElementoComputadorX = new Random();
            ElementoComputadorXX =
                ElementoComputadorX.Next(0, 100);

            ElementoComputadorY = new Random();
            ElementoComputadorYY =
                ElementoComputadorY.Next(0, 100);

            if(ElementoComputadorXX == ElementoComputadorYY)
            {
                ElementoComputadorZZ = ElementoComputadorYY + 8;
            }

            lblX.Text = ElementoComputadorXX.ToString();
            lblY.Text = ElementoComputadorZZ.ToString();
        }

        public void minerar()
        {
            int lblXX = Convert.ToInt16(lblX.Text);
            int lblYY = Convert.ToInt16(lblY.Text);
            int Res = Convert.ToInt16(txtResposta.Text);
            int Vres;

            if(Res != 0)
            {
                Vres = lblXX + lblYY;

                if (Vres == Res)
                {
                    FBit = Upg;
                    lblBitcoin.Text = FBit.ToString();

                    MessageBox.Show("Você conseguiu minerar um bitcoin!", "Minerador", MessageBoxButtons.OK);                    
                }
                else
                {
                    MessageBox.Show("Você não conseguiu minerar um bitcoin, tente novamente!", "Minerador", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Insira um valor para confirmar!!", "Minerador", MessageBoxButtons.OK);
            }
        }

        private void frmBitMin_Load(object sender, EventArgs e)
        {
            //Nao usar
        }

        private void txtResposta_TextChanged(object sender, EventArgs e)
        {
            //Nao usar
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            variaveis();

            txtResposta.ReadOnly = false;
            btnConfirmar.Enabled = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            minerar();
            txtResposta.ReadOnly = true;
            btnConfirmar.Enabled = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmBit frm = new frmBit(usr,FBit);
            frm.Show();
            Close();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }
    }
}
