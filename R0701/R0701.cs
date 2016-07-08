using System;
using System.Windows.Forms;

namespace R0701
{
    public partial class R0701 : Form
    {
        public R0701()
        {
            // Inicialización del los componentes de la interfaz 
            // gráfica de usuario: 
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            // Para asegurar que este evento se dispare correctamente 
            // se invoca el método base: 
            base.OnLoad(e);

            // Nombres de tecnologías relacionadas con .NET Framework: 
            string[] dotNet =
            {
                "C#", "WinForms", "WPF", "Visual Studio",
                "LINQ", "TPL", "Telerik", "DevExpress",
                "ReSharper", "OzCode", "JustCode", "ASP.NET"
            };

            // Invocación de SupendLayout() para asegurar que la lógica 
            // de agregación de controles de forma dinámica sea óptima: 
            this.SuspendLayout();

            // Variable auxiliar para controlar la posición horizontal del 
            // control a agregar: 
            int posicionHorizontal = 10;

            // Crea controles CheckBox de forma dinámica: 
            foreach (string app in dotNet)
            {
                // Crea un nuevo control tipo CheckBox: 
                CheckBox checkBox = new CheckBox();

                // Establece la configuración de este nuevo control: 
                checkBox.Top = posicionHorizontal;
                checkBox.Left = 10;
                checkBox.Text = app;

                // Actualiza la posición horizontal para el nuevo control: 
                posicionHorizontal += 30;

                // Agrega el nuevo control al panel contenido en formulario: 
                pnlContenedor.Controls.Add(checkBox);
            }

            // Reestablece la lógica del control una vez se han agregado de forma 
            // dinámica todos los controles CheckBox: 
            this.ResumeLayout();
        }
    }
}
