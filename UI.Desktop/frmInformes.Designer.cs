namespace UI.Desktop
{
    partial class frmInformes
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
            this.chbNomAp = new System.Windows.Forms.CheckBox();
            this.chbEdad = new System.Windows.Forms.CheckBox();
            this.chbObraSocial = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chbGrupoSanguineo = new System.Windows.Forms.CheckBox();
            this.cbxGrupoSanguineo = new System.Windows.Forms.ComboBox();
            this.chbDocumento = new System.Windows.Forms.CheckBox();
            this.cbxFactorSanguineo = new System.Windows.Forms.ComboBox();
            this.lblFactorSanguineo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chbNomAp
            // 
            this.chbNomAp.AutoSize = true;
            this.chbNomAp.Location = new System.Drawing.Point(55, 63);
            this.chbNomAp.Name = "chbNomAp";
            this.chbNomAp.Size = new System.Drawing.Size(111, 17);
            this.chbNomAp.TabIndex = 0;
            this.chbNomAp.Text = "Nombre y Apellido";
            this.chbNomAp.UseVisualStyleBackColor = true;
            // 
            // chbEdad
            // 
            this.chbEdad.AutoSize = true;
            this.chbEdad.Location = new System.Drawing.Point(55, 109);
            this.chbEdad.Name = "chbEdad";
            this.chbEdad.Size = new System.Drawing.Size(51, 17);
            this.chbEdad.TabIndex = 1;
            this.chbEdad.Text = "Edad";
            this.chbEdad.UseVisualStyleBackColor = true;
            // 
            // chbObraSocial
            // 
            this.chbObraSocial.AutoSize = true;
            this.chbObraSocial.Location = new System.Drawing.Point(55, 132);
            this.chbObraSocial.Name = "chbObraSocial";
            this.chbObraSocial.Size = new System.Drawing.Size(81, 17);
            this.chbObraSocial.TabIndex = 2;
            this.chbObraSocial.Text = "Obra Social";
            this.chbObraSocial.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(142, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(78, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // chbGrupoSanguineo
            // 
            this.chbGrupoSanguineo.AutoSize = true;
            this.chbGrupoSanguineo.Location = new System.Drawing.Point(55, 155);
            this.chbGrupoSanguineo.Name = "chbGrupoSanguineo";
            this.chbGrupoSanguineo.Size = new System.Drawing.Size(109, 17);
            this.chbGrupoSanguineo.TabIndex = 4;
            this.chbGrupoSanguineo.Text = "Grupo Sanguineo";
            this.chbGrupoSanguineo.UseVisualStyleBackColor = true;
            // 
            // cbxGrupoSanguineo
            // 
            this.cbxGrupoSanguineo.FormattingEnabled = true;
            this.cbxGrupoSanguineo.Location = new System.Drawing.Point(170, 153);
            this.cbxGrupoSanguineo.Name = "cbxGrupoSanguineo";
            this.cbxGrupoSanguineo.Size = new System.Drawing.Size(50, 21);
            this.cbxGrupoSanguineo.TabIndex = 5;
            // 
            // chbDocumento
            // 
            this.chbDocumento.AutoSize = true;
            this.chbDocumento.Location = new System.Drawing.Point(55, 86);
            this.chbDocumento.Name = "chbDocumento";
            this.chbDocumento.Size = new System.Drawing.Size(81, 17);
            this.chbDocumento.TabIndex = 6;
            this.chbDocumento.Text = "Documento";
            this.chbDocumento.UseVisualStyleBackColor = true;
            // 
            // cbxFactorSanguineo
            // 
            this.cbxFactorSanguineo.FormattingEnabled = true;
            this.cbxFactorSanguineo.Location = new System.Drawing.Point(269, 156);
            this.cbxFactorSanguineo.Name = "cbxFactorSanguineo";
            this.cbxFactorSanguineo.Size = new System.Drawing.Size(61, 21);
            this.cbxFactorSanguineo.TabIndex = 41;
            // 
            // lblFactorSanguineo
            // 
            this.lblFactorSanguineo.AutoSize = true;
            this.lblFactorSanguineo.Location = new System.Drawing.Point(230, 159);
            this.lblFactorSanguineo.Name = "lblFactorSanguineo";
            this.lblFactorSanguineo.Size = new System.Drawing.Size(37, 13);
            this.lblFactorSanguineo.TabIndex = 40;
            this.lblFactorSanguineo.Text = "Factor";
            // 
            // frmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.cbxFactorSanguineo);
            this.Controls.Add(this.lblFactorSanguineo);
            this.Controls.Add(this.chbDocumento);
            this.Controls.Add(this.cbxGrupoSanguineo);
            this.Controls.Add(this.chbGrupoSanguineo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chbObraSocial);
            this.Controls.Add(this.chbEdad);
            this.Controls.Add(this.chbNomAp);
            this.Name = "frmInformes";
            this.Text = "frmInformes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbNomAp;
        private System.Windows.Forms.CheckBox chbEdad;
        private System.Windows.Forms.CheckBox chbObraSocial;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox chbGrupoSanguineo;
        private System.Windows.Forms.ComboBox cbxGrupoSanguineo;
        private System.Windows.Forms.CheckBox chbDocumento;
        private System.Windows.Forms.ComboBox cbxFactorSanguineo;
        private System.Windows.Forms.Label lblFactorSanguineo;
    }
}