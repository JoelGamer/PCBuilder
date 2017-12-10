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
    public partial class frmPerfilAdv : Form
    {
        string usr;

        public frmPerfilAdv(string user)
        {
            InitializeComponent();
            string User = user.ToString();
            usr = User;
            lblNome.Text = usr;
            Perfil();
        }

        private void frmPerfilAdv_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        void Perfil()
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
                    break;
                }
            }
            else { }
        }
    }
}
