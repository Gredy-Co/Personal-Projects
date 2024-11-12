namespace ProyectoSunGlow___Progra_3
{
    partial class Programa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Programa));
            this.Pnl_Titulo = new System.Windows.Forms.Panel();
            this.TtlSunGlowVL = new System.Windows.Forms.Label();
            this.Pnl_Contenedor = new System.Windows.Forms.Panel();
            this.Btn_CerrarSesion = new System.Windows.Forms.PictureBox();
            this.Btn_Minimizar = new System.Windows.Forms.PictureBox();
            this.Btn_Restaurar = new System.Windows.Forms.PictureBox();
            this.Btn_Maximizar = new System.Windows.Forms.PictureBox();
            this.Btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.Pnl_Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_CerrarSesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Titulo
            // 
            this.Pnl_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(34)))));
            this.Pnl_Titulo.Controls.Add(this.Btn_CerrarSesion);
            this.Pnl_Titulo.Controls.Add(this.TtlSunGlowVL);
            this.Pnl_Titulo.Controls.Add(this.Btn_Minimizar);
            this.Pnl_Titulo.Controls.Add(this.Btn_Restaurar);
            this.Pnl_Titulo.Controls.Add(this.Btn_Maximizar);
            this.Pnl_Titulo.Controls.Add(this.Btn_Cerrar);
            this.Pnl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Titulo.Name = "Pnl_Titulo";
            this.Pnl_Titulo.Size = new System.Drawing.Size(1080, 68);
            this.Pnl_Titulo.TabIndex = 1;
            this.Pnl_Titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnl_Titulo_MouseDown);
            this.Pnl_Titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pnl_Titulo_MouseMove);
            this.Pnl_Titulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pnl_Titulo_MouseUp);
            // 
            // TtlSunGlowVL
            // 
            this.TtlSunGlowVL.AutoSize = true;
            this.TtlSunGlowVL.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TtlSunGlowVL.ForeColor = System.Drawing.Color.White;
            this.TtlSunGlowVL.Location = new System.Drawing.Point(12, 16);
            this.TtlSunGlowVL.Name = "TtlSunGlowVL";
            this.TtlSunGlowVL.Size = new System.Drawing.Size(146, 35);
            this.TtlSunGlowVL.TabIndex = 4;
            this.TtlSunGlowVL.Text = "SunGlow";
            // 
            // Pnl_Contenedor
            // 
            this.Pnl_Contenedor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Pnl_Contenedor.Location = new System.Drawing.Point(0, 68);
            this.Pnl_Contenedor.Name = "Pnl_Contenedor";
            this.Pnl_Contenedor.Size = new System.Drawing.Size(1080, 592);
            this.Pnl_Contenedor.TabIndex = 2;
            // 
            // Btn_CerrarSesion
            // 
            this.Btn_CerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_CerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_CerrarSesion.Image = global::ProyectoSunGlow___Progra_3.Properties.Resources.CerrarSesion;
            this.Btn_CerrarSesion.Location = new System.Drawing.Point(885, 14);
            this.Btn_CerrarSesion.Name = "Btn_CerrarSesion";
            this.Btn_CerrarSesion.Size = new System.Drawing.Size(34, 34);
            this.Btn_CerrarSesion.TabIndex = 5;
            this.Btn_CerrarSesion.TabStop = false;
            this.Btn_CerrarSesion.Click += new System.EventHandler(this.Btn_CerrarSesion_Click);
            this.Btn_CerrarSesion.MouseHover += new System.EventHandler(this.Btn_CerrarSesion_MouseHover);
            // 
            // Btn_Minimizar
            // 
            this.Btn_Minimizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Minimizar.Image = global::ProyectoSunGlow___Progra_3.Properties.Resources.Minimizar;
            this.Btn_Minimizar.Location = new System.Drawing.Point(921, 14);
            this.Btn_Minimizar.Name = "Btn_Minimizar";
            this.Btn_Minimizar.Size = new System.Drawing.Size(36, 34);
            this.Btn_Minimizar.TabIndex = 3;
            this.Btn_Minimizar.TabStop = false;
            this.Btn_Minimizar.Click += new System.EventHandler(this.Btn_Minimizar_Click);
            this.Btn_Minimizar.MouseHover += new System.EventHandler(this.Btn_Minimizar_MouseHover);
            // 
            // Btn_Restaurar
            // 
            this.Btn_Restaurar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Restaurar.Image = global::ProyectoSunGlow___Progra_3.Properties.Resources.Restaurar;
            this.Btn_Restaurar.Location = new System.Drawing.Point(959, 14);
            this.Btn_Restaurar.Name = "Btn_Restaurar";
            this.Btn_Restaurar.Size = new System.Drawing.Size(37, 28);
            this.Btn_Restaurar.TabIndex = 2;
            this.Btn_Restaurar.TabStop = false;
            this.Btn_Restaurar.Visible = false;
            this.Btn_Restaurar.Click += new System.EventHandler(this.Btn_Restaurar_Click);
            this.Btn_Restaurar.MouseHover += new System.EventHandler(this.Btn_Restaurar_MouseHover);
            // 
            // Btn_Maximizar
            // 
            this.Btn_Maximizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Maximizar.Image = global::ProyectoSunGlow___Progra_3.Properties.Resources.Maximizar;
            this.Btn_Maximizar.Location = new System.Drawing.Point(998, 14);
            this.Btn_Maximizar.Name = "Btn_Maximizar";
            this.Btn_Maximizar.Size = new System.Drawing.Size(35, 34);
            this.Btn_Maximizar.TabIndex = 1;
            this.Btn_Maximizar.TabStop = false;
            this.Btn_Maximizar.Click += new System.EventHandler(this.Btn_Maximizar_Click);
            this.Btn_Maximizar.MouseHover += new System.EventHandler(this.Btn_Maximizar_MouseHover);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.AccessibleDescription = "";
            this.Btn_Cerrar.AccessibleName = "";
            this.Btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cerrar.Image = global::ProyectoSunGlow___Progra_3.Properties.Resources.Cerrar;
            this.Btn_Cerrar.Location = new System.Drawing.Point(1033, 14);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(33, 39);
            this.Btn_Cerrar.TabIndex = 0;
            this.Btn_Cerrar.TabStop = false;
            this.Btn_Cerrar.Tag = "";
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            this.Btn_Cerrar.MouseHover += new System.EventHandler(this.Btn_Cerrar_MouseHover);
            // 
            // Programa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 660);
            this.Controls.Add(this.Pnl_Contenedor);
            this.Controls.Add(this.Pnl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Programa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Pnl_Titulo.ResumeLayout(false);
            this.Pnl_Titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_CerrarSesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Titulo;
        private System.Windows.Forms.Label TtlSunGlowVL;
        private System.Windows.Forms.Panel Pnl_Contenedor;
        private System.Windows.Forms.PictureBox Btn_Minimizar;
        private System.Windows.Forms.PictureBox Btn_Restaurar;
        private System.Windows.Forms.PictureBox Btn_Maximizar;
        private System.Windows.Forms.PictureBox Btn_Cerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Btn_CerrarSesion;
    }
}

