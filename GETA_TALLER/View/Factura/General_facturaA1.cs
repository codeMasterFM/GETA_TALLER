using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using GETA_TALLER.Model;

namespace GETA_TALLER.View.Factura
{
    public partial class General_facturaA1 : Form
    {
        int local_id = 0;
        GETA_tallerEntities4 db = new GETA_tallerEntities4();
        
        public General_facturaA1(int id_local)
        {
            InitializeComponent();
     
            local_id = id_local;
        

        }



        public void CargarFactura() {

            View.Factura.Factura1 factura1 = new View.Factura.Factura1();
            //local_id = int.Parse(factura1.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            // local_id =int.Parse(factura1.label2.Text);
          
            
            var detalle = db.factura_detalleA2(this.local_id).ToList();


            this.reportViewer1.RefreshReport();
            reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
          reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", detalle));
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarFactura();
        }
    }
}
