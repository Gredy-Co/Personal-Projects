namespace ProyectoSunGlow___Progra_3.Interfaz_Grafica
{
    partial class VenRepMovimientos
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
            this.DTVBitMovimientos = new System.Windows.Forms.DataGridView();
            this.ID_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora_Movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_FincasCrudUC = new System.Windows.Forms.Label();
            this.PctBx_FondoFCrud = new System.Windows.Forms.PictureBox();
            this.DTPMovFecha = new System.Windows.Forms.DateTimePicker();
            this.Btn_Consultar = new ProyectoSunGlow___Progra_3.ToolBox_Personalizado.ButtonRedondeado();
            ((System.ComponentModel.ISupportInitialize)(this.DTVBitMovimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBx_FondoFCrud)).BeginInit();
            this.SuspendLayout();
            // 
            // DTVBitMovimientos
            // 
            this.DTVBitMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTVBitMovimientos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.DTVBitMovimientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DTVBitMovimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DTVBitMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTVBitMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Usuario,
            this.Usuario,
            this.Seccion,
            this.Tipo_Movimiento,
            this.Fecha_Movimiento,
            this.Hora_Movimiento});
            this.DTVBitMovimientos.Location = new System.Drawing.Point(38, 110);
            this.DTVBitMovimientos.Name = "DTVBitMovimientos";
            this.DTVBitMovimientos.Size = new System.Drawing.Size(789, 420);
            this.DTVBitMovimientos.TabIndex = 61;
            // 
            // ID_Usuario
            // 
            this.ID_Usuario.HeaderText = "ID del Usuario";
            this.ID_Usuario.Name = "ID_Usuario";
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            // 
            // Seccion
            // 
            this.Seccion.HeaderText = "Sección";
            this.Seccion.Name = "Seccion";
            // 
            // Tipo_Movimiento
            // 
            this.Tipo_Movimiento.HeaderText = "Tipo De Movimiento";
            this.Tipo_Movimiento.Name = "Tipo_Movimiento";
            // 
            // Fecha_Movimiento
            // 
            this.Fecha_Movimiento.HeaderText = "Fecha Del Movimiento";
            this.Fecha_Movimiento.Name = "Fecha_Movimiento";
            // 
            // Hora_Movimiento
            // 
            this.Hora_Movimiento.HeaderText = "Hora Del Movimiento";
            this.Hora_Movimiento.Name = "Hora_Movimiento";
            // 
            // Lbl_FincasCrudUC
            // 
            this.Lbl_FincasCrudUC.AutoSize = true;
            this.Lbl_FincasCrudUC.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_FincasCrudUC.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FincasCrudUC.Location = new System.Drawing.Point(12, 18);
            this.Lbl_FincasCrudUC.Name = "Lbl_FincasCrudUC";
            this.Lbl_FincasCrudUC.Size = new System.Drawing.Size(308, 29);
            this.Lbl_FincasCrudUC.TabIndex = 60;
            this.Lbl_FincasCrudUC.Text = "Bitácora de Movimientos";
            // 
            // PctBx_FondoFCrud
            // 
            this.PctBx_FondoFCrud.BackColor = System.Drawing.Color.White;
            this.PctBx_FondoFCrud.Image = global::ProyectoSunGlow___Progra_3.Properties.Resources.FondoEntrEnvios;
            this.PctBx_FondoFCrud.Location = new System.Drawing.Point(0, 0);
            this.PctBx_FondoFCrud.Name = "PctBx_FondoFCrud";
            this.PctBx_FondoFCrud.Size = new System.Drawing.Size(865, 596);
            this.PctBx_FondoFCrud.TabIndex = 59;
            this.PctBx_FondoFCrud.TabStop = false;
            // 
            // DTPMovFecha
            // 
            this.DTPMovFecha.Location = new System.Drawing.Point(532, 33);
            this.DTPMovFecha.Name = "DTPMovFecha";
            this.DTPMovFecha.Size = new System.Drawing.Size(200, 20);
            this.DTPMovFecha.TabIndex = 63;
            this.DTPMovFecha.ValueChanged += new System.EventHandler(this.DTPMovFecha_ValueChanged);
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
            this.Btn_Consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Consultar.Location = new System.Drawing.Point(749, 18);
            this.Btn_Consultar.Name = "Btn_Consultar";
            this.Btn_Consultar.Size = new System.Drawing.Size(104, 44);
            this.Btn_Consultar.TabIndex = 62;
            this.Btn_Consultar.Text = "Consultar";
            this.Btn_Consultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Consultar.TextColor = System.Drawing.Color.White;
            this.Btn_Consultar.UseVisualStyleBackColor = false;
            // 
            // VenRepMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 592);
            this.Controls.Add(this.DTPMovFecha);
            this.Controls.Add(this.Btn_Consultar);
            this.Controls.Add(this.DTVBitMovimientos);
            this.Controls.Add(this.Lbl_FincasCrudUC);
            this.Controls.Add(this.PctBx_FondoFCrud);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VenRepMovimientos";
            this.Text = "VenRepMovimientos";
            ((System.ComponentModel.ISupportInitialize)(this.DTVBitMovimientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBx_FondoFCrud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DTVBitMovimientos;
        private System.Windows.Forms.Label Lbl_FincasCrudUC;
        private System.Windows.Forms.PictureBox PctBx_FondoFCrud;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora_Movimiento;
        private System.Windows.Forms.DateTimePicker DTPMovFecha;
        private ToolBox_Personalizado.ButtonRedondeado Btn_Consultar;
    }
}