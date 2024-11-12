namespace ProyectoSunGlow___Progra_3.Interfaz_Grafica
{
    partial class VenReportes
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Re = new System.Windows.Forms.TabControl();
            this.Rep1 = new System.Windows.Forms.TabPage();
            this.GraficoCajasDia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LblCantCajas = new System.Windows.Forms.Label();
            this.Lbl_Det1 = new System.Windows.Forms.Label();
            this.Lbl_SeleccioneFch1 = new System.Windows.Forms.Label();
            this.DTPFechaCajEmp = new System.Windows.Forms.DateTimePicker();
            this.Lbl_RepCantCajasXDia = new System.Windows.Forms.Label();
            this.PctBx_FondoUCrud = new System.Windows.Forms.PictureBox();
            this.Rep2 = new System.Windows.Forms.TabPage();
            this.LblCantPallets = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DTPPallEmp = new System.Windows.Forms.DateTimePicker();
            this.Lbl_CantPalletsXDia = new System.Windows.Forms.Label();
            this.PctBx_Fondo = new System.Windows.Forms.PictureBox();
            this.Rep3 = new System.Windows.Forms.TabPage();
            this.DTGVProcFruta = new System.Windows.Forms.DataGridView();
            this.NombreFinca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreBloque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreVariedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiposDeFrutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotatFrutas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.DTPProcFruta = new System.Windows.Forms.DateTimePicker();
            this.Lbl_ProcFruta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Rep4 = new System.Windows.Forms.TabPage();
            this.Lbl_CantKgRechDia = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.GraficoPalletsDia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Re.SuspendLayout();
            this.Rep1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoCajasDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBx_FondoUCrud)).BeginInit();
            this.Rep2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctBx_Fondo)).BeginInit();
            this.Rep3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVProcFruta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Rep4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoPalletsDia)).BeginInit();
            this.SuspendLayout();
            // 
            // Re
            // 
            this.Re.Controls.Add(this.Rep1);
            this.Re.Controls.Add(this.Rep2);
            this.Re.Controls.Add(this.Rep3);
            this.Re.Controls.Add(this.Rep4);
            this.Re.Location = new System.Drawing.Point(12, 11);
            this.Re.Name = "Re";
            this.Re.SelectedIndex = 0;
            this.Re.Size = new System.Drawing.Size(841, 568);
            this.Re.TabIndex = 0;
            // 
            // Rep1
            // 
            this.Rep1.Controls.Add(this.GraficoCajasDia);
            this.Rep1.Controls.Add(this.LblCantCajas);
            this.Rep1.Controls.Add(this.Lbl_Det1);
            this.Rep1.Controls.Add(this.Lbl_SeleccioneFch1);
            this.Rep1.Controls.Add(this.DTPFechaCajEmp);
            this.Rep1.Controls.Add(this.Lbl_RepCantCajasXDia);
            this.Rep1.Controls.Add(this.PctBx_FondoUCrud);
            this.Rep1.Location = new System.Drawing.Point(4, 22);
            this.Rep1.Name = "Rep1";
            this.Rep1.Padding = new System.Windows.Forms.Padding(3);
            this.Rep1.Size = new System.Drawing.Size(833, 542);
            this.Rep1.TabIndex = 0;
            this.Rep1.Text = "Reporte 1";
            this.Rep1.UseVisualStyleBackColor = true;
            // 
            // GraficoCajasDia
            // 
            chartArea1.Name = "ChartArea1";
            this.GraficoCajasDia.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GraficoCajasDia.Legends.Add(legend1);
            this.GraficoCajasDia.Location = new System.Drawing.Point(130, 174);
            this.GraficoCajasDia.Name = "GraficoCajasDia";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.GraficoCajasDia.Series.Add(series1);
            this.GraficoCajasDia.Size = new System.Drawing.Size(300, 300);
            this.GraficoCajasDia.TabIndex = 38;
            this.GraficoCajasDia.Text = "GraficoCajas";
            // 
            // LblCantCajas
            // 
            this.LblCantCajas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantCajas.Location = new System.Drawing.Point(290, 511);
            this.LblCantCajas.Name = "LblCantCajas";
            this.LblCantCajas.Size = new System.Drawing.Size(197, 19);
            this.LblCantCajas.TabIndex = 37;
            // 
            // Lbl_Det1
            // 
            this.Lbl_Det1.AutoSize = true;
            this.Lbl_Det1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Det1.Location = new System.Drawing.Point(13, 511);
            this.Lbl_Det1.Name = "Lbl_Det1";
            this.Lbl_Det1.Size = new System.Drawing.Size(259, 19);
            this.Lbl_Det1.TabIndex = 36;
            this.Lbl_Det1.Text = "Este día se empacaron un total de: ";
            // 
            // Lbl_SeleccioneFch1
            // 
            this.Lbl_SeleccioneFch1.AutoSize = true;
            this.Lbl_SeleccioneFch1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SeleccioneFch1.Location = new System.Drawing.Point(11, 97);
            this.Lbl_SeleccioneFch1.Name = "Lbl_SeleccioneFch1";
            this.Lbl_SeleccioneFch1.Size = new System.Drawing.Size(276, 19);
            this.Lbl_SeleccioneFch1.TabIndex = 35;
            this.Lbl_SeleccioneFch1.Text = "Seleccione el día que desea consultar:";
            // 
            // DTPFechaCajEmp
            // 
            this.DTPFechaCajEmp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFechaCajEmp.Location = new System.Drawing.Point(317, 93);
            this.DTPFechaCajEmp.Name = "DTPFechaCajEmp";
            this.DTPFechaCajEmp.Size = new System.Drawing.Size(200, 27);
            this.DTPFechaCajEmp.TabIndex = 34;
            this.DTPFechaCajEmp.ValueChanged += new System.EventHandler(this.DTPFechaCajEmp_ValueChanged);
            // 
            // Lbl_RepCantCajasXDia
            // 
            this.Lbl_RepCantCajasXDia.AutoSize = true;
            this.Lbl_RepCantCajasXDia.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.Lbl_RepCantCajasXDia.Location = new System.Drawing.Point(6, 9);
            this.Lbl_RepCantCajasXDia.Name = "Lbl_RepCantCajasXDia";
            this.Lbl_RepCantCajasXDia.Size = new System.Drawing.Size(466, 29);
            this.Lbl_RepCantCajasXDia.TabIndex = 33;
            this.Lbl_RepCantCajasXDia.Text = "Cantidad De Cajas Empacadas Por Día";
            // 
            // PctBx_FondoUCrud
            // 
            this.PctBx_FondoUCrud.BackColor = System.Drawing.Color.White;
            this.PctBx_FondoUCrud.Image = global::ProyectoSunGlow___Progra_3.Properties.Resources.FondoBolCosDet;
            this.PctBx_FondoUCrud.Location = new System.Drawing.Point(-19, -20);
            this.PctBx_FondoUCrud.Name = "PctBx_FondoUCrud";
            this.PctBx_FondoUCrud.Size = new System.Drawing.Size(899, 571);
            this.PctBx_FondoUCrud.TabIndex = 32;
            this.PctBx_FondoUCrud.TabStop = false;
            // 
            // Rep2
            // 
            this.Rep2.Controls.Add(this.GraficoPalletsDia);
            this.Rep2.Controls.Add(this.LblCantPallets);
            this.Rep2.Controls.Add(this.label2);
            this.Rep2.Controls.Add(this.label3);
            this.Rep2.Controls.Add(this.DTPPallEmp);
            this.Rep2.Controls.Add(this.Lbl_CantPalletsXDia);
            this.Rep2.Controls.Add(this.PctBx_Fondo);
            this.Rep2.Location = new System.Drawing.Point(4, 22);
            this.Rep2.Name = "Rep2";
            this.Rep2.Padding = new System.Windows.Forms.Padding(3);
            this.Rep2.Size = new System.Drawing.Size(833, 542);
            this.Rep2.TabIndex = 1;
            this.Rep2.Text = "Reporte 2";
            this.Rep2.UseVisualStyleBackColor = true;
            // 
            // LblCantPallets
            // 
            this.LblCantPallets.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantPallets.Location = new System.Drawing.Point(288, 510);
            this.LblCantPallets.Name = "LblCantPallets";
            this.LblCantPallets.Size = new System.Drawing.Size(276, 19);
            this.LblCantPallets.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 510);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 19);
            this.label2.TabIndex = 40;
            this.label2.Text = "Este día se empacaron un total de: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 19);
            this.label3.TabIndex = 39;
            this.label3.Text = "Seleccione el día que desea consultar:";
            // 
            // DTPPallEmp
            // 
            this.DTPPallEmp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPPallEmp.Location = new System.Drawing.Point(317, 93);
            this.DTPPallEmp.Name = "DTPPallEmp";
            this.DTPPallEmp.Size = new System.Drawing.Size(200, 27);
            this.DTPPallEmp.TabIndex = 38;
            this.DTPPallEmp.ValueChanged += new System.EventHandler(this.DTPPallEmp_ValueChanged);
            // 
            // Lbl_CantPalletsXDia
            // 
            this.Lbl_CantPalletsXDia.AutoSize = true;
            this.Lbl_CantPalletsXDia.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.Lbl_CantPalletsXDia.Location = new System.Drawing.Point(6, 9);
            this.Lbl_CantPalletsXDia.Name = "Lbl_CantPalletsXDia";
            this.Lbl_CantPalletsXDia.Size = new System.Drawing.Size(481, 29);
            this.Lbl_CantPalletsXDia.TabIndex = 35;
            this.Lbl_CantPalletsXDia.Text = "Cantidad De Pallets Empacadas Por Día";
            // 
            // PctBx_Fondo
            // 
            this.PctBx_Fondo.BackColor = System.Drawing.Color.White;
            this.PctBx_Fondo.Image = global::ProyectoSunGlow___Progra_3.Properties.Resources.FondoBolCosDet;
            this.PctBx_Fondo.Location = new System.Drawing.Point(-19, -20);
            this.PctBx_Fondo.Name = "PctBx_Fondo";
            this.PctBx_Fondo.Size = new System.Drawing.Size(899, 571);
            this.PctBx_Fondo.TabIndex = 34;
            this.PctBx_Fondo.TabStop = false;
            // 
            // Rep3
            // 
            this.Rep3.Controls.Add(this.DTGVProcFruta);
            this.Rep3.Controls.Add(this.label1);
            this.Rep3.Controls.Add(this.DTPProcFruta);
            this.Rep3.Controls.Add(this.Lbl_ProcFruta);
            this.Rep3.Controls.Add(this.pictureBox1);
            this.Rep3.Location = new System.Drawing.Point(4, 22);
            this.Rep3.Name = "Rep3";
            this.Rep3.Size = new System.Drawing.Size(833, 542);
            this.Rep3.TabIndex = 2;
            this.Rep3.Text = "Reporte 3";
            this.Rep3.UseVisualStyleBackColor = true;
            // 
            // DTGVProcFruta
            // 
            this.DTGVProcFruta.AllowUserToAddRows = false;
            this.DTGVProcFruta.AllowUserToDeleteRows = false;
            this.DTGVProcFruta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DTGVProcFruta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVProcFruta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreFinca,
            this.NombreLote,
            this.NombreBloque,
            this.NombreVariedad,
            this.TiposDeFrutos,
            this.TotatFrutas});
            this.DTGVProcFruta.Location = new System.Drawing.Point(69, 242);
            this.DTGVProcFruta.Name = "DTGVProcFruta";
            this.DTGVProcFruta.ReadOnly = true;
            this.DTGVProcFruta.Size = new System.Drawing.Size(644, 150);
            this.DTGVProcFruta.TabIndex = 42;
            // 
            // NombreFinca
            // 
            this.NombreFinca.HeaderText = "Nombre_Finca";
            this.NombreFinca.Name = "NombreFinca";
            this.NombreFinca.ReadOnly = true;
            // 
            // NombreLote
            // 
            this.NombreLote.HeaderText = "Nombre Lote";
            this.NombreLote.Name = "NombreLote";
            this.NombreLote.ReadOnly = true;
            // 
            // NombreBloque
            // 
            this.NombreBloque.HeaderText = "Nombre Bloque";
            this.NombreBloque.Name = "NombreBloque";
            this.NombreBloque.ReadOnly = true;
            // 
            // NombreVariedad
            // 
            this.NombreVariedad.HeaderText = "Nombre de la Variedad de Fruta";
            this.NombreVariedad.Name = "NombreVariedad";
            this.NombreVariedad.ReadOnly = true;
            // 
            // TiposDeFrutos
            // 
            this.TiposDeFrutos.HeaderText = "Tipos De Frutos";
            this.TiposDeFrutos.Name = "TiposDeFrutos";
            this.TiposDeFrutos.ReadOnly = true;
            // 
            // TotatFrutas
            // 
            this.TotatFrutas.HeaderText = "Total de Frutas";
            this.TotatFrutas.Name = "TotatFrutas";
            this.TotatFrutas.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 19);
            this.label1.TabIndex = 41;
            this.label1.Text = "Seleccione el día que desea consultar:";
            // 
            // DTPProcFruta
            // 
            this.DTPProcFruta.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPProcFruta.Location = new System.Drawing.Point(317, 93);
            this.DTPProcFruta.Name = "DTPProcFruta";
            this.DTPProcFruta.Size = new System.Drawing.Size(200, 27);
            this.DTPProcFruta.TabIndex = 40;
            this.DTPProcFruta.ValueChanged += new System.EventHandler(this.DTPProcFruta_ValueChanged);
            // 
            // Lbl_ProcFruta
            // 
            this.Lbl_ProcFruta.AutoSize = true;
            this.Lbl_ProcFruta.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.Lbl_ProcFruta.Location = new System.Drawing.Point(6, 9);
            this.Lbl_ProcFruta.Name = "Lbl_ProcFruta";
            this.Lbl_ProcFruta.Size = new System.Drawing.Size(528, 29);
            this.Lbl_ProcFruta.TabIndex = 37;
            this.Lbl_ProcFruta.Text = "Mostrar La Procedencia de La Fruta Por Día";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::ProyectoSunGlow___Progra_3.Properties.Resources.FondoBolCosDet;
            this.pictureBox1.Location = new System.Drawing.Point(-19, -20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(899, 571);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // Rep4
            // 
            this.Rep4.Controls.Add(this.Lbl_CantKgRechDia);
            this.Rep4.Controls.Add(this.pictureBox2);
            this.Rep4.Location = new System.Drawing.Point(4, 22);
            this.Rep4.Name = "Rep4";
            this.Rep4.Size = new System.Drawing.Size(833, 542);
            this.Rep4.TabIndex = 3;
            this.Rep4.Text = "Reporte 4";
            this.Rep4.UseVisualStyleBackColor = true;
            // 
            // Lbl_CantKgRechDia
            // 
            this.Lbl_CantKgRechDia.AutoSize = true;
            this.Lbl_CantKgRechDia.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.Lbl_CantKgRechDia.Location = new System.Drawing.Point(6, 9);
            this.Lbl_CantKgRechDia.Name = "Lbl_CantKgRechDia";
            this.Lbl_CantKgRechDia.Size = new System.Drawing.Size(749, 58);
            this.Lbl_CantKgRechDia.TabIndex = 39;
            this.Lbl_CantKgRechDia.Text = "Mostrar La Cantidad De Frutas y Kilogramos Que Se Rechazan\r\n Por Día";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::ProyectoSunGlow___Progra_3.Properties.Resources.FondoBolCosDet;
            this.pictureBox2.Location = new System.Drawing.Point(-19, -20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(899, 571);
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // GraficoPalletsDia
            // 
            chartArea2.Name = "ChartArea1";
            this.GraficoPalletsDia.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.GraficoPalletsDia.Legends.Add(legend2);
            this.GraficoPalletsDia.Location = new System.Drawing.Point(119, 162);
            this.GraficoPalletsDia.Name = "GraficoPalletsDia";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.GraficoPalletsDia.Series.Add(series2);
            this.GraficoPalletsDia.Size = new System.Drawing.Size(300, 300);
            this.GraficoPalletsDia.TabIndex = 42;
            this.GraficoPalletsDia.Text = "GraficoPallets";
            // 
            // VenReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 592);
            this.Controls.Add(this.Re);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VenReportes";
            this.Text = "VenRepCantFrutasKgRechXDia";
            this.Re.ResumeLayout(false);
            this.Rep1.ResumeLayout(false);
            this.Rep1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoCajasDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBx_FondoUCrud)).EndInit();
            this.Rep2.ResumeLayout(false);
            this.Rep2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctBx_Fondo)).EndInit();
            this.Rep3.ResumeLayout(false);
            this.Rep3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVProcFruta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Rep4.ResumeLayout(false);
            this.Rep4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoPalletsDia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Re;
        private System.Windows.Forms.TabPage Rep1;
        private System.Windows.Forms.TabPage Rep2;
        private System.Windows.Forms.PictureBox PctBx_FondoUCrud;
        private System.Windows.Forms.Label Lbl_RepCantCajasXDia;
        private System.Windows.Forms.Label Lbl_CantPalletsXDia;
        private System.Windows.Forms.PictureBox PctBx_Fondo;
        private System.Windows.Forms.TabPage Rep3;
        private System.Windows.Forms.Label Lbl_ProcFruta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage Rep4;
        private System.Windows.Forms.Label Lbl_CantKgRechDia;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Lbl_SeleccioneFch1;
        private System.Windows.Forms.DateTimePicker DTPFechaCajEmp;
        private System.Windows.Forms.Label LblCantCajas;
        private System.Windows.Forms.Label Lbl_Det1;
        private System.Windows.Forms.Label LblCantPallets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DTPPallEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTPProcFruta;
        private System.Windows.Forms.DataGridView DTGVProcFruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreFinca;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreBloque;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreVariedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiposDeFrutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotatFrutas;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficoCajasDia;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficoPalletsDia;
    }
}