namespace R0702_Telerik
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
            this.rlvContenedor = new Telerik.WinControls.UI.RadListView();
            this.imlImagenes = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rlvContenedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // rlvContenedor
            // 
            this.rlvContenedor.AllowColumnReorder = false;
            this.rlvContenedor.AllowColumnResize = false;
            this.rlvContenedor.AllowDrop = true;
            this.rlvContenedor.AllowEdit = false;
            this.rlvContenedor.AllowRemove = false;
            this.rlvContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rlvContenedor.Location = new System.Drawing.Point(0, 0);
            this.rlvContenedor.Name = "rlvContenedor";
            this.rlvContenedor.Size = new System.Drawing.Size(452, 360);
            this.rlvContenedor.TabIndex = 0;
            this.rlvContenedor.Text = "_";
            this.rlvContenedor.ItemMouseDoubleClick += new Telerik.WinControls.UI.ListViewItemEventHandler(this.rlvContenedor_ItemMouseDoubleClick);
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
            this.ClientSize = new System.Drawing.Size(452, 360);
            this.Controls.Add(this.rlvContenedor);
            this.Name = "R0702";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R0702 [Telerik]";
            ((System.ComponentModel.ISupportInitialize)(this.rlvContenedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadListView rlvContenedor;
        private System.Windows.Forms.ImageList imlImagenes;
    }
}