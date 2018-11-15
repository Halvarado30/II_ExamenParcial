using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Examen_II_Parcial.Models;

namespace Examen_II_Parcial
{
    public partial class FrmCancion : Form
    {
        public FrmCancion()
        {
            InitializeComponent();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtnombre.Text == "" || txtartista.Text == "" || txtalbum.Text == "")
            {
                MessageBox.Show("Hay campos vacios", "ERROR", MessageBoxButtons.OK);
            }
            else
            {
                // Instancia de la Clase Cancion
                Cancion nuevaC = new Cancion();
                nuevaC.nombre = txtnombre.Text;
                nuevaC.artista = Convert.ToInt16(txtartista.Text);
                nuevaC.album = Convert.ToInt16(txtartista.Text);
            }
            
        }
    }
}
