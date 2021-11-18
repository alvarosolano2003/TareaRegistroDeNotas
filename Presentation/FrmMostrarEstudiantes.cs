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
    public partial class FrmMostrarEstudiantes : Form
    {
        public EstudiantesModel estudiantesModel;
        public FrmMostrarEstudiantes()
        {
            estudiantesModel = AccesData.estudiantesModelAD;
            InitializeComponent();
        }

        private void FrmMostrarEstudiantes_Load(object sender, EventArgs e)
        {
            dgvShowEstudiantes.DataSource = estudiantesModel.GetAll();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            AccesData.estudiantesModelAD = estudiantesModel;

            FrmGeneral frmGeneral = new FrmGeneral();
            frmGeneral.Activate();
            frmGeneral.Show();
            this.Close();
        }
    }
}
