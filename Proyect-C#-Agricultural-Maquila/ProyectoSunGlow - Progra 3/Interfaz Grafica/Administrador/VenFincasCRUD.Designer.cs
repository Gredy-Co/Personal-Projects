namespace ProyectoSunGlow___Progra_3.Interfaz_Grafica.Administrador
{
    partial class VenFincasCRUD
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
            this.Lbl_FincasCrudUC = new System.Windows.Forms.Label();
            this.PctBx_FondoFCrud = new System.Windows.Forms.PictureBox();
            this.CmbBx_Fincas = new System.Windows.Forms.ComboBox();
            this.LblFincas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbBx_Propietario = new System.Windows.Forms.ComboBox();
            this.Btn_ReactivarUsuario = new ProyectoSunGlow___Progra_3.ToolBox_Personalizado.ButtonRedondeado();
            this.Btn_Eliminar = new ProyectoSunGlow___Progra_3.ToolBox_Personalizado.ButtonRedondeado();
            this.Btn_Modificar = new ProyectoSunGlow___Progra_3.ToolBox_Personalizado.ButtonRedondeado();
            this.Btn_Consultar = new ProyectoSunGlow___Progra_3.ToolBox_Personalizado.ButtonRedondeado();
            this.TxtBx_Ubicacion = new ProyectoSunGlow___Progra_3.ToolBox_Personalizado.TextBoxRedondeado();
            this.TxtBx_NombreFinca = new ProyectoSunGlow___Progra_3.ToolBox_Personalizado.TextBoxRedondeado();
            this.TxtBx_Tipo_De_Suelo = new ProyectoSunGlow___Progra_3.ToolBox_Personalizado.TextBoxRedondeado();
            this.Btn_Guardar = new ProyectoSunGlow___Progra_3.ToolBox_Personalizado.ButtonRedondeado();
            this.TxtBx_AreaTotal = new System.Windows.Forms.TextBox();
            this.LblAreaTtotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PctBx_FondoFCrud)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_FincasCrudUC
            // 
            this.Lbl_FincasCrudUC.AutoSize = true;
            this.Lbl_FincasCrudUC.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_FincasCrudUC.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FincasCrudUC.Location = new System.Drawing.Point(14, 15);
            this.Lbl_FincasCrudUC.Name = "Lbl_FincasCrudUC";
            this.Lbl_FincasCrudUC.Size = new System.Drawing.Size(222, 29);
            this.Lbl_FincasCrudUC.TabIndex = 32;
            this.Lbl_FincasCrudUC.Text = "Gestión de Fincas";
            // 
            // PctBx_FondoFCrud
            // 
            this.PctBx_FondoFCrud.BackColor = System.Drawing.Color.White;
            this.PctBx_FondoFCrud.Image = global::ProyectoSunGlow___Progra_3.Properties.Resources.FondoCRUDS;
            this.PctBx_FondoFCrud.Location = new System.Drawing.Point(0, 0);
            this.PctBx_FondoFCrud.Name = "PctBx_FondoFCrud";
            this.PctBx_FondoFCrud.Size = new System.Drawing.Size(865, 592);
            this.PctBx_FondoFCrud.TabIndex = 31;
            this.PctBx_FondoFCrud.TabStop = false;
            // 
            // CmbBx_Fincas
            // 
            this.CmbBx_Fincas.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CmbBx_Fincas.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBx_Fincas.FormattingEnabled = true;
            this.CmbBx_Fincas.Location = new System.Drawing.Point(29, 104);
            this.CmbBx_Fincas.Name = "CmbBx_Fincas";
            this.CmbBx_Fincas.Size = new System.Drawing.Size(307, 26);
            this.CmbBx_Fincas.TabIndex = 33;
            this.CmbBx_Fincas.SelectedIndexChanged += new System.EventHandler(this.CmbBx_Fincas_SelectedIndexChanged);
            // 
            // LblFincas
            // 
            this.LblFincas.AutoSize = true;
            this.LblFincas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFincas.Location = new System.Drawing.Point(26, 77);
            this.LblFincas.Name = "LblFincas";
            this.LblFincas.Size = new System.Drawing.Size(66, 19);
            this.LblFincas.TabIndex = 34;
            this.LblFincas.Text = "Fincas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "Propietario:";
            // 
            // CmbBx_Propietario
            // 
            this.CmbBx_Propietario.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CmbBx_Propietario.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBx_Propietario.FormattingEnabled = true;
            this.CmbBx_Propietario.Location = new System.Drawing.Point(30, 171);
            this.CmbBx_Propietario.Name = "CmbBx_Propietario";
            this.CmbBx_Propietario.Size = new System.Drawing.Size(307, 26);
            this.CmbBx_Propietario.TabIndex = 35;
            this.CmbBx_Propietario.SelectedIndexChanged += new System.EventHandler(this.CmbBx_Propietario_SelectedIndexChanged);
            // 
            // Btn_ReactivarUsuario
            // 
            this.Btn_ReactivarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(27)))));
            this.Btn_ReactivarUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(27)))));
            this.Btn_ReactivarUsuario.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_ReactivarUsuario.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Btn_ReactivarUsuario.BorderRadius = 40;
            this.Btn_ReactivarUsuario.BorderSize = 0;
            this.Btn_ReactivarUsuario.FlatAppearance.BorderSize = 0;
            this.Btn_ReactivarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ReactivarUsuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ReactivarUsuario.ForeColor = System.Drawing.Color.White;
            this.Btn_ReactivarUsuario.Location = new System.Drawing.Point(249, 529);
            this.Btn_ReactivarUsuario.Name = "Btn_ReactivarUsuario";
            this.Btn_ReactivarUsuario.Size = new System.Drawing.Size(181, 40);
            this.Btn_ReactivarUsuario.TabIndex = 30;
            this.Btn_ReactivarUsuario.Text = "Reactivar Finca\r\n";
            this.Btn_ReactivarUsuario.TextColor = System.Drawing.Color.White;
            this.Btn_ReactivarUsuario.UseVisualStyleBackColor = false;
            this.Btn_ReactivarUsuario.Click += new System.EventHandler(this.Btn_ReactivarUsuario_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(27)))));
            this.Btn_Eliminar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(27)))));
            this.Btn_Eliminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Eliminar.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Btn_Eliminar.BorderRadius = 40;
            this.Btn_Eliminar.BorderSize = 0;
            this.Btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.Btn_Eliminar.Image = global::ProyectoSunGlow___Progra_3.Properties.Resources.Borrar;
            this.Btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Eliminar.Location = new System.Drawing.Point(49, 529);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(181, 40);
            this.Btn_Eliminar.TabIndex = 29;
            this.Btn_Eliminar.Text = "Eliminar Finca\r\n";
            this.Btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Eliminar.TextColor = System.Drawing.Color.White;
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(27)))));
            this.Btn_Modificar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(27)))));
            this.Btn_Modificar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Modificar.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Btn_Modificar.BorderRadius = 40;
            this.Btn_Modificar.BorderSize = 0;
            this.Btn_Modificar.FlatAppearance.BorderSize = 0;
            this.Btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Modificar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modificar.ForeColor = System.Drawing.Color.White;
            this.Btn_Modificar.Image = global::ProyectoSunGlow___Progra_3.Properties.Resources.Modificar;
            this.Btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Modificar.Location = new System.Drawing.Point(168, 461);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(140, 40);
            this.Btn_Modificar.TabIndex = 28;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Modificar.TextColor = System.Drawing.Color.White;
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Consultar
            // 
            this.Btn_Consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(27)))));
            this.Btn_Consultar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(27)))));
            this.Btn_Consultar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Consultar.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Btn_Consultar.BorderRadius = 40;
            this.Btn_Consultar.BorderSize = 0;
            this.Btn_Consultar.FlatAppearance.BorderSize = 0;
            this.Btn_Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Consultar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Consultar.ForeColor = System.Drawing.Color.White;
            this.Btn_Consultar.Image = global::ProyectoSunGlow___Progra_3.Properties.Resources.Consultar;
            this.Btn_Consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Consultar.Location = new System.Drawing.Point(320, 461);
            this.Btn_Consultar.Name = "Btn_Consultar";
            this.Btn_Consultar.Size = new System.Drawing.Size(140, 40);
            this.Btn_Consultar.TabIndex = 27;
            this.Btn_Consultar.Text = "Consultar";
            this.Btn_Consultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Consultar.TextColor = System.Drawing.Color.White;
            this.Btn_Consultar.UseVisualStyleBackColor = false;
            this.Btn_Consultar.Click += new System.EventHandler(this.Btn_Consultar_Click);
            // 
            // TxtBx_Ubicacion
            // 
            this.TxtBx_Ubicacion.BackColor = System.Drawing.Color.White;
            this.TxtBx_Ubicacion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(27)))));
            this.TxtBx_Ubicacion.BorderFocusColor = System.Drawing.Color.Orange;
            this.TxtBx_Ubicacion.BorderRadius = 10;
            this.TxtBx_Ubicacion.BorderSize = 2;
            this.TxtBx_Ubicacion.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_Ubicacion.ForeColor = System.Drawing.Color.DimGray;
            this.TxtBx_Ubicacion.Location = new System.Drawing.Point(80, 292);
            this.TxtBx_Ubicacion.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBx_Ubicacion.Multiline = false;
            this.TxtBx_Ubicacion.Name = "TxtBx_Ubicacion";
            this.TxtBx_Ubicacion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtBx_Ubicacion.PasswordChar = false;
            this.TxtBx_Ubicacion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtBx_Ubicacion.PlaceholderText = "Ubicación";
            this.TxtBx_Ubicacion.Size = new System.Drawing.Size(307, 33);
            this.TxtBx_Ubicacion.TabIndex = 20;
            this.TxtBx_Ubicacion.Texts = "";
            this.TxtBx_Ubicacion.UnderlinedStyle = false;
            // 
            // TxtBx_NombreFinca
            // 
            this.TxtBx_NombreFinca.BackColor = System.Drawing.Color.White;
            this.TxtBx_NombreFinca.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(27)))));
            this.TxtBx_NombreFinca.BorderFocusColor = System.Drawing.Color.Orange;
            this.TxtBx_NombreFinca.BorderRadius = 10;
            this.TxtBx_NombreFinca.BorderSize = 2;
            this.TxtBx_NombreFinca.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_NombreFinca.ForeColor = System.Drawing.Color.DimGray;
            this.TxtBx_NombreFinca.Location = new System.Drawing.Point(80, 240);
            this.TxtBx_NombreFinca.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBx_NombreFinca.Multiline = false;
            this.TxtBx_NombreFinca.Name = "TxtBx_NombreFinca";
            this.TxtBx_NombreFinca.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtBx_NombreFinca.PasswordChar = false;
            this.TxtBx_NombreFinca.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtBx_NombreFinca.PlaceholderText = "Nombre de la Finca";
            this.TxtBx_NombreFinca.Size = new System.Drawing.Size(307, 33);
            this.TxtBx_NombreFinca.TabIndex = 19;
            this.TxtBx_NombreFinca.Texts = "";
            this.TxtBx_NombreFinca.UnderlinedStyle = false;
            // 
            // TxtBx_Tipo_De_Suelo
            // 
            this.TxtBx_Tipo_De_Suelo.BackColor = System.Drawing.Color.White;
            this.TxtBx_Tipo_De_Suelo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(27)))));
            this.TxtBx_Tipo_De_Suelo.BorderFocusColor = System.Drawing.Color.Orange;
            this.TxtBx_Tipo_De_Suelo.BorderRadius = 10;
            this.TxtBx_Tipo_De_Suelo.BorderSize = 2;
            this.TxtBx_Tipo_De_Suelo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_Tipo_De_Suelo.ForeColor = System.Drawing.Color.DimGray;
            this.TxtBx_Tipo_De_Suelo.Location = new System.Drawing.Point(80, 395);
            this.TxtBx_Tipo_De_Suelo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBx_Tipo_De_Suelo.Multiline = false;
            this.TxtBx_Tipo_De_Suelo.Name = "TxtBx_Tipo_De_Suelo";
            this.TxtBx_Tipo_De_Suelo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtBx_Tipo_De_Suelo.PasswordChar = false;
            this.TxtBx_Tipo_De_Suelo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtBx_Tipo_De_Suelo.PlaceholderText = "Tipo de Suelo";
            this.TxtBx_Tipo_De_Suelo.Size = new System.Drawing.Size(307, 33);
            this.TxtBx_Tipo_De_Suelo.TabIndex = 22;
            this.TxtBx_Tipo_De_Suelo.Texts = "";
            this.TxtBx_Tipo_De_Suelo.UnderlinedStyle = false;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(27)))));
            this.Btn_Guardar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(27)))));
            this.Btn_Guardar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Guardar.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Btn_Guardar.BorderRadius = 40;
            this.Btn_Guardar.BorderSize = 0;
            this.Btn_Guardar.FlatAppearance.BorderSize = 0;
            this.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guardar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.Btn_Guardar.Image = global::ProyectoSunGlow___Progra_3.Properties.Resources.Guardar;
            this.Btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Guardar.Location = new System.Drawing.Point(18, 461);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(140, 40);
            this.Btn_Guardar.TabIndex = 26;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Guardar.TextColor = System.Drawing.Color.White;
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // TxtBx_AreaTotal
            // 
            this.TxtBx_AreaTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBx_AreaTotal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_AreaTotal.Location = new System.Drawing.Point(168, 349);
            this.TxtBx_AreaTotal.Name = "TxtBx_AreaTotal";
            this.TxtBx_AreaTotal.Size = new System.Drawing.Size(219, 26);
            this.TxtBx_AreaTotal.TabIndex = 37;
            this.TxtBx_AreaTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBx_AreaTotal_KeyPress);
            // 
            // LblAreaTtotal
            // 
            this.LblAreaTtotal.AutoSize = true;
            this.LblAreaTtotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAreaTtotal.Location = new System.Drawing.Point(80, 351);
            this.LblAreaTtotal.Name = "LblAreaTtotal";
            this.LblAreaTtotal.Size = new System.Drawing.Size(82, 18);
            this.LblAreaTtotal.TabIndex = 38;
            this.LblAreaTtotal.Text = "Área Total:";
            // 
            // VenFincasCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 592);
            this.Controls.Add(this.LblAreaTtotal);
            this.Controls.Add(this.TxtBx_AreaTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbBx_Propietario);
            this.Controls.Add(this.LblFincas);
            this.Controls.Add(this.CmbBx_Fincas);
            this.Controls.Add(this.Lbl_FincasCrudUC);
            this.Controls.Add(this.Btn_ReactivarUsuario);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Consultar);
            this.Controls.Add(this.TxtBx_Ubicacion);
            this.Controls.Add(this.TxtBx_NombreFinca);
            this.Controls.Add(this.TxtBx_Tipo_De_Suelo);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.PctBx_FondoFCrud);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VenFincasCRUD";
            this.Text = "VenFincasCRUD";
            this.Load += new System.EventHandler(this.VenFincasCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctBx_FondoFCrud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_FincasCrudUC;
        private ToolBox_Personalizado.ButtonRedondeado Btn_ReactivarUsuario;
        private ToolBox_Personalizado.ButtonRedondeado Btn_Eliminar;
        private ToolBox_Personalizado.ButtonRedondeado Btn_Modificar;
        private ToolBox_Personalizado.ButtonRedondeado Btn_Consultar;
        private ToolBox_Personalizado.TextBoxRedondeado TxtBx_Ubicacion;
        private ToolBox_Personalizado.TextBoxRedondeado TxtBx_NombreFinca;
        private ToolBox_Personalizado.TextBoxRedondeado TxtBx_Tipo_De_Suelo;
        private ToolBox_Personalizado.ButtonRedondeado Btn_Guardar;
        private System.Windows.Forms.PictureBox PctBx_FondoFCrud;
        private System.Windows.Forms.ComboBox CmbBx_Fincas;
        private System.Windows.Forms.Label LblFincas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbBx_Propietario;
        private System.Windows.Forms.TextBox TxtBx_AreaTotal;
        private System.Windows.Forms.Label LblAreaTtotal;
    }
}