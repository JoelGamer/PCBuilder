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
    public partial class frmPerfil : Form
    {
        string usr;

        public frmPerfil(string user)
        {
            InitializeComponent();
            string User = user.ToString();
            usr = User;
            lblNome.Text = usr;

            updt();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmPerfil_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMainmenu frm = new frmMainmenu(usr);
            Close();
        }

        void updt()
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=DB-PCBuilder-Usrs;Integrated Security=True;");
            con.Open();
            string str = "select usr_usuario,din_usuario,bitm_usuario,upg_usuario from USUARIO where usr_usuario='" + usr + "'";
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
                    lblBitm.Text = dr[2].ToString();
                    lblUpg.Text = dr[3].ToString();
                    break;
                }
            }
            else { }
        }
    }
}