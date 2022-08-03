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
using System.Data.SqlClient;

namespace GETA_TALLER.View.Factura
{
    public partial class Factura : Form
    {
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

        GETA_tallerEntities4 db = new GETA_tallerEntities4();
        GETA_factura factura = new GETA_factura();
        GETA_cliente cliente = new GETA_cliente();
        GETA_vehiculo vehiculo = new GETA_vehiculo();
        GETA_mecanico mecanico = new GETA_mecanico();
        GETA_servicio servicio = new GETA_servicio();
        GETA_detalle_reparacion detalle = new GETA_detalle_reparacion();
        
        

        SqlConnection conn = null;

        public Factura()
        {
            InitializeComponent();
            ver_cliente();
            conexion();
        }
        public void conexion() { 
        
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
            sqlConnectionStringBuilder.DataSource = @"(localdb)\MSSQLLocalDB";
            sqlConnectionStringBuilder.InitialCatalog = "GETA_taller";
            sqlConnectionStringBuilder.IntegratedSecurity = true;
            var conexion = sqlConnectionStringBuilder.ConnectionString;

            SqlConnection sqlConnection = new SqlConnection(conexion);
            conn = sqlConnection;
           
        }

        public void ver_cliente()
        {
           var consulta = db.GETA_cliente.Where(x => x.ESTADO == 1).ToList();

            dataGridView1_cliente.DataSource = consulta;
           
        }
        public void detalles() {
             id_cliente = int.Parse(dataGridView1_cliente.CurrentRow.Cells[0].Value.ToString());
         
            int servicio_precio = 0;//
            int mano_de_obra = 0;//
            int detalle_cantidad = 0;//
            int inventario_precio = 0;
            string texto = "";
            conexion();
            conn.Open();


            try
            {
                //CLIENTE
                SqlCommand cliente = new SqlCommand($"select * from GETA_cliente where ESTADO = '1' and id_cliente = '{id_cliente}'", conn);
                SqlDataReader drcliente = cliente.ExecuteReader();
                if (drcliente.Read()) texto = $"NOMBRE : {drcliente["NOMBRE"].ToString()}  {Environment.NewLine} APELLIDO {drcliente["APELLIDO"]} {Environment.NewLine} ";
                drcliente.Close();
                try
                {
                    //VEHICULO
                    SqlCommand vehiculo = new SqlCommand($"select * from GETA_vehiculo where ESTADO = '1' and id_cliente = '{id_cliente}' ", conn);
                    SqlDataReader drvehiculo = vehiculo.ExecuteReader(); 
                    if (drvehiculo.Read()) id_vehiculo = $"{drvehiculo["id_vehiculo"]}"; aux = $" MATRICULA :{drvehiculo["MATRICULA"]}  {Environment.NewLine}  MODELO :{drvehiculo["MODELO"]} {drvehiculo["COLOR"]}{Environment.NewLine}";
                    texto = texto + aux;
                    drvehiculo.Close();
                }catch (Exception ex) { MessageBox.Show("rellene los campo de vehiculo para este usuario"); }

                try
                {
                    //SERVICIO
                    SqlCommand servicio = new SqlCommand($"select * from GETA_servicio where ESTADO = '1' and id_vehiculo = '{id_vehiculo}'", conn);
                    SqlDataReader drservicio = servicio.ExecuteReader();
                    if (drservicio.Read()) servicio_precio = int.Parse($"{drservicio["PRECIO"]}"); id_servicio = $"{drservicio["id_servicio"]}"; aux = $"EVALUACION: {drservicio["EVALUCION"]}  {Environment.NewLine}  PRECIO: {drservicio["PRECIO"]} {Environment.NewLine}";
                    texto = texto + aux;
                    drservicio.Close();
                }catch(Exception ex) { MessageBox.Show("rellene los campos de servicio para este usuario"); }

                try
                {
                    //DETALLER
                    SqlCommand detalle = new SqlCommand($"select * from GETA_detalle_reparacion where ESTADO = '1' and id_servicio = '{id_servicio}'", conn);
                    SqlDataReader drdetalle = detalle.ExecuteReader();
                    if (drdetalle.Read()) id_detalle = $"{drdetalle["id_detalle"]}"; mano_de_obra = int.Parse($" {drdetalle["MANO_OBRA"]}"); detalle_cantidad = int.Parse($"{drdetalle["CANTIDAD"]} "); id_detalle = $"{drdetalle["id_detalle"]}"; aux = $" CANTIDAD DE PRODUCTOS UTILISADO : {drdetalle["CANTIDAD"]}  {Environment.NewLine} {Environment.NewLine}PRECIO DE MANO DE OBRA : {drdetalle["MANO_OBRA"]}   {Environment.NewLine} COMENTARIO DEL MECANICO : {drdetalle["COMETARIO"]}{Environment.NewLine}{Environment.NewLine} {Environment.NewLine}{Environment.NewLine}";
                    texto = texto + aux;
                    drdetalle.Close();
                }catch (Exception ex) { MessageBox.Show("rellene los campos de detalle para este usuario"); }


                    //INVENTARIO
                    SqlCommand inventario = new SqlCommand($"select * from GETA_inventario_repuesto where ESTADO = '1'", conn);
                    SqlDataReader drinventario = inventario.ExecuteReader();
                    if (drinventario.Read()) id_inventario = $"{drinventario["id_inventario"]}"; inventario_precio = int.Parse($"{drinventario["PRECIO"]}"); aux = $"  PRECIO '{drinventario["PRECIO"]}'   PRODUCTO  '{drinventario["NOMBRE_PIEZAS"]}'  ";
                    MessageBox.Show(id_servicio);
                    texto = texto + aux;
                    drinventario.Close();
                MessageBox.Show($"inventario {id_inventario}");

                try
                {

                    //MECANICO
                    SqlCommand mecanico = new SqlCommand($"select * from GETA_mecanico where ESTADO = '1' and id_detalle = '{id_detalle}'", conn);
                    SqlDataReader drmecanico = mecanico.ExecuteReader();
                    if (drmecanico.Read()) id_mecanico = $"{drmecanico["id_mecanico"]}"; aux = $" NOMBRE :  {drmecanico["NOMBRE"]} APELLIDO : {drmecanico["APELLID0"]} FACTURA : {drmecanico["CEDULA"]} {Environment.NewLine}";
                    texto = texto + aux;
                    textBox1.Text = texto;
                    drmecanico.Close();
                }
                catch (Exception ex) { MessageBox.Show("este usuario no tiene un mecanico asignado"); }
                //FACTURA
                SqlCommand factura = new SqlCommand($"select * from GETA_factura where id_cliente = '2004'",conn);
                SqlDataReader drfactura = factura.ExecuteReader();
                if (drfactura.Read()) id_factura = $"{drfactura["id_factura"]}";
                drfactura.Close();

                //TALLER
                /*  SqlCommand taller = new SqlCommand("select * from GETA_taller ");
                  SqlDataReader rctaller = taller.ExecuteReader();
                  if (rctaller.Read()) id_taller = $"{rctaller["id_taller"]}";
                  rctaller.Close();*/

                //TALLER
                var taller = (from rctaller in db.GETA_taller
                                select new
                                {

                                    rctaller.id_taller

                                }).ToList();
                foreach (var item in taller)
                {
                    id_taller = item.id_taller.ToString();

                    MessageBox.Show(id_taller);
                }

                //MECANICO ID
                var C_mecanico = (from rcmecanico in db.GETA_mecanico 
                                  join rcvehiculo in db.GETA_vehiculo
                                  on rcmecanico.id_vehiculo equals rcvehiculo.id_vehiculo
                                  join rccliente in db.GETA_cliente 
                                  on rcvehiculo.id_cliente equals rccliente.id_cliente
                                select new
                                {
                                    rcmecanico.id_mecanico
                                }).First();

                MessageBox.Show(mecanico.ToString());



                /*Divide el monto pagado entre 1.18 y le dará el monto facturado y a esto le saca el
                    18 % y al sumarle le dará el monto pagado*/
                int sub_total = (detalle_cantidad * inventario_precio) + (mano_de_obra + servicio_precio);

                tb_sub_total.Text = sub_total.ToString();
                double aux_total = sub_total / double.Parse(tb_itb.Text);
                total = (aux_total / 18) / 100;
                tb_total.Text = total.ToString();
            }
            catch (Exception ex) {

                MessageBox.Show("llena tos los datos para este usuario antes de factural");
            }
        }
            


