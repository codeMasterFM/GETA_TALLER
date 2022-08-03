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

namespace GETA_TALLER.View.Detalle
{

    public partial class detalle_de_reparacion : Form
    {
        string recategoria= "";
        GETA_tallerEntities4 db = new GETA_tallerEntities4();
        GETA_detalle_reparacion detalle = new GETA_detalle_reparacion();
        
        public detalle_de_reparacion()
        {
            InitializeComponent();
            llenar_categoria();
        }

        public void llenar_categoria() {

            #region Consulta de mecanico
            var mecanico = (from mecancio in db.GETA_mecanico
                            where mecancio.ESTADO == 1 && mecancio.ELIMINAR == 0
                            select new
                            {
                                mecancio.id_mecanico,
                                mecancio.NOMBRE,

                            }).ToList();
            cb_mecanico.DataSource = mecanico;
            cb_mecanico.DisplayMember = "NOMBRE";
            cb_mecanico.ValueMember = "id_mecanico";
            #endregion

            #region Inventario categoria

            var categoria_inventario = (from rcinventario in db.GETA_inventario_repuesto

                              select new
                              {

                                  rcinventario.CATEGORIA


                              }).ToList();

            comboBox3.DataSource = categoria_inventario;
            comboBox3.DisplayMember = "CATEGORIA";
            comboBox3.ValueMember = "CATEGORIA";
             
            

            #endregion


            

        
        }
        public void llenar_inventario() {
            recategoria = comboBox3.SelectedValue.ToString();

            var inventario = (from rcinventario in db.GETA_inventario_repuesto
                              where rcinventario.CATEGORIA == recategoria

                              select new
                              {

                                  rcinventario.id_inventario,
                                  rcinventario.NOMBRE_PIEZAS,
                                  rcinventario.PRECIO


                              }).ToList();

            cb_inventario.DataSource = inventario;
            cb_inventario.DisplayMember = "NOMBRE_PIEZAS";
            cb_inventario.ValueMember = "id_inventario";
           
        }
        public void agrear_detalle() {


            if (cb_cantidad.Text == string.Empty)
            {

                MessageBox.Show("rellene la cantidad de piezas");
            }
            else if (cb_mano_obra.Text == string.Empty)
            {

                MessageBox.Show("rellene la mano de obra");
            }
            else if (cb_inventario.Text == string.Empty)
            {
                MessageBox.Show("rellene el campo de pieza");
            }
            else
            {
                int IDvehiculo =0; 
                int id_mecanico = int.Parse(cb_mecanico.SelectedValue.ToString());
                var id_vehiculo = (from RCid_vehiculo in db.GETA_vehiculo
                                  join rcmecanico in db.GETA_mecanico
                                  on RCid_vehiculo.id_vehiculo equals rcmecanico.id_vehiculo
                                  where RCid_vehiculo.ESTADO == 1 && rcmecanico.id_mecanico == id_mecanico
                                  select new { 
                                  RCid_vehiculo.id_vehiculo
                                  }).ToList();


                foreach (var item in id_vehiculo) IDvehiculo = int.Parse(item.id_vehiculo.ToString()); /*IDvehiculo = int.Parse(id_vehiculo.ToString())*/;
                
                detalle.CANTIDAD = cb_cantidad.Text;
                detalle.MANO_OBRA = double.Parse(cb_mano_obra.Text);
                detalle.COMETARIO = tb_comentario.Text;
                detalle.id_inventario = int.Parse(cb_inventario.SelectedValue.ToString());
                detalle.id_mecanico = int.Parse(cb_mecanico.SelectedValue.ToString());
                detalle.ESTADO = 1;
                detalle.id_vehiculo = IDvehiculo;
                db.GETA_detalle_reparacion.Add(detalle);
                db.SaveChanges();

                MessageBox.Show("EL DETALLE SE AGREGO CORRECTAMENTE ");
            }

            

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            llenar_inventario();
         
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            agrear_detalle();
        }
    }
}
