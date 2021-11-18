using Domain.Entites;
using Domain.Enums;
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
    public partial class FrmMostrarInformacion : Form
    {
        public List<Matriculas> matriculas = new List<Matriculas>();
        public FrmMostrarInformacion()
        {
            InitializeComponent();
        }

        private string DeterminarClases(Asignaturas[] a)
        {
            string M = string.Empty;
            int i=0;
            foreach(Asignaturas asignaturas in a)
            {
                M = $"{M}   {a[i]}";
                i++;
            }
            return M;
        }
        private string DeterminateGrupo(Grupo aux)
        {
            if (aux == Domain.Enums.Grupo.M1)
            {
                return "1M1";
            }
            else if (aux == Domain.Enums.Grupo.M2)
            {
                return "1M2";
            }
            else if (aux == Domain.Enums.Grupo.M3)
            {
                return "1M3";
            }
            else if (aux == Domain.Enums.Grupo.T1)
            {
                return "1T1";
            }
            else
            {
                throw new ArgumentException();
            }
        }

        private void FrmMostrarInformacion_Load(object sender, EventArgs e)
        {
            string aux = string.Empty;
            int i = 1;

            //string mostrar = string.Format("{0: -20} {1: -15} {2: -30}",
            // "Nombre", "Apellido", "Carnet");

            foreach (Matriculas a in matriculas)
            {
                string Grupo = DeterminateGrupo(a.Grupo);
                string Clases = DeterminarClases(a.Asignaturas);
                //if (i == 1)
                //{
                //    aux = $"\n Carnet\t   Grupo\t    Fecha\t   {aux} \n {i}. {a.Carnet}\t  {Grupo}\t {a.Fecha} {Clases}\t ";
                //    i++;
                //}
                //else
                //{
                //    aux = $"{aux} \n {i}. {a.Carnet}\t  {Grupo}\t {a.Fecha} {Clases} ";
                //    i++;
                //}
                aux = $"{aux}\n {i}. Carnet:{a.Carnet}   Grupo:{Grupo}   Fecha:{a.Fecha}   Asignaturas{Clases} ";
                i++;
            }

            rtbMostrar.Text = aux;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

            FrmGeneral general = new FrmGeneral();
            
            general.Activate();
            general.Show();
            this.Close();
        }
    }
}
