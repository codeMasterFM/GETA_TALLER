using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GETA_TALLER.Model;

namespace GETA_TALLER.View.Factura
{
    public partial class Factura1 : Form
    {
        public int id = 0;
        GETA_tallerEntities4 db = new GETA_tallerEntities4();
        GETA_factura factura = new GETA_factura();
        public Factura1()
        {
            InitializeComponent();
            ver_cliente();
        }

        public void ver_cliente()
        {
            var consulta = db.GETA_cliente.Where(x => x.ESTADO == 1).ToList();

            dataGridView1.DataSource = consulta;

        }

        public void llenarID() {
          id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            label2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            View.Factura.General_facturaA1 general_FacturaA1 = new View.Factura.General_facturaA1(id);
            general_FacturaA1.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarID();
           
        }
    }
}
