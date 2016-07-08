namespace R0701_Telerik
{
    partial class R0701
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
            this.pnlRadContenedor = new Telerik.WinControls.UI.RadScrollablePanel();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRadContenedor)).BeginInit();
            this.pnlRadContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRadContenedor
            // 
            this.pnlRadContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRadContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlRadContenedor.Name = "pnlRadContenedor";
            // 
            // pnlRadContenedor.PanelContainer
            // 
            this.pnlRadContenedor.PanelContainer.Size = new System.Drawing.Size(300, 328);
            this.pnlRadContenedor.Size = new System.Drawing.Size(302, 330);
            this.pnlRadContenedor.TabIndex = 0;
            this.pnlRadContenedor.Text = "radScrollablePanel1";
            // 
            // R0701
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 330);
            this.Controls.Add(this.pnlRadContenedor);
            this.Name = "R0701";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "R0701 [Telerik]";
            ((System.ComponentModel.ISupportInitialize)(this.pnlRadContenedor)).EndInit();
            this.pnlRadContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadScrollablePanel pnlRadContenedor;
    }
}