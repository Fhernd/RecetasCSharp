﻿using System;
using System.Windows.Forms;

namespace R0703_DevExpress
{
    /// <summary>
    /// Clase para demostrar el procesamiento genérico de controles.
    /// </summary>
    public partial class R0703 : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// Crea un nuevo formulario de tipo Form.
        /// </summary>
        public R0703()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Infoca la función para procesamiento genérico de los controles de este formulario.
        /// </summary>
        /// <param name="sender">Objeto generador del evento.</param>
        /// <param name="e">Datos del evento.</param>
        private void btnProcesarControles_Click(object sender, EventArgs e)
        {
            ProcesarControles(this);
        }

        /// <summary>
        /// Procesa de forma genérica-recursiva los controles de este formulario.
        /// </summary>
        /// <param name="control">Control padre.</param>
        private void ProcesarControles(Control control)
        {
            // Sólo proceso controles de tipo TextEdit: 
            if (control is DevExpress.XtraEditors.TextEdit)
            {
                control.Text = "";
            }

            // Procesamiento recursivo de cada control integral de la 
            // interfaz: 
            foreach (Control controlAnidado in control.Controls)
            {
                ProcesarControles(controlAnidado);
            }
        }
    }
}
