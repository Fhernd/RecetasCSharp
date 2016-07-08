namespace R0701_DevExpress
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
            this.xtrSclContenedor = new DevExpress.XtraEditors.XtraScrollableControl();
            this.SuspendLayout();
            // 
            // xtrSclContenedor
            // 
            this.xtrSclContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtrSclContenedor.Location = new System.Drawing.Point(0, 0);
            this.xtrSclContenedor.Name = "xtrSclContenedor";
            this.xtrSclContenedor.Size = new System.Drawing.Size(294, 321);
            this.xtrSclContenedor.TabIndex = 0;
            // 
            // R0701
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(294, 321);
            this.Controls.Add(this.xtrSclContenedor);
            this.Name = "R0701";
            this.Text = "R0701 [DevExpress]";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.XtraScrollableControl xtrSclContenedor;
    }
}

