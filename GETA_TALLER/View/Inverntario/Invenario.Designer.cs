namespace GETA_TALLER.View.Inverntario
{
    partial class tb_inventario
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
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tb_eliminar = new System.Windows.Forms.Button();
            this.bt_actualizar = new System.Windows.Forms.Button();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_cantidad = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.tb_nombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1245, 148);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 54);
            this.button1.TabIndex = 30;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(142, 435);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(180, 26);
            this.tbPrecio.TabIndex = 28;
            // 
            // tb_eliminar
            // 
            this.tb_eliminar.Location = new System.Drawing.Point(277, 526);
            this.tb_eliminar.Name = "tb_eliminar";
            this.tb_eliminar.Size = new System.Drawing.Size(112, 43);
            this.tb_eliminar.TabIndex = 27;
            this.tb_eliminar.Text = "ELIMINAR";
            this.tb_eliminar.UseVisualStyleBackColor = true;
            this.tb_eliminar.Click += new System.EventHandler(this.tb_eliminar_Click);
            // 
            // bt_actualizar
            // 
            this.bt_actualizar.Location = new System.Drawing.Point(142, 526);
            this.bt_actualizar.Name = "bt_actualizar";
            this.bt_actualizar.Size = new System.Drawing.Size(129, 43);
            this.bt_actualizar.TabIndex = 26;
            this.bt_actualizar.Text = "MODIFICAR";
            this.bt_actualizar.UseVisualStyleBackColor = true;
            this.bt_actualizar.Click += new System.EventHandler(this.bt_actualizar_Click);
            // 
            // bt_agregar
            // 
            this.bt_agregar.Location = new System.Drawing.Point(22, 526);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(112, 43);
            this.bt_agregar.TabIndex = 25;
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
            this.dataGridView1.Location = new System.Drawing.Point(411, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1012, 417);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "PRECIO";
            // 
            // tb_cantidad
            // 
            this.tb_cantidad.AutoSize = true;
            this.tb_cantidad.Location = new System.Drawing.Point(28, 372);
            this.tb_cantidad.Name = "tb_cantidad";
            this.tb_cantidad.Size = new System.Drawing.Size(91, 20);
            this.tb_cantidad.TabIndex = 22;
            this.tb_cantidad.Text = "CANTIDAD";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(140, 366);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(180, 26);
            this.tbCantidad.TabIndex = 21;
            // 
            // tb_nombre
            // 
            this.tb_nombre.AutoSize = true;
            this.tb_nombre.Location = new System.Drawing.Point(40, 306);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(79, 20);
            this.tb_nombre.TabIndex = 20;
            this.tb_nombre.Text = "NOMBRE";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(140, 300);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(180, 26);
            this.tbNombre.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "CATEGORIA";
            // 
            // tbCategoria
            // 
            this.tbCategoria.Location = new System.Drawing.Point(140, 240);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Size = new System.Drawing.Size(180, 26);
            this.tbCategoria.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Inventario";
            // 
            // tb_inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tb_eliminar);
            this.Controls.Add(this.bt_actualizar);
            this.Controls.Add(this.bt_agregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_cantidad);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCategoria);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "tb_inventario";
            this.Text = "Invenario";
            this.Load += new System.EventHandler(this.Invenario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Button tb_eliminar;
        private System.Windows.Forms.Button bt_actualizar;
        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tb_cantidad;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label tb_nombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCategoria;
        private System.Windows.Forms.Label label1;
    }
}