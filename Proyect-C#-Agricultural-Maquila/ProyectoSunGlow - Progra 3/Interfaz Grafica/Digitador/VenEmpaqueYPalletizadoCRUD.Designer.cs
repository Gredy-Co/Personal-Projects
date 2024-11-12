namespace ProyectoSunGlow___Progra_3.Interfaz_Grafica.Digitador
{
    partial class VenEmpaqueYPalletizadoCRUD
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
            this.Lbl_EmPaCrudUC = new System.Windows.Forms.Label();
            this.Btn_Empacar = new ProyectoSunGlow___Progra_3.ToolBox_Personalizado.ButtonRedondeado();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PctBx_FondoUCrud = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBx_FondoUCrud)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_EmPaCrudUC
            // 
            this.Lbl_EmPaCrudUC.AutoSize = true;
            this.Lbl_EmPaCrudUC.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_EmPaCrudUC.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EmPaCrudUC.Location = new System.Drawing.Point(14, 13);
            this.Lbl_EmPaCrudUC.Name = "Lbl_EmPaCrudUC";
            this.Lbl_EmPaCrudUC.Size = new System.Drawing.Size(418, 29);
            this.Lbl_EmPaCrudUC.TabIndex = 32;
            this.Lbl_EmPaCrudUC.Text = "Gestión de Empaque y Palletizado";
            // 
            // Btn_Empacar
            // 
            this.Btn_Empacar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(27)))));
            this.Btn_Empacar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(27)))));
            this.Btn_Empacar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Empacar.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Btn_Empacar.BorderRadius = 40;
            this.Btn_Empacar.BorderSize = 0;
            this.Btn_Empacar.FlatAppearance.BorderSize = 0;
            this.Btn_Empacar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Empacar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Empacar.ForeColor = System.Drawing.Color.White;
            this.Btn_Empacar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Empacar.Location = new System.Drawing.Point(166, 400);
            this.Btn_Empacar.Name = "Btn_Empacar";
            this.Btn_Empacar.Size = new System.Drawing.Size(142, 44);
            this.Btn_Empacar.TabIndex = 65;
            this.Btn_Empacar.Text = "Empacar Fruta";
            this.Btn_Empacar.TextColor = System.Drawing.Color.White;
            this.Btn_Empacar.UseVisualStyleBackColor = false;
            this.Btn_Empacar.Click += new System.EventHandler(this.Btn_Empacar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoSunGlow___Progra_3.Properties.Resources.pina;
            this.pictureBox1.Location = new System.Drawing.Point(112, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 264);
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // PctBx_FondoUCrud
            // 
            this.PctBx_FondoUCrud.BackColor = System.Drawing.Color.White;
            this.PctBx_FondoUCrud.Image = global::ProyectoSunGlow___Progra_3.Properties.Resources.FondoCRUDS;
            this.PctBx_FondoUCrud.Location = new System.Drawing.Point(0, 0);
            this.PctBx_FondoUCrud.Name = "PctBx_FondoUCrud";
            this.PctBx_FondoUCrud.Size = new System.Drawing.Size(865, 592);
            this.PctBx_FondoUCrud.TabIndex = 31;
            this.PctBx_FondoUCrud.TabStop = false;
            // 
            // VenEmpaqueYPalletizadoCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 592);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Empacar);
            this.Controls.Add(this.Lbl_EmPaCrudUC);
            this.Controls.Add(this.PctBx_FondoUCrud);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VenEmpaqueYPalletizadoCRUD";
            this.Text = "VenEmpaqueYPalletizadoCRUD";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBx_FondoUCrud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_EmPaCrudUC;
        private System.Windows.Forms.PictureBox PctBx_FondoUCrud;
        private ToolBox_Personalizado.ButtonRedondeado Btn_Empacar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}