namespace GETA_TALLER.View.Servicio
{
    partial class Servicio
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
            this.label5 = new System.Windows.Forms.Label();
            this.cb_vehiculo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_eliminar = new System.Windows.Forms.Button();
            this.bt_actualizar = new System.Windows.Forms.Button();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_precio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_evaluacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1072, 40);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 43;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 357);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "VEHICULO";
            // 
            // cb_vehiculo
            // 
            this.cb_vehiculo.FormattingEnabled = true;
            this.cb_vehiculo.Location = new System.Drawing.Point(18, 382);
            this.cb_vehiculo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_vehiculo.Name = "cb_vehiculo";
            this.cb_vehiculo.Size = new System.Drawing.Size(290, 28);
            this.cb_vehiculo.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 37);
            this.label1.TabIndex = 40;
            this.label1.Text = "SERVICIO";
            // 
            // tb_eliminar
            // 
            this.tb_eliminar.Location = new System.Drawing.Point(288, 457);
            this.tb_eliminar.Name = "tb_eliminar";
            this.tb_eliminar.Size = new System.Drawing.Size(112, 43);
            this.tb_eliminar.TabIndex = 39;
            this.tb_eliminar.Text = "ELIMINAR";
            this.tb_eliminar.UseVisualStyleBackColor = true;
            this.tb_eliminar.Click += new System.EventHandler(this.tb_eliminar_Click);
            // 
            // bt_actualizar
            // 
            this.bt_actualizar.Location = new System.Drawing.Point(136, 457);
            this.bt_actualizar.Name = "bt_actualizar";
            this.bt_actualizar.Size = new System.Drawing.Size(146, 43);
            this.bt_actualizar.TabIndex = 38;
            this.bt_actualizar.Text = "MODIFICAR";
            this.bt_actualizar.UseVisualStyleBackColor = true;
            this.bt_actualizar.Click += new System.EventHandler(this.bt_actualizar_Click);
            // 
            // bt_agregar
            // 
            this.bt_agregar.Location = new System.Drawing.Point(18, 457);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(112, 43);
            this.bt_agregar.TabIndex = 37;
            this.bt_agregar.Text = "AGREGAR";
            this.bt_agregar.UseVisualStyleBackColor = true;
            this.bt_agregar.Click += new System.EventHandler(this.bt_agregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(441, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(742, 417);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "PRECIO";
            // 
            // tb_precio
            // 
            this.tb_precio.Location = new System.Drawing.Point(141, 265);
            this.tb_precio.Name = "tb_precio";
            this.tb_precio.Size = new System.Drawing.Size(180, 26);
            this.tb_precio.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "EVALUACION";
            // 
            // tb_evaluacion
            // 
            this.tb_evaluacion.Location = new System.Drawing.Point(141, 205);
            this.tb_evaluacion.Name = "tb_evaluacion";
            this.tb_evaluacion.Size = new System.Drawing.Size(180, 26);
            this.tb_evaluacion.TabIndex = 30;
            // 
            // Servicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_vehiculo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_eliminar);
            this.Controls.Add(this.bt_actualizar);
            this.Controls.Add(this.bt_agregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_precio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_evaluacion);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Servicio";
            this.Text = "Servicio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_vehiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tb_eliminar;
        private System.Windows.Forms.Button bt_actualizar;
        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_precio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_evaluacion;
    }
}