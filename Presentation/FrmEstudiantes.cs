using Domain.Entites;
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
    public partial class FrmEstudiantes : Form
    {
        public MatriculasModel matriculasModel;
        public EstudiantesModel estudiatesModel;
        public NotasModel notasModel;

        public int i { get; set; }
        public FrmEstudiantes()
        {
            i = AccesData.count;
            matriculasModel = AccesData.matriculaModelAD;
            notasModel = AccesData.notasModelAD;
            estudiatesModel = i > 0 ? AccesData.estudiantesModelAD : new EstudiantesModel();
            InitializeComponent();
        }

        private void FrmEstudiantes_Load(object sender, EventArgs e)
        {
            lblNMatricula.Text = matriculasModel.GetAll()[i].NumeroDeMatricula.ToString();
            txtCarnet.Text = matriculasModel.GetAll()[i].Carnet;
            CLS();
            CheckLimits();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                CatchExceptions(txtCarnet.Text == string.Empty);
                CatchExceptions(txtNombre.Text == string.Empty);
                CatchExceptions(txtApellido.Text == string.Empty);
                CatchExceptions(dtpFechaNacimiento.Value == null);
                CatchExceptions(notasModel.GetAll() == null);

                Estudiantes est = new Estudiantes()
                {
                    Matricula = matriculasModel.GetAll()[i],
                    Id = matriculasModel.GetAll()[i].NumeroDeMatricula,
                    Nombres = txtNombre.Text,
                    Apellidos = txtApellido.Text,
                    Carnet = txtCarnet.Text,
                    FechaDeNacimiento = dtpFechaNacimiento.Value,
                    Edad = DateTime.Now.Year - dtpFechaNacimiento.Value.Year,
                    Notas = notasModel.GetAll().ToArray()
                };

                estudiatesModel.Create(est);

                MessageBox.Show("El ingreso del estudiante ha sido un exito.",
                    "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCAgregar_Click(object sender, EventArgs e)
        {
            AccesData.estudiantesModelAD = estudiatesModel;
            AccesData.count = i;

            FrmNotas frmNotas = new FrmNotas(matriculasModel.GetAll()[i].Asignaturas);
            frmNotas.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AccesData.count = 0;
            AccesData.estudiantesModelAD = estudiatesModel;
            AccesData.matriculaModelAD = matriculasModel;

            FrmGeneral frmGeneral = new FrmGeneral();
            frmGeneral.matriculasModel = this.matriculasModel;
            frmGeneral.estudiantesModel = this.estudiatesModel;
            frmGeneral.Activate();
            frmGeneral.Show();
            this.Close();
        }

        private void CheckLimits()
        {
            if (matriculasModel.GetAll().Count - 1 == i)
            {
                btnMSiguiente.Visible = false;
                btnMAnterior.Visible = true;
            }
            else if (i == 0)
            {
                btnMSiguiente.Visible = true;
                btnMAnterior.Visible = false;
            }
        }

        private void btnMSiguiente_Click(object sender, EventArgs e)
        {
            ++i;
            //AccesData.count = i;
            lblNMatricula.Text = matriculasModel.GetAll()[i].NumeroDeMatricula.ToString();
            CLS();
            CheckLimits();
        }

        private void btnMAnterior_Click(object sender, EventArgs e)
        {
            --i;
            //AccesData.count = i;
            lblNMatricula.Text = matriculasModel.GetAll()[i].NumeroDeMatricula.ToString();
            CLS();
            CheckLimits();
        }

        private void CLS()
        {
            if (estudiatesModel.GetAll().Count > i)
            {
                txtNombre.Text = estudiatesModel.GetAll()[i].Nombres;
                txtApellido.Text = estudiatesModel.GetAll()[i].Apellidos;
                txtCarnet.Text = estudiatesModel.GetAll()[i].Carnet;
                dtpFechaNacimiento.Value = estudiatesModel.GetAll()[i].FechaDeNacimiento;

                btnAceptar.Visible = false;
                return;
            }

            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCarnet.Text = matriculasModel.GetAll()[i].Carnet;
            dtpFechaNacimiento.Value = DateTime.Now;
            
            btnAceptar.Visible = true;
        }

        private void CatchExceptions(bool v)
        {
            if (v == true)
            {
                throw new ArgumentException("Todos los campos deben estar llenos.");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{matriculasModel.GetAll().Count}");
        }
    }
}
