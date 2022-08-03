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

namespace GETA_TALLER.View.Vehiculo
{
    public partial class Vehiculo : Form
    {
        int id;
        GETA_tallerEntities4 db = new GETA_tallerEntities4();
        GETA_vehiculo vehiculo = new GETA_vehiculo();


        public Vehiculo()
        {
            InitializeComponent();
            ver();
            // MessageBox.Show($"{vehiculo.GETA_cliente.NOMBRE}");

                  }


        public void ver()
        {

            var consulta = (from vehiculo in db.GETA_vehiculo where vehiculo.ESTADO == 1
                            
                            join cliente in db.GETA_cliente 
                            on vehiculo.id_cliente equals cliente.id_cliente

                            
                            select new {
                               vehiculo.id_vehiculo,
                               cliente.NOMBRE,
                               cliente.APELLIDO,
                               vehiculo.MATRICULA,
                               vehiculo.MODELO,
                               vehiculo.COLOR,
                               
                              
                           }).ToList();
                          
            dataGridView1.DataSource = consulta;

            


            cb_propietario.DataSource = db.GETA_cliente.Where(x => x.ESTADO == 1).ToList();
            cb_propietario.DisplayMember ="NOMBRE";
            cb_propietario.ValueMember = "id_cliente";
            //  comboBox1.DataSource = db.persona_.ToList();
            // comboBox1.DisplayMember = "nombre";

          
        }


        public void Agreagar()
            {
            if (tb_matricula.Text == string.Empty) MessageBox.Show("se requiere rellenar todos los campos");
            else
            {
                vehiculo.MATRICULA = tb_matricula.Text;
                vehiculo.MODELO = tb_modelo.Text;
                vehiculo.COLOR = tb_color.Text;
                vehiculo.ESTADO = 1;
                vehiculo.id_cliente = int.Parse(cb_propietario.SelectedValue.ToString());
                db.GETA_vehiculo.Add(vehiculo);
                db.SaveChanges();

                ver();
                limpiar_campos();

                MessageBox.Show("La accion se realizo con exito");
            }
        }


        public void modificar() {
            if (tb_matricula.Text == string.Empty) MessageBox.Show("se requiere rellenar todos los campos");
            else
            {
                vehiculo = db.GETA_vehiculo.Find(id);
                vehiculo.MATRICULA = tb_matricula.Text;
                vehiculo.MODELO = tb_modelo.Text;
                vehiculo.COLOR = tb_color.Text;
                vehiculo.ESTADO = 1;
                vehiculo.id_cliente = int.Parse(cb_propietario.SelectedValue.ToString());
                db.Entry(vehiculo).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show(cb_propietario.SelectedValue.ToString());

                ver();
                limpiar_campos();

                MessageBox.Show("La accion se realizo con exito");
            }
        }
        public void eliminar() {
            if (tb_matricula.Text == string.Empty) MessageBox.Show("se requiere rellenar todos los campos");
            else
            {
                vehiculo = db.GETA_vehiculo.Find(id);
                vehiculo.MATRICULA = tb_matricula.Text;
                vehiculo.MODELO = tb_modelo.Text;
                vehiculo.COLOR = tb_color.Text;
                vehiculo.ESTADO = 0;
           //     vehiculo.id_cliente = int.Parse(cb_propietario.SelectedValue.ToString());
                db.Entry(vehiculo).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                ver();
                limpiar_campos();

                MessageBox.Show("La accion se realizo con exito");

            }
        }

        public void limpiar_campos() {

            tb_modelo.Text = string.Empty;
            tb_matricula.Text = string.Empty;
            tb_color.Text = string.Empty;
            

        }

        public void llenarTB() {
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            tb_matricula.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tb_modelo.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tb_color.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
           // var consulta = db.GETA_cliente.Where(x => x.ESTADO == 1 ).ToList();

            //cb_propietario.DataSource = db.GETA_cliente.Where(x => x.ESTADO == 1).ToList();

        }
        private void bt_agregar_Click(object sender, EventArgs e)
        {

            Agreagar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_propietario.SelectedValue.ToString());
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarTB();
        }

        private void bt_actualizar_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void tb_eliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Vehiculo_Load(object sender, EventArgs e)
        {

        }
    }
}
