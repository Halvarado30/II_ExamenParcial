﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_II_Parcial
{
    public partial class PantallaInicio : Form
    {
        public PantallaInicio()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarCancion_Click(object sender, EventArgs e)
        {
            FrmCancionesE canE = new FrmCancionesE();
            canE.Show();
        }

        private void btnAgregarcancion_Click(object sender, EventArgs e)
        {
            FrmCancion can = new FrmCancion();
            can.Show();
        }
    }
}
