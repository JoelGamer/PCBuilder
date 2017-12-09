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
    public partial class frmLoja : Form
    {
        int FinDinheiro;
        int ver;
        long FDinheiro;
        string usr;

        public frmLoja(string user)
        {
            InitializeComponent();
            string User = user.ToString();
            usr = User;

            updt();
            cbxCPU();
            cbxPCM();
            cbxRAM();
            cbxGPU();
            cbxFdA();
            cbxGab();
        }

        private void frmLoja_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        // Insert na tabela
        private void btnNNome_Click(object sender, EventArgs e)
        {
            long Dinheiro = Convert.ToInt64(lblDinheiro.Text);

            verif();

            if (ver == 0)
            {
                if (Dinheiro > FinDinheiro)
                {
                    FDinheiro = Dinheiro - FinDinheiro;
                    lblDinheiro.Text = FDinheiro.ToString();

                    compinsrt();
                    updtdin();
                }
                else
                {
                    MessageBox.Show("Você não tem dinheiro para comprar esse computador...!", "Loja", MessageBoxButtons.OK);
                }
            }
            else
            {
                ver = 0;
            }
        }

        private void compinsrt()
        {
            int Forca = Convert.ToInt32(lblForca.Text);

            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=DB-PCBuilder-Usrs;Integrated Security=True;");
            string str = "insert into COMPT(usr_compt,pcn_compt,cpu_compt,pcm_compt,fda_compt,ram_compt,gpu_compt,gab_compt,for_compt) values('" + usr + "')";
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Parabéns você acabou de comprar um computador!!", "Loja", MessageBoxButtons.OK);
        }

        private void verif()
        {
            if (String.IsNullOrEmpty(txtPCNome.Text))
            {
                MessageBox.Show("Você esqueceu de colocar o nome do seu computador!!", "Loja", MessageBoxButtons.OK);
                ver = 1;
            }
            else { }
        }
        // Fim do Insert

        private void lblForca_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblGDinheiro.Text = "0";
            lblForca.Text = "0";
            txtPCNome.Text = "";
            FinDinheiro = 0;
        }

        void updt()
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=DB-PCBuilder-Usrs;Integrated Security=True;");
            con.Open();
            string str = "select usr_usuario,din_usuario from USUARIO where usr_usuario='" + usr + "'";
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
                    break;
                }
            }
            else { }
        }

        void updtdin()
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
                        new SqlCommand("UPDATE USUARIO SET din_usuario=@Name WHERE usr_usuario='" + usr + "'", conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", FDinheiro);

                        int rows = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                //Log exception
                //Display Error message
            }
        }

        void cbxCPU()
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=DB-PCBuilder-Usrs;Integrated Security=True;");
            con.Open();
            string str = "select nome_cpu from CPU";
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
                    cbxCPX.Items.Add(nomes);
                }
            }
        }

        void cbxPCM()
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=DB-PCBuilder-Usrs;Integrated Security=True;");
            con.Open();
            string str = "select nome_pcm from PCM";
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
                    cbxPCX.Items.Add(nomes);
                }
            }
        }

        void cbxRAM()
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=DB-PCBuilder-Usrs;Integrated Security=True;");
            con.Open();
            string str = "select nome_ram from RAM";
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
                    cbxRAX.Items.Add(nomes);
                }
            }
        }

        void cbxGPU()
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=DB-PCBuilder-Usrs;Integrated Security=True;");
            con.Open();
            string str = "select nome_gpu from GPU";
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
                    cbxGPX.Items.Add(nomes);
                }
            }
        }

        void cbxFdA()
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=DB-PCBuilder-Usrs;Integrated Security=True;");
            con.Open();
            string str = "select nome_fda from FdA";
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
                    cbxFdX.Items.Add(nomes);
                }
            }
        }

        void cbxGab()
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=DB-PCBuilder-Usrs;Integrated Security=True;");
            con.Open();
            string str = "select nome_gab from GAB";
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
                    cbxGax.Items.Add(nomes);
                }
            }
        }
    }//Fim do form
}//Fim do form
