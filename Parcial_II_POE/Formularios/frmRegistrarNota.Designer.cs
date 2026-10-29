namespace Parcial_II_POE.Formularios
{
    partial class frmRegistrarNota
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
            this.cmbEstudiante = new System.Windows.Forms.ComboBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.lblTipoNota = new System.Windows.Forms.Label();
            this.cmbTipoNota = new System.Windows.Forms.ComboBox();
            this.lblLaboratorio = new System.Windows.Forms.Label();
            this.txtLaboratorio = new System.Windows.Forms.TextBox();
            this.lblParcial = new System.Windows.Forms.Label();
            this.txtParcial = new System.Windows.Forms.TextBox();
            this.lblAsistencia = new System.Windows.Forms.Label();
            this.txtAsistencia = new System.Windows.Forms.TextBox();
            this.lblNotaFinal = new System.Windows.Forms.Label();
            this.lblNotaFinalValor = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvRegistro = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Location = new System.Drawing.Point(20, 28);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Text = "Estudiante:";
            // 
            // cmbEstudiante
            // 
            this.cmbEstudiante.Location = new System.Drawing.Point(120, 25);
            this.cmbEstudiante.Name = "cmbEstudiante";
            this.cmbEstudiante.Size = new System.Drawing.Size(260, 24);
            this.cmbEstudiante.TabIndex = 0;
            this.cmbEstudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstudiante.FormattingEnabled = true;
            this.cmbEstudiante.SelectedIndexChanged += new System.EventHandler(this.cmbEstudiante_SelectedIndexChanged);
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(20, 68);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Text = "Materia:";
            // 
            // cmbMateria
            // 
            this.cmbMateria.Location = new System.Drawing.Point(120, 65);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(260, 24);
            this.cmbMateria.TabIndex = 1;
            this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.SelectedIndexChanged += new System.EventHandler(this.cmbMateria_SelectedIndexChanged);
            // 
            // lblTipoNota
            // 
            this.lblTipoNota.AutoSize = true;
            this.lblTipoNota.Location = new System.Drawing.Point(20, 108);
            this.lblTipoNota.Name = "lblTipoNota";
            this.lblTipoNota.Text = "Nota a registrar:";
            // 
            // cmbTipoNota
            // 
            this.cmbTipoNota.Location = new System.Drawing.Point(160, 105);
            this.cmbTipoNota.Name = "cmbTipoNota";
            this.cmbTipoNota.Size = new System.Drawing.Size(220, 24);
            this.cmbTipoNota.TabIndex = 2;
            this.cmbTipoNota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoNota.FormattingEnabled = true;
            this.cmbTipoNota.SelectedIndexChanged += new System.EventHandler(this.cmbTipoNota_SelectedIndexChanged);
            // 
            // lblLaboratorio
            // 
            this.lblLaboratorio.AutoSize = true;
            this.lblLaboratorio.Location = new System.Drawing.Point(420, 28);
            this.lblLaboratorio.Name = "lblLaboratorio";
            this.lblLaboratorio.Text = "Laboratorio (50%):";
            // 
            // txtLaboratorio
            // 
            this.txtLaboratorio.Location = new System.Drawing.Point(560, 25);
            this.txtLaboratorio.Name = "txtLaboratorio";
            this.txtLaboratorio.Size = new System.Drawing.Size(100, 22);
            this.txtLaboratorio.TabIndex = 3;
            this.txtLaboratorio.MaxLength = 5;
            this.txtLaboratorio.ReadOnly = true;
            this.txtLaboratorio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota_KeyPress);
            this.txtLaboratorio.TextChanged += new System.EventHandler(this.txtNota_TextChanged);
            // 
            // lblParcial
            // 
            this.lblParcial.AutoSize = true;
            this.lblParcial.Location = new System.Drawing.Point(420, 68);
            this.lblParcial.Name = "lblParcial";
            this.lblParcial.Text = "Parcial (40%):";
            // 
            // txtParcial
            // 
            this.txtParcial.Location = new System.Drawing.Point(560, 65);
            this.txtParcial.Name = "txtParcial";
            this.txtParcial.Size = new System.Drawing.Size(100, 22);
            this.txtParcial.TabIndex = 4;
            this.txtParcial.MaxLength = 5;
            this.txtParcial.ReadOnly = true;
            this.txtParcial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota_KeyPress);
            this.txtParcial.TextChanged += new System.EventHandler(this.txtNota_TextChanged);
            // 
            // lblAsistencia
            // 
            this.lblAsistencia.AutoSize = true;
            this.lblAsistencia.Location = new System.Drawing.Point(420, 108);
            this.lblAsistencia.Name = "lblAsistencia";
            this.lblAsistencia.Text = "Asistencia (10%):";
            // 
            // txtAsistencia
            // 
            this.txtAsistencia.Location = new System.Drawing.Point(560, 105);
            this.txtAsistencia.Name = "txtAsistencia";
            this.txtAsistencia.Size = new System.Drawing.Size(100, 22);
            this.txtAsistencia.TabIndex = 5;
            this.txtAsistencia.MaxLength = 5;
            this.txtAsistencia.ReadOnly = true;
            this.txtAsistencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota_KeyPress);
            this.txtAsistencia.TextChanged += new System.EventHandler(this.txtNota_TextChanged);
            // 
            // lblNotaFinal
            // 
            this.lblNotaFinal.AutoSize = true;
            this.lblNotaFinal.Location = new System.Drawing.Point(420, 150);
            this.lblNotaFinal.Name = "lblNotaFinal";
            this.lblNotaFinal.Text = "Nota final:";
            this.lblNotaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            // 
            // lblNotaFinalValor
            // 
            this.lblNotaFinalValor.AutoSize = true;
            this.lblNotaFinalValor.Location = new System.Drawing.Point(560, 150);
            this.lblNotaFinalValor.Name = "lblNotaFinalValor";
            this.lblNotaFinalValor.Text = "0.00";
            this.lblNotaFinalValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(280, 150);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 30);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvRegistro
            // 
            this.dgvRegistro.Location = new System.Drawing.Point(20, 200);
            this.dgvRegistro.Name = "dgvRegistro";
            this.dgvRegistro.Size = new System.Drawing.Size(740, 340);
            this.dgvRegistro.TabIndex = 7;
            this.dgvRegistro.AllowUserToAddRows = false;
            this.dgvRegistro.AllowUserToDeleteRows = false;
            this.dgvRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRegistro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistro.MultiSelect = false;
            this.dgvRegistro.ReadOnly = true;
            this.dgvRegistro.RowHeadersWidth = 51;
            this.dgvRegistro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistro_CellDoubleClick);
            // 
            // frmRegistrarNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 560);
            this.Controls.Add(this.dgvRegistro);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblNotaFinalValor);
            this.Controls.Add(this.lblNotaFinal);
            this.Controls.Add(this.txtAsistencia);
            this.Controls.Add(this.lblAsistencia);
            this.Controls.Add(this.txtParcial);
            this.Controls.Add(this.lblParcial);
            this.Controls.Add(this.txtLaboratorio);
            this.Controls.Add(this.lblLaboratorio);
            this.Controls.Add(this.cmbTipoNota);
            this.Controls.Add(this.lblTipoNota);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.cmbEstudiante);
            this.Controls.Add(this.lblEstudiante);
            this.KeyPreview = true;
            this.Name = "frmRegistrarNota";
            this.Text = "Registrar Nota";
            this.Load += new System.EventHandler(this.frmRegistrarNota_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRegistrarNota_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.ComboBox cmbEstudiante;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.Label lblTipoNota;
        private System.Windows.Forms.ComboBox cmbTipoNota;
        private System.Windows.Forms.Label lblLaboratorio;
        private System.Windows.Forms.TextBox txtLaboratorio;
        private System.Windows.Forms.Label lblParcial;
        private System.Windows.Forms.TextBox txtParcial;
        private System.Windows.Forms.Label lblAsistencia;
        private System.Windows.Forms.TextBox txtAsistencia;
        private System.Windows.Forms.Label lblNotaFinal;
        private System.Windows.Forms.Label lblNotaFinalValor;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvRegistro;
    }
}
