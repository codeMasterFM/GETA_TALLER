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

namespace GETA_TALLER.View.Servicio
{
    public partial class Servicio : Form
    {
        int id;
        GETA_tallerEntities4 db = new  GETA_tallerEntities4();
        GETA_servicio servicios = new  GETA_servicio();
       

        public Servicio()
        {
            InitializeComponent();
            ver();
        }



        public void ver() {

            var consulta = (from rcconsulta in db.GETA_servicio where rcconsulta.ESTADO == 1
                            join rcvehiculo in db.GETA_vehiculo
                            on rcconsulta.id_vehiculo equals rcvehiculo.id_vehiculo
                            select new
                            {
                                
                                rcconsulta.id_servicio,
                                rcvehiculo.MATRICULA,
                                rcvehiculo.MODELO,
                                rcconsulta.EVALUCION,
                                rcconsulta.PRECIO

                            }

                            ).ToList();

            dataGridView1.DataSource = consulta;
            cb_vehiculo.DataSource = db.GETA_vehiculo.Where(x => x.ESTADO == 1).ToList();
            cb_vehiculo.DisplayMember = "MATRICULA";
            cb_vehiculo.ValueMember = "id_vehiculo";
        }

        public void agreagar()
        {
            if (tb_evaluacion.Text == string.Empty) MessageBox.Show("por favor llenar todos los campos");
            else
            {
                servicios.EVALUCION = tb_evaluacion.Text;
                servicios.PRECIO = int.Parse(tb_precio.Text);
                servicios.id_vehiculo = int.Parse(cb_vehiculo.SelectedValue.ToString());
                servicios.ESTADO = 1;
                db.GETA_servicio.Add(servicios);
                db.SaveChanges();
                ver();
                limpiartb();
            }

        }

        public void modificar() {
            if (tb_evaluacion.Text == string.Empty) MessageBox.Show("por favor llenar todos los campos");
            else

            {
                servicios = db.GETA_servicio.Find(id);
                servicios.EVALUCION = tb_evaluacion.Text;
                servicios.PRECIO = int.Parse(tb_precio.Text);
                servicios.id_vehiculo = int.Parse(cb_vehiculo.SelectedValue.ToString());
                servicios.ESTADO = 1;
                db.Entry(servicios).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                ver();
                limpiartb();
            }
        }

        public void eliminar() {

            if (tb_evaluacion.Text == string.Empty) MessageBox.Show("por favor llenar todos los campos");
            else
            {

                servicios = db.GETA_servicio.Find(id);
                servicios.EVALUCION = tb_evaluacion.Text;
                servicios.PRECIO = int.Parse(tb_precio.Text);
            //    servicios.id_vehiculo = int.Parse(cb_vehiculo.SelectedValue.ToString());
                db.Entry(servicios).State = System.Data.Entity.EntityState.Modified;
                servicios.ESTADO = 0;
                db.SaveChanges();
                ver();
                limpiartb();
            }
        }




        public void llenartb() {
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            tb_evaluacion.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tb_precio.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        public void limpiartb() {

            tb_evaluacion.Text = string.Empty;
            tb_precio.Text = string.Empty;
        
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            llenartb();
        }

    
    }
}
