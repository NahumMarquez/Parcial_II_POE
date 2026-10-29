namespace Parcial_II_POE.Formularios
{
    partial class Panel
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
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarAEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarAMateriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarANotasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNotas
            // 
            this.dgvNotas.AllowUserToAddRows = false;
            this.dgvNotas.AllowUserToDeleteRows = false;
            this.dgvNotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNotas.Location = new System.Drawing.Point(0, 410);
            this.dgvNotas.MultiSelect = false;
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.ReadOnly = true;
            this.dgvNotas.RowHeadersWidth = 51;
            this.dgvNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotas.Size = new System.Drawing.Size(1100, 240);
            this.dgvNotas.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.materiasToolStripMenuItem,
            this.notasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1100, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarAEstudiantesToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.registrosToolStripMenuItem.Text = "Estudiantes";
            this.registrosToolStripMenuItem.Click += new System.EventHandler(this.registrosToolStripMenuItem_Click);
            // 
            // ingresarAEstudiantesToolStripMenuItem
            // 
            this.ingresarAEstudiantesToolStripMenuItem.Name = "ingresarAEstudiantesToolStripMenuItem";
            this.ingresarAEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.ingresarAEstudiantesToolStripMenuItem.Text = "Ingresar a Estudiantes";
            this.ingresarAEstudiantesToolStripMenuItem.Click += new System.EventHandler(this.ingresarAEstudiantesToolStripMenuItem_Click);
            // 
            // materiasToolStripMenuItem
            // 
            this.materiasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarAMateriasToolStripMenuItem});
            this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            this.materiasToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.materiasToolStripMenuItem.Text = "Materias";
            this.materiasToolStripMenuItem.Click += new System.EventHandler(this.materiasToolStripMenuItem_Click);
            // 
            // ingresarAMateriasToolStripMenuItem
            // 
            this.ingresarAMateriasToolStripMenuItem.Name = "ingresarAMateriasToolStripMenuItem";
            this.ingresarAMateriasToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.ingresarAMateriasToolStripMenuItem.Text = "Ingresar a Materias";
            this.ingresarAMateriasToolStripMenuItem.Click += new System.EventHandler(this.ingresarAMateriasToolStripMenuItem_Click_1);
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarANotasToolStripMenuItem1});
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.notasToolStripMenuItem.Text = "Notas";
            this.notasToolStripMenuItem.Click += new System.EventHandler(this.notasToolStripMenuItem_Click);
            // 
            // ingresarANotasToolStripMenuItem1
            // 
            this.ingresarANotasToolStripMenuItem1.Name = "ingresarANotasToolStripMenuItem1";
            this.ingresarANotasToolStripMenuItem1.Size = new System.Drawing.Size(197, 26);
            this.ingresarANotasToolStripMenuItem1.Text = "Ingresar a notas";
            this.ingresarANotasToolStripMenuItem1.Click += new System.EventHandler(this.ingresarANotasToolStripMenuItem1_Click);
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.dgvNotas);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Panel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel de Opciones";
            this.Load += new System.EventHandler(this.Panel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dgvNotas;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarANotasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ingresarAEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarAMateriasToolStripMenuItem;
    }
}