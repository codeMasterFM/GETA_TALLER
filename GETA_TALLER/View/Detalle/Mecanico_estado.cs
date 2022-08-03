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
    public partial class Mecanico_estado : Form
    {
        int id_mecanico;
        GETA_tallerEntities4 db = new GETA_tallerEntities4();
        GETA_mecanico mecanico = new GETA_mecanico();
        public Mecanico_estado()
        {
            InitializeComponent();
            ver_mecanico();
        }

        public void ver_mecanico()
        {
            var consulta = (from rcmecanico in db.GETA_mecanico
                            where rcmecanico.ESTADO == 1 && rcmecanico.ELIMINAR == 0
                            select new
                            {
                                rcmecanico.id_mecanico,
                                rcmecanico.NOMBRE,
                                rcmecanico.APELLID0,
                                rcmecanico.CEDULA,


                            }).ToList();


            dataGridView1.DataSource = consulta;

        }
        public void asignar_mecanico()
        {
            if (dataGridView1.CurrentRow.Cells[0].Value.ToString() == string.Empty)
            { MessageBox.Show("Seleccione un mecanico antes de presionar este botom "); }
            else {

                mecanico = db.GETA_mecanico.Find(id_mecanico);
                mecanico.ESTADO = 0;
                db.Entry(mecanico).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

            }
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_mecanico = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            asignar_mecanico();
            ver_mecanico();
        }
    }
}
