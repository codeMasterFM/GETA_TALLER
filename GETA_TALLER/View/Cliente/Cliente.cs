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
    public partial class Cliente : Form
    {

     GETA_tallerEntities4 db = new GETA_tallerEntities4();
        GETA_cliente cliente = new GETA_cliente();
        int id;
        public Cliente()
        {
            InitializeComponent();
            ver();
          
        }


        public void ver() {

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
 
        public void Agreagar() {

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
                ver();

            }
            catch (Exception)
            {

                MessageBox.Show("rellene todos los campos");
            }
           
        }
      
        public void eliminar() {
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
            }
            catch (Exception)
            {

                MessageBox.Show("rellene todos los campos");
            }
          
        }

        public void llenar_campos() {
            id = int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            tb_nombre.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tb_apellido.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tb_direccion.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tb_telefono.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
     

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            Agreagar();
        }

       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            llenar_campos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ver();
        }

        private void bt_actualizar_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void tb_eliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }
    }


}
