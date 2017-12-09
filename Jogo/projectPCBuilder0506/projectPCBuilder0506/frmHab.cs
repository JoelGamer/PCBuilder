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
    public partial class frmHab : Form
    {
        string usr;

        string PCS;
        string DpWb;
        string PCH;
        string SVH;
        string Comp;
        string Multi;
        string Fact;
        string CVit;
        string MVit;

        int PCSSql;
        int DpWbSql;
        int PCHSql;
        int SVHSql;
        int CompSql;
        int MultiSql;
        int FactSql;

        public frmHab(string user)
        {
            InitializeComponent();
            string User = user.ToString();
            usr = User;
            SqlPF();
            SqlHAB();
            BtnVer();
            HabUpdt();
        }

        void HabUpdt()
        {
            int PCSi = Convert.ToInt16(PCS);
            int DpWbi = Convert.ToInt16(DpWb);
            int PCHi = Convert.ToInt16(PCH);
            int SVHi = Convert.ToInt16(SVH);
            int Compi = Convert.ToInt16(Comp);
            int Multii = Convert.ToInt16(Multi);
            int Facti = Convert.ToInt16(Fact);

            PCSSql = PCSi;
            DpWbSql = DpWbi;
            PCHSql = PCHi;
            SVHSql = SVHi;
            CompSql = Compi;
            MultiSql = Multii;
            FactSql = Facti;
        }

        private void btnPCS_Click(object sender, EventArgs e)
        {
            PCSSql = 1;
        }

        private void btnDW_Click(object sender, EventArgs e)
        {
            DpWbSql = 1;
        }

        private void btnHack_Click(object sender, EventArgs e)
        {
            PCHSql = 1;
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            SVHSql = 1;
        }

        private void btnCompp_Click(object sender, EventArgs e)
        {
            CompSql = 1;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            MultiSql = 1;
        }

        private void btnFact_Click(object sender, EventArgs e)
        {
            FactSql = 1;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString =
                    "server=localhost;" +
                    "initial catalog=DB-PCBuilder-Usrs;" +
                    "Integrated Security = True;";
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd =
                        new SqlCommand("UPDATE HABILIDADES SET pcs_habilidade=@PCS,dpwb_habilidade=@DpWb,hack_habilidade=@PCH,serv_habilidade=@SVH,comp_habilidade=@Comp,multi_habilidade=@Multi,fact_habilidade=@Fact WHERE usr_habilidade='" + usr + "'", conn))
                    {
                        cmd.Parameters.AddWithValue("@PCS", PCSSql);
                        cmd.Parameters.AddWithValue("@DpWb", DpWbSql);
                        cmd.Parameters.AddWithValue("@PCH", PCHSql);
                        cmd.Parameters.AddWithValue("@SVH", SVHSql);
                        cmd.Parameters.AddWithValue("@Comp", CompSql);
                        cmd.Parameters.AddWithValue("@Multi", MultiSql);
                        cmd.Parameters.AddWithValue("@Fact", FactSql);

                        int rows = cmd.ExecuteNonQuery();

                        Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                //Log exception
                //Display Error message
            }
        }

        /*
            int PCSi = Convert.ToInt16(PCS);
            int DpWbi = Convert.ToInt16(DpWb);
            int PCHi = Convert.ToInt16(PCH);
            int SVHi = Convert.ToInt16(SVH);
            int Compi = Convert.ToInt16(Comp);
            int Multii = Convert.ToInt16(Multi);
            int Facti = Convert.ToInt16(Fact);
            int Din = Convert.ToInt32(lblDin.Text);
            int Vit = Convert.ToInt16(lblVit.Text);
            int PPCH = Convert.ToInt16(lblPCH.Text);
            int PSVH = Convert.ToInt16(lblSVH.Text);
            int PCVit = Convert.ToInt16(CVit);
            int PMVit = Convert.ToInt16(MVit);
        */

        void BtnVer()
        {
            BtnPCS();
            BtnDpWb();
            BtnPCH();
            BtnSVH();
            BtnComp();
            BtnMulti();
            BtnFact();
        }

        void SqlPF()
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=DB-PCBuilder-Usrs;Integrated Security=True;");
            con.Open();
            string str = "select usr_usuario,din_usuario,vit_usuario,pchack_usuario,sevhack_usuario,vitapr_usuario,vitmulti_usuario from USUARIO where usr_usuario='" + usr + "'";
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
                    lblDin.Text = dr[1].ToString();
                    lblVit.Text = dr[2].ToString();
                    lblPCH.Text = dr[3].ToString();
                    lblSVH.Text = dr[4].ToString();
                    CVit = dr[5].ToString();
                    MVit = dr[6].ToString();
                    break;
                }
            }
            else { }
        }

        void SqlHAB()
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
                    Comp = dr[5].ToString();
                    Multi = dr[6].ToString();
                    Fact = dr[7].ToString();
                    break;
                }
            }
            else { }
        }

        void BtnPCS()
        {
            int Vit = Convert.ToInt16(lblVit.Text);
            int PCSi = Convert.ToInt16(PCS);

            if (Vit >= 3 && PCSi == 0)
            {
                btnPCS.Enabled = true;
                Application.DoEvents();
            }
            else { }
        }
        
        void BtnDpWb()
        {
            int Vit = Convert.ToInt16(lblVit.Text);
            int DpWbi = Convert.ToInt16(DpWb);

            if(Vit >= 4 && DpWbi == 0)
            {
                btnDpWeb.Enabled = true;
                Application.DoEvents();
            }
            else { }
        }

        void BtnPCH()
        {
            int DpWbi = Convert.ToInt16(DpWb);
            int PCHi = Convert.ToInt16(PCH);

            if (DpWbi == 1 && PCHi == 0)
            {
                btnPCHack.Enabled = true;
                Application.DoEvents();
            }
            else { }
        }

        void BtnSVH()
        {
            int DpWbi = Convert.ToInt16(DpWb);
            int PCHi = Convert.ToInt16(PCH);
            int PPCH = Convert.ToInt16(lblPCH.Text);

            if (DpWbi == 1 && PPCH >= 10 && PCHi == 1)
            {
                btnSVHack.Enabled = true;
                Application.DoEvents();
            }
            else { }
        }
        
        void BtnComp()
        {
            int PSVH = Convert.ToInt16(lblSVH.Text);
            int DpWbi = Convert.ToInt16(DpWb);

            if(DpWbi == 1 && PSVH >= 5)
            {
                btnComp.Enabled = true;
                Application.DoEvents();
            }
            else { }
        }

        void BtnMulti()
        {
            int PCVit = Convert.ToInt16(CVit);
            int DpWbi = Convert.ToInt16(DpWb);

            if(PCVit >= 10 && DpWbi == 1)
            {
                btnMulti.Enabled = true;
                Application.DoEvents();
            }
            else { }
        }

        void BtnFact()
        {
            int PCVit = Convert.ToInt16(CVit);
            int DpWbi = Convert.ToInt16(DpWb);
            int PMVit = Convert.ToInt16(MVit);

            if(PCVit >= 15 && DpWbi == 1 && PMVit >= 10)
            {
                btnFact.Enabled = true;
                Application.DoEvents();
            }
            else { }
        }
    }//Fim
}//Fim
