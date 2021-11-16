using Domain.Entites;
using Domain.Enums;
using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FrmNotas : Form
    {
        public NotasModel notasModel = new NotasModel();
        public Asignaturas[] asignaturas;
        public int c { get; set; }
        public FrmNotas(Asignaturas[] arr)
        {
            asignaturas = arr;
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Notas n = new Notas()
                {
                    Asignatura = asignaturas[c],
                    IP = nudIP.Value,
                    IIP = nudIIP.Value,
                    IC = nudIC.Value,
                    IIC = nudIIC.Value,
                    Sistematicos = nudSis.Value,
                    NotaFinal = notasModel.CalculateFinalScore(nudIP.Value, nudIIP.Value, nudSis.Value, nudIC.Value, nudIIC.Value)
                };

                notasModel.Create(n);

                lblMsg.Visible = true;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmEstudiantes frmEstudiantes = new FrmEstudiantes();
            frmEstudiantes.notasModel = this.notasModel;
            frmEstudiantes.Activate();
            frmEstudiantes.Show();
            this.Close();
        }

        private void FrmNotas_Load(object sender, EventArgs e)
        {
           // notasModel.DeleteAll();

            if (c == asignaturas.Length)
            {
                btnSiguiente.Visible = false;
                lblAsignatura.Text = string.Empty;
                lblARestantes.Text = "0";
            }
            else
            {
                lblAsignatura.Text = DeterminateAsignatura(asignaturas[c]);
                lblARestantes.Text = $"{asignaturas.Length - c}";
            }

            CLS();
        }

        private void CLS()
        {
            nudIP.Value = 0;
            nudIIP.Value = 0;
            nudSis.Value = 0;
            nudIC.Value = 0;
            nudIIC.Value = 0;

            nudIC.Visible = false;
            nudIIC.Visible = false;

            lblMsg.Visible = false;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            ++c;

            if (c == asignaturas.Length)
            {
                btnSiguiente.Visible = false;
                lblAsignatura.Text = string.Empty;
                lblARestantes.Text = "0";
            }
            else
            {
                lblAsignatura.Text = DeterminateAsignatura(asignaturas[c]);
                lblARestantes.Text = $"{asignaturas.Length - c}";
            }

            CLS();
        }

        private string DeterminateAsignatura(Asignaturas a)
        {
            int count = 0;
            Asignaturas[] arrAs = {Domain.Enums.Asignaturas.AlgebraLineal,
                Domain.Enums.Asignaturas.ContabilidadDeCostos,
                Domain.Enums.Asignaturas.InglesII, Domain.Enums.Asignaturas.MatematicaII,
                Domain.Enums.Asignaturas.ProgramacionI, Domain.Enums.Asignaturas.Sociologia };

            foreach (Asignaturas asig in arrAs)
            {
                if (asig == a)
                {
                    break;
                }

                count++;
            }

            switch (count)
            {
                case 0:
                    return "Algebra Lineal";

                case 1:
                    return "Contabilidad de Costos";

                case 2:
                    return "Ingles II";

                case 3:
                    return "Matematica II";

                case 4:
                    return "Programacion I";

                case 5:
                    return "Sociologia";

                default:
                    throw new ArgumentException("Objeto no encontrado en asignaturas.");
            }
        }

        private void nudSis_ValueChanged(object sender, EventArgs e)
        {
            if (nudIP.Value + nudIIP.Value + nudSis.Value < 60)
            {
                nudIC.Visible = true;
            }
        }

        private void nudIC_ValueChanged(object sender, EventArgs e)
        {
            if (nudIC.Value + nudSis.Value < 60)
            {
                nudIIC.Visible = true;
            }
        }
    }
}
