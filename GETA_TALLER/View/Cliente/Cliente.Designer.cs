namespace GETA_TALLER.View
{
    partial class Cliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_apellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_direccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.bt_actualizar = new System.Windows.Forms.Button();
            this.tb_eliminar = new System.Windows.Forms.Button();
            this.tb_telefono = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // tb_nombre
            // 
            this.tb_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_nombre.Location = new System.Drawing.Point(123, 138);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(180, 26);
            this.tb_nombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "APELLIDO";
            // 
            // tb_apellido
            // 
            this.tb_apellido.Location = new System.Drawing.Point(123, 198);
            this.tb_apellido.Name = "tb_apellido";
            this.tb_apellido.Size = new System.Drawing.Size(180, 26);
            this.tb_apellido.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "DIRECCION";
            // 
            // tb_direccion
            // 
            this.tb_direccion.Location = new System.Drawing.Point(123, 265);
            this.tb_direccion.Name = "tb_direccion";
            this.tb_direccion.Size = new System.Drawing.Size(180, 26);
            this.tb_direccion.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "TELEFONO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(394, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1012, 417);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bt_agregar
            // 
            this.bt_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_agregar.ForeColor = System.Drawing.Color.White;
            this.bt_agregar.Location = new System.Drawing.Point(6, 425);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(112, 43);
            this.bt_agregar.TabIndex = 10;
            this.bt_agregar.Text = "AGREGAR";
            this.bt_agregar.UseVisualStyleBackColor = false;
            this.bt_agregar.Click += new System.EventHandler(this.bt_agregar_Click);
            // 
            // bt_actualizar
            // 
            this.bt_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_actualizar.ForeColor = System.Drawing.Color.White;
            this.bt_actualizar.Location = new System.Drawing.Point(124, 425);
            this.bt_actualizar.Name = "bt_actualizar";
            this.bt_actualizar.Size = new System.Drawing.Size(122, 43);
            this.bt_actualizar.TabIndex = 11;
            this.bt_actualizar.Text = "ACTUALIZAR";
            this.bt_actualizar.UseVisualStyleBackColor = false;
            this.bt_actualizar.Click += new System.EventHandler(this.bt_actualizar_Click);
            // 
            // tb_eliminar
            // 
            this.tb_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_eliminar.ForeColor = System.Drawing.Color.White;
            this.tb_eliminar.Location = new System.Drawing.Point(252, 425);
            this.tb_eliminar.Name = "tb_eliminar";
            this.tb_eliminar.Size = new System.Drawing.Size(112, 43);
            this.tb_eliminar.TabIndex = 12;
            this.tb_eliminar.Text = "ELIMINAR";
            this.tb_eliminar.UseVisualStyleBackColor = false;
            this.tb_eliminar.Click += new System.EventHandler(this.tb_eliminar_Click);
            // 
            // tb_telefono
            // 
            this.tb_telefono.Location = new System.Drawing.Point(126, 334);
            this.tb_telefono.Name = "tb_telefono";
            this.tb_telefono.Size = new System.Drawing.Size(180, 26);
            this.tb_telefono.TabIndex = 13;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1579, 572);
            this.Controls.Add(this.tb_telefono);
            this.Controls.Add(this.tb_eliminar);
            this.Controls.Add(this.bt_actualizar);
            this.Controls.Add(this.bt_agregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_direccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_apellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_apellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_direccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.Button bt_actualizar;
        private System.Windows.Forms.Button tb_eliminar;
        private System.Windows.Forms.TextBox tb_telefono;
    }
}