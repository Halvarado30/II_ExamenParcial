namespace Examen_II_Parcial
{
    partial class PantallaInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbPantallaInicio = new System.Windows.Forms.GroupBox();
            this.btnAlbum = new System.Windows.Forms.Button();
            this.btnArtista = new System.Windows.Forms.Button();
            this.btnCancion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbPantallaInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPantallaInicio
            // 
            this.gbPantallaInicio.Controls.Add(this.btnSalir);
            this.gbPantallaInicio.Controls.Add(this.btnCancion);
            this.gbPantallaInicio.Controls.Add(this.btnArtista);
            this.gbPantallaInicio.Controls.Add(this.btnAlbum);
            this.gbPantallaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPantallaInicio.Location = new System.Drawing.Point(47, 22);
            this.gbPantallaInicio.Name = "gbPantallaInicio";
            this.gbPantallaInicio.Size = new System.Drawing.Size(349, 341);
            this.gbPantallaInicio.TabIndex = 0;
            this.gbPantallaInicio.TabStop = false;
            this.gbPantallaInicio.Text = "Bullet Proof Records";
            // 
            // btnAlbum
            // 
            this.btnAlbum.Location = new System.Drawing.Point(92, 122);
            this.btnAlbum.Name = "btnAlbum";
            this.btnAlbum.Size = new System.Drawing.Size(151, 45);
            this.btnAlbum.TabIndex = 1;
            this.btnAlbum.Text = "Album";
            this.btnAlbum.UseVisualStyleBackColor = true;
            // 
            // btnArtista
            // 
            this.btnArtista.Location = new System.Drawing.Point(92, 53);
            this.btnArtista.Name = "btnArtista";
            this.btnArtista.Size = new System.Drawing.Size(151, 45);
            this.btnArtista.TabIndex = 2;
            this.btnArtista.Text = "Artista";
            this.btnArtista.UseVisualStyleBackColor = true;
            // 
            // btnCancion
            // 
            this.btnCancion.Location = new System.Drawing.Point(92, 199);
            this.btnCancion.Name = "btnCancion";
            this.btnCancion.Size = new System.Drawing.Size(151, 45);
            this.btnCancion.TabIndex = 3;
            this.btnCancion.Text = "Canción";
            this.btnCancion.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(92, 272);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(151, 45);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // PantallaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 427);
            this.Controls.Add(this.gbPantallaInicio);
            this.Name = "PantallaInicio";
            this.Text = "Pantalla de Inicio";
            this.gbPantallaInicio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPantallaInicio;
        private System.Windows.Forms.Button btnAlbum;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancion;
        private System.Windows.Forms.Button btnArtista;
    }
}

