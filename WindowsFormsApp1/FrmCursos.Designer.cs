namespace WindowsFormsApp1
{
    partial class FrmCursos
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
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.gboFiltrar = new System.Windows.Forms.GroupBox();
            this.rbMateria = new System.Windows.Forms.RadioButton();
            this.rbAlumno = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cboAlumnos = new System.Windows.Forms.ComboBox();
            this.cboMaterias = new System.Windows.Forms.ComboBox();
            this.btnCargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.gboFiltrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMaterias.Location = new System.Drawing.Point(21, 86);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterias.Size = new System.Drawing.Size(649, 231);
            this.dgvMaterias.TabIndex = 0;
            // 
            // gboFiltrar
            // 
            this.gboFiltrar.Controls.Add(this.rbMateria);
            this.gboFiltrar.Controls.Add(this.rbAlumno);
            this.gboFiltrar.Controls.Add(this.textBox1);
            this.gboFiltrar.Location = new System.Drawing.Point(21, 13);
            this.gboFiltrar.Name = "gboFiltrar";
            this.gboFiltrar.Size = new System.Drawing.Size(649, 57);
            this.gboFiltrar.TabIndex = 1;
            this.gboFiltrar.TabStop = false;
            this.gboFiltrar.Text = "Filtrar";
            // 
            // rbMateria
            // 
            this.rbMateria.AutoSize = true;
            this.rbMateria.Location = new System.Drawing.Point(519, 20);
            this.rbMateria.Name = "rbMateria";
            this.rbMateria.Size = new System.Drawing.Size(60, 17);
            this.rbMateria.TabIndex = 2;
            this.rbMateria.TabStop = true;
            this.rbMateria.Text = "Materia";
            this.rbMateria.UseVisualStyleBackColor = true;
            // 
            // rbAlumno
            // 
            this.rbAlumno.AutoSize = true;
            this.rbAlumno.Location = new System.Drawing.Point(393, 21);
            this.rbAlumno.Name = "rbAlumno";
            this.rbAlumno.Size = new System.Drawing.Size(60, 17);
            this.rbAlumno.TabIndex = 1;
            this.rbAlumno.TabStop = true;
            this.rbAlumno.Text = "Alumno";
            this.rbAlumno.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(339, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cboAlumnos
            // 
            this.cboAlumnos.FormattingEnabled = true;
            this.cboAlumnos.Location = new System.Drawing.Point(21, 351);
            this.cboAlumnos.Name = "cboAlumnos";
            this.cboAlumnos.Size = new System.Drawing.Size(252, 21);
            this.cboAlumnos.TabIndex = 2;
            // 
            // cboMaterias
            // 
            this.cboMaterias.FormattingEnabled = true;
            this.cboMaterias.Location = new System.Drawing.Point(304, 351);
            this.cboMaterias.Name = "cboMaterias";
            this.cboMaterias.Size = new System.Drawing.Size(250, 21);
            this.cboMaterias.TabIndex = 3;
            // 
            // btnCargar
            // 
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(570, 351);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(100, 23);
            this.btnCargar.TabIndex = 4;
            this.btnCargar.Text = "Cargar Materia";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // FrmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 407);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.cboMaterias);
            this.Controls.Add(this.cboAlumnos);
            this.Controls.Add(this.gboFiltrar);
            this.Controls.Add(this.dgvMaterias);
            this.Name = "FrmCursos";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.FrmCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.gboFiltrar.ResumeLayout(false);
            this.gboFiltrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.GroupBox gboFiltrar;
        private System.Windows.Forms.ComboBox cboAlumnos;
        private System.Windows.Forms.ComboBox cboMaterias;
        private System.Windows.Forms.RadioButton rbMateria;
        private System.Windows.Forms.RadioButton rbAlumno;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCargar;
    }
}