namespace R0703_WinForms
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
            this.btnBoton1 = new System.Windows.Forms.Button();
            this.lblEtiqueta1 = new System.Windows.Forms.Label();
            this.txtCampo1 = new System.Windows.Forms.TextBox();
            this.btnBoton2 = new System.Windows.Forms.Button();
            this.txtCampo2 = new System.Windows.Forms.TextBox();
            this.gbxControles = new System.Windows.Forms.GroupBox();
            this.lblEtiqueta2 = new System.Windows.Forms.Label();
            this.btnProcesarControles = new System.Windows.Forms.Button();
            this.gbxControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBoton1
            // 
            this.btnBoton1.Location = new System.Drawing.Point(26, 19);
            this.btnBoton1.Name = "btnBoton1";
            this.btnBoton1.Size = new System.Drawing.Size(75, 23);
            this.btnBoton1.TabIndex = 0;
            this.btnBoton1.Text = "Botón 1";
            this.btnBoton1.UseVisualStyleBackColor = true;
            // 
            // lblEtiqueta1
            // 
            this.lblEtiqueta1.AutoSize = true;
            this.lblEtiqueta1.Location = new System.Drawing.Point(23, 98);
            this.lblEtiqueta1.Name = "lblEtiqueta1";
            this.lblEtiqueta1.Size = new System.Drawing.Size(55, 13);
            this.lblEtiqueta1.TabIndex = 1;
            this.lblEtiqueta1.Text = "Etiqueta 1";
            // 
            // txtCampo1
            // 
            this.txtCampo1.Location = new System.Drawing.Point(26, 61);
            this.txtCampo1.Name = "txtCampo1";
            this.txtCampo1.Size = new System.Drawing.Size(100, 20);
            this.txtCampo1.TabIndex = 2;
            this.txtCampo1.Text = "Campo 1";
            // 
            // btnBoton2
            // 
            this.btnBoton2.Location = new System.Drawing.Point(176, 19);
            this.btnBoton2.Name = "btnBoton2";
            this.btnBoton2.Size = new System.Drawing.Size(75, 23);
            this.btnBoton2.TabIndex = 3;
            this.btnBoton2.Text = "Botón 2";
            this.btnBoton2.UseVisualStyleBackColor = true;
            // 
            // txtCampo2
            // 
            this.txtCampo2.Location = new System.Drawing.Point(176, 61);
            this.txtCampo2.Name = "txtCampo2";
            this.txtCampo2.Size = new System.Drawing.Size(100, 20);
            this.txtCampo2.TabIndex = 4;
            this.txtCampo2.Text = "Campo 2";
            // 
            // gbxControles
            // 
            this.gbxControles.Controls.Add(this.lblEtiqueta2);
            this.gbxControles.Controls.Add(this.btnBoton2);
            this.gbxControles.Controls.Add(this.txtCampo2);
            this.gbxControles.Controls.Add(this.btnBoton1);
            this.gbxControles.Controls.Add(this.lblEtiqueta1);
            this.gbxControles.Controls.Add(this.txtCampo1);
            this.gbxControles.Location = new System.Drawing.Point(12, 12);
            this.gbxControles.Name = "gbxControles";
            this.gbxControles.Size = new System.Drawing.Size(318, 120);
            this.gbxControles.TabIndex = 5;
            this.gbxControles.TabStop = false;
            this.gbxControles.Text = "Controles";
            // 
            // lblEtiqueta2
            // 
            this.lblEtiqueta2.AutoSize = true;
            this.lblEtiqueta2.Location = new System.Drawing.Point(176, 97);
            this.lblEtiqueta2.Name = "lblEtiqueta2";
            this.lblEtiqueta2.Size = new System.Drawing.Size(55, 13);
            this.lblEtiqueta2.TabIndex = 5;
            this.lblEtiqueta2.Text = "Etiqueta 2";
            // 
            // btnProcesarControles
            // 
            this.btnProcesarControles.Location = new System.Drawing.Point(95, 148);
            this.btnProcesarControles.Name = "btnProcesarControles";
            this.btnProcesarControles.Size = new System.Drawing.Size(148, 23);
            this.btnProcesarControles.TabIndex = 6;
            this.btnProcesarControles.Text = "Procesar Controles";
            this.btnProcesarControles.UseVisualStyleBackColor = true;
            this.btnProcesarControles.Click += new System.EventHandler(this.btnProcesarControles_Click);
            // 
            // R0703
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 181);
            this.Controls.Add(this.btnProcesarControles);
            this.Controls.Add(this.gbxControles);
            this.Name = "R0703";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R0703 [WinForms]";
            this.gbxControles.ResumeLayout(false);
            this.gbxControles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBoton1;
        private System.Windows.Forms.Label lblEtiqueta1;
        private System.Windows.Forms.TextBox txtCampo1;
        private System.Windows.Forms.Button btnBoton2;
        private System.Windows.Forms.TextBox txtCampo2;
        private System.Windows.Forms.GroupBox gbxControles;
        private System.Windows.Forms.Label lblEtiqueta2;
        private System.Windows.Forms.Button btnProcesarControles;
    }
}

