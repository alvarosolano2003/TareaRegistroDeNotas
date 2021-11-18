
namespace Presentation
{
    partial class FrmMatricula
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSociologia = new System.Windows.Forms.CheckBox();
            this.cbProgramacion = new System.Windows.Forms.CheckBox();
            this.cbMatematica = new System.Windows.Forms.CheckBox();
            this.cbIngles = new System.Windows.Forms.CheckBox();
            this.cbContabilidad = new System.Windows.Forms.CheckBox();
            this.cbAlgebra = new System.Windows.Forms.CheckBox();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cmbGrupo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCarnet);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbSociologia);
            this.groupBox2.Controls.Add(this.cbProgramacion);
            this.groupBox2.Controls.Add(this.cbMatematica);
            this.groupBox2.Controls.Add(this.cbIngles);
            this.groupBox2.Controls.Add(this.cbContabilidad);
            this.groupBox2.Controls.Add(this.cbAlgebra);
            this.groupBox2.Location = new System.Drawing.Point(43, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 128);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asignaturas";
            // 
            // cbSociologia
            // 
            this.cbSociologia.AutoSize = true;
            this.cbSociologia.Location = new System.Drawing.Point(188, 94);
            this.cbSociologia.Name = "cbSociologia";
            this.cbSociologia.Size = new System.Drawing.Size(75, 17);
            this.cbSociologia.TabIndex = 5;
            this.cbSociologia.Text = "Sociologia";
            this.cbSociologia.UseVisualStyleBackColor = true;
            // 
            // cbProgramacion
            // 
            this.cbProgramacion.AutoSize = true;
            this.cbProgramacion.Location = new System.Drawing.Point(188, 62);
            this.cbProgramacion.Name = "cbProgramacion";
            this.cbProgramacion.Size = new System.Drawing.Size(97, 17);
            this.cbProgramacion.TabIndex = 4;
            this.cbProgramacion.Text = "Programacion I";
            this.cbProgramacion.UseVisualStyleBackColor = true;
            // 
            // cbMatematica
            // 
            this.cbMatematica.AutoSize = true;
            this.cbMatematica.Location = new System.Drawing.Point(188, 27);
            this.cbMatematica.Name = "cbMatematica";
            this.cbMatematica.Size = new System.Drawing.Size(90, 17);
            this.cbMatematica.TabIndex = 3;
            this.cbMatematica.Text = "Matematica II";
            this.cbMatematica.UseVisualStyleBackColor = true;
            // 
            // cbIngles
            // 
            this.cbIngles.AutoSize = true;
            this.cbIngles.Location = new System.Drawing.Point(16, 94);
            this.cbIngles.Name = "cbIngles";
            this.cbIngles.Size = new System.Drawing.Size(63, 17);
            this.cbIngles.TabIndex = 2;
            this.cbIngles.Text = "Ingles II";
            this.cbIngles.UseVisualStyleBackColor = true;
            // 
            // cbContabilidad
            // 
            this.cbContabilidad.AutoSize = true;
            this.cbContabilidad.Location = new System.Drawing.Point(16, 62);
            this.cbContabilidad.Name = "cbContabilidad";
            this.cbContabilidad.Size = new System.Drawing.Size(134, 17);
            this.cbContabilidad.TabIndex = 1;
            this.cbContabilidad.Text = "Contabilidad de Costos";
            this.cbContabilidad.UseVisualStyleBackColor = true;
            // 
            // cbAlgebra
            // 
            this.cbAlgebra.AutoSize = true;
            this.cbAlgebra.Location = new System.Drawing.Point(16, 27);
            this.cbAlgebra.Name = "cbAlgebra";
            this.cbAlgebra.Size = new System.Drawing.Size(93, 17);
            this.cbAlgebra.TabIndex = 0;
            this.cbAlgebra.Text = "Algebra Lineal";
            this.cbAlgebra.UseVisualStyleBackColor = true;
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Items.AddRange(new object[] {
            "1M1",
            "1M2",
            "1M3",
            "1T1"});
            this.cmbGrupo.Location = new System.Drawing.Point(174, 94);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(200, 21);
            this.cmbGrupo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carnet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Grupo:";
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(174, 28);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(200, 20);
            this.txtCarnet.TabIndex = 4;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(174, 59);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(324, 308);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(243, 308);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 343);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMatricula";
            this.Text = "Formulario de Matricula";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbSociologia;
        private System.Windows.Forms.CheckBox cbProgramacion;
        private System.Windows.Forms.CheckBox cbMatematica;
        private System.Windows.Forms.CheckBox cbIngles;
        private System.Windows.Forms.CheckBox cbContabilidad;
        private System.Windows.Forms.CheckBox cbAlgebra;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}