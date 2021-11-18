
namespace Presentation
{
    partial class FrmMostrarInformacion
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
            this.rtbMostrar = new System.Windows.Forms.RichTextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbMostrar
            // 
            this.rtbMostrar.Location = new System.Drawing.Point(12, 12);
            this.rtbMostrar.Name = "rtbMostrar";
            this.rtbMostrar.Size = new System.Drawing.Size(763, 328);
            this.rtbMostrar.TabIndex = 0;
            this.rtbMostrar.Text = "";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(292, 358);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "Menu";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FrmMostrarInformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.rtbMostrar);
            this.Name = "FrmMostrarInformacion";
            this.Text = "FrmMostrarInformacion";
            this.Load += new System.EventHandler(this.FrmMostrarInformacion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMostrar;
        private System.Windows.Forms.Button btnRegresar;
    }
}