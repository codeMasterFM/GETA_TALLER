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

namespace GETA_TALLER.View.Taller
{

    public partial class Taller : Form
    {
        int id;
        GETA_tallerEntities4 db = new GETA_tallerEntities4();
        GETA_taller taller = new GETA_taller();
        public Taller()
        {
            InitializeComponent();
            ver();
        }
        public void ver() { 
        
            dataGridView1.DataSource = db.GETA_taller.ToList();

        }
        public void agregar() {
            if (tb_nombre.Text == string.Empty) MessageBox.Show("Favor llenar todos los campos");
            else
            {
                taller.NOMBRE = tb_nombre.Text;
                taller.TELEFONO = tb_telefono.Text;
                taller.CORREO = tb_correo.Text;
                taller.RNC = tb_rnc.Text;
                db.GETA_taller.Add(taller);
                db.SaveChanges();
                ver();
                limpiartb();
            }
        
        }

        public void modificar() {

            if (tb_nombre.Text == string.Empty) MessageBox.Show("Favor llenar todos los campos");
            else
            {
                taller = db.GETA_taller.Find(id);
                taller.NOMBRE = tb_nombre.Text;
                taller.TELEFONO = tb_telefono.Text;
                taller.CORREO = tb_correo.Text;
                taller.RNC = tb_rnc.Text;
                db.GETA_taller.Add(taller);
                db.Entry(taller).State = System.Data.Entity.EntityState.Modified;
                ver();
                limpiartb();
            }

        }

        public void eliminar() {

            taller = db.GETA_taller.Find(id);
            db.GETA_taller.Remove(taller);
            db.SaveChanges();
            limpiartb();
            ver();


        }

    
        public void llenartb() {
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            tb_nombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tb_telefono.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tb_correo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tb_rnc.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }
        public void limpiartb()
        {

            tb_nombre.Text = string.Empty;
            tb_telefono.Text = string.Empty;
            tb_correo.Text = string.Empty;
            tb_rnc.Text = string.Empty;


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
