namespace projectPCBuilder0506
{
    partial class frmMusicasAdv
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
            this.cbxMusicas = new System.Windows.Forms.ComboBox();
            this.tbrVolume = new System.Windows.Forms.TrackBar();
            this.btnVolt = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbrVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxMusicas
            // 
            this.cbxMusicas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMusicas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMusicas.FormattingEnabled = true;
            this.cbxMusicas.Location = new System.Drawing.Point(12, 85);
            this.cbxMusicas.Name = "cbxMusicas";
            this.cbxMusicas.Size = new System.Drawing.Size(204, 33);
            this.cbxMusicas.Sorted = true;
            this.cbxMusicas.TabIndex = 16;
            this.cbxMusicas.SelectedIndexChanged += new System.EventHandler(this.cbxMusicas_SelectedIndexChanged);
            // 
            // tbrVolume
            // 
            this.tbrVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.tbrVolume.Location = new System.Drawing.Point(525, 246);
            this.tbrVolume.Maximum = 100;
            this.tbrVolume.Name = "tbrVolume";
            this.tbrVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrVolume.Size = new System.Drawing.Size(45, 100);
            this.tbrVolume.TabIndex = 15;
            // 
            // btnVolt
            // 
            this.btnVolt.BackgroundImage = global::projectPCBuilder0506.Properties.Resources.musicavolt;
            this.btnVolt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolt.FlatAppearance.BorderSize = 0;
            this.btnVolt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolt.Location = new System.Drawing.Point(129, 286);
            this.btnVolt.Name = "btnVolt";
            this.btnVolt.Size = new System.Drawing.Size(60, 60);
            this.btnVolt.TabIndex = 14;
            this.btnVolt.UseVisualStyleBackColor = true;
            this.btnVolt.Click += new System.EventHandler(this.btnVolt_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.BackgroundImage = global::projectPCBuilder0506.Properties.Resources.musicaskip;
            this.btnSkip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSkip.FlatAppearance.BorderSize = 0;
            this.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkip.Location = new System.Drawing.Point(375, 286);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(60, 60);
            this.btnSkip.TabIndex = 13;
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(232, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "Músicas";
            // 
            // btnStop
            // 
            this.btnStop.BackgroundImage = global::projectPCBuilder0506.Properties.Resources.musicapse;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Location = new System.Drawing.Point(297, 286);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(60, 60);
            this.btnStop.TabIndex = 11;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackgroundImage = global::projectPCBuilder0506.Properties.Resources.muscstp;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Location = new System.Drawing.Point(210, 286);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(60, 60);
            this.btnPause.TabIndex = 10;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Visible = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImage = global::projectPCBuilder0506.Properties.Resources.musicastart;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(210, 286);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(60, 60);
            this.btnStart.TabIndex = 9;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmMusicasAdv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(582, 356);
            this.Controls.Add(this.cbxMusicas);
            this.Controls.Add(this.tbrVolume);
            this.Controls.Add(this.btnVolt);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Name = "frmMusicasAdv";
            this.Text = "Musicas";
            this.Load += new System.EventHandler(this.frmMusicasAdv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbrVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxMusicas;
        private System.Windows.Forms.TrackBar tbrVolume;
        private System.Windows.Forms.Button btnVolt;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
    }
}