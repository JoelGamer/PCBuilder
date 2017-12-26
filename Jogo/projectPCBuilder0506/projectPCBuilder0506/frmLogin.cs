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
    public partial class frmLogin : Form
    {
        string usr;
        string server;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistrar frm = new frmRegistrar();
            frm.Show();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cbxServer.Text == "")
            {
                MessageBox.Show("Você não selecionou um server!", "Login", MessageBoxButtons.OK);
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source="+ server +";Initial Catalog=DB-PCBuilder-Usrs;Integrated Security=True;");
                //SqlConnection con = new SqlConnection(@"Data Source=lab09-36;Initial Catalog=DB-PCBuilder-Usrs;Integrated Security=True;");
                con.Open();
                string str = "select usr_usuario,sen_usuario from USUARIO where usr_usuario='" + txtUsr.Text + "' and sen_usuario='" + txtSenha.Text + "'";
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
                        MessageBox.Show("Seja Bem-Vindo ao jogo!!", "Bem-Vindo!", MessageBoxButtons.OK);
                        usr = txtUsr.Text;
                        frmMainmenu frm = new frmMainmenu(usr,server);
                        frm.Show();
                        Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Parece que você errou o usuário ou a senha....!", "Login", MessageBoxButtons.OK);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUsr_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTDN frm = new frmTDN();
            frm.Show();
        }

        private void cbxServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxServer.Text == "LocalHost")
            {
                server = "localhost";
            }
            if(cbxServer.Text == "Hamachi")
            {
                server = "25.73.57.125";
            }
            else if(cbxServer.Text == "Online")
            {
                server = "192.168.0.13";
            }
        }
    }
}
