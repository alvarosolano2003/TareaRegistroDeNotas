
namespace Presentation
{
    partial class FrmMostrarNotas
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
            this.btnMostrarNotas = new System.Windows.Forms.Button();
            this.cmbEChose = new System.Windows.Forms.ComboBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrarNotas
            // 
            this.btnMostrarNotas.Location = new System.Drawing.Point(13, 13);
            this.btnMostrarNotas.Name = "btnMostrarNotas";
            this.btnMostrarNotas.Size = new System.Drawing.Size(160, 23);
            this.btnMostrarNotas.TabIndex = 1;
            this.btnMostrarNotas.Text = "Mostrar notas del estudiante:";
            this.btnMostrarNotas.UseVisualStyleBackColor = true;
            this.btnMostrarNotas.Click += new System.EventHandler(this.btnMostrarNotas_Click);
            // 
            // cmbEChose
            // 
            this.cmbEChose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEChose.FormattingEnabled = true;
            this.cmbEChose.Location = new System.Drawing.Point(198, 15);
            this.cmbEChose.Name = "cmbEChose";
            this.cmbEChose.Size = new System.Drawing.Size(206, 21);
            this.cmbEChose.TabIndex = 2;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(592, 13);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(97, 23);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(678, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // FrmMostrarNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 239);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.cmbEChose);
            this.Controls.Add(this.btnMostrarNotas);
            this.Name = "FrmMostrarNotas";
            this.Text = "Formulario de Mostrar Notas";
            this.Load += new System.EventHandler(this.FrmMostrarNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMostrarNotas;
        private System.Windows.Forms.ComboBox cmbEChose;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}