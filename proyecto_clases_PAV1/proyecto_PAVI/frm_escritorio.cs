using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_PAVI
{
    public partial class frm_escritorio : Form //Definicion de la clase, heredan de Form
    {
        public frm_escritorio()
        {
            InitializeComponent();
        }
        //Boton de salir, se relaciona con doble click en el boton del formulario
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
