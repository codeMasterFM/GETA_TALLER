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
    public partial class administrar : Form
    {
        public administrar()
        {
            InitializeComponent();
            View.Panel.PanelA1 panelA1 = new View.Panel.PanelA1();
            panelA1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             View.Inverntario.tb_inventario tb_Inventario = new Inverntario.tb_inventario();
            tb_Inventario.Show();
        }   

       
        private void button5_Click(object sender, EventArgs e)
        {
            View.Panel.PanelA1 panelA1 = new View.Panel.PanelA1();
            panelA1.Visible = true;
            this.Close();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            View.Inverntario.Mecanico mecanico = new View.Inverntario.Mecanico();
            mecanico.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            View.administrador.administrador administrador = new View.administrador.administrador();
            administrador.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Factura.Factura1 factura1 = new Factura.Factura1();
            factura1.Show();
        }
    }
}
