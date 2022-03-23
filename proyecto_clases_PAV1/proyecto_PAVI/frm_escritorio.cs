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
    /*
     * Para configurar el escritorio, las variables modificadas en Windows Forms fueron:
     * - (Name) -> cambiamos el nombre de la clase
     * - MinimizeBox, MaximizeBox y ControlBox -> Van a false para que no aparezcan
     * - BackColor -> Seteamos el color del fondo (En mi caso, celeste)
     * - Agregamos el MenuStrip, donde se agrego el boton Archivo y dentro de el el boton Salir
     * - WindowState -> Se seteo en Maximized
     */
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
