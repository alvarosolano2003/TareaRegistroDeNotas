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
            dataGridView1.DataSource = lisEModel;
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
    }
}
