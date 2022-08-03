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

namespace GETA_TALLER.View
{
    public partial class DetalleDeVenta : Form
    {

        int id;
        GETA_tallerEntities4 db = new GETA_tallerEntities4();
        GETA_detalle_reparacion reparacion = new GETA_detalle_reparacion();

        public DetalleDeVenta()
        {
            InitializeComponent();
            ver();
        }

        public void ver() {

            //  foreach (var item in db.GETA_detalle_reparacion.ToList())
            //{
            //   MessageBox.Show(item.ToString());
            //}

            var cunsulta = (from rcdetalle in db.GETA_detalle_reparacion where rcdetalle.ESTADO == 1
                            join rcservicio in db.GETA_servicio on rcdetalle.id_servicio equals rcservicio.id_servicio
                            join rcinventario in db.GETA_inventario_repuesto on rcdetalle.id_inventario equals  rcinventario.id_inventario
                            
                            
                            
                            
                            select new
                            {

                                rcdetalle.id_detalle,
                                rcinventario.NOMBRE_PIEZAS,
                                rcinventario.PRECIO,
                                rcdetalle.CANTIDAD,
                                rcservicio.EVALUCION,
                                rcdetalle.COMETARIO,
                                rcdetalle.MANO_OBRA,
                                


                            }).ToList();

            dataGridView1.DataSource = cunsulta;
            cb_servicio.DataSource = db.GETA_servicio.Where(x => x.ESTADO == 1).ToList();
            cb_servicio.DisplayMember = "EVALUCION";
            cb_servicio.ValueMember = "id_servicio";
            cb_inventario.DataSource = db.GETA_inventario_repuesto.Where(x => x.ESTADO == 1).ToList() ;
            cb_inventario.DisplayMember = "NOMBRE_PIEZAS";
            cb_inventario.ValueMember = "id_inventario";
          //  MessageBox.Show(cb_servicio.SelectedValue.ToString());

            
        }


        public void agreagar() {

            if (tb_cantidad.Text == string.Empty) MessageBox.Show("Favor rellenar todos los campos");
            else
            {
                reparacion.CANTIDAD =tb_cantidad.Text;
                reparacion.MANO_OBRA = double.Parse(tb_mano_obra.Text);
                reparacion.COMETARIO = $"{tb_comentario.Text} {cb_servicio.DisplayMember.ToString()}";
                reparacion.id_servicio = int.Parse(cb_servicio.SelectedValue.ToString());
                reparacion.id_inventario = int.Parse(cb_inventario.SelectedValue.ToString());
                reparacion.ESTADO = 1;
                db.GETA_detalle_reparacion.Add(reparacion);
                db.SaveChanges();
                ver();
                limpiartb();
            }
        }

        public void modificar() {
            if (tb_cantidad.Text == string.Empty) MessageBox.Show("Favor rellenar todos los campos");
            else
            {
                reparacion = db.GETA_detalle_reparacion.Find(id);   
                reparacion.MANO_OBRA = double.Parse(tb_mano_obra.Text);
                reparacion.COMETARIO = $"{tb_comentario.Text} {cb_servicio.DisplayMember.ToString()}";
                reparacion.id_servicio = int.Parse(cb_servicio.SelectedValue.ToString());
                reparacion.id_inventario = int.Parse(cb_inventario.SelectedValue.ToString());
                reparacion.ESTADO = 1;
                db.Entry(reparacion).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                ver();
                limpiartb();

            }
        }
       

        public void eliminar() {

            if (tb_cantidad.Text == string.Empty) MessageBox.Show("Favor rellenar todos los campos");
            else
            {
                reparacion = db.GETA_detalle_reparacion.Find(id);
                reparacion.CANTIDAD = tb_cantidad.Text;
                reparacion.MANO_OBRA = double.Parse(tb_mano_obra.Text);
                reparacion.COMETARIO = $"{tb_comentario.Text} {cb_servicio.SelectedText.ToString()}";
              //reparacion.id_servicio = int.Parse(cb_servicio.SelectedValue.ToString());
                reparacion.id_inventario = int.Parse(cb_inventario.SelectedValue.ToString());
                reparacion.ESTADO = 0;
                db.Entry(reparacion).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                ver();
                limpiartb();
            }

        }

        public void limpiartb() {
            tb_cantidad.Text = string.Empty;
            tb_mano_obra.Text = string.Empty;
            tb_comentario.Text = string.Empty;



        }

        public void llenartb() {
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            tb_cantidad.Text  = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tb_mano_obra.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tb_comentario.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            llenartb();
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            agreagar();
        }

        private void bt_actualizar_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void tb_eliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ver();
            MessageBox.Show(cb_servicio.SelectedItem.ToString());
        }

        
    }
}
