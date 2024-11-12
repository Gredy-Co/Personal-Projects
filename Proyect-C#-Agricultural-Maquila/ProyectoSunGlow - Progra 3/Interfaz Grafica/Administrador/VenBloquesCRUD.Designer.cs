namespace ProyectoSunGlow___Progra_3.Interfaz_Grafica.Administrador
{
    partial class VenBloquesCRUD
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
            this.Lbl_VarFrutos = new System.Windows.Forms.Label();
            this.CmbBx_Frutos = new System.Windows.Forms.ComboBox();
            this.Lbl_BloquesCrudUC = new System.Windows.Forms.Label();
            this.PctBx_FondoFCrud = new System.Windows.Forms.PictureBox();
            this.CmbBx_Lotes = new System.Windows.Forms.ComboBox();
            this.Lbl_Lote = new System.Windows.Forms.Label();
            this.Btn_Reactivar = new ProyectoSunGlow___Progra_3.ToolBox_Personalizado.ButtonRedondeado();
            this.Btn_Eliminar = new ProyectoSunGlow___Progra_3.ToolBox_Personalizado.ButtonRedondeado();
            this.Btn_Modificar = new ProyectoSunGlow___Progra_3.ToolBox_Personalizado.ButtonRedondeado();
            this.Btn_Consultar = new ProyectoSunGlow___Progra_3.ToolBox_Personalizado.ButtonRedondeado();
            this.TxtBx_NombreBloque = new ProyectoSunGlow___Progra_3.ToolBox_Personalizado.TextBoxRedondeado();
            this.Btn_Guardar = new ProyectoSunGlow___Progra_3.ToolBox_Personalizado.ButtonRedondeado();
            ((System.ComponentModel.ISupportInitialize)(this.PctBx_FondoFCrud)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_VarFrutos
            // 
            this.Lbl_VarFrutos.AutoSize = true;
            this.Lbl_VarFrutos.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_VarFrutos.Location = new System.Drawing.Point(84, 287);
            this.Lbl_VarFrutos.Name = "Lbl_VarFrutos";
            this.Lbl_VarFrutos.Size = new System.Drawing.Size(145, 19);
            this.Lbl_VarFrutos.TabIndex = 56;
            this.Lbl_VarFrutos.Text = "Variedad del Fruto:";
            // 
            // CmbBx_Frutos
            // 
            this.CmbBx_Frutos.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBx_Frutos.FormattingEnabled = true;
            this.CmbBx_Frutos.Location = new System.Drawing.Point(78, 309);
            this.CmbBx_Frutos.Name = "CmbBx_Frutos";
            this.CmbBx_Frutos.Size = new System.Drawing.Size(307, 26);
            this.CmbBx_Frutos.TabIndex = 55;
            this.CmbBx_Frutos.SelectedIndexChanged += new System.EventHandler(this.CmbBx_Frutos_SelectedIndexChanged);
            // 
            // Lbl_BloquesCrudUC
            // 
            this.Lbl_BloquesCrudUC.AutoSize = true;
            this.Lbl_BloquesCrudUC.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_BloquesCrudUC.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_BloquesCrudUC.Location = new System.Drawing.Point(14, 15);
            this.Lbl_BloquesCrudUC.Name = "Lbl_BloquesCrudUC";
            this.Lbl_BloquesCrudUC.Size = new System.Drawing.Size(241, 29);
            this.Lbl_BloquesCrudUC.TabIndex = 54;
            this.Lbl_BloquesCrudUC.Text = "Gestión de Bloques";
            // 
            // PctBx_FondoFCrud
            // 
            this.PctBx_FondoFCrud.BackColor = System.Drawing.Color.White;
            this.PctBx_FondoFCrud.Image = global::ProyectoSunGlow___Progra_3.Properties.Resources.FondoCRUDS;
            this.PctBx_FondoFCrud.Location = new System.Drawing.Point(0, 0);
            this.PctBx_FondoFCrud.Name = "PctBx_FondoFCrud";
            this.PctBx_FondoFCrud.Size = new System.Drawing.Size(865, 592);
            this.PctBx_FondoFCrud.TabIndex = 53;
            this.PctBx_FondoFCrud.TabStop = false;
            // 
            // CmbBx_Lotes
            // 
            this.CmbBx_Lotes.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBx_Lotes.FormattingEnabled = true;
            this.CmbBx_Lotes.Location = new System.Drawing.Point(78, 228);
            this.CmbBx_Lotes.Name = "CmbBx_Lotes";
            this.CmbBx_Lotes.Size = new System.Drawing.Size(307, 26);
            this.CmbBx_Lotes.TabIndex = 55;
            this.CmbBx_Lotes.SelectedIndexChanged += new System.EventHandler(this.CmbBx_Lotes_SelectedIndexChanged);
            // 
            // Lbl_Lote
            // 
            this.Lbl_Lote.AutoSize = true;
            this.Lbl_Lote.CausesValidation = false;
            this.Lbl_Lote.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Lote.Location = new System.Drawing.Point(84, 206);
            this.Lbl_Lote.Name = "Lbl_Lote";
            this.Lbl_Lote.Size = new System.Drawing.Size(158, 19);
            this.Lbl_Lote.TabIndex = 56;
            this.Lbl_Lote.Text = "Lote al que pertence:";
            // 
            // Btn_Reactivar
            // 
            this.Btn_Reactivar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(27)))));
            this.Btn_Reactivar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(27)))));
            this.Btn_Reactivar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Reactivar.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Btn_Reactivar.BorderRadius = 40;
            this.Btn_Reactivar.BorderSize = 0;
            this.Btn_Reactivar.FlatAppearance.BorderSize = 0;
            this.Btn_Reactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Reactivar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reactivar.ForeColor = System.Drawing.Color.White;
            this.Btn_Reactivar.Location = new System.Drawing.Point(249, 529);
            this.Btn_Reactivar.Name = "Btn_Reactivar";
            this.Btn_Reactivar.Size = new System.Drawing.Size(181, 40);
            this.Btn_Reactivar.TabIndex = 52;
            this.Btn_Reactivar.Text = "Reactivar Bloque";
            this.Btn_Reactivar.TextColor = System.Drawing.Color.White;
            this.Btn_Reactivar.UseVisualStyleBackColor = false;
            this.Btn_Reactivar.Click += new System.EventHandler(this.Btn_Reactivar_Click);
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
            this.Btn_Eliminar.TabIndex = 51;
            this.Btn_Eliminar.Text = "Eliminar Bloque\n";
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
            this.Btn_Modificar.TabIndex = 50;
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
            this.Btn_Consultar.TabIndex = 49;
            this.Btn_Consultar.Text = "Consultar";
            this.Btn_Consultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Consultar.TextColor = System.Drawing.Color.White;
            this.Btn_Consultar.UseVisualStyleBackColor = false;
            this.Btn_Consultar.Click += new System.EventHandler(this.Btn_Consultar_Click);
            // 
            // TxtBx_NombreBloque
            // 
            this.TxtBx_NombreBloque.BackColor = System.Drawing.Color.White;
            this.TxtBx_NombreBloque.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(27)))));
            this.TxtBx_NombreBloque.BorderFocusColor = System.Drawing.Color.Orange;
            this.TxtBx_NombreBloque.BorderRadius = 10;
            this.TxtBx_NombreBloque.BorderSize = 2;
            this.TxtBx_NombreBloque.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_NombreBloque.ForeColor = System.Drawing.Color.DimGray;
            this.TxtBx_NombreBloque.Location = new System.Drawing.Point(78, 145);
            this.TxtBx_NombreBloque.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBx_NombreBloque.Multiline = false;
            this.TxtBx_NombreBloque.Name = "TxtBx_NombreBloque";
            this.TxtBx_NombreBloque.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtBx_NombreBloque.PasswordChar = false;
            this.TxtBx_NombreBloque.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtBx_NombreBloque.PlaceholderText = "Nombre del Bloque";
            this.TxtBx_NombreBloque.Size = new System.Drawing.Size(307, 33);
            this.TxtBx_NombreBloque.TabIndex = 46;
            this.TxtBx_NombreBloque.Texts = "";
            this.TxtBx_NombreBloque.UnderlinedStyle = false;
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
            this.Btn_Guardar.TabIndex = 48;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Guardar.TextColor = System.Drawing.Color.White;
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // VenBloquesCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 592);
            this.Controls.Add(this.Lbl_Lote);
            this.Controls.Add(this.Lbl_VarFrutos);
            this.Controls.Add(this.CmbBx_Lotes);
            this.Controls.Add(this.CmbBx_Frutos);
            this.Controls.Add(this.Lbl_BloquesCrudUC);
            this.Controls.Add(this.Btn_Reactivar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Consultar);
            this.Controls.Add(this.TxtBx_NombreBloque);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.PctBx_FondoFCrud);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VenBloquesCRUD";
            this.Text = "VenBloques";
            this.Load += new System.EventHandler(this.VenBloquesCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctBx_FondoFCrud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_VarFrutos;
        private System.Windows.Forms.ComboBox CmbBx_Frutos;
        private System.Windows.Forms.Label Lbl_BloquesCrudUC;
        private ToolBox_Personalizado.ButtonRedondeado Btn_Reactivar;
        private ToolBox_Personalizado.ButtonRedondeado Btn_Eliminar;
        private ToolBox_Personalizado.ButtonRedondeado Btn_Modificar;
        private ToolBox_Personalizado.ButtonRedondeado Btn_Consultar;
        private ToolBox_Personalizado.TextBoxRedondeado TxtBx_NombreBloque;
        private ToolBox_Personalizado.ButtonRedondeado Btn_Guardar;
        private System.Windows.Forms.PictureBox PctBx_FondoFCrud;
        private System.Windows.Forms.ComboBox CmbBx_Lotes;
        private System.Windows.Forms.Label Lbl_Lote;
    }
}