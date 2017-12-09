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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            cbxAdm();
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            txtDin.Text = "0";
            txtBitm.Text = "0";
            txtUpg.Text = "1";
            txtVit.Text = "0";
            txtPCHack.Text = "0";
            txtServHack.Text = "0";           
            txtVitapr.Text = "0";
            txtVitmulti.Text = "0";           
        }

        void cbxAdm()
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=DB-PCBuilder-Usrs;Integrated Security=True;");
            con.Open();
            string str = "select usr_usuario from USUARIO";
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataTable dt = new DataTable();
            SqlDataReader dr;
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string nomes = dr.GetString(0);
                    cbxNome.Items.Add(nomes);
                }
            }
        }

        private void cbxNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=DB-PCBuilder-Usrs;Integrated Security=True;");
            con.Open();
            string str = "select usr_usuario,sen_usuario,ano_usuario,sexo_usuario,din_usuario,vit_usuario,bitm_usuario,upg_usuario,pchack_usuario,sevhack_usuario,vitapr_usuario,vitmulti_usuario from USUARIO where usr_usuario='" + cbxNome.Text +"'";
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
                    txtSenha.Text = dr[1].ToString();
                    txtAno.Text = dr[2].ToString();
                    txtSexo.Text = dr[3].ToString();
                    txtDin.Text = dr[4].ToString();
                    txtVit.Text = dr[5].ToString();
                    txtBitm.Text = dr[6].ToString();                    
                    txtUpg.Text = dr[7].ToString();
                    txtPCHack.Text = dr[8].ToString();
                    txtServHack.Text = dr[9].ToString();
                    txtVitapr.Text = dr[10].ToString();
                    txtVitmulti.Text = dr[11].ToString();
                    break;
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você deseja alterar os valores?", "Administrador", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                string Nome = Convert.ToString(cbxNome.Text);

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
                            new SqlCommand("UPDATE USUARIO SET din_usuario=@Din,bitm_usuario=@Bit,upg_usuario=@Upg,vit_usuario=@Vit,pchack_usuario=@PCHack,sevhack_usuario=@ServHack,vitapr_usuario=@Vitapr,vitmulti_usuario=@Vitmp WHERE usr_usuario='" + cbxNome.Text + "'", conn))
                        {
                            cmd.Parameters.AddWithValue("@Din", txtDin.Text);
                            cmd.Parameters.AddWithValue("@Bit", txtBitm.Text);
                            cmd.Parameters.AddWithValue("@Upg", txtUpg.Text);
                            cmd.Parameters.AddWithValue("@Vit", txtVit.Text);
                            cmd.Parameters.AddWithValue("@PCHack", txtPCHack.Text);
                            cmd.Parameters.AddWithValue("@ServHack", txtServHack.Text);
                            cmd.Parameters.AddWithValue("@Vitapr", txtVitapr.Text);
                            cmd.Parameters.AddWithValue("@Vitmp", txtVitmulti.Text);

                            int rows = cmd.ExecuteNonQuery();

                            MessageBox.Show("As alterações foram feitas com sucesso!", "Administrador", MessageBoxButtons.OK);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    //Log exception
                    //Display Error message
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }//Fim do void

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
