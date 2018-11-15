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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminarCancion = new System.Windows.Forms.Button();
            this.btnAgregarcancion = new System.Windows.Forms.Button();
            this.btnReportecancion = new System.Windows.Forms.Button();
            this.gbPantallaInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPantallaInicio
            // 
            this.gbPantallaInicio.BackColor = System.Drawing.Color.Transparent;
            this.gbPantallaInicio.Controls.Add(this.btnSalir);
            this.gbPantallaInicio.Controls.Add(this.btnEliminarCancion);
            this.gbPantallaInicio.Controls.Add(this.btnAgregarcancion);
            this.gbPantallaInicio.Controls.Add(this.btnReportecancion);
            this.gbPantallaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPantallaInicio.ForeColor = System.Drawing.Color.Black;
            this.gbPantallaInicio.Location = new System.Drawing.Point(47, 22);
            this.gbPantallaInicio.Name = "gbPantallaInicio";
            this.gbPantallaInicio.Size = new System.Drawing.Size(349, 341);
            this.gbPantallaInicio.TabIndex = 0;
            this.gbPantallaInicio.TabStop = false;
            this.gbPantallaInicio.Text = "Bullet Proof Records";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(69, 272);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(188, 45);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminarCancion
            // 
            this.btnEliminarCancion.Location = new System.Drawing.Point(69, 123);
            this.btnEliminarCancion.Name = "btnEliminarCancion";
            this.btnEliminarCancion.Size = new System.Drawing.Size(188, 45);
            this.btnEliminarCancion.TabIndex = 3;
            this.btnEliminarCancion.Text = "Eliminar Canción";
            this.btnEliminarCancion.UseVisualStyleBackColor = true;
            this.btnEliminarCancion.Click += new System.EventHandler(this.btnEliminarCancion_Click);
            // 
            // btnAgregarcancion
            // 
            this.btnAgregarcancion.Location = new System.Drawing.Point(69, 53);
            this.btnAgregarcancion.Name = "btnAgregarcancion";
            this.btnAgregarcancion.Size = new System.Drawing.Size(188, 45);
            this.btnAgregarcancion.TabIndex = 2;
            this.btnAgregarcancion.Text = "Agregar Cancion";
            this.btnAgregarcancion.UseVisualStyleBackColor = true;
            this.btnAgregarcancion.Click += new System.EventHandler(this.btnAgregarcancion_Click);
            // 
            // btnReportecancion
            // 
            this.btnReportecancion.Location = new System.Drawing.Point(69, 197);
            this.btnReportecancion.Name = "btnReportecancion";
            this.btnReportecancion.Size = new System.Drawing.Size(188, 47);
            this.btnReportecancion.TabIndex = 1;
            this.btnReportecancion.Text = "Reporte Canciones";
            this.btnReportecancion.UseVisualStyleBackColor = true;
            // 
            // PantallaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 405);
            this.Controls.Add(this.gbPantallaInicio);
            this.Name = "PantallaInicio";
            this.Text = "Pantalla de Inicio";
            this.gbPantallaInicio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPantallaInicio;
        private System.Windows.Forms.Button btnReportecancion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminarCancion;
        private System.Windows.Forms.Button btnAgregarcancion;
    }
}

