﻿namespace projectPCBuilder0506
{
    partial class frmFaccoes
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
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSendMsg = new System.Windows.Forms.TextBox();
            this.txtMsgBox = new System.Windows.Forms.TextBox();
            this.txtUsrConn = new System.Windows.Forms.TextBox();
            this.tmrConnect = new System.Windows.Forms.Timer(this.components);
            this.ReceiveMsgs = new System.ComponentModel.BackgroundWorker();
            this.ReceiveUsrs = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(691, 406);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 25);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSendMsg
            // 
            this.txtSendMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.txtSendMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSendMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSendMsg.ForeColor = System.Drawing.Color.White;
            this.txtSendMsg.Location = new System.Drawing.Point(239, 405);
            this.txtSendMsg.Name = "txtSendMsg";
            this.txtSendMsg.Size = new System.Drawing.Size(446, 25);
            this.txtSendMsg.TabIndex = 11;
            // 
            // txtMsgBox
            // 
            this.txtMsgBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtMsgBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMsgBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsgBox.ForeColor = System.Drawing.Color.White;
            this.txtMsgBox.Location = new System.Drawing.Point(239, 12);
            this.txtMsgBox.Multiline = true;
            this.txtMsgBox.Name = "txtMsgBox";
            this.txtMsgBox.ReadOnly = true;
            this.txtMsgBox.Size = new System.Drawing.Size(527, 386);
            this.txtMsgBox.TabIndex = 10;
            // 
            // txtUsrConn
            // 
            this.txtUsrConn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.txtUsrConn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsrConn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsrConn.ForeColor = System.Drawing.Color.White;
            this.txtUsrConn.Location = new System.Drawing.Point(12, 12);
            this.txtUsrConn.Multiline = true;
            this.txtUsrConn.Name = "txtUsrConn";
            this.txtUsrConn.ReadOnly = true;
            this.txtUsrConn.Size = new System.Drawing.Size(221, 417);
            this.txtUsrConn.TabIndex = 13;
            this.txtUsrConn.TextChanged += new System.EventHandler(this.txtUsrConn_TextChanged);
            // 
            // tmrConnect
            // 
            this.tmrConnect.Interval = 500;
            this.tmrConnect.Tick += new System.EventHandler(this.tmrConnect_Tick);
            // 
            // ReceiveMsgs
            // 
            this.ReceiveMsgs.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ReceiveMsgs_DoWork);
            // 
            // ReceiveUsrs
            // 
            this.ReceiveUsrs.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ReceiveUsrs_DoWork);
            // 
            // frmFaccoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(775, 443);
            this.Controls.Add(this.txtUsrConn);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSendMsg);
            this.Controls.Add(this.txtMsgBox);
            this.Name = "frmFaccoes";
            this.Text = "Facção";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtSendMsg;
        private System.Windows.Forms.TextBox txtMsgBox;
        private System.Windows.Forms.TextBox txtUsrConn;
        private System.Windows.Forms.Timer tmrConnect;
        private System.ComponentModel.BackgroundWorker ReceiveMsgs;
        private System.ComponentModel.BackgroundWorker ReceiveUsrs;
    }
}