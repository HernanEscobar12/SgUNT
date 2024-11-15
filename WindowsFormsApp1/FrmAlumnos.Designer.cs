namespace WindowsFormsApp1
{
    partial class FrmAlumnos
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
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.btnSelec = new System.Windows.Forms.Button();
            this.btnNue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAlumnos.Location = new System.Drawing.Point(9, 25);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(452, 234);
            this.dgvAlumnos.TabIndex = 0;
            // 
            // btnSelec
            // 
            this.btnSelec.Location = new System.Drawing.Point(12, 274);
            this.btnSelec.Name = "btnSelec";
            this.btnSelec.Size = new System.Drawing.Size(97, 42);
            this.btnSelec.TabIndex = 1;
            this.btnSelec.Text = "Seleccionar";
            this.btnSelec.UseVisualStyleBackColor = true;
            this.btnSelec.Click += new System.EventHandler(this.btnSelec_Click);
            // 
            // btnNue
            // 
            this.btnNue.Location = new System.Drawing.Point(364, 271);
            this.btnNue.Name = "btnNue";
            this.btnNue.Size = new System.Drawing.Size(97, 42);
            this.btnNue.TabIndex = 2;
            this.btnNue.Text = "Nuevo";
            this.btnNue.UseVisualStyleBackColor = true;
            this.btnNue.Click += new System.EventHandler(this.btnNue_Click);
            // 
            // FrmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 325);
            this.Controls.Add(this.btnNue);
            this.Controls.Add(this.btnSelec);
            this.Controls.Add(this.dgvAlumnos);
            this.MaximumSize = new System.Drawing.Size(490, 364);
            this.Name = "FrmAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.FrmAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Button btnSelec;
        private System.Windows.Forms.Button btnNue;
    }
}