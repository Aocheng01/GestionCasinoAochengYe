namespace GestionCasinoAochengYe.Forms.Formulario_Informe
{
    partial class FrmInformeDinamico
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
            this.lblIniciarSesion = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnConfig = new Guna.UI2.WinForms.Guna2Button();
            this.btnPartidas = new Guna.UI2.WinForms.Guna2Button();
            this.btnClientes = new Guna.UI2.WinForms.Guna2Button();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIniciarSesion
            // 
            this.lblIniciarSesion.AutoSize = true;
            this.lblIniciarSesion.BackColor = System.Drawing.Color.Transparent;
            this.lblIniciarSesion.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.lblIniciarSesion.Location = new System.Drawing.Point(12, 9);
            this.lblIniciarSesion.Name = "lblIniciarSesion";
            this.lblIniciarSesion.Size = new System.Drawing.Size(132, 37);
            this.lblIniciarSesion.TabIndex = 15;
            this.lblIniciarSesion.Text = "Informes";
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelContenedor.Controls.Add(this.btnConfig);
            this.panelContenedor.Controls.Add(this.btnPartidas);
            this.panelContenedor.Controls.Add(this.btnClientes);
            this.panelContenedor.Controls.Add(this.reportViewer1);
            this.panelContenedor.Controls.Add(this.lblIniciarSesion);
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(910, 552);
            this.panelContenedor.TabIndex = 5;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestionCasinoAochengYe.Informes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(19, 49);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(862, 475);
            this.reportViewer1.TabIndex = 16;
            // 
            // btnConfig
            // 
            this.btnConfig.Animated = true;
            this.btnConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnConfig.BorderColor = System.Drawing.Color.Transparent;
            this.btnConfig.BorderRadius = 20;
            this.btnConfig.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfig.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfig.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfig.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfig.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(2)))), ((int)(((byte)(19)))));
            this.btnConfig.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.Image = global::GestionCasinoAochengYe.Properties.Resources.build_circle_24dp_E8EAED_FILL0_wght400_GRAD0_opsz24;
            this.btnConfig.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnConfig.ImageSize = new System.Drawing.Size(25, 25);
            this.btnConfig.Location = new System.Drawing.Point(431, 9);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(124, 34);
            this.btnConfig.TabIndex = 19;
            this.btnConfig.Text = "Usuarios";
            this.btnConfig.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnConfig.UseTransparentBackground = true;
            this.btnConfig.Click += new System.EventHandler(this.btnInformeUsuarios_Click);
            // 
            // btnPartidas
            // 
            this.btnPartidas.Animated = true;
            this.btnPartidas.BackColor = System.Drawing.Color.Transparent;
            this.btnPartidas.BorderColor = System.Drawing.Color.Transparent;
            this.btnPartidas.BorderRadius = 20;
            this.btnPartidas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPartidas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPartidas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPartidas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPartidas.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(2)))), ((int)(((byte)(19)))));
            this.btnPartidas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPartidas.ForeColor = System.Drawing.Color.White;
            this.btnPartidas.Image = global::GestionCasinoAochengYe.Properties.Resources.poker_chip_24dp_E8EAED_FILL0_wght400_GRAD0_opsz24;
            this.btnPartidas.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPartidas.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPartidas.Location = new System.Drawing.Point(291, 9);
            this.btnPartidas.Name = "btnPartidas";
            this.btnPartidas.Size = new System.Drawing.Size(124, 34);
            this.btnPartidas.TabIndex = 18;
            this.btnPartidas.Text = "Partidas";
            this.btnPartidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnPartidas.UseTransparentBackground = true;
            this.btnPartidas.Click += new System.EventHandler(this.btnInformePartidas_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Animated = true;
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.BorderColor = System.Drawing.Color.Transparent;
            this.btnClientes.BorderRadius = 20;
            this.btnClientes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClientes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClientes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClientes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClientes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(2)))), ((int)(((byte)(19)))));
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = global::GestionCasinoAochengYe.Properties.Resources.group_24dp_E8EAED_FILL0_wght400_GRAD0_opsz24;
            this.btnClientes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClientes.ImageSize = new System.Drawing.Size(25, 25);
            this.btnClientes.Location = new System.Drawing.Point(150, 9);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(124, 36);
            this.btnClientes.TabIndex = 17;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnClientes.UseTransparentBackground = true;
            this.btnClientes.Click += new System.EventHandler(this.btnInformeClientes_Click);
            // 
            // FrmInformeDinamico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 551);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInformeDinamico";
            this.Text = "FrmInformeDinamico";
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIniciarSesion;
        private System.Windows.Forms.Panel panelContenedor;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI2.WinForms.Guna2Button btnConfig;
        private Guna.UI2.WinForms.Guna2Button btnPartidas;
        private Guna.UI2.WinForms.Guna2Button btnClientes;
    }
}