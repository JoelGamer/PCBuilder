namespace projectPCBuilder0506
{
    partial class frmHackear
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
            this.lblInt = new System.Windows.Forms.Label();
            this.btnServers = new System.Windows.Forms.Button();
            this.lblLix = new System.Windows.Forms.Label();
            this.btnPC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.BackColor = System.Drawing.Color.Transparent;
            this.lblInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInt.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInt.Location = new System.Drawing.Point(335, 169);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(65, 15);
            this.lblInt.TabIndex = 95;
            this.lblInt.Text = "Servidores";
            // 
            // btnServers
            // 
            this.btnServers.BackColor = System.Drawing.Color.White;
            this.btnServers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnServers.FlatAppearance.BorderSize = 0;
            this.btnServers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServers.Location = new System.Drawing.Point(338, 114);
            this.btnServers.Name = "btnServers";
            this.btnServers.Size = new System.Drawing.Size(55, 55);
            this.btnServers.TabIndex = 94;
            this.btnServers.UseVisualStyleBackColor = false;
            // 
            // lblLix
            // 
            this.lblLix.AutoSize = true;
            this.lblLix.BackColor = System.Drawing.Color.Transparent;
            this.lblLix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLix.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLix.Location = new System.Drawing.Point(23, 169);
            this.lblLix.Name = "lblLix";
            this.lblLix.Size = new System.Drawing.Size(32, 15);
            this.lblLix.TabIndex = 93;
            this.lblLix.Text = "PC\'s";
            // 
            // btnPC
            // 
            this.btnPC.BackColor = System.Drawing.Color.White;
            this.btnPC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPC.FlatAppearance.BorderSize = 0;
            this.btnPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPC.Location = new System.Drawing.Point(12, 114);
            this.btnPC.Name = "btnPC";
            this.btnPC.Size = new System.Drawing.Size(55, 55);
            this.btnPC.TabIndex = 92;
            this.btnPC.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 31);
            this.label1.TabIndex = 96;
            this.label1.Text = "Hackear";
            // 
            // frmHackear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(405, 196);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInt);
            this.Controls.Add(this.btnServers);
            this.Controls.Add(this.lblLix);
            this.Controls.Add(this.btnPC);
            this.Name = "frmHackear";
            this.Text = "Hackear";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.Button btnServers;
        private System.Windows.Forms.Label lblLix;
        private System.Windows.Forms.Button btnPC;
        private System.Windows.Forms.Label label1;
    }
}