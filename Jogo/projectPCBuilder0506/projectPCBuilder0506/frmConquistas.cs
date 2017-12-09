using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projectPCBuilder0506
{
    public partial class frmConquistas : Form
    {
        string usr;

        public frmConquistas(string user)
        {
            InitializeComponent();
            string User = user.ToString();
            usr = User;
            lblUsr.Text = usr;
            updt();
        }

        private void frmConquistas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CBitcoin()
        {
            int Cbitcoin = Convert.ToInt32(lblBitm.Text);

            if (Cbitcoin >= 1)
            {
                if (lblConBit1.ForeColor == Color.Red)
                {
                    lblConBit1.ForeColor = Color.Green;
                }
            }
            if (Cbitcoin >= 100)
            {
                if (lblConBit2.ForeColor == Color.Red)
                {
                    lblConBit2.ForeColor = Color.Green;
                }
            }
            if (Cbitcoin >= 400)
            {
                if (lblConBit3.ForeColor == Color.Red)
                {
                    lblConBit3.ForeColor = Color.Green;
                }
            }
            if (Cbitcoin >= 1000)
            {
                if(lblConBit4.ForeColor == Color.Red)
                {
                    lblConBit4.ForeColor = Color.Green;
                }
            }
        }//Fim do void

        private void CDinheiro()
        {
            long Cdinheiro = Convert.ToInt64(lblDinheiro.Text);

            if (Cdinheiro >= 100000)
            {
                if (lblConDin1.ForeColor == Color.Red)
                {
                    lblConDin1.ForeColor = Color.Green;
                }
            }
            if (Cdinheiro >= 1000000)
            {
                if (lblConDin2.ForeColor == Color.Red)
                {
                    lblConDin2.ForeColor = Color.Green;
                }
            }
            if (Cdinheiro >= 100000000)
            {
                if (lblConDin3.ForeColor == Color.Red)
                {
                    lblConDin3.ForeColor = Color.Green;
                }
            }
            if (Cdinheiro >= 1000000000)
            {
                if(lblConDin4.ForeColor == Color.Red)
                {
                    lblConDin4.ForeColor = Color.Green;
                }
            }
         }//Fim do void

        private void CVitorias()
        {
            int CVitorias = Convert.ToInt32(lblVit.Text);

            if (CVitorias >= 1)
            {
                if (lblConVit1.ForeColor == Color.Red)
                {
                    lblConVit1.ForeColor = Color.Green;
                }
            }
            if (CVitorias >= 2)
            {
                if (lblConVit2.ForeColor == Color.Red)
                {
                    lblConVit2.ForeColor = Color.Green;
                }
            }
            if (CVitorias >= 3)
            {
                if (lblConVit3.ForeColor == Color.Red)
                {
                    lblConVit3.ForeColor = Color.Green;
                }
            }
            if(CVitorias >= 4)
            {
                if(lblConVit4.ForeColor == Color.Red)
                {
                    lblConVit4.ForeColor = Color.Green;
                }
            }
        }//Fim do void

        private void CUpgrades()
        {
            int CUpgrades = Convert.ToInt32(lblUpgrade.Text);

            if (CUpgrades >= 2)
            {
                if (lblConUp1.ForeColor == Color.Red)
                {
                    lblConUp1.ForeColor = Color.Green;
                }
            }
            if (CUpgrades >= 5)
            {
                if (lblConUp2.ForeColor == Color.Red)
                {
                    lblConUp2.ForeColor = Color.Green;
                }
            }
            if (CUpgrades >= 15)
            {
                if (lblConUp3.ForeColor == Color.Red)
                {
                    lblConUp3.ForeColor = Color.Green;
                }
            }
            if(CUpgrades >= 30)
            {
                if(lblConUp4.ForeColor == Color.Red)
                {
                    lblConUp4.ForeColor = Color.Green;
                }
            }
        }//Fim do void

        void updt()
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=DB-PCBuilder-Usrs;Integrated Security=True;");
            con.Open();
            string str = "select usr_usuario,din_usuario,bitm_usuario,vit_usuario,upg_usuario from USUARIO where usr_usuario='" + usr + "'";
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    lblDinheiro.Text = dr[1].ToString();
                    lblBitm.Text = dr[2].ToString();
                    lblVit.Text = dr[3].ToString();
                    lblUpgrade.Text = dr[4].ToString();

                    CDinheiro();
                    CBitcoin();
                    CUpgrades();
                    CVitorias();
                    break;
                }
            }
            else { }
        }
    }//Watch out!!
}//Watch out!!