        private void dataGridView1_cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // ver_vehiculo();
            //ver_servicio();
            // ver_detalle();
            //ver_productos();
            //ver_mecanico();
            detalles();
        }

        public void agregar() {
            try
            {
                factura.PAGO = "NO PAGADO";
                factura.SUBTOTAL = double.Parse(tb_sub_total.Text);
                factura.TOTAL = total;
                factura.ITB = double.Parse(tb_itb.Text);
                factura.id_cliente = id_cliente;
                factura.id_vehiculo = int.Parse(id_vehiculo);
                factura.id_mecanico = int.Parse(id_mecanico);
                factura.id_inventario = int.Parse(id_inventario);
                factura.id_detalle = int.Parse(id_detalle);
                factura.fecha_salida = DateTime.Now;
                factura.id_taller = int.Parse(id_taller);
                factura.ESTADO = 1;
                db.GETA_factura.Add(factura);
                db.SaveChanges();
                MessageBox.Show("la factuara se genero con exito");
            }
            catch (Exception ex) { MessageBox.Show("selecione un usuario"); }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            agregar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            View.Factura.Generar_factura factura = new Generar_factura();
            factura.ShowDialog();
      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //PAGAR 
            factura = db.GETA_factura.Find(int.Parse(id_factura));
            factura.PAGO = "PAGADO";
            db.Entry(factura).State = System.Data.Entity.EntityState.Modified;
           //CLIENTE
            cliente = db.GETA_cliente.Find(id_cliente);
            cliente.ESTADO = 0;
            db.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
          
            //VEHICULO
            vehiculo = db.GETA_vehiculo.Find(int.Parse(id_vehiculo));
            vehiculo.ESTADO = 0;
            db.Entry(vehiculo).State = System.Data.Entity.EntityState.Modified;

            //SERVICIO 
            servicio = db.GETA_servicio.Find(int.Parse(id_servicio));
            servicio.ESTADO = 0;
            db.Entry(servicio).State = System.Data.Entity.EntityState.Modified;

            //DETALLE 
            detalle = db.GETA_detalle_reparacion.Find(int.Parse(id_detalle));
            detalle.ESTADO = 0;
            db.Entry(servicio).State = System.Data.Entity.EntityState.Modified;

            //MECANICO
            mecanico = db.GETA_mecanico.Find(int.Parse(id_mecanico));
            mecanico.ESTADO = 0;
            db.Entry(mecanico).State = System.Data.Entity.EntityState.Modified;



            
            
            db.SaveChanges();
        }
    }
}
