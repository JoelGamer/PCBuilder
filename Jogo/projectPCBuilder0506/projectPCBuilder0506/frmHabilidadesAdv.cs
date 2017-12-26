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
    public partial class frmHabilidadesAdv : Form
    {
        string usr;

        string PCS;
        string DpWb;
        string PCH;
        string SVH;
        string CompAdv;
        string CompMulti;
        string Fact;

        public frmHabilidadesAdv(string user)
        {
            InitializeComponent();
            string User = user.ToString();
            usr = User;
            SqlHab();
            Habilidades();
        }

        private void frmHabilidadesAdv_Load(object sender, EventArgs e)
        {

        }

        void SqlHab()
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=DB-PCBuilder-Usrs;Integrated Security=True;");
            con.Open();
            string str = "select usr_habilidade,pcs_habilidade,dpwb_habilidade,hack_habilidade,serv_habilidade,comp_habilidade,multi_habilidade,fact_habilidade from HABILIDADES where usr_habilidade='" + usr + "'";
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
                    PCS = dr[1].ToString();
                    DpWb = dr[2].ToString();
                    PCH = dr[3].ToString();
                    SVH = dr[4].ToString();
                    CompAdv = dr[5].ToString();
                    CompMulti = dr[6].ToString();
                    Fact = dr[7].ToString();
                    break;
                }
            }
            else { }
        }

        void Habilidades()
        {
            CPCS();
            CDPWB();
            CPCH();
            CSVH();
            CCOMPADV();
            CCOMPMULTI();
            CFACT();
        }

        void CPCS()
        {
            int CPCS = Convert.ToInt32(PCS);

            if (CPCS == 1)
            {
                if (lblPCS.ForeColor == Color.Red)
                {
                    lblPCS.ForeColor = Color.Green;
                }
            }
        }

        void CDPWB()
        {
            int CDPWB = Convert.ToInt32(DpWb);

            if (CDPWB == 1)
            {
                if (lblDpWb.ForeColor == Color.Red)
                {
                    lblDpWb.ForeColor = Color.Green;
                }
            }
        }

        void CPCH()
        {
            int CPCH = Convert.ToInt32(PCH);

            if (CPCH == 1)
            {
                if (lblPCH.ForeColor == Color.Red)
                {
                    lblPCH.ForeColor = Color.Green;
                }
            }
        }

        void CSVH()
        {
            int CSVH = Convert.ToInt32(SVH);

            if (CSVH == 1)
            {
                if (lblSVH.ForeColor == Color.Red)
                {
                    lblSVH.ForeColor = Color.Green;
                }
            }
        }

        void CCOMPADV()
        {
            int CCOMPADV = Convert.ToInt32(CompAdv);

            if (CCOMPADV == 1)
            {
                if (lblCompAdv.ForeColor == Color.Red)
                {
                    lblCompAdv.ForeColor = Color.Green;
                }
            }
        }

        void CCOMPMULTI()
        {
            int CCOMPMULTI = Convert.ToInt32(CompMulti);

            if (CCOMPMULTI == 1)
            {
                if (lblCompMulti.ForeColor == Color.Red)
                {
                    lblCompMulti.ForeColor = Color.Green;
                }
            }
        }

        void CFACT()
        {
            int CFACT = Convert.ToInt32(Fact);

            if (CFACT == 1)
            {
                if (lblFact.ForeColor == Color.Red)
                {
                    lblFact.ForeColor = Color.Green;
                }
            }
        }
    }//Acaba aqui
}
