using System;
using System.IO;
using System.Windows.Forms;

namespace R0702_DevExpress
{
    /// <summary>
    /// Representa un formulario XtraForm.
    /// </summary>
    public partial class R0702 : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// Crea un nuevo formulario XtraForm.
        /// </summary>
        public R0702()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga un objeto en la propiedad Tag de un objeto ListViewItem.
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
            // en el control ListView: 
            foreach (FileInfo archivo in archivos)
            {
                ListViewItem elementoLista = lvwContenedor.Items.Add(archivo.Name);
                elementoLista.ImageIndex = 0;

                // La información de cada objeto FileInfo se asocia con cada 
                // objeto ListViewItem: 
                elementoLista.Tag = archivo;
            }
        }

        /// <summary>
        /// Obtiene la información asociada a un objeto FileInfo y muestra 
        /// su contenido al usuario.
        /// </summary>
        /// <param name="sender">Objeto generador del evento.</param>
        /// <param name="e">Datos del evento.</param>
        private void lvwContenedor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = ((ListView) sender).SelectedItems[0];
            FileInfo infoArchivo = (FileInfo) item.Tag;
            string info = String.Format("{0} ocupa {1} bytes.", infoArchivo.FullName, infoArchivo.Length);

            MessageBox.Show(info, "Información Archivo");
        }
    }
}
