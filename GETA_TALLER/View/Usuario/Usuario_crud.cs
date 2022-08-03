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
    public partial class Usuario_crud : Form
    {
        int id;
        GETA_tallerEntities4 db = new GETA_tallerEntities4();
        GETA_usuario usuario = new GETA_usuario();
        
        public Usuario_crud()
        {
            InitializeComponent();
        }

        

        public void agregar() {
            int rol =0;
            if (rb_administrador.Checked) rol = 1;
            else if (rb_mecanico.Checked) rol = 0; else MessageBox.Show("Favor selecionar administeador o mecanico");
            usuario.NOMBRE = tb_nombre.Text;
            usuario.USUARIO = tb_usuario.Text;
            usuario.CONTRASENA = tb_contrasena.Text;
            usuario.ROL = rol;
            usuario.ESTADO = 1;
            db.GETA_usuario.Add(usuario);
            db.SaveChanges();
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            agregar();
        }


    
    }
}
