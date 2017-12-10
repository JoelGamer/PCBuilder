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
    public partial class frmConquistasAdv : Form
    {
        string usr;

        public frmConquistasAdv(string user)
        {
            InitializeComponent();
            string User = user.ToString();
            usr = User;
            lblNome.Text = usr;
            Conquistas();
        }

        private void frmConquistasAdv_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        void Conquistas()
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=DB-PCBuilder-Usrs;Integrated Security=True;");
            con.Open();
            string str = "select usr_usuario,din_usuario,pchack_usuario,sevhack_usuario,vitapr_usuario,vitmulti_usuario from USUARIO where usr_usuario='" + usr + "'";
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lblDinheiro.Text = "R$" + dr[1].ToString();
                    lblPCH.Text = dr[2].ToString();                  
                    lblSVH.Text = dr[3].ToString();                   
                    lblVitDpWb.Text = dr[4].ToString();
                    lblVitMulti.Text = dr[5].ToString();

                    CPCH();
                    CSVH();
                    CVDP();
                    CVMP();
                    break;
                }
            }
            else { }
        }

        private void CPCH()
        {
            int CPCH = Convert.ToInt32(lblPCH.Text);

            if (CPCH >= 1)
            {
                if (lblConPCH1.ForeColor == Color.Red)
                {
                    lblConPCH1.ForeColor = Color.Green;
                }
            }
            if (CPCH >= 100)
            {
                if (lblConPCH2.ForeColor == Color.Red)
                {
                    lblConPCH2.ForeColor = Color.Green;
                }
            }
            if (CPCH >= 500)
            {
                if (lblConPCH3.ForeColor == Color.Red)
                {
                    lblConPCH3.ForeColor = Color.Green;
                }
            }
            if (CPCH >= 1000)
            {
                if (lblConPCH4.ForeColor == Color.Red)
                {
                    lblConPCH4.ForeColor = Color.Green;
                }
            }
        }//Fim do void

        private void CSVH()
        {
            int CSVH = Convert.ToInt32(lblSVH.Text);

            if (CSVH >= 1)
            {
                if (lblConSVH1.ForeColor == Color.Red)
                {
                    lblConSVH1.ForeColor = Color.Green;
                }
            }
            if (CSVH >= 100)
            {
                if (lblConSVH2.ForeColor == Color.Red)
                {
                    lblConSVH2.ForeColor = Color.Green;
                }
            }
            if (CSVH >= 500)
            {
                if (lblConSVH3.ForeColor == Color.Red)
                {
                    lblConSVH3.ForeColor = Color.Green;
                }
            }
            if (CSVH >= 1000)
            {
                if (lblConSVH4.ForeColor == Color.Red)
                {
                    lblConSVH4.ForeColor = Color.Green;
                }
            }
        }//Fim do void

        private void CVDP()
        {
            int CVDP = Convert.ToInt32(lblVitDpWb.Text);

            if (CVDP >= 1)
            {
                if (lblConVDP1.ForeColor == Color.Red)
                {
                    lblConVDP1.ForeColor = Color.Green;
                }
            }
            if (CVDP >= 5)
            {
                if (lblConVDP2.ForeColor == Color.Red)
                {
                    lblConVDP2.ForeColor = Color.Green;
                }
            }
            if (CVDP >= 10)
            {
                if (lblConVDP3.ForeColor == Color.Red)
                {
                    lblConVDP3.ForeColor = Color.Green;
                }
            }
            if (CVDP >= 20)
            {
                if (lblConVDP4.ForeColor == Color.Red)
                {
                    lblConVDP4.ForeColor = Color.Green;
                }
            }
        }//Fim do void

        private void CVMP()
        {
            int CVMP = Convert.ToInt32(lblVitMulti.Text);

            if (CVMP >= 1)
            {
                if (lblConVMP1.ForeColor == Color.Red)
                {
                    lblConVMP1.ForeColor = Color.Green;
                }
            }
            if (CVMP >= 5)
            {
                if (lblConVMP2.ForeColor == Color.Red)
                {
                    lblConVMP2.ForeColor = Color.Green;
                }
            }
            if (CVMP >= 10)
            {
                if (lblConVMP3.ForeColor == Color.Red)
                {
                    lblConVMP3.ForeColor = Color.Green;
                }
            }
            if (CVMP >= 20)
            {
                if (lblConVMP4.ForeColor == Color.Red)
                {
                    lblConVMP4.ForeColor = Color.Green;
                }
            }
        }//Fim do void
    }
}
