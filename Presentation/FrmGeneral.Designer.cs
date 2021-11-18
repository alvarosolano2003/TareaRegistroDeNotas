
namespace Presentation
{
    partial class FrmGeneral
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
            this.gbMatriculas = new System.Windows.Forms.GroupBox();
            this.btnMAgregar = new System.Windows.Forms.Button();
            this.btnShowInformation = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnShowEstudiantes = new System.Windows.Forms.Button();
            this.btnECMostrar = new System.Windows.Forms.Button();
            this.btnEAgregar = new System.Windows.Forms.Button();
            this.rtbMatriculas = new System.Windows.Forms.RichTextBox();
            this.rtbJsonEstudiantes = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbMatriculas.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMatriculas
            // 
            this.gbMatriculas.Controls.Add(this.btnMAgregar);
            this.gbMatriculas.Controls.Add(this.btnShowInformation);
            this.gbMatriculas.Location = new System.Drawing.Point(12, 12);
            this.gbMatriculas.Name = "gbMatriculas";
            this.gbMatriculas.Size = new System.Drawing.Size(194, 116);
            this.gbMatriculas.TabIndex = 0;
            this.gbMatriculas.TabStop = false;
            this.gbMatriculas.Text = "Matriculas";
            // 
            // btnMAgregar
            // 
            this.btnMAgregar.Location = new System.Drawing.Point(7, 20);
            this.btnMAgregar.Name = "btnMAgregar";
            this.btnMAgregar.Size = new System.Drawing.Size(181, 23);
            this.btnMAgregar.TabIndex = 0;
            this.btnMAgregar.Text = "Agregar Matricula";
            this.btnMAgregar.UseVisualStyleBackColor = true;
            this.btnMAgregar.Click += new System.EventHandler(this.btnMAgregar_Click);
            // 
            // btnShowInformation
            // 
            this.btnShowInformation.Location = new System.Drawing.Point(7, 49);
            this.btnShowInformation.Name = "btnShowInformation";
            this.btnShowInformation.Size = new System.Drawing.Size(181, 23);
            this.btnShowInformation.TabIndex = 4;
            this.btnShowInformation.Text = "Mostrar Informacion";
            this.btnShowInformation.UseVisualStyleBackColor = true;
            this.btnShowInformation.Click += new System.EventHandler(this.btnShowInformation_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnShowEstudiantes);
            this.groupBox3.Controls.Add(this.btnECMostrar);
            this.groupBox3.Controls.Add(this.btnEAgregar);
            this.groupBox3.Location = new System.Drawing.Point(463, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(191, 116);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estudiantes";
            // 
            // btnShowEstudiantes
            // 
            this.btnShowEstudiantes.Location = new System.Drawing.Point(7, 80);
            this.btnShowEstudiantes.Name = "btnShowEstudiantes";
            this.btnShowEstudiantes.Size = new System.Drawing.Size(178, 23);
            this.btnShowEstudiantes.TabIndex = 2;
            this.btnShowEstudiantes.Text = "Mostrar informacion";
            this.btnShowEstudiantes.UseVisualStyleBackColor = true;
            this.btnShowEstudiantes.Click += new System.EventHandler(this.btnShowEstudiantes_Click);
            // 
            // btnECMostrar
            // 
            this.btnECMostrar.Location = new System.Drawing.Point(7, 50);
            this.btnECMostrar.Name = "btnECMostrar";
            this.btnECMostrar.Size = new System.Drawing.Size(178, 23);
            this.btnECMostrar.TabIndex = 1;
            this.btnECMostrar.Text = "Mostrar calificaciones";
            this.btnECMostrar.UseVisualStyleBackColor = true;
            this.btnECMostrar.Click += new System.EventHandler(this.btnECMostrar_Click);
            // 
            // btnEAgregar
            // 
            this.btnEAgregar.Location = new System.Drawing.Point(7, 20);
            this.btnEAgregar.Name = "btnEAgregar";
            this.btnEAgregar.Size = new System.Drawing.Size(178, 23);
            this.btnEAgregar.TabIndex = 0;
            this.btnEAgregar.Text = "Agregar Estudiantes";
            this.btnEAgregar.UseVisualStyleBackColor = true;
            this.btnEAgregar.Click += new System.EventHandler(this.btnEAgregar_Click);
            // 
            // rtbMatriculas
            // 
            this.rtbMatriculas.Location = new System.Drawing.Point(12, 205);
            this.rtbMatriculas.Name = "rtbMatriculas";
            this.rtbMatriculas.Size = new System.Drawing.Size(311, 157);
            this.rtbMatriculas.TabIndex = 2;
            this.rtbMatriculas.Text = "";
            // 
            // rtbJsonEstudiantes
            // 
            this.rtbJsonEstudiantes.Location = new System.Drawing.Point(341, 205);
            this.rtbJsonEstudiantes.Name = "rtbJsonEstudiantes";
            this.rtbJsonEstudiantes.Size = new System.Drawing.Size(313, 157);
            this.rtbJsonEstudiantes.TabIndex = 3;
            this.rtbJsonEstudiantes.Text = "";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(524, 415);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lista de Matriculas por carnet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Estudiantes en formato Json:";
            // 
            // FrmGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 372);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.rtbJsonEstudiantes);
            this.Controls.Add(this.rtbMatriculas);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbMatriculas);
            this.Name = "FrmGeneral";
            this.Text = "Formulario General";
            this.Activated += new System.EventHandler(this.FrmGeneral_Activated);
            this.gbMatriculas.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMatriculas;
        private System.Windows.Forms.Button btnMAgregar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtbMatriculas;
        private System.Windows.Forms.RichTextBox rtbJsonEstudiantes;
        private System.Windows.Forms.Button btnShowInformation;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnECMostrar;
        private System.Windows.Forms.Button btnEAgregar;
        private System.Windows.Forms.Button btnShowEstudiantes;
    }
}