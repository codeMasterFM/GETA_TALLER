namespace GETA_TALLER.View.Factura
{
    partial class Factura
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
            this.dataGridView1_cliente = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb_sub_total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_itb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1_cliente
            // 
            this.dataGridView1_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_cliente.Location = new System.Drawing.Point(63, 30);
            this.dataGridView1_cliente.Name = "dataGridView1_cliente";
            this.dataGridView1_cliente.RowHeadersWidth = 62;
            this.dataGridView1_cliente.RowTemplate.Height = 28;
            this.dataGridView1_cliente.Size = new System.Drawing.Size(425, 579);
            this.dataGridView1_cliente.TabIndex = 0;
            this.dataGridView1_cliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_cliente_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "CLIENTE";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Ivory;
            this.textBox1.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(533, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(421, 579);
            this.textBox1.TabIndex = 3;
            // 
            // tb_sub_total
            // 
            this.tb_sub_total.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tb_sub_total.Location = new System.Drawing.Point(1127, 79);
            this.tb_sub_total.Name = "tb_sub_total";
            this.tb_sub_total.ReadOnly = true;
            this.tb_sub_total.Size = new System.Drawing.Size(264, 26);
            this.tb_sub_total.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1017, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "SUBTOTAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1067, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "ITB";
            // 
            // tb_itb
            // 
            this.tb_itb.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tb_itb.Location = new System.Drawing.Point(1127, 159);
            this.tb_itb.Name = "tb_itb";
            this.tb_itb.ReadOnly = true;
            this.tb_itb.Size = new System.Drawing.Size(264, 26);
            this.tb_itb.TabIndex = 6;
            this.tb_itb.Text = "1.16";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1047, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "TOTAL";
            // 
            // tb_total
            // 
            this.tb_total.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tb_total.Location = new System.Drawing.Point(1127, 231);
            this.tb_total.Name = "tb_total";
            this.tb_total.ReadOnly = true;
            this.tb_total.Size = new System.Drawing.Size(264, 26);
            this.tb_total.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::GETA_TALLER.Properties.Resources.pago_en_efectivo;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(1127, 541);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(264, 68);
            this.button3.TabIndex = 12;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::GETA_TALLER.Properties.Resources.archivo;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(1127, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(264, 68);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::GETA_TALLER.Properties.Resources.general_factura;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(1127, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 68);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 757);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_itb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_sub_total);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1_cliente);
            this.Name = "Factura";
            this.Text = "Factura";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1_cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tb_sub_total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_itb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_total;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}