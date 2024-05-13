using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySosaEtapa5
{
    public partial class frmMainEtapa5 : Form
    {
        public frmMainEtapa5()
        {
            InitializeComponent();
        }

        clsVehiculo objAuto = new clsVehiculo();
        clsVehiculo objAvion = new clsVehiculo();
        clsVehiculo objBarco = new clsVehiculo();

        bool Auto = false;
        bool Avion = false;
        bool Barco = false;
        Random random = new Random();
        

        private void btnCrear_Click(object sender, EventArgs e)
        {
            // Limpiar los textos de los labels
            lblAuto.Text = "";
            lblAvion.Text = "";
            lblBarco.Text = "";

            // Eliminar los PictureBox existentes si ya están creados
            if (objAuto.pctAuto != null && objAuto.pctAuto.Parent != null)
            {
                Controls.Remove(objAuto.pctAuto);
            }
            if (objAvion.pctAvion != null && objAvion.pctAvion.Parent != null)
            {
                Controls.Remove(objAvion.pctAvion);
            }
            if (objBarco.pctBarco != null && objBarco.pctBarco.Parent != null)
            {
                Controls.Remove(objBarco.pctBarco);
            }

            int numeroAleatorio = random.Next(1, 4);

            switch (numeroAleatorio)
            {
                case 1:
                    objAuto.CrearAuto();
                    objAuto.pctAuto.Location = new Point(-20, 300);
                    Controls.Add(objAuto.pctAuto);
                    lblAuto.Text = objAuto.tipoVehiculo;
                    break;

                case 2:
                    objAvion.CrearAvion();
                    objAvion.pctAvion.Location = new Point(350, 50);
                    Controls.Add(objAvion.pctAvion);
                    lblAvion.Text = objAvion.tipoVehiculo;
                    break;

                case 3:
                    objBarco.CrearBarco();
                    objBarco.pctBarco.Location = new Point(600, 50);
                    Controls.Add(objBarco.pctBarco);
                    lblBarco.Text = objBarco.tipoVehiculo;
                    break;
            }
        }
    }
}
