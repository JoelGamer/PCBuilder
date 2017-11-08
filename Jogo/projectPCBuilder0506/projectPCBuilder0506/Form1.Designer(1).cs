namespace projectPCBuilder0506
{
    partial class frmStartup
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStartup));
            this.pgbStartup = new System.Windows.Forms.ProgressBar();
            this.tmrBar = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pgbStartup
            // 
            this.pgbStartup.Location = new System.Drawing.Point(12, 264);
            this.pgbStartup.Name = "pgbStartup";
            this.pgbStartup.Size = new System.Drawing.Size(463, 23);
            this.pgbStartup.TabIndex = 0;
            // 
            // tmrBar
            // 
            this.tmrBar.Interval = 1;
            this.tmrBar.Tick += new System.EventHandler(this.progressBar1_Click);
            // 
            // frmStartup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projectPCBuilder0506.Properties.Resources.pcpcpcpcpcpcpcpcpc;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(487, 299);
            this.Controls.Add(this.pgbStartup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStartup";
            this.Text = "PC Builder";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbStartup;
        private System.Windows.Forms.Timer tmrBar;

    }
}

