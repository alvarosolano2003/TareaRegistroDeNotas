
namespace Presentation
{
    partial class FrmNotas
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
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblARestantes = new System.Windows.Forms.Label();
            this.lblAlcp = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.nudIP = new System.Windows.Forms.NumericUpDown();
            this.nudIIP = new System.Windows.Forms.NumericUpDown();
            this.nudSis = new System.Windows.Forms.NumericUpDown();
            this.nudIC = new System.Windows.Forms.NumericUpDown();
            this.nudIIC = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAsignatura = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIIC)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMsg);
            this.groupBox1.Controls.Add(this.lblARestantes);
            this.groupBox1.Controls.Add(this.lblAlcp);
            this.groupBox1.Controls.Add(this.btnSiguiente);
            this.groupBox1.Controls.Add(this.nudIP);
            this.groupBox1.Controls.Add(this.nudIIP);
            this.groupBox1.Controls.Add(this.nudSis);
            this.groupBox1.Controls.Add(this.nudIC);
            this.groupBox1.Controls.Add(this.nudIIC);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblAsignatura);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calificaciones";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(29, 70);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(155, 13);
            this.lblMsg.TabIndex = 10;
            this.lblMsg.Text = "Calificacion agregada con exito";
            // 
            // lblARestantes
            // 
            this.lblARestantes.AutoSize = true;
            this.lblARestantes.Location = new System.Drawing.Point(121, 48);
            this.lblARestantes.Name = "lblARestantes";
            this.lblARestantes.Size = new System.Drawing.Size(18, 13);
            this.lblARestantes.TabIndex = 9;
            this.lblARestantes.Text = "int";
            // 
            // lblAlcp
            // 
            this.lblAlcp.AutoSize = true;
            this.lblAlcp.Location = new System.Drawing.Point(54, 48);
            this.lblAlcp.Name = "lblAlcp";
            this.lblAlcp.Size = new System.Drawing.Size(61, 13);
            this.lblAlcp.TabIndex = 8;
            this.lblAlcp.Text = "Restantes: ";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(85, 274);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(54, 23);
            this.btnSiguiente.TabIndex = 7;
            this.btnSiguiente.Text = "--->";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // nudIP
            // 
            this.nudIP.Location = new System.Drawing.Point(124, 105);
            this.nudIP.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.nudIP.Name = "nudIP";
            this.nudIP.Size = new System.Drawing.Size(77, 20);
            this.nudIP.TabIndex = 1;
            // 
            // nudIIP
            // 
            this.nudIIP.Location = new System.Drawing.Point(124, 135);
            this.nudIIP.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.nudIIP.Name = "nudIIP";
            this.nudIIP.Size = new System.Drawing.Size(77, 20);
            this.nudIIP.TabIndex = 2;
            // 
            // nudSis
            // 
            this.nudSis.Location = new System.Drawing.Point(124, 165);
            this.nudSis.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudSis.Name = "nudSis";
            this.nudSis.Size = new System.Drawing.Size(77, 20);
            this.nudSis.TabIndex = 3;
            this.nudSis.ValueChanged += new System.EventHandler(this.nudSis_ValueChanged);
            // 
            // nudIC
            // 
            this.nudIC.Location = new System.Drawing.Point(124, 202);
            this.nudIC.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.nudIC.Name = "nudIC";
            this.nudIC.Size = new System.Drawing.Size(77, 20);
            this.nudIC.TabIndex = 4;
            this.nudIC.ValueChanged += new System.EventHandler(this.nudIC_ValueChanged);
            // 
            // nudIIC
            // 
            this.nudIIC.Location = new System.Drawing.Point(124, 237);
            this.nudIIC.Name = "nudIIC";
            this.nudIIC.Size = new System.Drawing.Size(77, 20);
            this.nudIIC.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Convo 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Convo 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sistematicos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "2do Parcial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "1er Parcial";
            // 
            // lblAsignatura
            // 
            this.lblAsignatura.AutoSize = true;
            this.lblAsignatura.Location = new System.Drawing.Point(121, 25);
            this.lblAsignatura.Name = "lblAsignatura";
            this.lblAsignatura.Size = new System.Drawing.Size(32, 13);
            this.lblAsignatura.TabIndex = 1;
            this.lblAsignatura.Text = "string";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asignatura:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(98, 327);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(138, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Agregar calificaciones";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(17, 327);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FrmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 363);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmNotas";
            this.Text = "Formulario de Notas";
            this.Load += new System.EventHandler(this.FrmNotas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIIC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.NumericUpDown nudIP;
        private System.Windows.Forms.NumericUpDown nudIIP;
        private System.Windows.Forms.NumericUpDown nudSis;
        private System.Windows.Forms.NumericUpDown nudIC;
        private System.Windows.Forms.NumericUpDown nudIIC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAsignatura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblARestantes;
        private System.Windows.Forms.Label lblAlcp;
        private System.Windows.Forms.Label lblMsg;
    }
}