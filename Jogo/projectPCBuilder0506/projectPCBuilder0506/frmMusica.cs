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
using WMPLib;


namespace projectPCBuilder0506
{
    public partial class frmMusica : Form
    {
        string extencao;

        WindowsMediaPlayer player = new WindowsMediaPlayer();
       
        public frmMusica()
        {
            InitializeComponent();
            cbxMusica();
        }

        private void frmMusica_Load(object sender, EventArgs e)
        {
            int Volume = 20;

            player.settings.volume = Volume;
            tbrVolume.Value = Volume;         
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (extencao == null)
            {
                MessageBox.Show("Escolha uma música para ser reproduzido", "Música", MessageBoxButtons.OK);

                
            }
            else
            {
                player.controls.play();
                player.URL = extencao;
                btnPause.Visible = true;
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            player.controls.pause();
            btnPause.Visible = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            btnPause.Visible = false;
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            player.controls.next();
        }

        private void btnVolt_Click(object sender, EventArgs e)
        {
            player.controls.previous();
        }

        private void tbrVolume_Scroll(object sender, EventArgs e)
        {
            int Volume = Convert.ToInt16(tbrVolume.Value);

            player.settings.volume = Volume;
        }

        void cbxMusica()
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=DB-PCBuilder-Usrs;Integrated Security=True;");
            con.Open();
            string str = "select nome_musica from MUSICAS";
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
                    string musicas = dr.GetString(0);
                    cbxMusicas.Items.Add(musicas);
                }
            }
        }

        private void cbxMusicas_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=DB-PCBuilder-Usrs;Integrated Security=True;");
            con.Open();
            string str = "select nome_musica,exten_musica from MUSICAS where nome_musica='" + cbxMusicas.Text + "'";
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
                    extencao = dr[1].ToString();
                    player.controls.stop();
                    btnPause.Visible = false;
                    player.controls.play();
                    player.URL = extencao;
                    btnPause.Visible = true;
                    break;
                }
            }
        }
    }
}
