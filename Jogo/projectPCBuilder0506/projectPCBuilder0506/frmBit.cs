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
    public partial class frmBit : Form
    {
        string usr;
        int FUpgrade;
        long FDinheiro;
        int FBitm;
        int FBit;

        public frmBit(string user)
        {
            InitializeComponent();
            string User = user.ToString();
            usr = User;

            updt();
        }

        public frmBit(string user, int bit)
        {
            InitializeComponent();
            string User = user;
            int Bit = bit;
            usr = User;
            FBit = Bit;

            lblBitcoin.Text = FBit.ToString();
            updt();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnLiDe_Click(object sender, EventArgs e)
        {
            int upg = Convert.ToInt32(lblUpgrade.Text);

            updtbitm();

            frmBitMin frm = new frmBitMin(usr,upg);
            frm.Show();
            Close();
        }
        
        
        private void tmrBit_Tick(object sender, EventArgs e)
        {
            //Inativo 
        }

        private void btnConv_Click(object sender, EventArgs e)
        {
            int BDinheiro;
            long UDinheiro = Convert.ToInt64(lblDinheiro.Text);
            int Bit = Convert.ToInt16(lblBitcoin.Text);

            bitmup();

            BDinheiro = Bit * 2000;
            Bit = 0;
            FBit = Bit;
            FDinheiro = UDinheiro + BDinheiro;

            lblDinheiro.Text = FDinheiro.ToString();
            lblBitcoin.Text = FBit.ToString();
        }

        private void frmBit_Load(object sender, EventArgs e)
        {

        }

        private void btnApri_Click(object sender, EventArgs e)
        {
            int Dinheiro = Convert.ToInt32(lblDinheiro.Text);
            int Upgrade = Convert.ToInt32(lblUpgrade.Text);

            FUpgrade = Upgrade * 100000;

            if (Dinheiro >= FUpgrade)
            {
                FDinheiro = Dinheiro - FUpgrade;
                FUpgrade = Upgrade + 1;

                lblUpgrade.Text = FUpgrade.ToString();
                lblDinheiro.Text = FDinheiro.ToString();
            }
            else
            {
                MessageBox.Show("Você não term dinheiro para aprimorar o minerador!", "Aprimorar", MessageBoxButtons.OK);
            }


        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            int Bitcoin = Convert.ToInt32(lblBitcoin.Text);

            if (Bitcoin >= 1)
            {
                MessageBox.Show("Não se esqueca de converter os Bitcoin(s) se não vão ser roubados!!!", "!!!!", MessageBoxButtons.OK);
            }
            else
            {
                if(FDinheiro == 0 && FBitm == 0)
                {
                    Close();
                }
                else
                {
                    updtbit();
                    Close();
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        void bitmup()
        {
            int Bit = Convert.ToInt32(lblBitm.Text);

            FBitm = Bit + FBit;

            lblBitm.Text = FBitm.ToString();
        }

        void updt()
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=DB-PCBuilder-Usrs;Integrated Security=True;");
            con.Open();
            string str = "select usr_usuario,din_usuario,upg_usuario,bitm_usuario from USUARIO where usr_usuario='" + usr + "'";
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
                    lblUpgrade.Text = dr[2].ToString();
                    lblBitm.Text = dr[3].ToString();
                    break;
                }
            }
            else { }
        }

        void updtbit()
        {
            int MUpg = Convert.ToInt32(lblUpgrade.Text);

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
                        new SqlCommand("UPDATE USUARIO SET din_usuario=@Din,bitm_usuario=@Bit WHERE usr_usuario='" + usr + "'", conn))
                    {
                        cmd.Parameters.AddWithValue("@Din", FDinheiro);
                        cmd.Parameters.AddWithValue("@Bit", FBitm);
                        cmd.Parameters.AddWithValue("@Bit", MUpg);

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

        void updtbitm()
        {
            long MDinheiro = Convert.ToInt64(lblDinheiro.Text);
            int MBitm = Convert.ToInt32(lblBitm.Text);
            int MUpg = Convert.ToInt32(lblUpgrade.Text);

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
                        new SqlCommand("UPDATE USUARIO SET din_usuario=@Din,bitm_usuario=@Bit,upg_usuario=@Upg WHERE usr_usuario='" + usr + "'", conn))
                    {
                        cmd.Parameters.AddWithValue("@Din", MDinheiro);
                        cmd.Parameters.AddWithValue("@Bit", MBitm);
                        cmd.Parameters.AddWithValue("@Upg", MUpg);

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
    }
}
