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

namespace GETA_TALLER.View.Inverntario
{
    
    
    public partial class Mecanico : Form
    {
        GETA_tallerEntities4 db = new GETA_tallerEntities4();
        GETA_mecanico mecanico = new GETA_mecanico();
        int id;


        public Mecanico()
        {
            InitializeComponent();
            ver();
        }

        public void ver()
        {
            var consulta = (from rcmecanico in db.GETA_mecanico
                            where rcmecanico.ELIMINAR == 0
                            select new
                            {
                                rcmecanico.id_mecanico,
                                rcmecanico.NOMBRE,
                                rcmecanico.APELLID0,
                                rcmecanico.CEDULA

                            }).ToList();
            dataGridView1.DataSource = consulta;




        }
        public void agregar()
        {
            if (tb_nombre.Text == string.Empty) MessageBox.Show("Favor llenar todos los campos");
            else
            {
                mecanico.NOMBRE = tb_nombre.Text;
                mecanico.APELLID0 = tb_apellido.Text;
                mecanico.CEDULA = tb_cedula.Text;
               // mecanico.id_detalle = int.Parse(cb_detalle.SelectedValue.ToString());
                mecanico.ESTADO = 0;
                mecanico.ELIMINAR = 0;
                db.GETA_mecanico.Add(mecanico);
                db.SaveChanges();
                ver();
                limpiartb();
                

            }
        }


        public void eliminar() {

            mecanico.NOMBRE = tb_nombre.Text;
            mecanico.ELIMINAR = 1;
            db.Entry(mecanico).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            ver();
            limpiartb();
        }

        public void modificar() {
            mecanico = db.GETA_mecanico.Find(id);
            mecanico.NOMBRE = tb_nombre.Text;
            mecanico.APELLID0 = tb_apellido.Text;
            mecanico.CEDULA = tb_cedula.Text;
            mecanico.ELIMINAR = 0;
            db.Entry(mecanico).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            ver();
            limpiartb();

        }
        public void delete() {
            mecanico = db.GETA_mecanico.Find(id);
            mecanico.ELIMINAR = 1;
            db.Entry(mecanico).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            ver();
            limpiartb();
        }

        public void limpiartb()
        {


            tb_nombre.Text = string.Empty;
            tb_apellido.Text = string.Empty;
            tb_cedula.Text = string.Empty;

        }

        public void llenarTB() {

            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            tb_nombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tb_apellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tb_cedula.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();


        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            agregar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           modificar();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            delete();
        }

      

        private void tb_buscador_TextChanged(object sender, EventArgs e)
        {
            var consulta = (from rcmecanico in db.GETA_mecanico where rcmecanico.NOMBRE.Contains(tb_buscador.Text) &&  rcmecanico.ELIMINAR == 1 
                           select new { 
                           
                               rcmecanico.id_mecanico,
                               rcmecanico.NOMBRE,
                               rcmecanico.APELLID0,
                               rcmecanico.ESTADO

                           }).ToList();
            dataGridView1.DataSource = consulta;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarTB();
        }
    }
}
