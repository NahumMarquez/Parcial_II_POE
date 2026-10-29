namespace Parcial_II_POE.Formularios
{
    partial class frmRegistrarMateria
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvRegistro = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).BeginInit();
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
            this.txtCiclo.Size = new System.Drawing.Size(190, 22);
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
            this.txtCarrera.Size = new System.Drawing.Size(250, 22);
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
            this.txtNombre.Size = new System.Drawing.Size(250, 22);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.MaxLength = 100;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(110, 143);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 30);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvRegistro
            // 
            this.dgvRegistro.Location = new System.Drawing.Point(20, 195);
            this.dgvRegistro.Name = "dgvRegistro";
            this.dgvRegistro.Size = new System.Drawing.Size(740, 305);
            this.dgvRegistro.TabIndex = 4;
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
            // frmRegistrarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 520);
            this.Controls.Add(this.dgvRegistro);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.txtCiclo);
            this.Controls.Add(this.lblCiclo);
            this.KeyPreview = true;
            this.Name = "frmRegistrarMateria";
            this.Text = "Crear Materia";
            this.Load += new System.EventHandler(this.frmRegistrarMateria_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRegistrarMateria_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).EndInit();
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
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvRegistro;
    }
}
