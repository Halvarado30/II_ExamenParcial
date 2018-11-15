namespace Examen_II_Parcial
{
    partial class FrmCancion
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtaniocreacion = new System.Windows.Forms.TextBox();
            this.txtgenero = new System.Windows.Forms.TextBox();
            this.txtalbum = new System.Windows.Forms.TextBox();
            this.txtartista = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(157, 415);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(136, 43);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Artista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Album:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Genero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Año Creación:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtaniocreacion);
            this.groupBox1.Controls.Add(this.txtgenero);
            this.groupBox1.Controls.Add(this.txtalbum);
            this.groupBox1.Controls.Add(this.txtartista);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(45, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 317);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Canción";
            // 
            // txtaniocreacion
            // 
            this.txtaniocreacion.Location = new System.Drawing.Point(163, 252);
            this.txtaniocreacion.Name = "txtaniocreacion";
            this.txtaniocreacion.Size = new System.Drawing.Size(296, 30);
            this.txtaniocreacion.TabIndex = 10;
            // 
            // txtgenero
            // 
            this.txtgenero.Location = new System.Drawing.Point(112, 196);
            this.txtgenero.Name = "txtgenero";
            this.txtgenero.Size = new System.Drawing.Size(347, 30);
            this.txtgenero.TabIndex = 9;
            // 
            // txtalbum
            // 
            this.txtalbum.Location = new System.Drawing.Point(112, 150);
            this.txtalbum.Name = "txtalbum";
            this.txtalbum.Size = new System.Drawing.Size(347, 30);
            this.txtalbum.TabIndex = 8;
            // 
            // txtartista
            // 
            this.txtartista.Location = new System.Drawing.Point(112, 104);
            this.txtartista.Name = "txtartista";
            this.txtartista.Size = new System.Drawing.Size(347, 30);
            this.txtartista.TabIndex = 7;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(112, 57);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(347, 30);
            this.txtnombre.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(350, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(136, 43);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // FrmCancion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 485);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgregar);
            this.Name = "FrmCancion";
            this.Text = "Agregar Canción";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtaniocreacion;
        private System.Windows.Forms.TextBox txtgenero;
        private System.Windows.Forms.TextBox txtalbum;
        private System.Windows.Forms.TextBox txtartista;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btnSalir;
    }
}