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
    public partial class frmCompetidores : Form
    {
        string usr;
        int vitoria;

        public frmCompetidores(string user)
        {
            InitializeComponent();
            string User = user.ToString();
            usr = User;
            lblNome.Text = usr;

            updt();
            updtc();
        }

        private void frmCompetidores_Load(object sender, EventArgs e)
        {

        }

        private void btnComp1_Click(object sender, EventArgs e)
        {
            int Forca = Convert.ToInt32(lblForca.Text);

            if(Forca > 4500)
            {
                if(vitoria == 0)
                {
                    MessageBox.Show("Você venceu a batalha!", "Vitória!", MessageBoxButtons.OK);
                    vitoria++;
                    lblVitorias.Text = vitoria.ToString();
                }
                else
                {
                    MessageBox.Show("Você venceu a batalha!", "Vitória!", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Você perdeu a batalha!", "Derota!", MessageBoxButtons.OK);
            }
        }

        private void btnComp2_Click(object sender, EventArgs e)
        {
            int Forca = Convert.ToInt32(lblForca.Text);

            if (Forca > 14000)
            {
                if (vitoria <= 1)
                {
                    MessageBox.Show("Você venceu a batalha!", "Vitória!", MessageBoxButtons.OK);
                    vitoria++;
                    lblVitorias.Text = vitoria.ToString();
                }
                else
                {
                    MessageBox.Show("Você venceu a batalha!", "Vitória!", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Você perdeu a batalha!", "Derota!", MessageBoxButtons.OK);
            }
        }

        private void btnComp3_Click(object sender, EventArgs e)
        {
            int Forca = Convert.ToInt32(lblForca.Text);

            if (Forca > 22500)
            {
                if (vitoria <= 2)
                {
                    MessageBox.Show("Você venceu a batalha!", "Vitória!", MessageBoxButtons.OK);
                    vitoria++;
                    lblVitorias.Text = vitoria.ToString();
                }
                else
                {
                    MessageBox.Show("Você venceu a batalha!", "Vitória!", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Você perdeu a batalha!", "Derota!", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Forca = Convert.ToInt32(lblForca.Text);

            if (Forca > 53000)
            {
                if (vitoria <= 3)
                {
                    MessageBox.Show("Você venceu a batalha!", "Vitória!", MessageBoxButtons.OK);
                    vitoria++;
                    lblVitorias.Text = vitoria.ToString();
                }
                else
                {
                    MessageBox.Show("Você venceu a batalha!", "Vitória!", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Você perdeu a batalha!", "Derota!", MessageBoxButtons.OK);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }      

        void updt()
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=DB-PCBuilder-Usrs;Integrated Security=True;");
            con.Open();
            string str = "select usr_usuario,din_usuario,vit_usuario from USUARIO where usr_usuario='" + usr + "'";
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
                    lblDinheiro.Text = dr[1].ToString();
                    lblVitorias.Text = dr[2].ToString();
                    break;
                }
            }
            else { }
        }

        void updtc()
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
            else { }
        }
    }
}
