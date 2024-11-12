namespace ProyectoSunGlow___Progra_3.Interfaz_Grafica.Digitador
{
    partial class VenEntradaEnvios
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
            this.DTVEntradaEnvios = new System.Windows.Forms.DataGridView();
            this.Lbl_FincasCrudUC = new System.Windows.Forms.Label();
            this.PctBx_FondoFCrud = new System.Windows.Forms.PictureBox();
            this.DTPFecha = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.IDRecepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreConductor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlacaCamion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NBines = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_ConsultarEnvio = new ProyectoSunGlow___Progra_3.ToolBox_Personalizado.ButtonRedondeado();
            this.Btn_Añadir = new ProyectoSunGlow___Progra_3.ToolBox_Personalizado.ButtonRedondeado();
            ((System.ComponentModel.ISupportInitialize)(this.DTVEntradaEnvios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBx_FondoFCrud)).BeginInit();
            this.SuspendLayout();
            // 
            // DTVEntradaEnvios
            // 
            this.DTVEntradaEnvios.AllowUserToAddRows = false;
            this.DTVEntradaEnvios.AllowUserToDeleteRows = false;
            this.DTVEntradaEnvios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTVEntradaEnvios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.DTVEntradaEnvios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DTVEntradaEnvios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DTVEntradaEnvios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTVEntradaEnvios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDRecepcion,
            this.NombreConductor,
            this.PlacaCamion,
            this.Cedula,
            this.NBines,
            this.HoraEnvio,
            this.HoraLlegada,
            this.Fecha,
            this.PesoNeto,
            this.Estado});
            this.DTVEntradaEnvios.Location = new System.Drawing.Point(38, 111);
            this.DTVEntradaEnvios.Name = "DTVEntradaEnvios";
            this.DTVEntradaEnvios.ReadOnly = true;
            this.DTVEntradaEnvios.Size = new System.Drawing.Size(789, 416);
            this.DTVEntradaEnvios.TabIndex = 54;
            // 
            // Lbl_FincasCrudUC
            // 
            this.Lbl_FincasCrudUC.AutoSize = true;
            this.Lbl_FincasCrudUC.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_FincasCrudUC.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FincasCrudUC.Location = new System.Drawing.Point(13, 18);
            this.Lbl_FincasCrudUC.Name = "Lbl_FincasCrudUC";
            this.Lbl_FincasCrudUC.Size = new System.Drawing.Size(203, 29);
            this.Lbl_FincasCrudUC.TabIndex = 53;
            this.Lbl_FincasCrudUC.Text = "Entradas Envíos";
            // 
            // PctBx_FondoFCrud
            // 
            this.PctBx_FondoFCrud.BackColor = System.Drawing.Color.White;
            this.PctBx_FondoFCrud.Image = global::ProyectoSunGlow___Progra_3.Properties.Resources.FondoEntrEnvios;
            this.PctBx_FondoFCrud.Location = new System.Drawing.Point(0, 0);
            this.PctBx_FondoFCrud.Name = "PctBx_FondoFCrud";
            this.PctBx_FondoFCrud.Size = new System.Drawing.Size(865, 592);
            this.PctBx_FondoFCrud.TabIndex = 52;
            this.PctBx_FondoFCrud.TabStop = false;
            // 
            // DTPFecha
            // 
            this.DTPFecha.Location = new System.Drawing.Point(456, 40);
            this.DTPFecha.Name = "DTPFecha";
            this.DTPFecha.Size = new System.Drawing.Size(198, 20);
            this.DTPFecha.TabIndex = 56;
            this.DTPFecha.ValueChanged += new System.EventHandler(this.DTPFecha_ValueChanged);
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.Location = new System.Drawing.Point(402, 42);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(49, 16);
            this.Lbl_Fecha.TabIndex = 57;
            this.Lbl_Fecha.Text = "Fecha:";
            // 
            // IDRecepcion
            // 
            this.IDRecepcion.HeaderText = "ID Recepción";
            this.IDRecepcion.Name = "IDRecepcion";
            this.IDRecepcion.ReadOnly = true;
            // 
            // NombreConductor
            // 
            this.NombreConductor.HeaderText = "Nombre Del Conductor";
            this.NombreConductor.Name = "NombreConductor";
            this.NombreConductor.ReadOnly = true;
            // 
            // PlacaCamion
            // 
            this.PlacaCamion.HeaderText = "Placa Del Camión";
            this.PlacaCamion.Name = "PlacaCamion";
            this.PlacaCamion.ReadOnly = true;
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cédula del Conductor";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // NBines
            // 
            this.NBines.HeaderText = "Número de Bines";
            this.NBines.Name = "NBines";
            this.NBines.ReadOnly = true;
            // 
            // HoraEnvio
            // 
            this.HoraEnvio.HeaderText = "Hora De Envío";
            this.HoraEnvio.Name = "HoraEnvio";
            this.HoraEnvio.ReadOnly = true;
            // 
            // HoraLlegada
            // 
            this.HoraLlegada.HeaderText = "Hora De Llegada";
            this.HoraLlegada.Name = "HoraLlegada";
            this.HoraLlegada.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // PesoNeto
            // 
            this.PesoNeto.HeaderText = "Peso Neto";
            this.PesoNeto.Name = "PesoNeto";
            this.PesoNeto.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Btn_ConsultarEnvio
            // 
            this.Btn_ConsultarEnvio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(27)))));
            this.Btn_ConsultarEnvio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(27)))));
            this.Btn_ConsultarEnvio.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_ConsultarEnvio.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Btn_ConsultarEnvio.BorderRadius = 28;
            this.Btn_ConsultarEnvio.BorderSize = 0;
            this.Btn_ConsultarEnvio.FlatAppearance.BorderSize = 0;
            this.Btn_ConsultarEnvio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ConsultarEnvio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ConsultarEnvio.ForeColor = System.Drawing.Color.White;
            this.Btn_ConsultarEnvio.Location = new System.Drawing.Point(29, 551);
            this.Btn_ConsultarEnvio.Name = "Btn_ConsultarEnvio";
            this.Btn_ConsultarEnvio.Size = new System.Drawing.Size(146, 29);
            this.Btn_ConsultarEnvio.TabIndex = 58;
            this.Btn_ConsultarEnvio.Text = "Consultar Envío";
            this.Btn_ConsultarEnvio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ConsultarEnvio.TextColor = System.Drawing.Color.White;
            this.Btn_ConsultarEnvio.UseVisualStyleBackColor = false;
            this.Btn_ConsultarEnvio.Click += new System.EventHandler(this.Btn_ConsultarEnvio_Click);
            // 
            // Btn_Añadir
            // 
            this.Btn_Añadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(27)))));
            this.Btn_Añadir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(27)))));
            this.Btn_Añadir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Añadir.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Btn_Añadir.BorderRadius = 40;
            this.Btn_Añadir.BorderSize = 0;
            this.Btn_Añadir.FlatAppearance.BorderSize = 0;
            this.Btn_Añadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Añadir.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Añadir.ForeColor = System.Drawing.Color.White;
            this.Btn_Añadir.Image = global::ProyectoSunGlow___Progra_3.Properties.Resources.Icono_Mas;
            this.Btn_Añadir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Añadir.Location = new System.Drawing.Point(749, 26);
            this.Btn_Añadir.Name = "Btn_Añadir";
            this.Btn_Añadir.Size = new System.Drawing.Size(104, 40);
            this.Btn_Añadir.TabIndex = 55;
            this.Btn_Añadir.Text = "Añadir";
            this.Btn_Añadir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Añadir.TextColor = System.Drawing.Color.White;
            this.Btn_Añadir.UseVisualStyleBackColor = false;
            this.Btn_Añadir.Click += new System.EventHandler(this.Btn_Añadir_Click);
            // 
            // VenEntradaEnvios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 592);
            this.Controls.Add(this.Btn_ConsultarEnvio);
            this.Controls.Add(this.Lbl_Fecha);
            this.Controls.Add(this.DTPFecha);
            this.Controls.Add(this.Btn_Añadir);
            this.Controls.Add(this.DTVEntradaEnvios);
            this.Controls.Add(this.Lbl_FincasCrudUC);
            this.Controls.Add(this.PctBx_FondoFCrud);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VenEntradaEnvios";
            this.Text = "VenEntradaEnvios";
            ((System.ComponentModel.ISupportInitialize)(this.DTVEntradaEnvios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBx_FondoFCrud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolBox_Personalizado.ButtonRedondeado Btn_Añadir;
        private System.Windows.Forms.DataGridView DTVEntradaEnvios;
        private System.Windows.Forms.Label Lbl_FincasCrudUC;
        private System.Windows.Forms.PictureBox PctBx_FondoFCrud;
        private System.Windows.Forms.DateTimePicker DTPFecha;
        private System.Windows.Forms.Label Lbl_Fecha;
        private ToolBox_Personalizado.ButtonRedondeado Btn_ConsultarEnvio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDRecepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreConductor;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlacaCamion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn NBines;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraEnvio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoNeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}