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
        public MatriculasModel matriculasModel;
        public EstudiantesModel estudiantesModel;
        public FrmGeneral()
        {
            matriculasModel = new MatriculasModel();
            estudiantesModel = new EstudiantesModel();
            InitializeComponent();
        }

        private void btnMAgregar_Click(object sender, EventArgs e)
        {
            FrmMatricula matriculaFrm = new FrmMatricula();
            matriculaFrm.matriculasModel = this.matriculasModel;
            matriculaFrm.Activate();
            matriculaFrm.Show();
            this.Hide();
        }

        private void FrmGeneral_Activated(object sender, EventArgs e)
        {
            ShowInRTB();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            ShowInRTB();

            MessageBox.Show($"{matriculasModel.GetAll().Count}");
        }

        private void ShowInRTB()
        {
            if (matriculasModel.GetAll().Count == 0)
            {
                rtbMatriculas.Text = "No hay informacion para mostar.";
            }
            else
            {
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
                rtbJsonEstudiantes.Text = estudiantesModel.GetAsJson();
            }
        }

        private void btnEAgregar_Click(object sender, EventArgs e)
        {
            FrmEstudiantes frmEstudiantes = new FrmEstudiantes();
            frmEstudiantes.matriculasModel = this.matriculasModel;
            frmEstudiantes.estudiatesModel = this.estudiantesModel;
            frmEstudiantes.Activate();
            frmEstudiantes.Show();
            this.Hide();
        }
    }
}
