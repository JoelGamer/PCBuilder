namespace projectPCBuilder0506
{
    partial class frmRegistrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsr = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.txtCSenha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxSerie = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registrar-se no Jogo do PCBuilder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Usuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Senha:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtUsr
            // 
            this.txtUsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsr.Location = new System.Drawing.Point(275, 68);
            this.txtUsr.Name = "txtUsr";
            this.txtUsr.Size = new System.Drawing.Size(135, 26);
            this.txtUsr.TabIndex = 13;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(275, 109);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(135, 26);
            this.txtSenha.TabIndex = 14;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Location = new System.Drawing.Point(85, 294);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(161, 60);
            this.btnConfirmar.TabIndex = 15;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::projectPCBuilder0506.Properties.Resources.sair;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(1, 394);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(60, 60);
            this.btnSair.TabIndex = 16;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Série:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Sexo:";
            // 
            // cbxSexo
            // 
            this.cbxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.Location = new System.Drawing.Point(275, 237);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(135, 21);
            this.cbxSexo.TabIndex = 21;
            this.cbxSexo.SelectedIndexChanged += new System.EventHandler(this.cbxSexo_SelectedIndexChanged);
            // 
            // txtCSenha
            // 
            this.txtCSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCSenha.Location = new System.Drawing.Point(275, 152);
            this.txtCSenha.Name = "txtCSenha";
            this.txtCSenha.PasswordChar = '*';
            this.txtCSenha.Size = new System.Drawing.Size(135, 26);
            this.txtCSenha.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(80, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Confirmar Senha:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cbxSerie
            // 
            this.cbxSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSerie.FormattingEnabled = true;
            this.cbxSerie.Location = new System.Drawing.Point(275, 198);
            this.cbxSerie.Name = "cbxSerie";
            this.cbxSerie.Size = new System.Drawing.Size(135, 21);
            this.cbxSerie.TabIndex = 24;
            this.cbxSerie.SelectedIndexChanged += new System.EventHandler(this.cbxSerie_SelectedIndexChanged_1);
            // 
            // frmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::projectPCBuilder0506.Properties.Resources.bgcolor3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 453);
            this.Controls.Add(this.cbxSerie);
            this.Controls.Add(this.txtCSenha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxSexo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar";
            this.Load += new System.EventHandler(this.frmRegistrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsr;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxSexo;
        private System.Windows.Forms.TextBox txtCSenha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxSerie;
    }
}