namespace Parcial_II_POE.Formularios
{
    partial class frmRegistrarMateriaCmd
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblCiclo = new System.Windows.Forms.Label();
            this.txtCiclo = new System.Windows.Forms.TextBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCiclo
            // 
            this.lblCiclo.AutoSize = true;
            this.lblCiclo.Location = new System.Drawing.Point(20, 28);
            this.lblCiclo.Name = "lblCiclo";
            this.lblCiclo.Text = "Ciclo:";
            // 
            // txtCiclo
            // 
            this.txtCiclo.Location = new System.Drawing.Point(110, 25);
            this.txtCiclo.Name = "txtCiclo";
            this.txtCiclo.Size = new System.Drawing.Size(200, 22);
            this.txtCiclo.TabIndex = 0;
            this.txtCiclo.MaxLength = 20;
            this.txtCiclo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCiclo_KeyPress);
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(20, 68);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Text = "Carrera:";
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(110, 65);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(230, 22);
            this.txtCarrera.TabIndex = 1;
            this.txtCarrera.MaxLength = 100;
            this.txtCarrera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCarrera_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 108);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Text = "Materia:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(110, 105);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(230, 22);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.MaxLength = 100;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(110, 170);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 30);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(235, 170);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 30);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmRegistrarMateriaCmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 270);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.txtCiclo);
            this.Controls.Add(this.lblCiclo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Name = "frmRegistrarMateriaCmd";
            this.Text = "Editar Materia";
            this.Load += new System.EventHandler(this.frmRegistrarMateriaCmd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCiclo;
        private System.Windows.Forms.TextBox txtCiclo;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
