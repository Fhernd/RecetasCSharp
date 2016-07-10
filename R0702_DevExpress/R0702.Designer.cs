namespace R0702_DevExpress
{
    partial class R0702
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(R0702));
            this.lvwContenedor = new System.Windows.Forms.ListView();
            this.imlImagenes = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lvwContenedor
            // 
            this.lvwContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwContenedor.LargeImageList = this.imlImagenes;
            this.lvwContenedor.Location = new System.Drawing.Point(0, 0);
            this.lvwContenedor.Name = "lvwContenedor";
            this.lvwContenedor.Size = new System.Drawing.Size(444, 351);
            this.lvwContenedor.TabIndex = 0;
            this.lvwContenedor.UseCompatibleStateImageBehavior = false;
            this.lvwContenedor.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvwContenedor_MouseDoubleClick);
            // 
            // imlImagenes
            // 
            this.imlImagenes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlImagenes.ImageStream")));
            this.imlImagenes.TransparentColor = System.Drawing.Color.Transparent;
            this.imlImagenes.Images.SetKeyName(0, "notepad.ico");
            // 
            // R0702
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 351);
            this.Controls.Add(this.lvwContenedor);
            this.Name = "R0702";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R0702 [DevExpress]";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwContenedor;
        private System.Windows.Forms.ImageList imlImagenes;
    }
}

