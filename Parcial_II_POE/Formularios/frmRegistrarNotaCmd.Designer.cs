namespace Parcial_II_POE.Formularios
{
    partial class frmRegistrarNotaCmd
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
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.lblEstudianteValor = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblMateriaValor = new System.Windows.Forms.Label();
            this.lblLaboratorio = new System.Windows.Forms.Label();
            this.txtLaboratorio = new System.Windows.Forms.TextBox();
            this.lblParcial = new System.Windows.Forms.Label();
            this.txtParcial = new System.Windows.Forms.TextBox();
            this.lblAsistencia = new System.Windows.Forms.Label();
            this.txtAsistencia = new System.Windows.Forms.TextBox();
            this.lblNotaFinal = new System.Windows.Forms.Label();
            this.lblNotaFinalValor = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Location = new System.Drawing.Point(20, 25);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Text = "Estudiante:";
            // 
            // lblEstudianteValor
            // 
            this.lblEstudianteValor.AutoEllipsis = true;
            this.lblEstudianteValor.AutoSize = false;
            this.lblEstudianteValor.Size = new System.Drawing.Size(420, 20);
            this.lblEstudianteValor.Location = new System.Drawing.Point(120, 25);
            this.lblEstudianteValor.Name = "lblEstudianteValor";
            this.lblEstudianteValor.Text = "";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(20, 55);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Text = "Materia:";
            // 
            // lblMateriaValor
            // 
            this.lblMateriaValor.AutoEllipsis = true;
            this.lblMateriaValor.AutoSize = false;
            this.lblMateriaValor.Size = new System.Drawing.Size(420, 20);
            this.lblMateriaValor.Location = new System.Drawing.Point(120, 55);
            this.lblMateriaValor.Name = "lblMateriaValor";
            this.lblMateriaValor.Text = "";
            // 
            // lblLaboratorio
            // 
            this.lblLaboratorio.AutoSize = true;
            this.lblLaboratorio.Location = new System.Drawing.Point(20, 100);
            this.lblLaboratorio.Name = "lblLaboratorio";
            this.lblLaboratorio.Text = "Laboratorio (50%):";
            // 
            // txtLaboratorio
            // 
            this.txtLaboratorio.Location = new System.Drawing.Point(170, 97);
            this.txtLaboratorio.Name = "txtLaboratorio";
            this.txtLaboratorio.Size = new System.Drawing.Size(100, 22);
            this.txtLaboratorio.TabIndex = 0;
            this.txtLaboratorio.MaxLength = 5;
            this.txtLaboratorio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota_KeyPress);
            this.txtLaboratorio.TextChanged += new System.EventHandler(this.txtNota_TextChanged);
            // 
            // lblParcial
            // 
            this.lblParcial.AutoSize = true;
            this.lblParcial.Location = new System.Drawing.Point(20, 140);
            this.lblParcial.Name = "lblParcial";
            this.lblParcial.Text = "Parcial (40%):";
            // 
            // txtParcial
            // 
            this.txtParcial.Location = new System.Drawing.Point(170, 137);
            this.txtParcial.Name = "txtParcial";
            this.txtParcial.Size = new System.Drawing.Size(100, 22);
            this.txtParcial.TabIndex = 1;
            this.txtParcial.MaxLength = 5;
            this.txtParcial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota_KeyPress);
            this.txtParcial.TextChanged += new System.EventHandler(this.txtNota_TextChanged);
            // 
            // lblAsistencia
            // 
            this.lblAsistencia.AutoSize = true;
            this.lblAsistencia.Location = new System.Drawing.Point(20, 180);
            this.lblAsistencia.Name = "lblAsistencia";
            this.lblAsistencia.Text = "Asistencia (10%):";
            // 
            // txtAsistencia
            // 
            this.txtAsistencia.Location = new System.Drawing.Point(170, 177);
            this.txtAsistencia.Name = "txtAsistencia";
            this.txtAsistencia.Size = new System.Drawing.Size(100, 22);
            this.txtAsistencia.TabIndex = 2;
            this.txtAsistencia.MaxLength = 5;
            this.txtAsistencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota_KeyPress);
            this.txtAsistencia.TextChanged += new System.EventHandler(this.txtNota_TextChanged);
            // 
            // lblNotaFinal
            // 
            this.lblNotaFinal.AutoSize = true;
            this.lblNotaFinal.Location = new System.Drawing.Point(20, 220);
            this.lblNotaFinal.Name = "lblNotaFinal";
            this.lblNotaFinal.Text = "Nota final:";
            this.lblNotaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            // 
            // lblNotaFinalValor
            // 
            this.lblNotaFinalValor.AutoSize = true;
            this.lblNotaFinalValor.Location = new System.Drawing.Point(170, 220);
            this.lblNotaFinalValor.Name = "lblNotaFinalValor";
            this.lblNotaFinalValor.Text = "0.00";
            this.lblNotaFinalValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(165, 265);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 30);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(295, 265);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 30);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmRegistrarNotaCmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 330);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblNotaFinalValor);
            this.Controls.Add(this.lblNotaFinal);
            this.Controls.Add(this.txtAsistencia);
            this.Controls.Add(this.lblAsistencia);
            this.Controls.Add(this.txtParcial);
            this.Controls.Add(this.lblParcial);
            this.Controls.Add(this.txtLaboratorio);
            this.Controls.Add(this.lblLaboratorio);
            this.Controls.Add(this.lblMateriaValor);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblEstudianteValor);
            this.Controls.Add(this.lblEstudiante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Name = "frmRegistrarNotaCmd";
            this.Text = "Editar Nota";
            this.Load += new System.EventHandler(this.frmRegistrarNotaCmd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.Label lblEstudianteValor;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblMateriaValor;
        private System.Windows.Forms.Label lblLaboratorio;
        private System.Windows.Forms.TextBox txtLaboratorio;
        private System.Windows.Forms.Label lblParcial;
        private System.Windows.Forms.TextBox txtParcial;
        private System.Windows.Forms.Label lblAsistencia;
        private System.Windows.Forms.TextBox txtAsistencia;
        private System.Windows.Forms.Label lblNotaFinal;
        private System.Windows.Forms.Label lblNotaFinalValor;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
