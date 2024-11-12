namespace WindowsFormsApp1
{
    partial class FrmMainPrincipal
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
            this.btnCarreras = new System.Windows.Forms.Button();
            this.BtnCurso = new System.Windows.Forms.Button();
            this.btnProfesores = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.btnMaterias = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCarreras
            // 
            this.btnCarreras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarreras.Location = new System.Drawing.Point(33, 27);
            this.btnCarreras.Name = "btnCarreras";
            this.btnCarreras.Size = new System.Drawing.Size(274, 45);
            this.btnCarreras.TabIndex = 0;
            this.btnCarreras.Text = "CARRERAS";
            this.btnCarreras.UseVisualStyleBackColor = true;
            this.btnCarreras.Click += new System.EventHandler(this.btnCarreras_Click);
            // 
            // BtnCurso
            // 
            this.BtnCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCurso.Location = new System.Drawing.Point(33, 93);
            this.BtnCurso.Name = "BtnCurso";
            this.BtnCurso.Size = new System.Drawing.Size(274, 45);
            this.BtnCurso.TabIndex = 1;
            this.BtnCurso.Text = "CURSO";
            this.BtnCurso.UseVisualStyleBackColor = true;
            this.BtnCurso.Click += new System.EventHandler(this.BtnCurso_Click);
            // 
            // btnProfesores
            // 
            this.btnProfesores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfesores.Location = new System.Drawing.Point(33, 157);
            this.btnProfesores.Name = "btnProfesores";
            this.btnProfesores.Size = new System.Drawing.Size(274, 45);
            this.btnProfesores.TabIndex = 2;
            this.btnProfesores.Text = "PROFESORES";
            this.btnProfesores.UseVisualStyleBackColor = true;
            // 
            // btnUsuario
            // 
            this.btnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.Location = new System.Drawing.Point(33, 220);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(274, 45);
            this.btnUsuario.TabIndex = 3;
            this.btnUsuario.Text = "USUARIO";
            this.btnUsuario.UseVisualStyleBackColor = true;
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumnos.Location = new System.Drawing.Point(33, 282);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(274, 45);
            this.btnAlumnos.TabIndex = 4;
            this.btnAlumnos.Text = "ALUMNOS";
            this.btnAlumnos.UseVisualStyleBackColor = true;
            // 
            // btnMaterias
            // 
            this.btnMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterias.Location = new System.Drawing.Point(33, 351);
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.Size = new System.Drawing.Size(274, 45);
            this.btnMaterias.TabIndex = 5;
            this.btnMaterias.Text = "MATERIAS";
            this.btnMaterias.UseVisualStyleBackColor = true;
            this.btnMaterias.Click += new System.EventHandler(this.btnMaterias_Click);
            // 
            // FrmMainPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(351, 440);
            this.Controls.Add(this.btnMaterias);
            this.Controls.Add(this.btnAlumnos);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnProfesores);
            this.Controls.Add(this.BtnCurso);
            this.Controls.Add(this.btnCarreras);
            this.Name = "FrmMainPrincipal";
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmMainPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCarreras;
        private System.Windows.Forms.Button BtnCurso;
        private System.Windows.Forms.Button btnProfesores;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.Button btnMaterias;
    }
}