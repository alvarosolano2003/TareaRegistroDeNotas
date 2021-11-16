
namespace Presentation
{
    partial class FrmEstudiantes
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
            this.lblCalificaciones = new System.Windows.Forms.Label();
            this.btnCAgregar = new System.Windows.Forms.Button();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMSiguiente = new System.Windows.Forms.Button();
            this.btnMAnterior = new System.Windows.Forms.Button();
            this.lblNMatricula = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCalificaciones);
            this.groupBox1.Controls.Add(this.btnCAgregar);
            this.groupBox1.Controls.Add(this.dtpFechaNacimiento);
            this.groupBox1.Controls.Add(this.txtCarnet);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Estudiante";
            // 
            // lblCalificaciones
            // 
            this.lblCalificaciones.AutoSize = true;
            this.lblCalificaciones.Location = new System.Drawing.Point(23, 201);
            this.lblCalificaciones.Name = "lblCalificaciones";
            this.lblCalificaciones.Size = new System.Drawing.Size(171, 13);
            this.lblCalificaciones.TabIndex = 13;
            this.lblCalificaciones.Text = "No se han agregado calificaciones";
            // 
            // btnCAgregar
            // 
            this.btnCAgregar.Location = new System.Drawing.Point(47, 227);
            this.btnCAgregar.Name = "btnCAgregar";
            this.btnCAgregar.Size = new System.Drawing.Size(128, 23);
            this.btnCAgregar.TabIndex = 12;
            this.btnCAgregar.Text = "Agregar Calificaciones";
            this.btnCAgregar.UseVisualStyleBackColor = true;
            this.btnCAgregar.Click += new System.EventHandler(this.btnCAgregar_Click);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(183, 159);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(206, 20);
            this.dtpFechaNacimiento.TabIndex = 9;
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(183, 116);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(206, 20);
            this.txtCarnet.TabIndex = 8;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(183, 72);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(206, 20);
            this.txtApellido.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(183, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(206, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha de Nacimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Carnet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombres:";
            // 
            // btnMSiguiente
            // 
            this.btnMSiguiente.Location = new System.Drawing.Point(108, 35);
            this.btnMSiguiente.Name = "btnMSiguiente";
            this.btnMSiguiente.Size = new System.Drawing.Size(87, 23);
            this.btnMSiguiente.TabIndex = 11;
            this.btnMSiguiente.Text = "Siguiente";
            this.btnMSiguiente.UseVisualStyleBackColor = true;
            this.btnMSiguiente.Click += new System.EventHandler(this.btnMSiguiente_Click);
            // 
            // btnMAnterior
            // 
            this.btnMAnterior.Location = new System.Drawing.Point(11, 35);
            this.btnMAnterior.Name = "btnMAnterior";
            this.btnMAnterior.Size = new System.Drawing.Size(91, 23);
            this.btnMAnterior.TabIndex = 10;
            this.btnMAnterior.Text = "Anterior";
            this.btnMAnterior.UseVisualStyleBackColor = true;
            this.btnMAnterior.Click += new System.EventHandler(this.btnMAnterior_Click);
            // 
            // lblNMatricula
            // 
            this.lblNMatricula.AutoSize = true;
            this.lblNMatricula.Location = new System.Drawing.Point(53, 19);
            this.lblNMatricula.Name = "lblNMatricula";
            this.lblNMatricula.Size = new System.Drawing.Size(35, 13);
            this.lblNMatricula.TabIndex = 1;
            this.lblNMatricula.Text = "label2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMSiguiente);
            this.groupBox2.Controls.Add(this.lblNMatricula);
            this.groupBox2.Controls.Add(this.btnMAnterior);
            this.groupBox2.Location = new System.Drawing.Point(99, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 73);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Numero de Matricula";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(327, 374);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(146, 374);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(163, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Regresar al formulario general";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Prueba";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FrmEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 417);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEstudiantes";
            this.Text = "Formulario de Estudiantes";
            this.Load += new System.EventHandler(this.FrmEstudiantes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNMatricula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblCalificaciones;
        private System.Windows.Forms.Button btnCAgregar;
        private System.Windows.Forms.Button btnMSiguiente;
        private System.Windows.Forms.Button btnMAnterior;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button button1;
    }
}