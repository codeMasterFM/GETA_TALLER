namespace GETA_TALLER.View
{
    partial class DetalleDeVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.tb_eliminar = new System.Windows.Forms.Button();
            this.bt_actualizar = new System.Windows.Forms.Button();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_mano_obra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_cantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_comentario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_servicio = new System.Windows.Forms.ComboBox();
            this.cb_inventario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1286, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 54);
            this.button1.TabIndex = 44;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_eliminar
            // 
            this.tb_eliminar.Location = new System.Drawing.Point(266, 600);
            this.tb_eliminar.Name = "tb_eliminar";
            this.tb_eliminar.Size = new System.Drawing.Size(112, 43);
            this.tb_eliminar.TabIndex = 42;
            this.tb_eliminar.Text = "ELIMINAR";
            this.tb_eliminar.UseVisualStyleBackColor = true;
            this.tb_eliminar.Click += new System.EventHandler(this.tb_eliminar_Click);
            // 
            // bt_actualizar
            // 
            this.bt_actualizar.Location = new System.Drawing.Point(130, 600);
            this.bt_actualizar.Name = "bt_actualizar";
            this.bt_actualizar.Size = new System.Drawing.Size(129, 43);
            this.bt_actualizar.TabIndex = 41;
            this.bt_actualizar.Text = "MODIFICAR";
            this.bt_actualizar.UseVisualStyleBackColor = true;
            this.bt_actualizar.Click += new System.EventHandler(this.bt_actualizar_Click);
            // 
            // bt_agregar
            // 
            this.bt_agregar.Location = new System.Drawing.Point(12, 600);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(112, 43);
            this.bt_agregar.TabIndex = 40;
            this.bt_agregar.Text = "AGREGAR";
            this.bt_agregar.UseVisualStyleBackColor = true;
            this.bt_agregar.Click += new System.EventHandler(this.bt_agregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(398, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1012, 417);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "MANO DE OBRA";
            // 
            // tb_mano_obra
            // 
            this.tb_mano_obra.Location = new System.Drawing.Point(160, 292);
            this.tb_mano_obra.Multiline = true;
            this.tb_mano_obra.Name = "tb_mano_obra";
            this.tb_mano_obra.Size = new System.Drawing.Size(180, 29);
            this.tb_mano_obra.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "CANTIDAD";
            // 
            // tb_cantidad
            // 
            this.tb_cantidad.Location = new System.Drawing.Point(160, 219);
            this.tb_cantidad.Name = "tb_cantidad";
            this.tb_cantidad.Size = new System.Drawing.Size(180, 26);
            this.tb_cantidad.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 37);
            this.label1.TabIndex = 31;
            this.label1.Text = "DETALLE DE REPARACION";
            // 
            // tb_comentario
            // 
            this.tb_comentario.Location = new System.Drawing.Point(32, 425);
            this.tb_comentario.Multiline = true;
            this.tb_comentario.Name = "tb_comentario";
            this.tb_comentario.Size = new System.Drawing.Size(289, 147);
            this.tb_comentario.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "COMENTARIO";
            // 
            // cb_servicio
            // 
            this.cb_servicio.FormattingEnabled = true;
            this.cb_servicio.Location = new System.Drawing.Point(585, 44);
            this.cb_servicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_servicio.Name = "cb_servicio";
            this.cb_servicio.Size = new System.Drawing.Size(628, 28);
            this.cb_servicio.TabIndex = 47;
            // 
            // cb_inventario
            // 
            this.cb_inventario.FormattingEnabled = true;
            this.cb_inventario.Location = new System.Drawing.Point(585, 132);
            this.cb_inventario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_inventario.Name = "cb_inventario";
            this.cb_inventario.Size = new System.Drawing.Size(628, 28);
            this.cb_inventario.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(581, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "SERVICIO A REALIZAR ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(581, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "REPUESTOS";
            // 
            // DetalleDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 692);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_inventario);
            this.Controls.Add(this.cb_servicio);
            this.Controls.Add(this.tb_comentario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_eliminar);
            this.Controls.Add(this.bt_actualizar);
            this.Controls.Add(this.bt_agregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_mano_obra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_cantidad);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DetalleDeVenta";
            this.Text = "DetalleDeVenta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button tb_eliminar;
        private System.Windows.Forms.Button bt_actualizar;
        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_mano_obra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_cantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_comentario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_servicio;
        private System.Windows.Forms.ComboBox cb_inventario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}