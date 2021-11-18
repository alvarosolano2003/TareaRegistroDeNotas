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
    public partial class FrmMostrarNotas : Form
    {
        public EstudiantesModel estudiantesModel;
        public List<Estudiantes> lisEModel = new List<Estudiantes>();
        public FrmMostrarNotas()
        {
            estudiantesModel = AccesData.estudiantesModelAD;
            lisEModel = estudiantesModel.GetAll();
            InitializeComponent();
        }

        private void btnMostrarNotas_Click(object sender, EventArgs e)
        {
            string aux = string.Empty;

            foreach (Notas n in lisEModel[cmbEChose.SelectedIndex].Notas)
            {
                aux = $@"{aux} 
                {string.Format("{0,-20}| {1,-20}| {2,-20}| {3,-20}| {4,-20}| {5,-20}|",
                 $"{DeterminateAsignatura(n.Asignatura)}", $"{n.IP}", $"{n.IIP}", $"{n.Sistematicos}",
                 $"{n.IC}", $"{n.IIC}")} ";
            }

            richTextBox1.Text = $@"{string.Format("{0,-20}| {1,-20}| {2,-20}| {3,-20}| {4,-20}| {5,-20}|",
                "Asignatura", "1er Parcial", "2do Parcial", "Sistematico", "Convocatoria 1", "Convocatoria 2")}
            {aux}";
        }

        private void FrmMostrarNotas_Load(object sender, EventArgs e)
        {
            List<string> cmbElements = new List<string>();

            foreach (Estudiantes e_iterator in lisEModel)
            {
                cmbElements.Add($"{e_iterator.Nombres} {e_iterator.Apellidos}");
            }

            cmbEChose.DataSource = cmbElements;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            //AccesData.estudiantesModelAD = estudiantesModel;
            FrmGeneral frmGeneral = new FrmGeneral();
            //frmGeneral.Activate();
            frmGeneral.Show();
            this.Close();
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
    }
}
