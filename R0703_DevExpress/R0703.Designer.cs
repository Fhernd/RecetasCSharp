namespace R0703_DevExpress
{
    partial class R0703
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblEtiqueta2 = new DevExpress.XtraEditors.LabelControl();
            this.lblEtiqueta1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCampo2 = new DevExpress.XtraEditors.TextEdit();
            this.txtCampo1 = new DevExpress.XtraEditors.TextEdit();
            this.btnBoton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnBoton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnProcesarControles = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCampo2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCampo1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblEtiqueta2);
            this.groupControl1.Controls.Add(this.lblEtiqueta1);
            this.groupControl1.Controls.Add(this.txtCampo2);
            this.groupControl1.Controls.Add(this.txtCampo1);
            this.groupControl1.Controls.Add(this.btnBoton2);
            this.groupControl1.Controls.Add(this.btnBoton1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(318, 120);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Controles";
            // 
            // lblEtiqueta2
            // 
            this.lblEtiqueta2.Location = new System.Drawing.Point(180, 95);
            this.lblEtiqueta2.Name = "lblEtiqueta2";
            this.lblEtiqueta2.Size = new System.Drawing.Size(49, 13);
            this.lblEtiqueta2.TabIndex = 5;
            this.lblEtiqueta2.Text = "Etiqueta 2";
            // 
            // lblEtiqueta1
            // 
            this.lblEtiqueta1.Location = new System.Drawing.Point(6, 95);
            this.lblEtiqueta1.Name = "lblEtiqueta1";
            this.lblEtiqueta1.Size = new System.Drawing.Size(49, 13);
            this.lblEtiqueta1.TabIndex = 4;
            this.lblEtiqueta1.Text = "Etiqueta 1";
            // 
            // txtCampo2
            // 
            this.txtCampo2.EditValue = "Campo 2";
            this.txtCampo2.Location = new System.Drawing.Point(180, 66);
            this.txtCampo2.Name = "txtCampo2";
            this.txtCampo2.Size = new System.Drawing.Size(100, 20);
            this.txtCampo2.TabIndex = 3;
            // 
            // txtCampo1
            // 
            this.txtCampo1.EditValue = "Campo 1";
            this.txtCampo1.Location = new System.Drawing.Point(6, 63);
            this.txtCampo1.Name = "txtCampo1";
            this.txtCampo1.Size = new System.Drawing.Size(100, 20);
            this.txtCampo1.TabIndex = 2;
            // 
            // btnBoton2
            // 
            this.btnBoton2.Location = new System.Drawing.Point(180, 24);
            this.btnBoton2.Name = "btnBoton2";
            this.btnBoton2.Size = new System.Drawing.Size(100, 23);
            this.btnBoton2.TabIndex = 1;
            this.btnBoton2.Text = "Botón";
            // 
            // btnBoton1
            // 
            this.btnBoton1.Location = new System.Drawing.Point(6, 24);
            this.btnBoton1.Name = "btnBoton1";
            this.btnBoton1.Size = new System.Drawing.Size(100, 23);
            this.btnBoton1.TabIndex = 0;
            this.btnBoton1.Text = "Botón 1";
            // 
            // btnProcesarControles
            // 
            this.btnProcesarControles.Location = new System.Drawing.Point(119, 146);
            this.btnProcesarControles.Name = "btnProcesarControles";
            this.btnProcesarControles.Size = new System.Drawing.Size(106, 23);
            this.btnProcesarControles.TabIndex = 1;
            this.btnProcesarControles.Text = "Procesar Controles";
            this.btnProcesarControles.Click += new System.EventHandler(this.btnProcesarControles_Click);
            // 
            // R0703
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 181);
            this.Controls.Add(this.btnProcesarControles);
            this.Controls.Add(this.groupControl1);
            this.Name = "R0703";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R0703 [DevExpress]";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCampo2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCampo1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnBoton2;
        private DevExpress.XtraEditors.SimpleButton btnBoton1;
        private DevExpress.XtraEditors.TextEdit txtCampo1;
        private DevExpress.XtraEditors.LabelControl lblEtiqueta2;
        private DevExpress.XtraEditors.LabelControl lblEtiqueta1;
        private DevExpress.XtraEditors.TextEdit txtCampo2;
        private DevExpress.XtraEditors.SimpleButton btnProcesarControles;
    }
}

