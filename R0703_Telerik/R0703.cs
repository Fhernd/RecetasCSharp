using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace R0703_Telerik
{
    /// <summary>
    /// Clase para demostrar el procesamiento genérico de controles.
    /// </summary>
    public partial class R0703 : Telerik.WinControls.UI.RadForm
    {
        /// <summary>
        /// Crea un nuevo formulario de tipo RadForm.
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
            // Sólo procesa controles de tipo RadTextBox: 
            if (control is RadTextBox)
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
