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
    public partial class frmInventario : Form
    {
        string usr;

        public frmInventario(string user)
        {
            InitializeComponent();
            string User = user.ToString();
            usr = User;

            updt();
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {

        }

        void updt()
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=DB-PCBuilder-Usrs;Integrated Security=True;");
            con.Open();
            string str = "select usr_compt,pcn_compt,cpu_compt,pcm_compt,fda_compt,ram_compt,gpu_compt,gab_compt,for_compt from COMPT where usr_compt='" + usr + "'";
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
                    lblPCN.Text = dr[1].ToString();              
                    lblCPU.Text = dr[2].ToString();
                    lblPCM.Text = dr[3].ToString();
                    lblFdA.Text = dr[4].ToString();
                    lblRAM.Text = dr[5].ToString();
                    lblGPU.Text = dr[6].ToString();
                    lblGab.Text = dr[7].ToString();
                    lblForca.Text = dr[8].ToString();
                    break;
                }
            }
            else
            {
                MessageBox.Show("Você ainda não comprou um computador ainda!!", "Inventário", MessageBoxButtons.OK);
                Close();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
