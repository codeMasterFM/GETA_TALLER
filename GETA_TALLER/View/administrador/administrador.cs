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

namespace GETA_TALLER.View.administrador
{
    public partial class administrador : Form
    {
        int id;
        int id_vehiculo;
        int id_macanico;
        string matricula;

        GETA_tallerEntities4 db = new GETA_tallerEntities4();
        GETA_cliente cliente = new GETA_cliente();
        GETA_vehiculo vehiculo = new GETA_vehiculo();
        GETA_mecanico mecanico = new GETA_mecanico();
        public administrador()
        {
            InitializeComponent();
            ver();
            ver_mecanico();
        }

        #region Cliente
        public void ver()
        {

            var consulta = (from cliente in db.GETA_cliente
                            where cliente.ESTADO == 1
                            select new
                            {
                                cliente.id_cliente,
                                cliente.NOMBRE,
                                cliente.APELLIDO,
                                cliente.DIRECCION,
                                cliente.TELEFONO,
                                cliente.FECHA_REGISTRO,

                            }).ToList();


            dataGridView1.DataSource = consulta;


        }

        public void Agreagar()
        {

            try
            {
                cliente.NOMBRE = tb_nombre.Text;
                cliente.APELLIDO = tb_apellido.Text;
                cliente.DIRECCION = tb_direccion.Text;
                cliente.TELEFONO = tb_telefono.Text;
                cliente.FECHA_REGISTRO = DateTime.Now;
                cliente.ESTADO = 1;


                db.GETA_cliente.Add(cliente);
                db.SaveChanges();
                ver();
                ver_vehiculo();
            }
            catch (Exception ex) { MessageBox.Show("rellene todos los campos"); }
        }
        public void modificar()
        {
            //    models.persona_ persona = db.persona_.Find(id);

            // GETA_cliente cliente = new GETA_cliente();

            // models.persona_ persona = db.persona_.Find(id);
            // persona.nombre = textBox1.Text;

            try
            {
                cliente = db.GETA_cliente.Find(id);
                cliente.NOMBRE = tb_nombre.Text;
                cliente.APELLIDO = tb_apellido.Text;
                cliente.DIRECCION = tb_direccion.Text;
                cliente.TELEFONO = tb_telefono.Text;
                cliente.FECHA_REGISTRO = DateTime.Now;
                cliente.ESTADO = 1;

                db.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                ver_vehiculo();
                ver();

            }
            catch (Exception)
            {

                MessageBox.Show("rellene todos los campos");
            }

        }

        public void eliminar()
        {
            try
            {
                cliente = db.GETA_cliente.Find(id);
                cliente.NOMBRE = tb_nombre.Text;
                cliente.APELLIDO = tb_apellido.Text;
                cliente.DIRECCION = tb_direccion.Text;
                cliente.TELEFONO = tb_telefono.Text;
                cliente.FECHA_REGISTRO = DateTime.Now;
                cliente.ESTADO = 0;

                db.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                ver();
                ver_vehiculo();
            }
            catch (Exception)
            {

                MessageBox.Show("rellene todos los campos");
            }

        }

        public void llenar_campos()
        {
            id = int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            tb_nombre.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tb_apellido.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tb_direccion.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tb_telefono.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            ver_vehiculo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agreagar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            llenar_campos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            eliminar();
        }
        #endregion


        
        #region Vehiculo
        public void ver_vehiculo()
        {

            var consulta = (from vehiculo in db.GETA_vehiculo
                            where vehiculo.ESTADO == 1 && vehiculo.id_cliente == id

                            join cliente in db.GETA_cliente
                            on vehiculo.id_cliente equals cliente.id_cliente


                            select new
                            {
                              vehiculo.id_vehiculo,
                              vehiculo.MATRICULA,
                              vehiculo.MODELO,
                              vehiculo.COLOR


                            }).ToList();

            dataGridView2.DataSource = consulta;

            //  comboBox1.DataSource = db.persona_.ToList();
            // comboBox1.DisplayMember = "nombre";


        }

