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
    public partial class frmRegistrar : Form
    {
        public frmRegistrar()
        {
            InitializeComponent();

            Dictionary<int, string> sexo = new Dictionary<int, string>();
            sexo.Add(1, "Masculino");
            sexo.Add(2, "Feminino");
            cbxSexo.DataSource = new BindingSource(sexo, null);
            cbxSexo.DisplayMember = "Value";
            cbxSexo.ValueMember = "Key";

            string vSexo = ((KeyValuePair<int, string>)cbxSexo.SelectedItem).Value;
            //
            //As duas Combo Boxes com os valores
            //
            Dictionary<int, string> serie = new Dictionary<int, string>();
            serie.Add(1, "1ºAno");
            serie.Add(2, "2ºAno");
            serie.Add(3, "3ºAno");
            serie.Add(4, "4ºAno");
            serie.Add(5, "5ºAno");
            cbxSerie.DataSource = new BindingSource(serie, null);
            cbxSerie.DisplayMember = "Value";
            cbxSerie.ValueMember = "Key";

            string vSerie = ((KeyValuePair<int, string>)cbxSerie.SelectedItem).Value;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string Usuario = Convert.ToString(txtUsr.Text);
            string Senha = Convert.ToString(txtSenha.Text);
            string CSenha = Convert.ToString(txtCSenha.Text);

            if (Senha == CSenha)
            {
                registrar();
            }
            else
            {
                MessageBox.Show("As senhas não são iguais!!", "Senha!", MessageBoxButtons.OK);
            }
        }

        void registrar()
        {           
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=DB-PCBuilder-Usrs;Integrated Security=True;");
            string str = "insert into USUARIO(usr_usuario,sen_usuario,ano_usuario,sexo_usuario,din_usuario,bitm_usuario,vit_usuario,upg_usuario) values('"+txtUsr.Text+"','"+txtSenha.Text+"','"+ cbxSerie.Text+ "','"+ cbxSexo.Text+ "','"+0+"','"+0+"','"+0+"','"+1+"')";
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            cmd.ExecuteNonQuery();
            
            MessageBox.Show("Parabéns você acabou de ser registrado", "Registro", MessageBoxButtons.OK);
        }

        private void cbxSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Affs
        }

        private void frmRegistrar_Load(object sender, EventArgs e)
        {

        }

        private void cbxSerie_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cbxSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }//Hi
}//Hey
