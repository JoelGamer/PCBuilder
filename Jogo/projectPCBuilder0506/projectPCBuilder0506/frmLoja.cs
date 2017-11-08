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
        int LForca;
        int CDin;
        int PDin;
        int RDin;
        int GDin;
        int FDin;
        int GBDin;
        int CFor;
        int PFor;
        int RFor;
        int GFor;
        int FFor;
        int GBFor;
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
        }

        private void frmLoja_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        //
        // Inicio da Compra das peças
        //

        private void CPUs()
        {
            if (rbtC1.Checked == true)
            {
                CDin = +5000;
                CFor = +500;
                lblCPU.Text = "Intel Atom";
                Dinheiro();
            }

            if (rbtC2.Checked == true)
            {
                CDin = +6500;
                CFor = +1000;
                lblCPU.Text = "Intel Pentium";
                Dinheiro();
            }

            if (rbtC3.Checked == true)
            {
                CDin = +7900;
                CFor = +1500;
                lblCPU.Text = "Intel Core I3 1ºGer";
                Dinheiro();
            }

            if (rbtC4.Checked == true)
            {
                CDin = +10000;
                CFor = +2000;
                lblCPU.Text = "Intel Core I3 2ºGer";
                Dinheiro();
            }

            if (rbtC5.Checked == true)
            {
                CDin = +13000;
                CFor = +2500;
                lblCPU.Text = "Intel Core I3 3ºGer";
                Dinheiro();
            }

            if (rbtC6.Checked == true)
            {
                CDin = +15500;
                CFor = +3000;
                lblCPU.Text = "Intel Core I5 1ºGer";
                Dinheiro();
            }

            if (rbtC7.Checked == true)
            {
                CDin = +17600;
                CFor = +3500;
                lblCPU.Text = "Intel Core I5 2ºGer";
                Dinheiro();
            }

            if (rbtC8.Checked == true)
            {
                CDin = +19500;
                CFor = +4000;
                lblCPU.Text = "Intel Core I5 3ºGer";
                Dinheiro();
            }

            if (rbtC9.Checked == true)
            {
                CDin = +22000;
                CFor = +4500;
                lblCPU.Text = "Intel Core I7 1ºGer";
                Dinheiro();
            }

            if (rbtC10.Checked == true)
            {
                CDin = +25000;
                CFor = +5000;
                lblCPU.Text = "Intel Core I7 2ºGer";
                Dinheiro();
            }

            if (rbtC11.Checked == true)
            {
                CDin = +27700;
                CFor = +5500;
                lblCPU.Text = "Intel Core I7 3ºGer";
                Dinheiro();
            }

            if (rbtC12.Checked == true)
            {
                CDin = +31000;
                CFor = +6000;
                lblCPU.Text = "Intel Core I7 Extreme Edition";
                Dinheiro();
            }
        }

        private void PCM()
        {
            if (rbtPCM1.Checked == true)
            {
                PDin = 3500;
                PFor = 500;
                lblPCM.Text = "Gigabyte B150s";
                Dinheiro();
            }

            if (rbtPCM2.Checked == true)
            {
                PDin = 5500;
                PFor = 1000;
                lblPCM.Text = "Gigabyte H150s";
                Dinheiro();
            }

            if (rbtPCM3.Checked == true)
            {
                PDin = 7800;
                PFor = 1500;
                lblPCM.Text = "Gigabyte Z150s";
                Dinheiro();
            }

            if (rbtPCM4.Checked == true)
            {
                PDin = 11000;
                PFor = 2000;
                lblPCM.Text = "Gigabyte ProGaming H1650";
                Dinheiro();
            }

            if (rbtPCM5.Checked == true)
            {
                PDin = 13500;
                PFor = 2500;
                lblPCM.Text = "Gigabyte ProGaming Z2300";
                Dinheiro();
            }

            if (rbtPCM6.Checked == true)
            {
                PDin = 17500;
                PFor = 3000;
                lblPCM.Text = "Gigabyte Extreme Edition Z3000";
                Dinheiro();
            }

            if (rbtPCM7.Checked == true)
            {
                PDin = 4000;
                PFor = 1000;
                lblPCM.Text = "Asus H280";
                Dinheiro();
            }

            if (rbtPCM8.Checked == true)
            {
                PDin = 6000;
                PFor = 1500;
                lblPCM.Text = "Asus Y280s";
                Dinheiro();
            }

            if (rbtPCM9.Checked == true)
            {
                PDin = 8300;
                PFor = 2000;
                lblPCM.Text = "Asus A320";
                Dinheiro();
            }

            if (rbtPCM10.Checked == true)
            {
                PDin = 11500;
                PFor = 2500;
                lblPCM.Text = "Asus Professional Y3600s";
                Dinheiro();
            }

            if (rbtPCM11.Checked == true)
            {
                PDin = 14000;
                PFor = 3000;
                lblPCM.Text = "Asus Professional A4100s";
                Dinheiro();
            }

            if (rbtPCM12.Checked == true)
            {
                PDin = 18500;
                PFor = 3500;
                lblPCM.Text = "Asus Edição Limitada A5200s";
                Dinheiro();
            }
        }

        private void RAM()
        { 
            if (rbtRAM1.Checked == true)
            {
                RDin = 1500;
                RFor = 500;
                lblRAM.Text = "HiperX RGB 2GB";
                Dinheiro();
            }

            if (rbtRAM2.Checked == true)
            {
                RDin = 3500;
                RFor = 1000;
                lblRAM.Text = "HiperX RGB 4GB";
                Dinheiro();
            }

            if (rbtRAM3.Checked == true)
            {
                RDin = 6000;
                RFor = 1500;
                lblRAM.Text = "HiperX RGB 8GB";
                Dinheiro();
            }

            if (rbtRAM4.Checked == true)
            {
                RDin = 8500;
                RFor = 2000;
                lblRAM.Text = "HiperX RGB 16GB";
                Dinheiro();
            }

            if (rbtRAM5.Checked == true)
            {
                RDin = 10500;
                RFor = 2500;
                lblRAM.Text = "HiperX RGB 32GB";
                Dinheiro();
            }

            if (rbtRAM6.Checked == true)
            {
                RDin = 12000;
                RFor = 3000;
                lblRAM.Text = "HiperX RGB 64GB";
                Dinheiro();
            }

            if (rbtRAM7.Checked == true)
            {
                RDin = 2000;
                RFor = 1000;
                lblRAM.Text = "Corsair 2GB";
                Dinheiro();
            }

            if (rbtRAM8.Checked == true)
            {
                RDin = 4500;
                RFor = 1500;
                lblRAM.Text = "Corsair 4GB";
                Dinheiro();
            }

            if (rbtRAM9.Checked == true)
            {
                RDin = 6000;
                RFor = 2000;
                lblRAM.Text = "Corsair 8GB";
                Dinheiro();
            }

            if (rbtRAM10.Checked == true)
            {
                RDin = 9500;
                RFor = 2500;
                lblRAM.Text = "Corsair 16GB";
                Dinheiro();
            }

            if (rbtRAM11.Checked == true)
            {
                RDin = 11000;
                RFor = 3000;
                lblRAM.Text = "Corsair 32GB";
                Dinheiro();
            }

            if (rbtRAM12.Checked == true)
            {
                RDin = 13000;
                RFor = 3500;
                lblRAM.Text = "Corsair 64GB";
                Dinheiro();
            }
        }

        private void GPU()
        {
            if (rbtCG1.Checked == true)
            {
                GDin = 4000;
                LForca = 500;
                lblGPU.Text = "GT 740 510MB";
                Dinheiro();
            }

            if (rbtCG2.Checked == true)
            {
                GDin = 5500;
                LForca = 1000;
                lblGPU.Text = "GT 840 1GB";
                Dinheiro();
            }

            if (rbtCG3.Checked == true)
            {
                GDin = 7500;
                GFor = 1500;
                lblGPU.Text = "GTX 750 1.5GB";
                Dinheiro();
            }

            if (rbtCG4.Checked == true)
            {
                GDin = 9500;
                GFor = 2000;
                lblGPU.Text = "GTX 950 2GB";
                Dinheiro();
            }

            if (rbtCG5.Checked == true)
            {
                GDin = 11000;
                GFor = 2500;
                lblGPU.Text = "GTX 960 3GB";
                Dinheiro();
            }

            if (rbtCG6.Checked == true)
            {
                GDin = 13500;
                GFor = 3000;
                lblGPU.Text = "GTX 970 4GB";
                Dinheiro();
            }

            if (rbtCG7.Checked == true)
            {
                GDin = 17500;
                GFor = 3500;
                lblGPU.Text = "GTX 980 4.5GB";
                Dinheiro();
            }

            if (rbtCG8.Checked == true)
            {
                GDin = 20000;
                GFor = 4000;
                lblGPU.Text = "GTX 1050 3GB";
                Dinheiro();
            }

            if (rbtCG9.Checked == true)
            {
                GDin = 22500;
                GFor = 4500;
                lblGPU.Text = "GTX 1060 4GB";
                Dinheiro();
            }

            if (rbtCG10.Checked == true)
            {
                GDin = 26500;
                GFor = 5000;
                lblGPU.Text = "GTX 1070 6GB";
                Dinheiro();
            }

            if (rbtCG11.Checked == true)
            {
                GDin = 29500;
                GFor = 5500;
                lblGPU.Text = "TITAN Z 8GB";
                Dinheiro();
            }

            if (rbtCG12.Checked == true)
            {
                GDin = 32000;
                GFor = 6000;
                lblGPU.Text = "GTX 1080TI 11GB";
                Dinheiro();

            }
        }

        private void FdA()
        {
            if (rbtF1.Checked == true)
            {
                FDin = 2500;
                FFor = 500;
                lblFdA.Text = "XT 300W";
                Dinheiro();
            }

            if (rbtF2.Checked == true)
            {
                FDin = 4000;
                FFor = 1000;
                lblFdA.Text = "XT 450W";
                Dinheiro();
            }

            if (rbtF3.Checked == true)
            {
                FDin = 7250;
                FFor = 1500;
                lblFdA.Text = "XT 600W Edição Bronze";
                Dinheiro();
            }

            if (rbtF4.Checked == true)
            {
                FDin = 10000;
                FFor = 2000;
                lblFdA.Text = "XT 850W Edição Prata";
                Dinheiro();
            }

            if (rbtF5.Checked == true)
            {
                FDin = 12000;
                FFor = 2500;
                lblFdA.Text = "XT 1050W Edição Dourada";
                Dinheiro();
            }

            if (rbtF6.Checked == true)
            {
                FDin = 15000;
                FFor = 3000;
                lblFdA.Text = "XT 1250W Edição Platina";
                Dinheiro();
            }

            if (rbtF7.Checked == true)
            {
                FDin = 3000;
                FFor = 1000;
                lblFdA.Text = "EVGA 300W";
                Dinheiro();
            }

            if (rbtF8.Checked == true)
            {
                FDin = 4500;
                FFor = 1500;
                lblFdA.Text = "EVGA 450W";
                Dinheiro();
            }

            if (rbtF9.Checked == true)
            {
                FDin = 7750;
                FFor = 2000;
                lblFdA.Text = "EVGA 600W Edição Bronze";
                Dinheiro();
            }

            if (rbtF10.Checked == true)
            {
                FDin = 10500;
                FFor = 2500;
                lblFdA.Text = "EVGA 850W Edição Prata";
                Dinheiro();
            }

            if (rbtF11.Checked == true)
            {
                FDin = 12500;
                FFor = 3000;
                lblFdA.Text = "EVGA 1050W Edição Dourada";
                Dinheiro();
            }

            if (rbtF12.Checked == true)
            {
                FDin = 15500;
                FFor = 3500;
                lblFdA.Text = "EVGA 1250W Edição Platina";
                Dinheiro();
            }
        }

        private void Gab()
        {
            if (rbtGB1.Checked == true)
            {
                GBDin = 2500;
                GBFor = 500;
                lblGab.Text = "Thermaltake Level 10";
                Dinheiro();
            }

            if (rbtGB2.Checked == true)
            {
                GBDin = 4000;
                GBFor = 1000;
                lblGab.Text = "Cooler Master HAF X";
                Dinheiro();
            }

            if (rbtGB3.Checked == true)
            {
                GBDin = 7250;
                GBFor = 1500;
                lblGab.Text = "SilverStone Temjin TJ11";
                Dinheiro();
            }

            if (rbtGB4.Checked == true)
            {
                GBDin = 10000;
                GBFor = 2000;
                lblGab.Text = "Themaltake VN 1000V";
                Dinheiro();
            }

            if (rbtGB5.Checked == true)
            {
                GBDin = 12000;
                GBFor = 2500;
                lblGab.Text = "NZXT H2 Silent Midtower";
                Dinheiro();
            }

            if (rbtGB6.Checked == true)
            {
                GBDin = 15000;
                GBFor = 3000;
                lblGab.Text = "Cooler Master Silencio 550";
                Dinheiro();
            }

            if (rbtGB7.Checked == true)
            {
                GBDin = 3000;
                GBFor = 1000;
                lblGab.Text = "Java Cross 450";
                Dinheiro();
            }

            if (rbtGB8.Checked == true)
            {
                GBDin = 4500;
                GBFor = 1500;
                lblGab.Text = "Mathe's Uncle 320";
                Dinheiro();
            }

            if (rbtGB9.Checked == true)
            {
                GBDin = 7750;
                GBFor = 2000;
                lblGab.Text = "Bluecase BG-024";
                Dinheiro();
            }

            if (rbtGB10.Checked == true)
            {
                GBDin = 10500;
                GBFor = 2500;
                lblGab.Text = "Corsair Alpha";
                Dinheiro();
            }

            if (rbtGB11.Checked == true)
            {
                GBDin = 12500;
                GBFor = 3000;
                lblGab.Text = "Sharkoon TG5";
                Dinheiro();
            }

            if (rbtGB12.Checked == true)
            {
                GBDin = 15500;
                GBFor = 3500;
                lblGab.Text = "ATX MidTower";
                Dinheiro();
            }
        }

        //
        // Fim da compra das peças
        //

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
            string str = "insert into COMPT(usr_compt,pcn_compt,cpu_compt,pcm_compt,fda_compt,ram_compt,gpu_compt,gab_compt,for_compt) values('" + usr + "','" + txtPCNome.Text + "','" + lblCPU.Text + "','" + lblPCM.Text + "','" + lblFdA.Text + "','" + lblRAM.Text + "','" + lblGPU.Text + "','" + lblGab.Text + "','"+ Forca +"')";
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
            if (String.IsNullOrEmpty(lblCPU.Text))
            {
                MessageBox.Show("Você esqueceu de colocar o CPU!!", "Loja", MessageBoxButtons.OK);
                ver = 1;
            }
            else { }
            if (String.IsNullOrEmpty(lblPCM.Text))
            {
                MessageBox.Show("Você esqueceu de colocar a Placa Mãe!!", "Loja", MessageBoxButtons.OK);
                ver = 1;
            }
            else { }
            if (String.IsNullOrEmpty(lblGPU.Text))
            {
                MessageBox.Show("Você esqueceu de colocar o GPU!!", "Loja", MessageBoxButtons.OK);
                ver = 1;
            }
            else { }
            if (String.IsNullOrEmpty(lblRAM.Text))
            {
                MessageBox.Show("Você esqueceu de colocar a RAM!!", "Loja", MessageBoxButtons.OK);
                ver = 1;
            }
            else { }
            if (String.IsNullOrEmpty(lblFdA.Text))
            {
                MessageBox.Show("Você esqueceu de colocar a Fonte de Alimentação!!", "Loja", MessageBoxButtons.OK);
                ver = 1;
            }
            else { }
            if (String.IsNullOrEmpty(lblGab.Text))
            {
                MessageBox.Show("Você esqueceu de colocar o Gabinete!!", "Loja", MessageBoxButtons.OK);
                ver = 1;
            }
            else { }
        }
        // Fim do Insert

        private void btnCCPU_Click(object sender, EventArgs e)
        {
            CPUs();
        }

        private void btnCFdA_Click(object sender, EventArgs e)
        {
            FdA();
        }

        private void btnCPCM_Click(object sender, EventArgs e)
        {
            PCM();
        }

        private void btnCRAM_Click(object sender, EventArgs e)
        {
            RAM();
        }

        private void btnCGPU_Click(object sender, EventArgs e)
        {
            GPU();
        }

        void Dinheiro()
        {
            FinDinheiro = CDin + PDin + RDin + GDin + FDin + GBDin;
            LForca = CFor + PFor + RFor + GFor + FFor + GBFor;

            lblGDinheiro.Text = FinDinheiro.ToString();
            lblForca.Text = LForca.ToString();
        }

        private void gpbFdA_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton38_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gpbCPU_Enter(object sender, EventArgs e)
        {

        }

        private void lblForca_Click(object sender, EventArgs e)
        {

        }

        private void btnSelecionarGab_Click(object sender, EventArgs e)
        {
            Gab();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblCPU.Text = "";
            lblPCM.Text = "";
            lblRAM.Text = "";
            lblGPU.Text = "";
            lblFdA.Text = "";
            lblGab.Text = "";
            lblGDinheiro.Text = "0";
            lblForca.Text = "0";
            txtPCNome.Text = "";
            FinDinheiro = 0;
            LForca = 0;
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

        private void rbtGB3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
