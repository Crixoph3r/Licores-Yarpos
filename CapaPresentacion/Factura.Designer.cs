namespace CapaPresentacion
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
            this.CancelarBTN = new System.Windows.Forms.Button();
            this.DgvFactura = new System.Windows.Forms.DataGridView();
            this.ModificarFacBTN = new System.Windows.Forms.Button();
            this.CrearFacturaBTN = new System.Windows.Forms.Button();
            this.IDClienteLBL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ImprimirFacturaBTN = new System.Windows.Forms.Button();
            this.LimpiarBTN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IDFactruraTXT = new System.Windows.Forms.TextBox();
            this.IDfacturaLBL = new System.Windows.Forms.Label();
            this.IDCLienteTXT = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.FechaFacturaPICK = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TPagarTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFactura)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelarBTN
            // 
            this.CancelarBTN.BackColor = System.Drawing.Color.Black;
            this.CancelarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelarBTN.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.CancelarBTN.ForeColor = System.Drawing.Color.White;
            this.CancelarBTN.Location = new System.Drawing.Point(696, 582);
            this.CancelarBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelarBTN.Name = "CancelarBTN";
            this.CancelarBTN.Size = new System.Drawing.Size(153, 49);
            this.CancelarBTN.TabIndex = 23;
            this.CancelarBTN.Text = "Salir";
            this.CancelarBTN.UseVisualStyleBackColor = false;
            this.CancelarBTN.Click += new System.EventHandler(this.CancelarBTN_Click);
            // 
            // DgvFactura
            // 
            this.DgvFactura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFactura.Location = new System.Drawing.Point(349, 346);
            this.DgvFactura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgvFactura.Name = "DgvFactura";
            this.DgvFactura.RowHeadersWidth = 51;
            this.DgvFactura.Size = new System.Drawing.Size(879, 202);
            this.DgvFactura.TabIndex = 21;
            this.DgvFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFactura_CellContentClick);
            this.DgvFactura.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFactura_CellContentDoubleClick);
            // 
            // ModificarFacBTN
            // 
            this.ModificarFacBTN.BackColor = System.Drawing.Color.Black;
            this.ModificarFacBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModificarFacBTN.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarFacBTN.ForeColor = System.Drawing.Color.White;
            this.ModificarFacBTN.Location = new System.Drawing.Point(577, 274);
            this.ModificarFacBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModificarFacBTN.Name = "ModificarFacBTN";
            this.ModificarFacBTN.Size = new System.Drawing.Size(200, 49);
            this.ModificarFacBTN.TabIndex = 19;
            this.ModificarFacBTN.Text = "Modificar Factura";
            this.ModificarFacBTN.UseVisualStyleBackColor = false;
            this.ModificarFacBTN.Click += new System.EventHandler(this.ModificarFacBTN_Click);
            // 
            // CrearFacturaBTN
            // 
            this.CrearFacturaBTN.BackColor = System.Drawing.Color.Black;
            this.CrearFacturaBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CrearFacturaBTN.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearFacturaBTN.ForeColor = System.Drawing.Color.White;
            this.CrearFacturaBTN.Location = new System.Drawing.Point(327, 274);
            this.CrearFacturaBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CrearFacturaBTN.Name = "CrearFacturaBTN";
            this.CrearFacturaBTN.Size = new System.Drawing.Size(200, 49);
            this.CrearFacturaBTN.TabIndex = 18;
            this.CrearFacturaBTN.Text = "Agregar Factura";
            this.CrearFacturaBTN.UseVisualStyleBackColor = false;
            this.CrearFacturaBTN.Click += new System.EventHandler(this.CrearFacturaBTN_Click);
            // 
            // IDClienteLBL
            // 
            this.IDClienteLBL.AutoSize = true;
            this.IDClienteLBL.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.IDClienteLBL.Location = new System.Drawing.Point(604, 130);
            this.IDClienteLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDClienteLBL.Name = "IDClienteLBL";
            this.IDClienteLBL.Size = new System.Drawing.Size(95, 22);
            this.IDClienteLBL.TabIndex = 14;
            this.IDClienteLBL.Text = "ID Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(927, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "Fecha";
            // 
            // ImprimirFacturaBTN
            // 
            this.ImprimirFacturaBTN.BackColor = System.Drawing.Color.Black;
            this.ImprimirFacturaBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImprimirFacturaBTN.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImprimirFacturaBTN.ForeColor = System.Drawing.Color.White;
            this.ImprimirFacturaBTN.Location = new System.Drawing.Point(1041, 274);
            this.ImprimirFacturaBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ImprimirFacturaBTN.Name = "ImprimirFacturaBTN";
            this.ImprimirFacturaBTN.Size = new System.Drawing.Size(200, 49);
            this.ImprimirFacturaBTN.TabIndex = 51;
            this.ImprimirFacturaBTN.Text = "Imprimir Factura";
            this.ImprimirFacturaBTN.UseVisualStyleBackColor = false;
            // 
            // LimpiarBTN
            // 
            this.LimpiarBTN.BackColor = System.Drawing.Color.Black;
            this.LimpiarBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LimpiarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LimpiarBTN.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpiarBTN.ForeColor = System.Drawing.Color.White;
            this.LimpiarBTN.Location = new System.Drawing.Point(807, 274);
            this.LimpiarBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LimpiarBTN.Name = "LimpiarBTN";
            this.LimpiarBTN.Size = new System.Drawing.Size(200, 49);
            this.LimpiarBTN.TabIndex = 54;
            this.LimpiarBTN.Text = "Limpiar";
            this.LimpiarBTN.UseVisualStyleBackColor = false;
            this.LimpiarBTN.Click += new System.EventHandler(this.LimpiarBTN_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(876, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 25);
            this.label5.TabIndex = 56;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1256, 135);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 25);
            this.label6.TabIndex = 57;
            this.label6.Text = "*";
            // 
            // IDFactruraTXT
            // 
            this.IDFactruraTXT.Location = new System.Drawing.Point(411, 130);
            this.IDFactruraTXT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDFactruraTXT.Name = "IDFactruraTXT";
            this.IDFactruraTXT.Size = new System.Drawing.Size(160, 22);
            this.IDFactruraTXT.TabIndex = 76;
            // 
            // IDfacturaLBL
            // 
            this.IDfacturaLBL.AutoSize = true;
            this.IDfacturaLBL.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.IDfacturaLBL.Location = new System.Drawing.Point(304, 133);
            this.IDfacturaLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDfacturaLBL.Name = "IDfacturaLBL";
            this.IDfacturaLBL.Size = new System.Drawing.Size(99, 22);
            this.IDfacturaLBL.TabIndex = 75;
            this.IDfacturaLBL.Text = "Factura ID";
            // 
            // IDCLienteTXT
            // 
            this.IDCLienteTXT.FormattingEnabled = true;
            this.IDCLienteTXT.Location = new System.Drawing.Point(707, 130);
            this.IDCLienteTXT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDCLienteTXT.Name = "IDCLienteTXT";
            this.IDCLienteTXT.Size = new System.Drawing.Size(160, 24);
            this.IDCLienteTXT.TabIndex = 77;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(665, 193);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 57);
            this.button1.TabIndex = 79;
            this.button1.Text = "Ingresar Productos a Factura";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FechaFacturaPICK
            // 
            this.FechaFacturaPICK.CustomFormat = "dd-MM-yyyy";
            this.FechaFacturaPICK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaFacturaPICK.Location = new System.Drawing.Point(992, 130);
            this.FechaFacturaPICK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FechaFacturaPICK.Name = "FechaFacturaPICK";
            this.FechaFacturaPICK.Size = new System.Drawing.Size(255, 22);
            this.FechaFacturaPICK.TabIndex = 60;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1512, 52);
            this.panel1.TabIndex = 80;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(931, 23);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(560, 12);
            this.panel9.TabIndex = 67;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(21, 23);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(560, 12);
            this.panel8.TabIndex = 66;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(659, -1);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 55);
            this.label11.TabIndex = 58;
            this.label11.Text = "&Factura";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Location = new System.Drawing.Point(645, 666);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(208, 12);
            this.panel6.TabIndex = 83;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(853, 666);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(659, 12);
            this.panel5.TabIndex = 82;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(13, 666);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(637, 12);
            this.panel4.TabIndex = 81;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 626);
            this.panel2.TabIndex = 84;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1499, 52);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 626);
            this.panel3.TabIndex = 85;
            // 
            // TPagarTXT
            // 
            this.TPagarTXT.Location = new System.Drawing.Point(1115, 193);
            this.TPagarTXT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TPagarTXT.Name = "TPagarTXT";
            this.TPagarTXT.Size = new System.Drawing.Size(160, 22);
            this.TPagarTXT.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1008, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 86;
            this.label2.Text = "Factura ID";
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1512, 678);
            this.Controls.Add(this.TPagarTXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IDCLienteTXT);
            this.Controls.Add(this.IDFactruraTXT);
            this.Controls.Add(this.IDfacturaLBL);
            this.Controls.Add(this.FechaFacturaPICK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LimpiarBTN);
            this.Controls.Add(this.ImprimirFacturaBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelarBTN);
            this.Controls.Add(this.DgvFactura);
            this.Controls.Add(this.ModificarFacBTN);
            this.Controls.Add(this.CrearFacturaBTN);
            this.Controls.Add(this.IDClienteLBL);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFactura)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelarBTN;
        private System.Windows.Forms.DataGridView DgvFactura;
        private System.Windows.Forms.Button ModificarFacBTN;
        private System.Windows.Forms.Button CrearFacturaBTN;
        private System.Windows.Forms.Label IDClienteLBL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ImprimirFacturaBTN;
        private System.Windows.Forms.Button LimpiarBTN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IDFactruraTXT;
        private System.Windows.Forms.Label IDfacturaLBL;
        private System.Windows.Forms.ComboBox IDCLienteTXT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker FechaFacturaPICK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TPagarTXT;
        private System.Windows.Forms.Label label2;
    }
}