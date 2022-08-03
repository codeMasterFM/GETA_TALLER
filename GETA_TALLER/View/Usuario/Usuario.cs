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

namespace GETA_TALLER.View.Usuario
{
    public partial class Usuario : Form
    {
        GETA_tallerEntities4 db = new GETA_tallerEntities4();
        GETA_usuario usuario = new GETA_usuario();
        public Usuario()
        {
            InitializeComponent();
          
        }public void validar() {
          

            var consulta = (from usuarioq in db.GETA_usuario
                                    select new
                                    {
                                        usuarioq.USUARIO,
                                        usuarioq.CONTRASENA,
                                        usuarioq.ROL
                                       

                                    }).ToList();

            


            foreach (var item in consulta)
            {
                if (item.USUARIO == tb_usuario.Text)
                {
                    foreach (var valor in consulta )
                    {
                        if (item.CONTRASENA == tb_contrasena.Text && item.ROL == 1)
                        {

                            View.Panel.Panel panel = new View.Panel.Panel();
                            panel.Show();
                            panel.validar = 1;
                            Usuario usuario = new Usuario();
                            usuario.Enabled = false;
                        }
                        else {

                            View.Panel.Panel panel = new View.Panel.Panel();
                            panel.Show();
                            panel.validar = 0 ;
                            Usuario usuario = new Usuario();
                            usuario.Enabled = false;

                        }
                      
                    }
                    
                }
                
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validar();
           
        }
    }
}
