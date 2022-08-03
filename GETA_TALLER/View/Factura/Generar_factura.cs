using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using GETA_TALLER.Model;

namespace GETA_TALLER.View.Factura
{
    public partial class Generar_factura : Form
    {
        Model.GETA_tallerEntities4 db = new Model.GETA_tallerEntities4();
        Model.GETA_cliente cliente = new Model.GETA_cliente();
        GETA_vehiculo vehiculo = new GETA_vehiculo();
        GETA_mecanico mecanico = new GETA_mecanico();
        GETA_servicio servicio = new GETA_servicio();
        GETA_detalle_reparacion detalle = new GETA_detalle_reparacion();
        SqlConnection conn = null;

        public int id_cliente = 0;
        string id_inventario = "";
        public string id_factura = "";
        public string id_vehiculo = "";
        public string id_servicio = "";
        public string id_detalle = "";
        public string id_mecanico = "";
        public string id_taller = "";
        public double total = 0;
        string aux;

   

        public Generar_factura()
        {
            InitializeComponent();
        }

        public void conexion()
        {

            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
            sqlConnectionStringBuilder.DataSource = @"(localdb)\MSSQLLocalDB";
            sqlConnectionStringBuilder.InitialCatalog = "GETA_taller";
            sqlConnectionStringBuilder.IntegratedSecurity = true;
            var conexion = sqlConnectionStringBuilder.ConnectionString;

            SqlConnection sqlConnection = new SqlConnection(conexion);
            conn = sqlConnection;

        }

    

        private void Generar_factura_Load(object sender, EventArgs e)
        {
          
            

    //        reportViewer1.LocalReport.DataSources.Add("Report1", detalle_taller);
            
            
          
            

          
        }


        private void button1_Click(object sender, EventArgs e)
        {


            int id_vehiculo = 0;

            

            
        
            
               
                int id = int.Parse(textBox1.Text);

                


            int id_mecanico = int.Parse(textBox2.Text); 
            /*               var cliente = (from rccliente in db.GETA_cliente where rccliente.id_cliente == id

                                           select new
                                           {
                                              rccliente.id_cliente,
                                              rccliente.NOMBRE,
                                              rccliente.APELLIDO,
                                              rccliente.DIRECCION,
                                              rccliente.FECHA_REGISTRO

                                           }).ToList();




                        foreach (var item in cliente) {

                            id_vehiculo = item.id_cliente;
                        }*/
            /* var vehiculo = (from rcvehiculo in db.GETA_vehiculo
                             where rcvehiculo.id_vehiculo == id_vehiculo
                             select new
                             {
                                 rcvehiculo.MATRICULA,
                                 rcvehiculo.MODELO,
                                 rcvehiculo.COLOR
                             }).ToList();
                             */
            
                           
            var detalle = (from rcdetalle in db.factura_detalle11(id,id_mecanico)
                          select new {
                            
                            rcdetalle.CLIENTE_NOMBRE,
                            rcdetalle.CLIENTE_APELLIDO,
                            rcdetalle.CLIENTE_TELEFONO,
                            rcdetalle.CLIENTE_DIRECCION,
                            rcdetalle.NOMBRE_MECANICO,
                            rcdetalle.MECANICO_APELLIDO,
                            rcdetalle.CEDULA,
                            rcdetalle.REPUESTOS,
                            rcdetalle.CANTIDAD,
                            rcdetalle.ITB,
                            rcdetalle.MANO_OBRA,
                            rcdetalle.SUBTOTAL,
                            rcdetalle.TOTAL,
                            rcdetalle.FECHA_REGISTRO


                            

                          }).ToList();
           
           
                
               


       /*     conexion();
            conn.Open();
            SqlCommand factura = new SqlCommand(
                $@"SELECT GETA_cliente.NOMBRE, GETA_cliente.APELLIDO , GETA_cliente.TELEFONO, GETA_cliente.DIRECCION,
                GETA_vehiculo.MATRICULA, GETA_vehiculo.MODELO, GETA_vehiculo.COLOR,
                GETA_mecanico.NOMBRE as 'NOMBRE MECANICO', GETA_mecanico.APELLID0, GETA_mecanico.CEDULA,
                GETA_taller.NOMBRE, GETA_taller.TELEFONO, GETA_taller.CORREO, GETA_taller.CORREO
                FROM GETA_factura
                join GETA_taller on GETA_taller.id_taller = GETA_factura.id_taller
                join GETA_mecanico on  GETA_mecanico.id_mecanico = GETA_factura.id_mecanico
                join GETA_vehiculo on GETA_vehiculo.id_vehiculo = GETA_factura.id_vehiculo
                join GETA_cliente on GETA_factura.id_cliente = GETA_factura.id_cliente
                where GETA_cliente.id_cliente = '{textBox1.Text}'",conn
                
                );
            SqlDataReader reader = factura.ExecuteReader();

            List<string> consulta = new List<string>();
            while (reader.Read()) { 
            
                consulta.Add(reader.GetString(0).ToString());
                consulta.Add(reader.GetString(1).ToString());
                consulta.Add(reader.GetString(2).ToString());
                consulta.Add(reader.GetString(3).ToString());
                consulta.Add(reader.GetString(4).ToString());
                consulta.Add(reader.GetString(5).ToString());
                consulta.Add(reader.GetString(6).ToString());
                consulta.Add(reader.GetString(7).ToString());
            }*/
            
            this.reportViewer1.RefreshReport();
            reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1",detalle));
          //reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2",vehiculo));
           
           

          
            


        }


    }
}
