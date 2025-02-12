namespace GestionCasinoAochengYe.Forms
{
    partial class EditarPartidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarPartidas));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.dateTimePickerFecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.txtBoxApuesta = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxGanancia = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxJuego = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEditarPartida = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.btnMaxi = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnRes = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.panelContenedor.SuspendLayout();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaxi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.panelContenedor.Controls.Add(this.btnCancelar);
            this.panelContenedor.Controls.Add(this.btnGuardar);
            this.panelContenedor.Controls.Add(this.label2);
            this.panelContenedor.Controls.Add(this.label8);
            this.panelContenedor.Controls.Add(this.label7);
            this.panelContenedor.Controls.Add(this.label6);
            this.panelContenedor.Controls.Add(this.label1);
            this.panelContenedor.Controls.Add(this.lblEditarPartida);
            this.panelContenedor.Controls.Add(this.txtBoxJuego);
            this.panelContenedor.Controls.Add(this.txtBoxGanancia);
            this.panelContenedor.Controls.Add(this.txtBoxApuesta);
            this.panelContenedor.Controls.Add(this.dateTimePickerFecha);
            this.panelContenedor.Controls.Add(this.panelBarraTitulo);
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(390, 552);
            this.panelContenedor.TabIndex = 9;
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.BackColor = System.Drawing.Color.White;
            this.dateTimePickerFecha.BorderColor = System.Drawing.Color.Transparent;
            this.dateTimePickerFecha.Checked = true;
            this.dateTimePickerFecha.FillColor = System.Drawing.Color.White;
            this.dateTimePickerFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(112, 165);
            this.dateTimePickerFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerFecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(257, 33);
            this.dateTimePickerFecha.TabIndex = 25;
            this.dateTimePickerFecha.Value = new System.DateTime(2025, 2, 12, 1, 53, 56, 826);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(13)))), ((int)(((byte)(37)))));
            this.panelBarraTitulo.Controls.Add(this.btnMaxi);
            this.panelBarraTitulo.Controls.Add(this.btnCerrar);
            this.panelBarraTitulo.Controls.Add(this.btnRes);
            this.panelBarraTitulo.Controls.Add(this.btnMin);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(390, 36);
            this.panelBarraTitulo.TabIndex = 20;
            this.panelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseDown);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // txtBoxApuesta
            // 
            this.txtBoxApuesta.Animated = true;
            this.txtBoxApuesta.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxApuesta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(2)))), ((int)(((byte)(19)))));
            this.txtBoxApuesta.BorderRadius = 8;
            this.txtBoxApuesta.BorderThickness = 2;
            this.txtBoxApuesta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxApuesta.DefaultText = "";
            this.txtBoxApuesta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxApuesta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxApuesta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxApuesta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxApuesta.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtBoxApuesta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxApuesta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtBoxApuesta.ForeColor = System.Drawing.Color.White;
            this.txtBoxApuesta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxApuesta.Location = new System.Drawing.Point(112, 225);
            this.txtBoxApuesta.Name = "txtBoxApuesta";
            this.txtBoxApuesta.PasswordChar = '\0';
            this.txtBoxApuesta.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.txtBoxApuesta.PlaceholderText = "";
            this.txtBoxApuesta.SelectedText = "";
            this.txtBoxApuesta.Size = new System.Drawing.Size(258, 34);
            this.txtBoxApuesta.TabIndex = 26;
            // 
            // txtBoxGanancia
            // 
            this.txtBoxGanancia.Animated = true;
            this.txtBoxGanancia.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxGanancia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(2)))), ((int)(((byte)(19)))));
            this.txtBoxGanancia.BorderRadius = 8;
            this.txtBoxGanancia.BorderThickness = 2;
            this.txtBoxGanancia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxGanancia.DefaultText = "";
            this.txtBoxGanancia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxGanancia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxGanancia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxGanancia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxGanancia.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtBoxGanancia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxGanancia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtBoxGanancia.ForeColor = System.Drawing.Color.White;
            this.txtBoxGanancia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxGanancia.Location = new System.Drawing.Point(112, 290);
            this.txtBoxGanancia.Name = "txtBoxGanancia";
            this.txtBoxGanancia.PasswordChar = '\0';
            this.txtBoxGanancia.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.txtBoxGanancia.PlaceholderText = "";
            this.txtBoxGanancia.SelectedText = "";
            this.txtBoxGanancia.Size = new System.Drawing.Size(258, 34);
            this.txtBoxGanancia.TabIndex = 27;
            // 
            // txtBoxJuego
            // 
            this.txtBoxJuego.Animated = true;
            this.txtBoxJuego.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxJuego.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(2)))), ((int)(((byte)(19)))));
            this.txtBoxJuego.BorderRadius = 8;
            this.txtBoxJuego.BorderThickness = 2;
            this.txtBoxJuego.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxJuego.DefaultText = "";
            this.txtBoxJuego.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxJuego.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxJuego.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxJuego.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxJuego.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtBoxJuego.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxJuego.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtBoxJuego.ForeColor = System.Drawing.Color.White;
            this.txtBoxJuego.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxJuego.Location = new System.Drawing.Point(111, 347);
            this.txtBoxJuego.Name = "txtBoxJuego";
            this.txtBoxJuego.PasswordChar = '\0';
            this.txtBoxJuego.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.txtBoxJuego.PlaceholderText = "";
            this.txtBoxJuego.SelectedText = "";
            this.txtBoxJuego.Size = new System.Drawing.Size(258, 34);
            this.txtBoxJuego.TabIndex = 28;
            // 
            // lblEditarPartida
            // 
            this.lblEditarPartida.AutoSize = true;
            this.lblEditarPartida.BackColor = System.Drawing.Color.Transparent;
            this.lblEditarPartida.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarPartida.ForeColor = System.Drawing.Color.White;
            this.lblEditarPartida.Location = new System.Drawing.Point(95, 50);
            this.lblEditarPartida.Name = "lblEditarPartida";
            this.lblEditarPartida.Size = new System.Drawing.Size(195, 37);
            this.lblEditarPartida.TabIndex = 29;
            this.lblEditarPartida.Text = "Editar partida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "Apuesta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(7, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "Ganancia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(7, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 25);
            this.label8.TabIndex = 33;
            this.label8.Text = "Juego";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-108, -77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "ID";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Animated = true;
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BorderColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BorderRadius = 20;
            this.btnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(2)))), ((int)(((byte)(19)))));
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = global::GestionCasinoAochengYe.Properties.Resources.do_not_disturb_on_24dp_E8EAED_FILL0_wght400_GRAD0_opsz24;
            this.btnCancelar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancelar.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCancelar.Location = new System.Drawing.Point(216, 478);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(162, 37);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseTransparentBackground = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Animated = true;
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BorderColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BorderRadius = 20;
            this.btnGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(2)))), ((int)(((byte)(19)))));
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::GestionCasinoAochengYe.Properties.Resources.save_24dp_E8EAED_FILL0_wght400_GRAD0_opsz24;
            this.btnGuardar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGuardar.ImageSize = new System.Drawing.Size(30, 30);
            this.btnGuardar.Location = new System.Drawing.Point(13, 478);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(162, 37);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseTransparentBackground = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnMaxi
            // 
            this.btnMaxi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaxi.Image = ((System.Drawing.Image)(resources.GetObject("btnMaxi.Image")));
            this.btnMaxi.Location = new System.Drawing.Point(325, 8);
            this.btnMaxi.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaxi.Name = "btnMaxi";
            this.btnMaxi.Size = new System.Drawing.Size(27, 24);
            this.btnMaxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaxi.TabIndex = 5;
            this.btnMaxi.TabStop = false;
            this.btnMaxi.Click += new System.EventHandler(this.btnMaxi_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(356, 8);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(23, 24);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnRes
            // 
            this.btnRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRes.Image = ((System.Drawing.Image)(resources.GetObject("btnRes.Image")));
            this.btnRes.Location = new System.Drawing.Point(325, 8);
            this.btnRes.Margin = new System.Windows.Forms.Padding(2);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(27, 24);
            this.btnRes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRes.TabIndex = 4;
            this.btnRes.TabStop = false;
            this.btnRes.Visible = false;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(295, 8);
            this.btnMin.Margin = new System.Windows.Forms.Padding(2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(26, 24);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 4;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // EditarPartidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 552);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarPartidas";
            this.Text = "EditarPartidas";
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMaxi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.PictureBox btnMaxi;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnRes;
        private System.Windows.Forms.PictureBox btnMin;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerFecha;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxApuesta;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxJuego;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxGanancia;
        private System.Windows.Forms.Label lblEditarPartida;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private System.Windows.Forms.Label label2;
    }
}