        public void Agreagar_vehiculo()
        {
            if (tb_matricula.Text == string.Empty) MessageBox.Show("se requiere rellenar todos los campos");
            else
            {
                vehiculo.MATRICULA = tb_matricula.Text;
                vehiculo.MODELO = tb_modelo.Text;
                vehiculo.COLOR = tb_matricula.Text;
                vehiculo.ESTADO = 1;
                vehiculo.id_cliente = id;
                db.GETA_vehiculo.Add(vehiculo);
                db.SaveChanges();

                ver();
                limpiar_campos();

                MessageBox.Show("La accion se realizo con exito");
            }
        }
        public void modificar_vehiculo()
        {
            if (tb_matricula.Text == string.Empty) MessageBox.Show("se requiere rellenar todos los campos");
            else
            {
                vehiculo = db.GETA_vehiculo.Find(id_vehiculo);
                vehiculo.MATRICULA = tb_matricula.Text;
                vehiculo.MODELO = tb_modelo.Text;
                vehiculo.COLOR = tb_color.Text;
                vehiculo.ESTADO = 1;
                vehiculo.id_cliente = id;
                db.Entry(vehiculo).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                ver();
                limpiar_campos();

                MessageBox.Show("La accion se realizo con exito");
            }
        }
        public void eliminar_vehiculo()
        {
            if (tb_matricula.Text == string.Empty) MessageBox.Show("se requiere rellenar todos los campos");
            else
            {
                vehiculo = db.GETA_vehiculo.Find(id_vehiculo);
              //  vehiculo.MATRICULA = tb_matricula.Text;
               // vehiculo.MODELO = tb_modelo.Text;
               // vehiculo.COLOR = tb_color.Text;
                vehiculo.ESTADO = 0;
                //     vehiculo.id_cliente = int.Parse(cb_propietario.SelectedValue.ToString());
                db.Entry(vehiculo).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                ver();
                limpiar_campos();

                MessageBox.Show("La accion se realizo con exito");

            }
        }

        public void limpiar_campos()
        {

            tb_modelo.Text = string.Empty;
            tb_matricula.Text = string.Empty;
            tb_color.Text = string.Empty;


        }

        public void llenarTB()
        {
            id_vehiculo = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            tb_matricula.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            tb_modelo.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            tb_color.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            matricula = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            // var consulta = db.GETA_cliente.Where(x => x.ESTADO == 1 ).ToList();

            //cb_propietario.DataSource = db.GETA_cliente.Where(x => x.ESTADO == 1).ToList();

        }
        #endregion

        #region Mecanico

        public void ver_mecanico()
        {
            var consulta = (from rcmecanico in db.GETA_mecanico
                            where rcmecanico.ESTADO == 0 && rcmecanico.ELIMINAR == 0
                            select new
                            {
                                rcmecanico.id_mecanico,
                                rcmecanico.NOMBRE,
                                rcmecanico.APELLID0,
                                rcmecanico.CEDULA,
                                

                            }).ToList();


            dataGridView3.DataSource = consulta;
   
        }
        public void asignar_mecanico()
        {
            if (tb_nombre.Text == string.Empty) MessageBox.Show("Favor llenar todos los campos");
            else
            {
                mecanico = db.GETA_mecanico.Find(id_macanico);
                mecanico.id_vehiculo = id_vehiculo;
                mecanico.ESTADO = 1;
                db.Entry(mecanico).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                ver();
                ver_mecanico();
                ver_vehiculo();
            }
        }
       
        public void llenartb()
        {
            id_macanico = int.Parse(dataGridView3.CurrentRow.Cells[0].Value.ToString());
          
            
           
         
           button8.ResetText();
           button8.Text =$" Asignar {matricula} A {'\n'}{dataGridView3.CurrentRow.Cells[1].Value.ToString()}  {dataGridView3.CurrentRow.Cells[2].Value.ToString()}"; 


        }
        #endregion 


        private void button6_Click(object sender, EventArgs e)
        {
            Agreagar_vehiculo();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            modificar_vehiculo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            eliminar_vehiculo();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarTB();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var consulta = (from cliente in db.GETA_cliente where cliente.ESTADO == 1 &&  cliente.NOMBRE.Contains(textBox1.Text)
                           select new
                           {
                               cliente.id_cliente,
                               cliente.NOMBRE,
                               cliente.APELLIDO,
                               cliente.DIRECCION,
                               cliente.TELEFONO,
                               cliente.FECHA_REGISTRO,

                           }).ToList();


            dataGridView1.DataSource = consulta;
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            llenartb();
           
                }

        private void button8_Click(object sender, EventArgs e)
        {
            asignar_mecanico();
        }
    }
}
