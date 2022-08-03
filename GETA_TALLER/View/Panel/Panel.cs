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
    
    public partial class Panel : Form
    {
       
        
        int height = 0;
        int width = 0;
        public Panel()
        {
            InitializeComponent();
           // validar_usuario();
            height = panel_mostra_form.Height;
            width = panel_mostra_form.Width;

            MessageBox.Show(label1.Text);
        }

        public int validar;



        public void validar_usuario() {

            if (validar == 0) { 
            
                tb_cliente.Enabled = false;
                tb_vehiculo.Enabled = false;
                tb_inventario.Enabled = false;
                tb_usuario.Enabled = false;
                tb_taller.Enabled = false;  
                tb_detalle.Enabled = false;
                tb_detalle.Enabled = false;

            
            }
        }

     
        private void button1_Click_1(object sender, EventArgs e)
        {
            panel_mostra_form.Controls.Clear();
            View.Inverntario.tb_inventario tb_Inventario = new View.Inverntario.tb_inventario();
            tb_Inventario.TopLevel = false;
            tb_Inventario.Width = width;
            tb_Inventario.Height = height;
            tb_Inventario.Show();
            panel_mostra_form.Controls.Add(tb_Inventario);
            ;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           // validar_usuario();
            panel_mostra_form.Controls.Clear();
            View.Cliente cliente = new Cliente();
            cliente.WindowState = FormWindowState.Maximized;
            cliente.TopLevel = false;
            cliente.Width = 1000;
            cliente.Height = 1000;
            cliente.Show();
            panel_mostra_form.Controls.Add(cliente);

            View.Inverntario.tb_inventario tb_Inventario = new Inverntario.tb_inventario();
            tb_Inventario.Close();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panel_mostra_form.Controls.Clear();
            Vehiculo.Vehiculo vehiculo = new Vehiculo.Vehiculo();
            vehiculo.TopLevel = false;
            vehiculo.Width = 1000;
            vehiculo.Height = 1000;
            vehiculo.Show();
            panel_mostra_form.Controls.Add(vehiculo);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            panel_mostra_form.Controls.Clear();
            View.Servicio.Servicio servicio = new View.Servicio.Servicio();
            servicio.TopLevel = false;
            servicio.Width = 1000;
            servicio.Height = 1000;
            servicio.Show();
            panel_mostra_form.Controls.Add(servicio);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            panel_mostra_form.Controls.Clear();
            View.DetalleDeVenta detalle = new View.DetalleDeVenta();
            detalle.TopLevel = false;
            detalle.Width = 1000;
            detalle.Height = 1000;
            detalle.Show();
            panel_mostra_form.Controls.Add(detalle);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            panel_mostra_form.Controls.Clear();
            View.Mecanico.Mecanico mecanico = new Mecanico.Mecanico();
            mecanico.TopLevel = false;
            mecanico.Width = 1000;
            mecanico.Height = 1000;
            mecanico.Show();
            panel_mostra_form.Controls.Add(mecanico);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            panel_mostra_form.Controls.Clear();
            View.Factura.Factura factura = new View.Factura.Factura();
            factura.TopLevel = false;
            factura.Width = 1000;
            factura.Height = 1000;
            factura.Show();
            panel_mostra_form.Controls.Add(factura);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel_mostra_form.Controls.Clear();
            View.Usuario.Usuario_crud usuario = new View.Usuario.Usuario_crud();
            usuario.TopLevel = false;
            usuario.Width = 1000;
            usuario.Height = 1000;
            usuario.Show();
            panel_mostra_form.Controls.Add(usuario);
        }

      

        private void button10_Click(object sender, EventArgs e)
        {
            if (panel_sub_menu.Visible == true)
            {
                panel_sub_menu.Visible = false;
            }
            else { panel_sub_menu.Visible = true; }


        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (panel_sub_config.Visible == true)
            {
                panel_sub_config.Visible = false;

            }
            else { panel_sub_config.Visible = true; }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            View.Taller.Taller  taller = new View.Taller.Taller();
            taller.Show();
        }
    }
}
