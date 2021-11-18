
namespace Presentation
{
    partial class FrmMostrarEstudiantes
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
            this.dgvShowEstudiantes = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShowEstudiantes
            // 
            this.dgvShowEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowEstudiantes.Location = new System.Drawing.Point(13, 13);
            this.dgvShowEstudiantes.Name = "dgvShowEstudiantes";
            this.dgvShowEstudiantes.Size = new System.Drawing.Size(687, 274);
            this.dgvShowEstudiantes.TabIndex = 0;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(563, 294);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(123, 23);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FrmMostrarEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 341);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dgvShowEstudiantes);
            this.Name = "FrmMostrarEstudiantes";
            this.Text = "Mostrar estudiantes";
            this.Load += new System.EventHandler(this.FrmMostrarEstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowEstudiantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowEstudiantes;
        private System.Windows.Forms.Button btnRegresar;
    }
}