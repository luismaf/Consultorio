namespace UI.Desktop
{
    partial class frmObrasSociales
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
            this.lstObrasSociales = new System.Windows.Forms.ListBox();
            this.btnAgregarObrasSociales = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstObrasSociales
            // 
            this.lstObrasSociales.FormattingEnabled = true;
            this.lstObrasSociales.Location = new System.Drawing.Point(12, 12);
            this.lstObrasSociales.Name = "lstObrasSociales";
            this.lstObrasSociales.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstObrasSociales.Size = new System.Drawing.Size(275, 160);
            this.lstObrasSociales.TabIndex = 43;
            this.lstObrasSociales.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstObrasSociales_MouseDoubleClick);
            // 
            // btnAgregarObrasSociales
            // 
            this.btnAgregarObrasSociales.Location = new System.Drawing.Point(299, 12);
            this.btnAgregarObrasSociales.Name = "btnAgregarObrasSociales";
            this.btnAgregarObrasSociales.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarObrasSociales.TabIndex = 44;
            this.btnAgregarObrasSociales.Text = "Agregar";
            this.btnAgregarObrasSociales.UseVisualStyleBackColor = true;
            this.btnAgregarObrasSociales.Click += new System.EventHandler(this.btnAgregarObrasSociales_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.CausesValidation = false;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelar.Location = new System.Drawing.Point(299, 41);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 45;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmObrasSociales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 188);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregarObrasSociales);
            this.Controls.Add(this.lstObrasSociales);
            this.Name = "frmObrasSociales";
            this.Text = "frmObrasSociales";
            this.Load += new System.EventHandler(this.frmObrasSociales_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmObrasSociales_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstObrasSociales;
        private System.Windows.Forms.Button btnAgregarObrasSociales;
        private System.Windows.Forms.Button btnCancelar;
    }
}