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
    public partial class frmTDN : Form
    {
        public frmTDN()
        {
            InitializeComponent();
        }

        private void btnConf_Click(object sender, EventArgs e)
        {
            chngusrnm();
        }

        void chngusrnm()
        {
            string VUser = Convert.ToString(txtNUser.Text);
            string User = Convert.ToString(txtUser.Text);
            string Senha = Convert.ToString(txtSenha.Text);

            if (String.IsNullOrEmpty(VUser))
            {
                MessageBox.Show("Você esqueceu de colocar o seu novo nome!!", "Trocar de Usuario", MessageBoxButtons.OK);
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=DB-PCBuilder-Usrs;Integrated Security=True;");
                con.Open();
                string str = "select usr_usuario,sen_usuario from USUARIO where usr_usuario='" + User + "' and sen_usuario='" + Senha + "'";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataAdapter da = new SqlDataAdapter(str, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        updtusr();
                    }
                }
                else
                {
                    MessageBox.Show("Parece que você errou a senha....!", "Login", MessageBoxButtons.OK);
                }
            }
        }

        void updtusr()
        {
            string NUser = Convert.ToString(txtNUser.Text);

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
                        new SqlCommand("UPDATE USUARIO SET usr_usuario=@Name WHERE usr_usuario='" + txtUser.Text + "'", conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", NUser);

                        int rows = cmd.ExecuteNonQuery();

                        MessageBox.Show("Você alterou o seu nome!!", "Trocar de Nome", MessageBoxButtons.OK);

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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
