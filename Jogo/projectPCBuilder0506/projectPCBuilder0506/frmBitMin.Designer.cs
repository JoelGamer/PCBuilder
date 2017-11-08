namespace projectPCBuilder0506
{
    partial class frmBitMin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBitMin));
            this.label1 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBitcoin = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(219, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minerador";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.BackColor = System.Drawing.Color.Transparent;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.ForeColor = System.Drawing.SystemColors.Control;
            this.lblX.Location = new System.Drawing.Point(193, 95);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(0, 26);
            this.lblX.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(131, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Calcular a soma dos dois números";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(239, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "+";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.BackColor = System.Drawing.Color.Transparent;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.ForeColor = System.Drawing.SystemColors.Control;
            this.lblY.Location = new System.Drawing.Point(266, 95);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(0, 26);
            this.lblY.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(312, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "=";
            // 
            // txtResposta
            // 
            this.txtResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResposta.Location = new System.Drawing.Point(343, 92);
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.ReadOnly = true;
            this.txtResposta.Size = new System.Drawing.Size(42, 32);
            this.txtResposta.TabIndex = 6;
            this.txtResposta.Text = "0";
            this.txtResposta.TextChanged += new System.EventHandler(this.txtResposta_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bitcoin(s) Minerados:";
            // 
            // lblBitcoin
            // 
            this.lblBitcoin.AutoSize = true;
            this.lblBitcoin.BackColor = System.Drawing.Color.Transparent;
            this.lblBitcoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBitcoin.ForeColor = System.Drawing.Color.White;
            this.lblBitcoin.Location = new System.Drawing.Point(229, 293);
            this.lblBitcoin.Name = "lblBitcoin";
            this.lblBitcoin.Size = new System.Drawing.Size(24, 26);
            this.lblBitcoin.TabIndex = 8;
            this.lblBitcoin.Text = "0";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.BackgroundImage = global::projectPCBuilder0506.Properties.Resources.bitconfirmar;
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Location = new System.Drawing.Point(12, 161);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(60, 60);
            this.btnConfirmar.TabIndex = 11;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.Control;
            this.btnVoltar.BackgroundImage = global::projectPCBuilder0506.Properties.Resources.sair;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(461, 268);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(60, 60);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciar.BackgroundImage = global::projectPCBuilder0506.Properties.Resources.bitstart;
            this.btnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Location = new System.Drawing.Point(12, 95);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(60, 60);
            this.btnIniciar.TabIndex = 9;
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // frmBitMin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.BackgroundImage = global::projectPCBuilder0506.Properties.Resources.mining;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(520, 328);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblBitcoin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResposta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBitMin";
            this.Text = "Minerador";
            this.Load += new System.EventHandler(this.frmBitMin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBitcoin;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnConfirmar;
    }
}