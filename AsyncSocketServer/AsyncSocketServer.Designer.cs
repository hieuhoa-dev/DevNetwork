﻿namespace Lab6_1
{
    partial class AsyncSocketServer
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
            this.btnAcceptIncomingAsync = new System.Windows.Forms.Button();
            this.btnStopServer = new System.Windows.Forms.Button();
            this.btnSendAll = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMessenge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClientInfo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClients = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAcceptIncomingAsync
            // 
            this.btnAcceptIncomingAsync.Location = new System.Drawing.Point(44, 34);
            this.btnAcceptIncomingAsync.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAcceptIncomingAsync.Name = "btnAcceptIncomingAsync";
            this.btnAcceptIncomingAsync.Size = new System.Drawing.Size(441, 100);
            this.btnAcceptIncomingAsync.TabIndex = 0;
            this.btnAcceptIncomingAsync.Text = "Accept Incoming Connection";
            this.btnAcceptIncomingAsync.UseVisualStyleBackColor = true;
            this.btnAcceptIncomingAsync.Click += new System.EventHandler(this.btnAcceptIncomingAsync_Click);
            // 
            // btnStopServer
            // 
            this.btnStopServer.Location = new System.Drawing.Point(520, 40);
            this.btnStopServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStopServer.Name = "btnStopServer";
            this.btnStopServer.Size = new System.Drawing.Size(112, 88);
            this.btnStopServer.TabIndex = 0;
            this.btnStopServer.Text = "Stop Server";
            this.btnStopServer.UseVisualStyleBackColor = true;
            this.btnStopServer.Click += new System.EventHandler(this.btnStopServer_Click);
            // 
            // btnSendAll
            // 
            this.btnSendAll.Location = new System.Drawing.Point(520, 143);
            this.btnSendAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSendAll.Name = "btnSendAll";
            this.btnSendAll.Size = new System.Drawing.Size(112, 83);
            this.btnSendAll.TabIndex = 0;
            this.btnSendAll.Text = "Send All";
            this.btnSendAll.UseVisualStyleBackColor = true;
            this.btnSendAll.Click += new System.EventHandler(this.btnSendAll_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(44, 168);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(439, 36);
            this.txtMessage.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Text:";
            // 
            // txtMessenge
            // 
            this.txtMessenge.Location = new System.Drawing.Point(44, 252);
            this.txtMessenge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMessenge.Multiline = true;
            this.txtMessenge.Name = "txtMessenge";
            this.txtMessenge.Size = new System.Drawing.Size(441, 78);
            this.txtMessenge.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Messenge";
            // 
            // txtClientInfo
            // 
            this.txtClientInfo.Location = new System.Drawing.Point(44, 392);
            this.txtClientInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClientInfo.Multiline = true;
            this.txtClientInfo.Name = "txtClientInfo";
            this.txtClientInfo.Size = new System.Drawing.Size(588, 81);
            this.txtClientInfo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 368);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Client Info";
            // 
            // txtClients
            // 
            this.txtClients.Location = new System.Drawing.Point(520, 278);
            this.txtClients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClients.Multiline = true;
            this.txtClients.Name = "txtClients";
            this.txtClients.Size = new System.Drawing.Size(112, 52);
            this.txtClients.TabIndex = 1;
            this.txtClients.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số Clients";
            // 
            // AsyncSocketServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 514);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClientInfo);
            this.Controls.Add(this.txtMessenge);
            this.Controls.Add(this.txtClients);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnSendAll);
            this.Controls.Add(this.btnStopServer);
            this.Controls.Add(this.btnAcceptIncomingAsync);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AsyncSocketServer";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Forml_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcceptIncomingAsync;
        private System.Windows.Forms.Button btnStopServer;
        private System.Windows.Forms.Button btnSendAll;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMessenge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClientInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClients;
        private System.Windows.Forms.Label label4;
    }
}
