namespace GETA_TALLER.View.Taller
{
    partial class Taller
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
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_eliminar = new System.Windows.Forms.Button();
            this.bt_modificar = new System.Windows.Forms.Button();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_correo = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.tb_telefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_rnc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 79;
            this.label3.Text = "RNC";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1295, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 54);
            this.button1.TabIndex = 77;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tb_eliminar
            // 
            this.tb_eliminar.Location = new System.Drawing.Point(274, 462);
            this.tb_eliminar.Name = "tb_eliminar";
            this.tb_eliminar.Size = new System.Drawing.Size(112, 43);
            this.tb_eliminar.TabIndex = 76;
            this.tb_eliminar.Text = "ELIMINAR";
            this.tb_eliminar.UseVisualStyleBackColor = true;
            this.tb_eliminar.Visible = false;
            this.tb_eliminar.Click += new System.EventHandler(this.tb_eliminar_Click);
            // 
            // bt_modificar
            // 
            this.bt_modificar.Location = new System.Drawing.Point(138, 462);
            this.bt_modificar.Name = "bt_modificar";
            this.bt_modificar.Size = new System.Drawing.Size(129, 43);
            this.bt_modificar.TabIndex = 75;
            this.bt_modificar.Text = "MODIFICAR";
            this.bt_modificar.UseVisualStyleBackColor = true;
            this.bt_modificar.Click += new System.EventHandler(this.bt_modificar_Click);
            // 
            // bt_agregar
            // 
            this.bt_agregar.Location = new System.Drawing.Point(20, 462);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(112, 43);
            this.bt_agregar.TabIndex = 74;
            this.bt_agregar.Text = "AGREGAR";
            this.bt_agregar.UseVisualStyleBackColor = true;
            this.bt_agregar.Visible = false;
            this.bt_agregar.Click += new System.EventHandler(this.bt_agregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(407, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1012, 417);
            this.dataGridView1.TabIndex = 73;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 72;
            this.label6.Text = "CORREO";
            // 
            // tb_correo
            // 
            this.tb_correo.Location = new System.Drawing.Point(161, 317);
            this.tb_correo.Multiline = true;
            this.tb_correo.Name = "tb_correo";
            this.tb_correo.Size = new System.Drawing.Size(180, 29);
            this.tb_correo.TabIndex = 71;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(51, 251);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(94, 20);
            this.label.TabIndex = 70;
            this.label.Text = "TELEFONO";
            // 
            // tb_telefono
            // 
            this.tb_telefono.Location = new System.Drawing.Point(161, 246);
            this.tb_telefono.Name = "tb_telefono";
            this.tb_telefono.Size = new System.Drawing.Size(180, 26);
            this.tb_telefono.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "NOMBRE";
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(161, 182);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(180, 26);
            this.tb_nombre.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 37);
            this.label1.TabIndex = 66;
            this.label1.Text = "TALLER";
            // 
            // tb_rnc
            // 
            this.tb_rnc.Location = new System.Drawing.Point(161, 393);
            this.tb_rnc.Multiline = true;
            this.tb_rnc.Name = "tb_rnc";
            this.tb_rnc.Size = new System.Drawing.Size(180, 29);
            this.tb_rnc.TabIndex = 80;
            // 
            // Taller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 638);
            this.Controls.Add(this.tb_rnc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_eliminar);
            this.Controls.Add(this.bt_modificar);
            this.Controls.Add(this.bt_agregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_correo);
            this.Controls.Add(this.label);
            this.Controls.Add(this.tb_telefono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.label1);
            this.Name = "Taller";
            this.Text = "Taller";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button tb_eliminar;
        private System.Windows.Forms.Button bt_modificar;
        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_correo;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox tb_telefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_rnc;
    }
}