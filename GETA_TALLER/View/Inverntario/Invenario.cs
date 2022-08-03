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
    public partial class tb_inventario : Form
    {
        int id;
        GETA_tallerEntities4 db = new GETA_tallerEntities4();
       GETA_inventario_repuesto inventario = new GETA_inventario_repuesto();


        public tb_inventario()
        {
            InitializeComponent();
            ver();
        }

        private void Invenario_Load(object sender, EventArgs e)
        {

        }

        public void ver() {
        
            dataGridView1.DataSource = db.GETA_inventario_repuesto.Where(x => x.ESTADO == 1).ToList();
            
        
        }

        public void agregar()
        {
            if (tbCategoria.Text == string.Empty) MessageBox.Show("favor rellenar los campos vacios"); else {
                inventario.CATEGORIA = tbCategoria.Text;
                inventario.NOMBRE_PIEZAS = tbNombre.Text;
                inventario.CANTIDAD_DISPONIBLE = int.Parse(tbCantidad.Text);
                inventario.PRECIO = int.Parse(tbPrecio.Text);
                inventario.ESTADO = 1;
                db.GETA_inventario_repuesto.Add(inventario);
                db.SaveChanges();
                ver();
                limpiartb();
            }
        }

        public void modificar() {

            if (tbCategoria.Text == string.Empty) MessageBox.Show("favor rellenar los campos vacios") ;
            else
            {
                inventario = db.GETA_inventario_repuesto.Find(id);
                inventario.CATEGORIA = tbCategoria.Text;
                inventario.NOMBRE_PIEZAS = tbNombre.Text;
                inventario.CANTIDAD_DISPONIBLE = int.Parse(tbCantidad.Text);
                inventario.PRECIO = int.Parse(tbPrecio.Text);
                inventario.ESTADO = 1;
                db.Entry(inventario).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                ver();
                limpiartb();
            }
        }

        public void eliminar ()
        {
            if (tbCategoria.Text == string.Empty) MessageBox.Show("favor rellenar los campos vacios") ;
            else
            {
                inventario = db.GETA_inventario_repuesto.Find(id);
                inventario.CATEGORIA = tbCategoria.Text;
                inventario.NOMBRE_PIEZAS = tbNombre.Text;
                inventario.CANTIDAD_DISPONIBLE = int.Parse(tbCantidad.Text);
                inventario.PRECIO = int.Parse(tbPrecio.Text);
                inventario.ESTADO = 0;
                db.Entry(inventario).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                ver();
                limpiartb();
            }
        }

        public void limpiartb() {

            tbCategoria.Text = string.Empty;
            tbNombre.Text = string.Empty;
            tbCantidad.Text = string.Empty;
            tbPrecio.Text = string.Empty;
        
        }

        public void llenartb() {
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            tbCategoria.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbNombre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbCantidad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbPrecio.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            

        }
        private void bt_agregar_Click(object sender, EventArgs e)
        {
            agregar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            llenartb();
        }

        private void bt_actualizar_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void tb_eliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }
    }
}
