namespace projectPCBuilder0506
{
    partial class frmChatGeral
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
            this.txtMsgBox = new System.Windows.Forms.TextBox();
            this.txtSendMsg = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.ReceiveMsgs = new System.ComponentModel.BackgroundWorker();
            this.tmrConnect = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtMsgBox
            // 
            this.txtMsgBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtMsgBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMsgBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsgBox.ForeColor = System.Drawing.Color.White;
            this.txtMsgBox.Location = new System.Drawing.Point(12, 12);
            this.txtMsgBox.Multiline = true;
            this.txtMsgBox.Name = "txtMsgBox";
            this.txtMsgBox.ReadOnly = true;
            this.txtMsgBox.Size = new System.Drawing.Size(527, 386);
            this.txtMsgBox.TabIndex = 7;
            // 
            // txtSendMsg
            // 
            this.txtSendMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.txtSendMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSendMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSendMsg.ForeColor = System.Drawing.Color.White;
            this.txtSendMsg.Location = new System.Drawing.Point(12, 405);
            this.txtSendMsg.Name = "txtSendMsg";
            this.txtSendMsg.Size = new System.Drawing.Size(446, 25);
            this.txtSendMsg.TabIndex = 8;
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(464, 405);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 25);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // ReceiveMsgs
            // 
            this.ReceiveMsgs.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ReceiveMsgs_DoWork);
            // 
            // tmrConnect
            // 
            this.tmrConnect.Interval = 500;
            this.tmrConnect.Tick += new System.EventHandler(this.tmrConnect_Tick);
            // 
            // frmChatGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(551, 442);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSendMsg);
            this.Controls.Add(this.txtMsgBox);
            this.Name = "frmChatGeral";
            this.Text = "Chat Geral";
            this.Load += new System.EventHandler(this.frmChatGeral_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMsgBox;
        private System.Windows.Forms.TextBox txtSendMsg;
        private System.Windows.Forms.Button btnSend;
        private System.ComponentModel.BackgroundWorker ReceiveMsgs;
        private System.Windows.Forms.Timer tmrConnect;
    }
}