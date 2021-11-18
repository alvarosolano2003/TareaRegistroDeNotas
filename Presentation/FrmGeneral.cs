using Domain.Entites;
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
    public partial class FrmGeneral : Form
    {
        public MatriculasModel matriculasModel = new MatriculasModel();
        public EstudiantesModel estudiantesModel = new EstudiantesModel();
        public FrmGeneral()
        {
            matriculasModel = AccesData.matriculaModelAD == null ? new MatriculasModel() : AccesData.matriculaModelAD; 
            InitializeComponent();
        }

        private void btnMAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                GetAccesData();

                FrmMatricula matriculaFrm = new FrmMatricula();
                matriculaFrm.matriculasModel = this.matriculasModel;
                matriculaFrm.Activate();
                matriculaFrm.Show();
                this.Hide();

                GetAccesData();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"{ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void FrmGeneral_Activated(object sender, EventArgs e)
        {
            ShowInRTB();
        }

        private void ShowInRTB()
        {
            int b = matriculasModel.GetAll().Count;

            if (matriculasModel.GetAll().Count == 0)
            {
                AddAccesData();
                rtbMatriculas.Text = "No hay informacion para mostar.";
            }
            else
            {
                GetAccesData();

                List<Matriculas> listMatriculas = matriculasModel.GetAll();
                string aux = string.Empty;
                int i = 1;

                foreach (Matriculas a in listMatriculas)
                {
                    aux = $"{aux} \n {i}. {a.Carnet}";
                    i++;
                }

                rtbMatriculas.Text = aux;
            }

            if (estudiantesModel.GetAll().Count == 0)
            {
                rtbJsonEstudiantes.Text = "No hay informacion para mostar.";
            }
            else
            {
                GetAccesData();

                rtbJsonEstudiantes.Text = estudiantesModel.GetAsJson();
            }
        }

        private void btnEAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                CatchExceptions(AccesData.matriculaModelAD.GetAll().Count == 0);

                AddAccesData();

                FrmEstudiantes frmEstudiantes = new FrmEstudiantes();
                frmEstudiantes.Activate();
                frmEstudiantes.Show();
                this.Hide();

                GetAccesData();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"{ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void AddAccesData()
        {
            AccesData.estudiantesModelAD = this.estudiantesModel;
            AccesData.matriculaModelAD = this.matriculasModel;
        }

        private void GetAccesData()
        {
            this.estudiantesModel = AccesData.estudiantesModelAD;
            this.matriculasModel = AccesData.matriculaModelAD;
        }

        private void CatchExceptions(bool v)
        {
            if (v == true)
            {
                throw new ArgumentException("No existen datos para mostrar. Agregue datos.");
            }
        }

        private void btnShowEstudiantes_Click(object sender, EventArgs e)
        {
            try
            {
                CatchExceptions(AccesData.estudiantesModelAD.GetAll().Count == 0);

                FrmMostrarEstudiantes frmMostrarEstudiantes = new FrmMostrarEstudiantes();
                frmMostrarEstudiantes.Show();
                this.Hide();

                //GetAccesData();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"{ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnECMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                CatchExceptions(AccesData.estudiantesModelAD.GetAll().Count == 0);

                FrmMostrarNotas frmMostrarNotas = new FrmMostrarNotas();
                frmMostrarNotas.estudiantesModel = this.estudiantesModel;
                frmMostrarNotas.Show();
                this.Hide();

                GetAccesData();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"{ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowInformation_Click(object sender, EventArgs e)
        {
            FrmMostrarInformacion frmMostrar = new FrmMostrarInformacion();
            frmMostrar.matriculas = matriculasModel.GetAll();
            frmMostrar.Show();
        }
    }
}
