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
    public partial class frmLojaAdv : Form
    {
        string usr;

        int VTotal;
        int FTotal;

        int CVTotal;
        int CFTotal;

        int PVTotal;
        int PFTotal;

        int RVTotal;
        int RFTotal;

        int GVTotal;
        int GFTotal;

        int FVTotal;
        int FFTotal;

        int GaVTotal;
        int GaFTotal;

        public frmLojaAdv(string user)
        {
            InitializeComponent();
            string User = user.ToString();
            usr = User;

            SelectUser();
            cbxCPU();
            cbxPCM();
            cbxRAM();
            cbxGPU();
            cbxFdA();
            cbxGab();
        }

        void SelectUser()
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
                    lblDin.Text = dr[1].ToString();
                    break;
                }
            }
            else { }
        }

        void UpdtDin()
        {
            int UDin = Convert.ToInt32(lblDin.Text);

            UDin = UDin - VTotal;

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
                        cmd.Parameters.AddWithValue("@Name", UDin);

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

        void CompInsert()
        {
            string PCNome = Convert.ToString(txtPCNome.Text);

            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=DB-PCBuilder-Usrs;Integrated Security=True;");
            string str = "insert into COMPT(usr_compt,pcn_compt,cpu_compt,pcm_compt,fda_compt,ram_compt,gpu_compt,gab_compt,for_compt) values('" + usr + "','" + PCNome + "','" + cbxCPX.Text + "','" + cbxPCX.Text + "','" + cbxFdX.Text + "','" + cbxRAX.Text + "','" + cbxGPX.Text + "','" + cbxGax.Text + "','" + FTotal + "')";
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Parabéns você acabou de comprar um computador!!", "Loja", MessageBoxButtons.OK);
        }

        void VeFTotal()
        {
            VTotal = CVTotal + PVTotal + RVTotal + GVTotal + FVTotal + GaVTotal;
            FTotal = CFTotal + PFTotal + RFTotal + GFTotal + FFTotal + GaFTotal;

            lblVTotal.Text = VTotal.ToString();
            lblFTotal.Text = FTotal.ToString();
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

        private void cbxCPX_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CDin;
            string CFor;

            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=DB-PCBuilder-Usrs;Integrated Security=True;");
            con.Open();
            string str = "select nome_cpu,valor_cpu,forca_cpu from CPU where nome_cpu='" + cbxCPX.Text + "'";
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
                    CDin = dr[1].ToString();
                    CFor = dr[2].ToString();

                    int CDini = Convert.ToInt32(CDin);
                    int CFori = Convert.ToInt32(CFor);

                    CVTotal = CDini;
                    CFTotal = CFori;

                    VeFTotal();
                }
            }
            else { }
        }

        private void cbxPCX_SelectedIndexChanged(object sender, EventArgs e)
        {
            string PDin;
            string PFor;

            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=DB-PCBuilder-Usrs;Integrated Security=True;");
            con.Open();
            string str = "select nome_pcm,valor_pcm,forca_pcm from PCM where nome_pcm='" + cbxPCX.Text + "'";
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
                    PDin = dr[1].ToString();
                    PFor = dr[2].ToString();

                    int CDini = Convert.ToInt32(PDin);
                    int CFori = Convert.ToInt32(PFor);

                    PVTotal = CDini;
                    PFTotal = CFori;

                    VeFTotal();
                }
            }
            else { }
        }

        private void cbxRAX_SelectedIndexChanged(object sender, EventArgs e)
        {
            string RDin;
            string RFor;

            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=DB-PCBuilder-Usrs;Integrated Security=True;");
            con.Open();
            string str = "select nome_ram,valor_ram,forca_ram from RAM where nome_ram='" + cbxRAX.Text + "'";
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
                    RDin = dr[1].ToString();
                    RFor = dr[2].ToString();

                    int CDini = Convert.ToInt32(RDin);
                    int CFori = Convert.ToInt32(RFor);

                    RVTotal = CDini;
                    RFTotal = CFori;

                    VeFTotal();
                }
            }
            else { }
        }

        private void cbxGPX_SelectedIndexChanged(object sender, EventArgs e)
        {
            string GDin;
            string GFor;

            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=DB-PCBuilder-Usrs;Integrated Security=True;");
            con.Open();
            string str = "select nome_gpu,valor_gpu,forca_gpu from GPU where nome_gpu='" + cbxGPX.Text + "'";
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
                    GDin = dr[1].ToString();
                    GFor = dr[2].ToString();

                    int CDini = Convert.ToInt32(GDin);
                    int CFori = Convert.ToInt32(GFor);

                    GVTotal = CDini;
                    GFTotal = CFori;

                    VeFTotal();
                }
            }
            else { }
        }

        private void cbxFdX_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FDin;
            string FFor;

            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=DB-PCBuilder-Usrs;Integrated Security=True;");
            con.Open();
            string str = "select nome_fda,valor_fda,forca_fda from FdA where nome_fda='" + cbxFdX.Text + "'";
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
                    FDin = dr[1].ToString();
                    FFor = dr[2].ToString();

                    int CDini = Convert.ToInt32(FDin);
                    int CFori = Convert.ToInt32(FFor);

                    FVTotal = CDini;
                    FFTotal = CFori;

                    VeFTotal();
                }
            }
            else { }
        }

        private void cbxGax_SelectedIndexChanged(object sender, EventArgs e)
        {
            string GaDin;
            string GaFor;

            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=DB-PCBuilder-Usrs;Integrated Security=True;");
            con.Open();
            string str = "select nome_gab,valor_gab,forca_gab from GAB where nome_gab='" + cbxGax.Text + "'";
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
                    GaDin = dr[1].ToString();
                    GaFor = dr[2].ToString();

                    int CDini = Convert.ToInt32(GaDin);
                    int CFori = Convert.ToInt32(GaFor);

                    GaVTotal = CDini;
                    GaFTotal = CFori;

                    VeFTotal();
                }
            }
            else { }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            int Din = Convert.ToInt32(lblDin.Text);
            string PCNome = Convert.ToString(txtPCNome.Text);


            if (PCNome == "")
            {
                MessageBox.Show("Insira um nome para o seu PC", "Loja", MessageBoxButtons.OK);
            }
            else
            {
                if (Din >= VTotal)
                {
                    CompInsert();
                    UpdtDin();
                }
                else
                {
                    MessageBox.Show("Você não tem dinheiro para comprar esse PC", "Loja", MessageBoxButtons.OK);
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblVTotal.Text = "0";
            lblFTotal.Text = "0";
            txtPCNome.Text = "";
            cbxCPX.Text = "";
            cbxPCX.Text = "";
            cbxRAX.Text = "";
            cbxFdX.Text = "";
            cbxGPX.Text = "";
            cbxGax.Text = "";
            VTotal = 0;
            FTotal = 0;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
