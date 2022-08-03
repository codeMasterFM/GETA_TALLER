namespace GETA_TALLER.View.Vehiculo
{
    partial class Vehiculo
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
            this.tb_eliminar = new System.Windows.Forms.Button();
            this.bt_actualizar = new System.Windows.Forms.Button();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_color = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_modelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_matricula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_propietario = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_eliminar
            // 
            this.tb_eliminar.Location = new System.Drawing.Point(292, 460);
            this.tb_eliminar.Name = "tb_eliminar";
            this.tb_eliminar.Size = new System.Drawing.Size(112, 43);
            this.tb_eliminar.TabIndex = 24;
            this.tb_eliminar.Text = "ELIMINAR";
            this.tb_eliminar.UseVisualStyleBackColor = true;
            this.tb_eliminar.Click += new System.EventHandler(this.tb_eliminar_Click);
            // 
            // bt_actualizar
            // 
            this.bt_actualizar.Location = new System.Drawing.Point(141, 460);
            this.bt_actualizar.Name = "bt_actualizar";
            this.bt_actualizar.Size = new System.Drawing.Size(146, 43);
            this.bt_actualizar.TabIndex = 23;
            this.bt_actualizar.Text = "MODIFICAR";
            this.bt_actualizar.UseVisualStyleBackColor = true;
            this.bt_actualizar.Click += new System.EventHandler(this.bt_actualizar_Click);
            // 
            // bt_agregar
            // 
            this.bt_agregar.Location = new System.Drawing.Point(22, 460);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(112, 43);
            this.bt_agregar.TabIndex = 22;
            this.bt_agregar.Text = "AGREGAR";
            this.bt_agregar.UseVisualStyleBackColor = true;
            this.bt_agregar.Click += new System.EventHandler(this.bt_agregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(446, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(779, 417);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "COLOR";
            // 
            // tb_color
            // 
            this.tb_color.Location = new System.Drawing.Point(141, 283);
            this.tb_color.Name = "tb_color";
            this.tb_color.Size = new System.Drawing.Size(180, 26);
            this.tb_color.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "MODELO";
            // 
            // tb_modelo
            // 
            this.tb_modelo.Location = new System.Drawing.Point(141, 217);
            this.tb_modelo.Name = "tb_modelo";
            this.tb_modelo.Size = new System.Drawing.Size(180, 26);
            this.tb_modelo.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "MATRICULA";
            // 
            // tb_matricula
            // 
            this.tb_matricula.Location = new System.Drawing.Point(141, 157);
            this.tb_matricula.Name = "tb_matricula";
            this.tb_matricula.Size = new System.Drawing.Size(180, 26);
            this.tb_matricula.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 37);
            this.label1.TabIndex = 26;
            this.label1.Text = "Vehiculo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cb_propietario
            // 
            this.cb_propietario.FormattingEnabled = true;
            this.cb_propietario.Location = new System.Drawing.Point(34, 385);
            this.cb_propietario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_propietario.Name = "cb_propietario";
            this.cb_propietario.Size = new System.Drawing.Size(290, 28);
            this.cb_propietario.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 360);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "PROPIETARIO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1233, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 29;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Vehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1558, 680);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_propietario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_eliminar);
            this.Controls.Add(this.bt_actualizar);
            this.Controls.Add(this.bt_agregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_color);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_modelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_matricula);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Vehiculo";
            this.Text = "Vehiculo";
            this.Load += new System.EventHandler(this.Vehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button tb_eliminar;
        private System.Windows.Forms.Button bt_actualizar;
        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_color;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_modelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_matricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_propietario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}