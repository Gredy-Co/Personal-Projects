namespace ProyectoSunGlow___Progra_3.Interfaz_Grafica.Digitador
{
    partial class VenEntradaBoletas
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
            this.DTVBoletas = new System.Windows.Forms.DataGridView();
            this.IDBoleta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consecutivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnvioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuadrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCosecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraCosecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_FincasCrudUC = new System.Windows.Forms.Label();
            this.Btn_Añadir = new ProyectoSunGlow___Progra_3.ToolBox_Personalizado.ButtonRedondeado();
            this.PctBx_FondoFCrud = new System.Windows.Forms.PictureBox();
            this.Btn_Atras = new ProyectoSunGlow___Progra_3.ToolBox_Personalizado.ButtonRedondeado();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.DTPFecha = new System.Windows.Forms.DateTimePicker();
            this.Btn_ConsultarEnvio = new ProyectoSunGlow___Progra_3.ToolBox_Personalizado.ButtonRedondeado();
            ((System.ComponentModel.ISupportInitialize)(this.DTVBoletas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBx_FondoFCrud)).BeginInit();
            this.SuspendLayout();
            // 
            // DTVBoletas
            // 
            this.DTVBoletas.AllowUserToDeleteRows = false;
            this.DTVBoletas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTVBoletas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.DTVBoletas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DTVBoletas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DTVBoletas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTVBoletas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDBoleta,
            this.Consecutivo,
            this.EnvioID,
            this.Cuadrilla,
            this.FechaCosecha,
            this.HoraCosecha,
            this.Estado});
            this.DTVBoletas.Location = new System.Drawing.Point(38, 110);
            this.DTVBoletas.Name = "DTVBoletas";
            this.DTVBoletas.ReadOnly = true;
            this.DTVBoletas.Size = new System.Drawing.Size(789, 420);
            this.DTVBoletas.TabIndex = 58;
            // 
            // IDBoleta
            // 
            this.IDBoleta.HeaderText = "ID Boleta";
            this.IDBoleta.Name = "IDBoleta";
            this.IDBoleta.ReadOnly = true;
            // 
            // Consecutivo
            // 
            this.Consecutivo.HeaderText = "Consecutivo";
            this.Consecutivo.Name = "Consecutivo";
            this.Consecutivo.ReadOnly = true;
            // 
            // EnvioID
            // 
            this.EnvioID.HeaderText = "Envío ID";
            this.EnvioID.Name = "EnvioID";
            this.EnvioID.ReadOnly = true;
            // 
            // Cuadrilla
            // 
            this.Cuadrilla.HeaderText = "Cuadrilla";
            this.Cuadrilla.Name = "Cuadrilla";
            this.Cuadrilla.ReadOnly = true;
            // 
            // FechaCosecha
            // 
            this.FechaCosecha.HeaderText = "Fecha de Cosecha";
            this.FechaCosecha.Name = "FechaCosecha";
            this.FechaCosecha.ReadOnly = true;
            // 
            // HoraCosecha
            // 
            this.HoraCosecha.HeaderText = "Hora de Cosecha";
            this.HoraCosecha.Name = "HoraCosecha";
            this.HoraCosecha.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Lbl_FincasCrudUC
            // 
            this.Lbl_FincasCrudUC.AutoSize = true;
            this.Lbl_FincasCrudUC.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_FincasCrudUC.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FincasCrudUC.Location = new System.Drawing.Point(12, 18);
            this.Lbl_FincasCrudUC.Name = "Lbl_FincasCrudUC";
            this.Lbl_FincasCrudUC.Size = new System.Drawing.Size(213, 29);
            this.Lbl_FincasCrudUC.TabIndex = 57;
            this.Lbl_FincasCrudUC.Text = "Entradas Boletas";
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
            this.Btn_Añadir.Location = new System.Drawing.Point(747, 25);
            this.Btn_Añadir.Name = "Btn_Añadir";
            this.Btn_Añadir.Size = new System.Drawing.Size(104, 44);
            this.Btn_Añadir.TabIndex = 59;
            this.Btn_Añadir.Text = "Añadir";
            this.Btn_Añadir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Añadir.TextColor = System.Drawing.Color.White;
            this.Btn_Añadir.UseVisualStyleBackColor = false;
            this.Btn_Añadir.Click += new System.EventHandler(this.Btn_Añadir_Click);
            // 
            // PctBx_FondoFCrud
            // 
            this.PctBx_FondoFCrud.BackColor = System.Drawing.Color.White;
            this.PctBx_FondoFCrud.Image = global::ProyectoSunGlow___Progra_3.Properties.Resources.FondoEntrEnvios;
            this.PctBx_FondoFCrud.Location = new System.Drawing.Point(0, 0);
            this.PctBx_FondoFCrud.Name = "PctBx_FondoFCrud";
            this.PctBx_FondoFCrud.Size = new System.Drawing.Size(865, 596);
            this.PctBx_FondoFCrud.TabIndex = 56;
            this.PctBx_FondoFCrud.TabStop = false;
            // 
            // Btn_Atras
            // 
            this.Btn_Atras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(27)))));
            this.Btn_Atras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(27)))));
            this.Btn_Atras.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Atras.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Btn_Atras.BorderRadius = 37;
            this.Btn_Atras.BorderSize = 0;
            this.Btn_Atras.FlatAppearance.BorderSize = 0;
            this.Btn_Atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Atras.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Atras.ForeColor = System.Drawing.Color.White;
            this.Btn_Atras.Image = global::ProyectoSunGlow___Progra_3.Properties.Resources.Icono_Atras;
            this.Btn_Atras.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Atras.Location = new System.Drawing.Point(8, 550);
            this.Btn_Atras.Name = "Btn_Atras";
            this.Btn_Atras.Size = new System.Drawing.Size(100, 37);
            this.Btn_Atras.TabIndex = 62;
            this.Btn_Atras.Text = "Atrás";
            this.Btn_Atras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Atras.TextColor = System.Drawing.Color.White;
            this.Btn_Atras.UseVisualStyleBackColor = false;
            this.Btn_Atras.Click += new System.EventHandler(this.Btn_Atras_Click);
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.Location = new System.Drawing.Point(402, 42);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(49, 16);
            this.Lbl_Fecha.TabIndex = 64;
            this.Lbl_Fecha.Text = "Fecha:";
            // 
            // DTPFecha
            // 
            this.DTPFecha.Location = new System.Drawing.Point(456, 40);
            this.DTPFecha.Name = "DTPFecha";
            this.DTPFecha.Size = new System.Drawing.Size(198, 20);
            this.DTPFecha.TabIndex = 63;
            this.DTPFecha.ValueChanged += new System.EventHandler(this.DTPFecha_ValueChanged);
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
            this.Btn_ConsultarEnvio.Location = new System.Drawing.Point(355, 554);
            this.Btn_ConsultarEnvio.Name = "Btn_ConsultarEnvio";
            this.Btn_ConsultarEnvio.Size = new System.Drawing.Size(155, 29);
            this.Btn_ConsultarEnvio.TabIndex = 65;
            this.Btn_ConsultarEnvio.Text = "Consultar Boleta";
            this.Btn_ConsultarEnvio.TextColor = System.Drawing.Color.White;
            this.Btn_ConsultarEnvio.UseVisualStyleBackColor = false;
            this.Btn_ConsultarEnvio.Click += new System.EventHandler(this.Btn_ConsultarEnvio_Click);
            // 
            // VenEntradaBoletas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 592);
            this.Controls.Add(this.Btn_ConsultarEnvio);
            this.Controls.Add(this.Lbl_Fecha);
            this.Controls.Add(this.DTPFecha);
            this.Controls.Add(this.Btn_Atras);
            this.Controls.Add(this.Btn_Añadir);
            this.Controls.Add(this.DTVBoletas);
            this.Controls.Add(this.Lbl_FincasCrudUC);
            this.Controls.Add(this.PctBx_FondoFCrud);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VenEntradaBoletas";
            this.Text = "VenEntradaBoletas";
            ((System.ComponentModel.ISupportInitialize)(this.DTVBoletas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBx_FondoFCrud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolBox_Personalizado.ButtonRedondeado Btn_Añadir;
        private System.Windows.Forms.DataGridView DTVBoletas;
        private System.Windows.Forms.Label Lbl_FincasCrudUC;
        private System.Windows.Forms.PictureBox PctBx_FondoFCrud;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDBoleta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consecutivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnvioID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuadrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCosecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraCosecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private ToolBox_Personalizado.ButtonRedondeado Btn_Atras;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.DateTimePicker DTPFecha;
        private ToolBox_Personalizado.ButtonRedondeado Btn_ConsultarEnvio;
    }
}