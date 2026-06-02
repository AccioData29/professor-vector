using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALGEBRA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inicializarFormulario()
        {
            try
            {
                cmbOperaciones.Text = "";

                #region[Combo Operaciones]
                cmbOperaciones.Items.Add("Suma");
                cmbOperaciones.Items.Add("Resta");
                cmbOperaciones.Items.Add("Multiplicación");
                cmbOperaciones.Items.Add("Inversa");
                cmbOperaciones.Items.Add("Transpuesta");
                cmbOperaciones.Items.Add("Escalar");
                cmbOperaciones.Items.Add("Determinante");
                #endregion

                cmbDimension.Text = "";

                #region[Combo Dimensión]
                cmbDimension.Items.Add("2x2");
                cmbDimension.Items.Add("3x3");
                cmbDimension.Items.Add("4x4");
                cmbDimension.Items.Add("5x5");
                #endregion
            }
            catch(Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }
    }
}
