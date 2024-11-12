namespace ProyectoSunGlow___Progra_3.Interfaz_Grafica.Digitador
{
    partial class VenInmersion
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
            this.DGVDisponible = new System.Windows.Forms.DataGridView();
            this.IDDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumBoleta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumBin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVSumergido = new System.Windows.Forms.DataGridView();
            this.IDDet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NBoleta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NBin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.PctBx_FondoFCrud = new System.Windows.Forms.PictureBox();
            this.Btn_Sumergir = new ProyectoSunGlow___Progra_3.ToolBox_Personalizado.ButtonRedondeado();
            this.TxtBx_BusquedaBol = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDisponible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSumergido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBx_FondoFCrud)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVDisponible
            // 
            this.DGVDisponible.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVDisponible.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVDisponible.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVDisponible.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDDetalle,
            this.NumBoleta,
            this.NumBin});
            this.DGVDisponible.Location = new System.Drawing.Point(177, 102);
            this.DGVDisponible.Name = "DGVDisponible";
            this.DGVDisponible.Size = new System.Drawing.Size(302, 389);
            this.DGVDisponible.TabIndex = 58;
            this.DGVDisponible.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDisponible_CellDoubleClick);
            // 
            // IDDetalle
            // 
            this.IDDetalle.HeaderText = "ID Detalle";
            this.IDDetalle.Name = "IDDetalle";
            this.IDDetalle.ReadOnly = true;
            this.IDDetalle.Visible = false;
            // 
            // NumBoleta
            // 
            this.NumBoleta.HeaderText = "# Boleta";
            this.NumBoleta.Name = "NumBoleta";
            // 
            // NumBin
            // 
            this.NumBin.HeaderText = "# Bin";
            this.NumBin.Name = "NumBin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(539, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 60;
            this.label1.Text = "Sumergido";
            // 
            // DGVSumergido
            // 
            this.DGVSumergido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVSumergido.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVSumergido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVSumergido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDDet,
            this.NBoleta,
            this.NBin});
            this.DGVSumergido.Location = new System.Drawing.Point(537, 102);
            this.DGVSumergido.Name = "DGVSumergido";
            this.DGVSumergido.Size = new System.Drawing.Size(302, 389);
            this.DGVSumergido.TabIndex = 61;
            this.DGVSumergido.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSumergido_CellDoubleClick);
            // 
            // IDDet
            // 
            this.IDDet.HeaderText = "ID Detalle";
            this.IDDet.Name = "IDDet";
            this.IDDet.ReadOnly = true;
            this.IDDet.Visible = false;
            // 
            // NBoleta
            // 
            this.NBoleta.HeaderText = "# Boleta";
            this.NBoleta.Name = "NBoleta";
            // 
            // NBin
            // 
            this.NBin.HeaderText = "# Bin";
            this.NBin.Name = "NBin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 62;
            this.label2.Text = "Disponible";
            // 
            // PctBx_FondoFCrud
            // 
            this.PctBx_FondoFCrud.BackColor = System.Drawing.Color.White;
            this.PctBx_FondoFCrud.Image = global::ProyectoSunGlow___Progra_3.Properties.Resources.FondoInmersion;
            this.PctBx_FondoFCrud.Location = new System.Drawing.Point(0, 0);
            this.PctBx_FondoFCrud.Name = "PctBx_FondoFCrud";
            this.PctBx_FondoFCrud.Size = new System.Drawing.Size(865, 596);
            this.PctBx_FondoFCrud.TabIndex = 57;
            this.PctBx_FondoFCrud.TabStop = false;
            // 
            // Btn_Sumergir
            // 
            this.Btn_Sumergir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(27)))));
            this.Btn_Sumergir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(27)))));
            this.Btn_Sumergir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Sumergir.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Btn_Sumergir.BorderRadius = 40;
            this.Btn_Sumergir.BorderSize = 0;
            this.Btn_Sumergir.FlatAppearance.BorderSize = 0;
            this.Btn_Sumergir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Sumergir.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sumergir.ForeColor = System.Drawing.Color.White;
            this.Btn_Sumergir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Sumergir.Location = new System.Drawing.Point(438, 514);
            this.Btn_Sumergir.Name = "Btn_Sumergir";
            this.Btn_Sumergir.Size = new System.Drawing.Size(142, 44);
            this.Btn_Sumergir.TabIndex = 64;
            this.Btn_Sumergir.Text = "Sumergir Fruta";
            this.Btn_Sumergir.TextColor = System.Drawing.Color.White;
            this.Btn_Sumergir.UseVisualStyleBackColor = false;
            this.Btn_Sumergir.Click += new System.EventHandler(this.Btn_Sumergir_Click);
            // 
            // TxtBx_BusquedaBol
            // 
            this.TxtBx_BusquedaBol.Location = new System.Drawing.Point(38, 222);
            this.TxtBx_BusquedaBol.Name = "TxtBx_BusquedaBol";
            this.TxtBx_BusquedaBol.Size = new System.Drawing.Size(100, 20);
            this.TxtBx_BusquedaBol.TabIndex = 65;
            this.TxtBx_BusquedaBol.TextChanged += new System.EventHandler(this.TxtBx_BusquedaBol_TextChanged);
            this.TxtBx_BusquedaBol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBx_BusquedaBol_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Búsqueda Boleta:";
            // 
            // VenInmersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 592);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBx_BusquedaBol);
            this.Controls.Add(this.Btn_Sumergir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGVSumergido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVDisponible);
            this.Controls.Add(this.PctBx_FondoFCrud);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VenInmersion";
            this.Text = "VenInmersion";
            ((System.ComponentModel.ISupportInitialize)(this.DGVDisponible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSumergido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBx_FondoFCrud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PctBx_FondoFCrud;
        private System.Windows.Forms.DataGridView DGVDisponible;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVSumergido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumBoleta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumBin;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDet;
        private System.Windows.Forms.DataGridViewTextBoxColumn NBoleta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NBin;
        private ToolBox_Personalizado.ButtonRedondeado Btn_Sumergir;
        private System.Windows.Forms.TextBox TxtBx_BusquedaBol;
        private System.Windows.Forms.Label label3;
    }
}