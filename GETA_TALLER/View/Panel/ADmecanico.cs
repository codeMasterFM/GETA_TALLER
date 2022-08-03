using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GETA_TALLER.View.Panel
{
    public partial class ADmecanico : Form
    {
        public ADmecanico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View.Detalle.detalle_de_reparacion detalle_De_Reparacion = new View.Detalle.detalle_de_reparacion();
            detalle_De_Reparacion.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            View.Detalle.Mecanico_estado mecanico_Estado = new View.Detalle.Mecanico_estado();
            mecanico_Estado.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
