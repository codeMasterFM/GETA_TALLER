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

namespace GETA_TALLER.View.Mecanico
{
    public partial class Mecanico : Form
    {

        int id;
        GETA_tallerEntities4 db = new GETA_tallerEntities4();
        GETA_mecanico mecanico = new GETA_mecanico();

        public Mecanico()
        {
            InitializeComponent();
            ver();
        }

        public void ver()
        {
            var consulta = (from rcmecanico in db.GETA_mecanico where rcmecanico.ESTADO == 1
                            join rcdetalle in db.GETA_detalle_reparacion on rcmecanico.id_detalle equals rcdetalle.id_detalle
                            select new 
                          {
                                rcmecanico.id_mecanico,
                                rcdetalle.COMETARIO,
                                rcdetalle.MANO_OBRA,
                                rcmecanico.NOMBRE,
                                rcmecanico.APELLID0,
                                rcmecanico.CEDULA,
                               
                            }).ToList();


           dataGridView1.DataSource = consulta;
            cb_detalle.DataSource = db.GETA_detalle_reparacion.Where(x => x.ESTADO == 1).ToList();
           cb_detalle.DisplayMember = "COMETARIO";
            cb_detalle.ValueMember = "id_detalle";


        }
        public void agregar() {
            if (tb_nombre.Text == string.Empty) MessageBox.Show("Favor llenar todos los campos"); else {
                mecanico.NOMBRE = tb_nombre.Text;
                mecanico.APELLID0 = tb_apellido.Text;
                mecanico.CEDULA = tb_cedula.Text;
                mecanico.id_detalle = int.Parse(cb_detalle.SelectedValue.ToString());
                mecanico.ESTADO = 1;
                db.GETA_mecanico.Add(mecanico);
                db.SaveChanges();
                ver();
                limpiartb();

            }
        }
        public void modificar()
        {
            if (tb_nombre.Text == string.Empty) MessageBox.Show("Favor llenar todos los campos");
            else
            {
                mecanico = db.GETA_mecanico.Find(id);
                mecanico.NOMBRE = tb_nombre.Text;
                mecanico.APELLID0 = tb_apellido.Text;
                mecanico.CEDULA = tb_cedula.Text;
                mecanico.id_detalle = int.Parse(cb_detalle.SelectedValue.ToString());
                mecanico.ESTADO = 1;
                db.Entry(mecanico).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                ver();
                limpiartb();

            }
        }

        public void eliminar() {
            if (tb_nombre.Text == string.Empty) MessageBox.Show("Favor llenar todos los campos");
            else
            {
                mecanico = db.GETA_mecanico.Find(id);
                mecanico.NOMBRE = tb_nombre.Text;
                mecanico.APELLID0 = tb_apellido.Text;
                mecanico.CEDULA = tb_cedula.Text;
              //mecanico.id_detalle = int.Parse(cb_detalle.SelectedValue.ToString());
                mecanico.ESTADO = 0;
                db.Entry(mecanico).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                ver();
                limpiartb();
            }
        }

        public void llenartb() {
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            tb_nombre.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tb_apellido.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tb_cedula.Text =dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        public void limpiartb() { 
        
        
            tb_nombre.Text = string.Empty;
            tb_apellido.Text= string.Empty;
            tb_cedula.Text = string.Empty;

        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
             agregar();

        }

        private void bt_modificar_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void tb_eliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            llenartb();
        }
    }
}
