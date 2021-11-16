using Domain.Entites;
using Domain.Enums;
using Domain.Interfaces;
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
    public partial class FrmMatricula : Form
    {
        public MatriculasModel matriculasModel;
        public int Count { get; set; }
        public FrmMatricula()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                CatchExceptions(txtCarnet.Text == string.Empty);
                CatchExceptions(dtpFecha.Value == null);
                CatchExceptions(cmbGrupo.SelectedIndex < 0);

                Matriculas m = new Matriculas()
                {
                    NumeroDeMatricula = ++Count,
                    Fecha = dtpFecha.Value,
                    Carnet = txtCarnet.Text,
                    Grupo = (Grupo)cmbGrupo.SelectedIndex,
                    Asignaturas = IngresarAsignaturas()
                };

                matriculasModel.Create(m);

                MessageBox.Show("El ingreso de matricula ha sido un exito.",
                    "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CLS();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"{ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmGeneral general = new FrmGeneral();
            general.matriculasModel = this.matriculasModel;
            general.Activate();
            general.Show();
            this.Close();
        }

        private Asignaturas[] IngresarAsignaturas()
        {
            List<Asignaturas> asignaturas = new List<Asignaturas>();

            if (cbAlgebra.Checked == true)
            {
                asignaturas.Add(Domain.Enums.Asignaturas.AlgebraLineal);
            }
            if (cbContabilidad.Checked == true)
            {
                asignaturas.Add(Domain.Enums.Asignaturas.ContabilidadDeCostos);
            }
            if (cbIngles.Checked == true)
            {
                asignaturas.Add(Domain.Enums.Asignaturas.InglesII);
            }
            if (cbMatematica.Checked == true)
            {
                asignaturas.Add(Domain.Enums.Asignaturas.MatematicaII);
            }
            if (cbProgramacion.Checked == true)
            {
                asignaturas.Add(Domain.Enums.Asignaturas.ProgramacionI);
            }
            if (cbSociologia.Checked == true)
            {
                asignaturas.Add(Domain.Enums.Asignaturas.Sociologia);
            }

            if (asignaturas.Count == 0)
            {
                throw new ArgumentException("Debe seleccionar al menos una asignatura.");
            }

            return asignaturas.ToArray();
        }

        private void CatchExceptions(bool v)
        {
            if (v == true)
            {
                throw new ArgumentException("Todos los campos deben estar llenos.");
            }
        }

        private void CLS()
        {
            txtCarnet.Text = string.Empty;
            dtpFecha.Value = DateTime.Now;
            cmbGrupo.SelectedIndex = -1;
            cbAlgebra.Checked = false;
            cbContabilidad.Checked = false;
            cbIngles.Checked = false;
            cbMatematica.Checked = false;
            cbProgramacion.Checked = false;
            cbSociologia.Checked = false;
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{matriculasModel.GetAll().Count}");
        }
    }
}
