﻿namespace MerceariaSantana
{
    partial class FormLogin
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
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblSenhaInvalida = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.White;
            this.pnlLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlLogin.Controls.Add(this.lblSenhaInvalida);
            this.pnlLogin.Controls.Add(this.txtSenha);
            this.pnlLogin.Controls.Add(this.txtUsuario);
            this.pnlLogin.Controls.Add(this.label3);
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlLogin.Size = new System.Drawing.Size(800, 450);
            this.pnlLogin.TabIndex = 4;
            // 
            // lblSenhaInvalida
            // 
            this.lblSenhaInvalida.AutoSize = true;
            this.lblSenhaInvalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaInvalida.ForeColor = System.Drawing.Color.Red;
            this.lblSenhaInvalida.Location = new System.Drawing.Point(239, 28);
            this.lblSenhaInvalida.Name = "lblSenhaInvalida";
            this.lblSenhaInvalida.Size = new System.Drawing.Size(114, 20);
            this.lblSenhaInvalida.TabIndex = 5;
            this.lblSenhaInvalida.Text = "Senha Inválida";
            this.lblSenhaInvalida.Visible = false;
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(273, 197);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(235, 26);
            this.txtSenha.TabIndex = 1;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(273, 119);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(235, 26);
            this.txtUsuario.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(269, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(269, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuário";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLogin.Location = new System.Drawing.Point(342, 248);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 34);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlLogin);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblSenhaInvalida;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
    }
}