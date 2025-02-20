namespace CapaPresentacion
{
    partial class DVenta
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
            this.DgvDVentas = new System.Windows.Forms.DataGridView();
            this.AgregarVenta = new System.Windows.Forms.Button();
            this.ModificarVentaBTN = new System.Windows.Forms.Button();
            this.ImprimirVenta = new System.Windows.Forms.Button();
            this.SalirBTN = new System.Windows.Forms.Button();
            this.CantidadTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IDventaTXT = new System.Windows.Forms.TextBox();
            this.IDdventaLBL = new System.Windows.Forms.Label();
            this.IDProductoCMB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.IDFacturaCMB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvDVentas
            // 
            this.DgvDVentas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvDVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDVentas.Location = new System.Drawing.Point(86, 202);
            this.DgvDVentas.Name = "DgvDVentas";
            this.DgvDVentas.Size = new System.Drawing.Size(644, 169);
            this.DgvDVentas.TabIndex = 0;
            this.DgvDVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDVentas_CellContentClick);
            this.DgvDVentas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDVentas_CellContentDoubleClick);
            // 
            // AgregarVenta
            // 
            this.AgregarVenta.BackColor = System.Drawing.Color.Black;
            this.AgregarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarVenta.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarVenta.ForeColor = System.Drawing.Color.White;
            this.AgregarVenta.Location = new System.Drawing.Point(221, 152);
            this.AgregarVenta.Name = "AgregarVenta";
            this.AgregarVenta.Size = new System.Drawing.Size(118, 40);
            this.AgregarVenta.TabIndex = 1;
            this.AgregarVenta.Text = "Agregar Venta";
            this.AgregarVenta.UseVisualStyleBackColor = false;
            this.AgregarVenta.Click += new System.EventHandler(this.AgregarVenta_Click);
            // 
            // ModificarVentaBTN
            // 
            this.ModificarVentaBTN.BackColor = System.Drawing.Color.Black;
            this.ModificarVentaBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModificarVentaBTN.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarVentaBTN.ForeColor = System.Drawing.Color.White;
            this.ModificarVentaBTN.Location = new System.Drawing.Point(362, 152);
            this.ModificarVentaBTN.Name = "ModificarVentaBTN";
            this.ModificarVentaBTN.Size = new System.Drawing.Size(130, 40);
            this.ModificarVentaBTN.TabIndex = 2;
            this.ModificarVentaBTN.Text = "Modificar Venta";
            this.ModificarVentaBTN.UseVisualStyleBackColor = false;
            this.ModificarVentaBTN.Click += new System.EventHandler(this.ModificarVentaBTN_Click);
            // 
            // ImprimirVenta
            // 
            this.ImprimirVenta.BackColor = System.Drawing.Color.Black;
            this.ImprimirVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImprimirVenta.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImprimirVenta.ForeColor = System.Drawing.Color.White;
            this.ImprimirVenta.Location = new System.Drawing.Point(511, 152);
            this.ImprimirVenta.Name = "ImprimirVenta";
            this.ImprimirVenta.Size = new System.Drawing.Size(124, 40);
            this.ImprimirVenta.TabIndex = 3;
            this.ImprimirVenta.Text = "Imprimir Venta";
            this.ImprimirVenta.UseVisualStyleBackColor = false;
            // 
            // SalirBTN
            // 
            this.SalirBTN.BackColor = System.Drawing.Color.Black;
            this.SalirBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalirBTN.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalirBTN.ForeColor = System.Drawing.Color.White;
            this.SalirBTN.Location = new System.Drawing.Point(363, 395);
            this.SalirBTN.Name = "SalirBTN";
            this.SalirBTN.Size = new System.Drawing.Size(75, 31);
            this.SalirBTN.TabIndex = 4;
            this.SalirBTN.Text = "Salir";
            this.SalirBTN.UseVisualStyleBackColor = false;
            this.SalirBTN.Click += new System.EventHandler(this.SalirBTN_Click);
            // 
            // CantidadTXT
            // 
            this.CantidadTXT.Location = new System.Drawing.Point(630, 96);
            this.CantidadTXT.Name = "CantidadTXT";
            this.CantidadTXT.Size = new System.Drawing.Size(100, 20);
            this.CantidadTXT.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "IDFactura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "IDProducto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(554, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(248, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 20);
            this.label6.TabIndex = 66;
            this.label6.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(496, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 67;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(736, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 68;
            this.label5.Text = "*";
            // 
            // IDventaTXT
            // 
            this.IDventaTXT.Location = new System.Drawing.Point(110, 54);
            this.IDventaTXT.Name = "IDventaTXT";
            this.IDventaTXT.Size = new System.Drawing.Size(75, 20);
            this.IDventaTXT.TabIndex = 75;
            // 
            // IDdventaLBL
            // 
            this.IDdventaLBL.AutoSize = true;
            this.IDdventaLBL.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDdventaLBL.Location = new System.Drawing.Point(33, 57);
            this.IDdventaLBL.Name = "IDdventaLBL";
            this.IDdventaLBL.Size = new System.Drawing.Size(66, 17);
            this.IDdventaLBL.TabIndex = 74;
            this.IDdventaLBL.Text = "Venta ID";
            // 
            // IDProductoCMB
            // 
            this.IDProductoCMB.FormattingEnabled = true;
            this.IDProductoCMB.Location = new System.Drawing.Point(390, 96);
            this.IDProductoCMB.Name = "IDProductoCMB";
            this.IDProductoCMB.Size = new System.Drawing.Size(121, 21);
            this.IDProductoCMB.TabIndex = 76;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(517, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 77;
            this.label7.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(355, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 43);
            this.label11.TabIndex = 79;
            this.label11.Text = "&Venta";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(486, 12);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(290, 10);
            this.panel9.TabIndex = 80;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(43, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 10);
            this.panel1.TabIndex = 81;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 43);
            this.panel2.TabIndex = 82;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 407);
            this.panel3.TabIndex = 83;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(790, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 407);
            this.panel4.TabIndex = 84;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(469, 440);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(321, 10);
            this.panel5.TabIndex = 85;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(10, 440);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(321, 10);
            this.panel6.TabIndex = 86;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gray;
            this.panel7.Location = new System.Drawing.Point(331, 440);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(138, 10);
            this.panel7.TabIndex = 87;
            // 
            // IDFacturaCMB
            // 
            this.IDFacturaCMB.FormattingEnabled = true;
            this.IDFacturaCMB.Location = new System.Drawing.Point(133, 93);
            this.IDFacturaCMB.Name = "IDFacturaCMB";
            this.IDFacturaCMB.Size = new System.Drawing.Size(121, 21);
            this.IDFacturaCMB.TabIndex = 88;
            // 
            // DVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IDFacturaCMB);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.IDProductoCMB);
            this.Controls.Add(this.IDventaTXT);
            this.Controls.Add(this.IDdventaLBL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CantidadTXT);
            this.Controls.Add(this.SalirBTN);
            this.Controls.Add(this.ImprimirVenta);
            this.Controls.Add(this.ModificarVentaBTN);
            this.Controls.Add(this.AgregarVenta);
            this.Controls.Add(this.DgvDVentas);
            this.Controls.Add(this.panel2);
            this.Name = "DVenta";
            this.Text = "DVenta";
            this.Load += new System.EventHandler(this.DVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDVentas;
        private System.Windows.Forms.Button AgregarVenta;
        private System.Windows.Forms.Button ModificarVentaBTN;
        private System.Windows.Forms.Button ImprimirVenta;
        private System.Windows.Forms.Button SalirBTN;
        private System.Windows.Forms.TextBox CantidadTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IDventaTXT;
        private System.Windows.Forms.Label IDdventaLBL;
        private System.Windows.Forms.ComboBox IDProductoCMB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox IDFacturaCMB;
    }
}