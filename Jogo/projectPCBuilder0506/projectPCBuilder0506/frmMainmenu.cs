﻿using System;
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
    public partial class frmMainmenu : Form
    {
        string usr;
        int clk;

        public frmMainmenu(string user)
        {
            InitializeComponent();
            string User = user.ToString();
            usr = User;
        }
        
        private void btnPerfil_Click(object sender, EventArgs e)
        {
            frmPerfil frm = new frmPerfil(usr);
            frm.Show();
        }

        private void frmProjeto_Load(object sender, EventArgs e)
        {

        }

        private void btnOfficina_Click(object sender, EventArgs e)
        {
            frmLoja frm = new frmLoja(usr);
            frm.Show();
        }

        private void btnConquista_Click(object sender, EventArgs e)
        {
            frmConquistas frm = new frmConquistas(usr);
            frm.Show();
        }

        private void btnLix_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tem nada aqui, Fon!", "Lixeira", MessageBoxButtons.OK);
        }

        private void btnInternet_Click(object sender, EventArgs e)
        { 
            frmInternet frm = new frmInternet(usr);
            frm.Show();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(clk == 1)
            {
                btnSair.Visible = false;
                btnPDF.Visible = false;
                btnCriadores.Visible = false;
                gpbPDF.Visible = false;
                Application.DoEvents();
                clk = 0;
            }
            else
            {
                btnSair.Visible = true;
                btnPDF.Visible = true;
                btnCriadores.Visible = true;
                Application.DoEvents();
                clk = 1;
            }           
        }

        private void btnCriadores_Click(object sender, EventArgs e)
        {
            frmCriadores frm = new frmCriadores();
            frm.Show();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(gpbPDF.Visible == true)
            {
                gpbPDF.Visible = false;
            }
            else
            {
                gpbPDF.Visible = true;
            }          
        }

        private void PDF1_click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.colorful;
            menub();
        }

        private void PDF2_click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.bgblack;
            menub();
        }

        private void PDF3_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.bgcolor3;
            menuw();
        }

        private void PDF4_click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.picole;
            menub();

        }

        void menuw()
        {
            btnSair.BackColor = Color.White;
            btnSair.ForeColor = Color.Black;
            btnPDF.BackColor = Color.White;
            btnPDF.ForeColor = Color.Black;
            btnCriadores.BackColor = Color.White;
            btnCriadores.ForeColor = Color.Black;
            btnMenu.BackgroundImage = Properties.Resources.menuw;
        }

        void menub()
        {
            btnSair.BackColor = Color.Black;
            btnSair.ForeColor = Color.White;
            btnPDF.BackColor = Color.Black;
            btnPDF.ForeColor = Color.White;
            btnCriadores.BackColor = Color.Black;
            btnCriadores.ForeColor = Color.White;
            btnMenu.BackgroundImage = Properties.Resources.menu;
        }
    }
}
