using System;
using System.IO;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace R0702_Telerik
{
    /// <summary>
    /// Demostración de uso de Tag en Telerik.
    /// </summary>
    public partial class R0702 : Telerik.WinControls.UI.RadForm
    {
        /// <summary>
        /// Crea una nueva instancia del formulario basado en RadForm.
        /// </summary>
        public R0702()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga un objeto en la propiedad Tag de un objeto ListviewDataItem.
        /// </summary>
        /// <param name="e">Datos del evento.</param>
        protected override void OnLoad(EventArgs e)
        {
            // Invoca al método OnLoad() para asegurar que la carga del evento 
            // sea correcta: 
            base.OnLoad(e);

            // Obtiene todos los archivos del directorio raíz: 
            DirectoryInfo directorioC = new DirectoryInfo(@"C:\");
            FileInfo[] archivos = directorioC.GetFiles();

            // Muestra cada uno de los archivos del directorio C:\ 
            // en el control RadListView: 
            foreach (FileInfo archivo in archivos)
            {
                ListViewDataItem lvdiElemento = new ListViewDataItem(archivo.Name);
                rlvContenedor.Items.Add(lvdiElemento);
                lvdiElemento.ImageIndex = 0;

                // La información de cada objeto FileInfo se asocia con cada 
                // objeto ListViewDataItem: 
                lvdiElemento.Tag = archivo;
            }
        }

        /// <summary>
        /// Responde al evento de doble clic sobre uno de los nombres de archivo.
        /// </summary>
        /// <param name="sender">Objeto generador del evento.</param>
        /// <param name="e">Datos del evento.</param>
        private void rlvContenedor_ItemMouseDoubleClick(object sender, ListViewItemEventArgs e)
        {
            ListViewDataItem lvdiElemento = ((RadListViewElement) sender).CurrentItem;
            FileInfo infoArchivo = (FileInfo) lvdiElemento.Tag;

            string info = String.Format("{0} ocupa {1} bytes.", infoArchivo.FullName, infoArchivo.Length);

            MessageBox.Show(info, "Información Archivo");
        }
    }
}
