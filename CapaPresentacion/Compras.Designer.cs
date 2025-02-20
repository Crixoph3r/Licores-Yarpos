namespace CapaPresentacion
{
    partial class Compras
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
            this.ImprimirCompraBTN = new System.Windows.Forms.Button();
            this.ModificarCompraBTN = new System.Windows.Forms.Button();
            this.CancelarComprasBTN = new System.Windows.Forms.Button();
            this.DgvCompras = new System.Windows.Forms.DataGridView();
            this.CrearCuentaBTN = new System.Windows.Forms.Button();
            this.CantidadCompraTXT = new System.Windows.Forms.TextBox();
            this.CantidadCompraLBL = new System.Windows.Forms.Label();
            this.FechaEntregaDT = new System.Windows.Forms.DateTimePicker();
            this.IDProveedorLBL = new System.Windows.Forms.Label();
            this.IDProductoLBL = new System.Windows.Forms.Label();
            this.FecaheEntregaDATE = new System.Windows.Forms.Label();
            this.LimpiarBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IDProductoCBM = new System.Windows.Forms.ComboBox();
            this.IDProveedorCMB = new System.Windows.Forms.ComboBox();
            this.IDComprasTXT = new System.Windows.Forms.TextBox();
            this.IDcomprasLBL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCompras)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImprimirCompraBTN
            // 
            this.ImprimirCompraBTN.BackColor = System.Drawing.Color.Black;
            this.ImprimirCompraBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImprimirCompraBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImprimirCompraBTN.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.ImprimirCompraBTN.ForeColor = System.Drawing.Color.White;
            this.ImprimirCompraBTN.Location = new System.Drawing.Point(796, 247);
            this.ImprimirCompraBTN.Name = "ImprimirCompraBTN";
            this.ImprimirCompraBTN.Size = new System.Drawing.Size(170, 40);
            this.ImprimirCompraBTN.TabIndex = 39;
            this.ImprimirCompraBTN.Text = "Imprimir Compra";
            this.ImprimirCompraBTN.UseVisualStyleBackColor = false;
            // 
            // ModificarCompraBTN
            // 
            this.ModificarCompraBTN.BackColor = System.Drawing.Color.Black;
            this.ModificarCompraBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModificarCompraBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModificarCompraBTN.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.ModificarCompraBTN.ForeColor = System.Drawing.Color.White;
            this.ModificarCompraBTN.Location = new System.Drawing.Point(375, 247);
            this.ModificarCompraBTN.Name = "ModificarCompraBTN";
            this.ModificarCompraBTN.Size = new System.Drawing.Size(170, 40);
            this.ModificarCompraBTN.TabIndex = 37;
            this.ModificarCompraBTN.Text = "Modificar Compra";
            this.ModificarCompraBTN.UseVisualStyleBackColor = false;
            this.ModificarCompraBTN.Click += new System.EventHandler(this.ModificarCompraBTN_Click);
            // 
            // CancelarComprasBTN
            // 
            this.CancelarComprasBTN.BackColor = System.Drawing.Color.Black;
            this.CancelarComprasBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarComprasBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelarComprasBTN.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.CancelarComprasBTN.ForeColor = System.Drawing.Color.White;
            this.CancelarComprasBTN.Location = new System.Drawing.Point(515, 475);
            this.CancelarComprasBTN.Name = "CancelarComprasBTN";
            this.CancelarComprasBTN.Size = new System.Drawing.Size(115, 40);
            this.CancelarComprasBTN.TabIndex = 36;
            this.CancelarComprasBTN.Text = "Salir";
            this.CancelarComprasBTN.UseVisualStyleBackColor = false;
            this.CancelarComprasBTN.Click += new System.EventHandler(this.CancelarBTN_Click);
            // 
            // DgvCompras
            // 
            this.DgvCompras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCompras.Location = new System.Drawing.Point(27, 306);
            this.DgvCompras.Name = "DgvCompras";
            this.DgvCompras.Size = new System.Drawing.Size(1091, 138);
            this.DgvCompras.TabIndex = 34;
            this.DgvCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCompras_CellContentClick);
            this.DgvCompras.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCompras_CellContentDoubleClick);
            // 
            // CrearCuentaBTN
            // 
            this.CrearCuentaBTN.BackColor = System.Drawing.Color.Black;
            this.CrearCuentaBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CrearCuentaBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CrearCuentaBTN.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.CrearCuentaBTN.ForeColor = System.Drawing.Color.White;
            this.CrearCuentaBTN.Location = new System.Drawing.Point(171, 247);
            this.CrearCuentaBTN.Name = "CrearCuentaBTN";
            this.CrearCuentaBTN.Size = new System.Drawing.Size(170, 40);
            this.CrearCuentaBTN.TabIndex = 33;
            this.CrearCuentaBTN.Text = "Agregar Compra";
            this.CrearCuentaBTN.UseVisualStyleBackColor = false;
            this.CrearCuentaBTN.Click += new System.EventHandler(this.CrearCuentaBTN_Click);
            // 
            // CantidadCompraTXT
            // 
            this.CantidadCompraTXT.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadCompraTXT.Location = new System.Drawing.Point(944, 190);
            this.CantidadCompraTXT.Name = "CantidadCompraTXT";
            this.CantidadCompraTXT.Size = new System.Drawing.Size(100, 25);
            this.CantidadCompraTXT.TabIndex = 32;
            this.CantidadCompraTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantidadCompraTXT_KeyPress);
            // 
            // CantidadCompraLBL
            // 
            this.CantidadCompraLBL.AutoSize = true;
            this.CantidadCompraLBL.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadCompraLBL.Location = new System.Drawing.Point(790, 197);
            this.CantidadCompraLBL.Name = "CantidadCompraLBL";
            this.CantidadCompraLBL.Size = new System.Drawing.Size(148, 17);
            this.CantidadCompraLBL.TabIndex = 31;
            this.CantidadCompraLBL.Text = "Cantidad de Compra";
            // 
            // FechaEntregaDT
            // 
            this.FechaEntregaDT.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaEntregaDT.Location = new System.Drawing.Point(166, 117);
            this.FechaEntregaDT.Name = "FechaEntregaDT";
            this.FechaEntregaDT.Size = new System.Drawing.Size(200, 25);
            this.FechaEntregaDT.TabIndex = 30;
            // 
            // IDProveedorLBL
            // 
            this.IDProveedorLBL.AutoSize = true;
            this.IDProveedorLBL.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDProveedorLBL.Location = new System.Drawing.Point(537, 193);
            this.IDProveedorLBL.Name = "IDProveedorLBL";
            this.IDProveedorLBL.Size = new System.Drawing.Size(101, 17);
            this.IDProveedorLBL.TabIndex = 26;
            this.IDProveedorLBL.Text = "ID Proveedor";
            // 
            // IDProductoLBL
            // 
            this.IDProductoLBL.AutoSize = true;
            this.IDProductoLBL.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDProductoLBL.Location = new System.Drawing.Point(274, 191);
            this.IDProductoLBL.Name = "IDProductoLBL";
            this.IDProductoLBL.Size = new System.Drawing.Size(91, 17);
            this.IDProductoLBL.TabIndex = 24;
            this.IDProductoLBL.Text = "ID Producto";
            // 
            // FecaheEntregaDATE
            // 
            this.FecaheEntregaDATE.AutoSize = true;
            this.FecaheEntregaDATE.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FecaheEntregaDATE.ForeColor = System.Drawing.Color.Black;
            this.FecaheEntregaDATE.Location = new System.Drawing.Point(36, 117);
            this.FecaheEntregaDATE.Name = "FecaheEntregaDATE";
            this.FecaheEntregaDATE.Size = new System.Drawing.Size(124, 17);
            this.FecaheEntregaDATE.TabIndex = 23;
            this.FecaheEntregaDATE.Text = "Fecha de Entrega";
            // 
            // LimpiarBTN
            // 
            this.LimpiarBTN.BackColor = System.Drawing.Color.Black;
            this.LimpiarBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LimpiarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LimpiarBTN.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpiarBTN.ForeColor = System.Drawing.Color.White;
            this.LimpiarBTN.Location = new System.Drawing.Point(590, 247);
            this.LimpiarBTN.Name = "LimpiarBTN";
            this.LimpiarBTN.Size = new System.Drawing.Size(150, 40);
            this.LimpiarBTN.TabIndex = 53;
            this.LimpiarBTN.Text = "Limpiar";
            this.LimpiarBTN.UseVisualStyleBackColor = false;
            this.LimpiarBTN.Click += new System.EventHandler(this.LimpiarBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(492, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(761, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1050, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "*";
            // 
            // IDProductoCBM
            // 
            this.IDProductoCBM.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDProductoCBM.FormattingEnabled = true;
            this.IDProductoCBM.Location = new System.Drawing.Point(363, 189);
            this.IDProductoCBM.Name = "IDProductoCBM";
            this.IDProductoCBM.Size = new System.Drawing.Size(121, 25);
            this.IDProductoCBM.TabIndex = 58;
            this.IDProductoCBM.SelectedIndexChanged += new System.EventHandler(this.IDProductoCBM_SelectedIndexChanged);
            // 
            // IDProveedorCMB
            // 
            this.IDProveedorCMB.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDProveedorCMB.FormattingEnabled = true;
            this.IDProveedorCMB.Location = new System.Drawing.Point(634, 192);
            this.IDProveedorCMB.Name = "IDProveedorCMB";
            this.IDProveedorCMB.Size = new System.Drawing.Size(121, 25);
            this.IDProveedorCMB.TabIndex = 59;
            // 
            // IDComprasTXT
            // 
            this.IDComprasTXT.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDComprasTXT.Location = new System.Drawing.Point(166, 188);
            this.IDComprasTXT.Name = "IDComprasTXT";
            this.IDComprasTXT.Size = new System.Drawing.Size(75, 25);
            this.IDComprasTXT.TabIndex = 73;
            // 
            // IDcomprasLBL
            // 
            this.IDcomprasLBL.AutoSize = true;
            this.IDcomprasLBL.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDcomprasLBL.Location = new System.Drawing.Point(78, 191);
            this.IDcomprasLBL.Name = "IDcomprasLBL";
            this.IDcomprasLBL.Size = new System.Drawing.Size(82, 17);
            this.IDcomprasLBL.TabIndex = 72;
            this.IDcomprasLBL.Text = "Compra ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 42);
            this.panel1.TabIndex = 74;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(698, 19);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(420, 10);
            this.panel9.TabIndex = 67;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(16, 19);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(420, 10);
            this.panel8.TabIndex = 66;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(491, -1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 43);
            this.label11.TabIndex = 58;
            this.label11.Text = "&Compra";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Location = new System.Drawing.Point(484, 541);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(172, 10);
            this.panel6.TabIndex = 77;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(656, 541);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(478, 10);
            this.panel5.TabIndex = 76;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 541);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(484, 10);
            this.panel4.TabIndex = 75;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 509);
            this.panel2.TabIndex = 78;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1124, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 509);
            this.panel3.TabIndex = 79;
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1134, 551);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.IDComprasTXT);
            this.Controls.Add(this.IDcomprasLBL);
            this.Controls.Add(this.IDProveedorCMB);
            this.Controls.Add(this.IDProductoCBM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LimpiarBTN);
            this.Controls.Add(this.ImprimirCompraBTN);
            this.Controls.Add(this.ModificarCompraBTN);
            this.Controls.Add(this.CancelarComprasBTN);
            this.Controls.Add(this.DgvCompras);
            this.Controls.Add(this.CrearCuentaBTN);
            this.Controls.Add(this.CantidadCompraTXT);
            this.Controls.Add(this.CantidadCompraLBL);
            this.Controls.Add(this.FechaEntregaDT);
            this.Controls.Add(this.IDProveedorLBL);
            this.Controls.Add(this.IDProductoLBL);
            this.Controls.Add(this.FecaheEntregaDATE);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Compras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCompras)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ImprimirCompraBTN;
        private System.Windows.Forms.Button ModificarCompraBTN;
        private System.Windows.Forms.Button CancelarComprasBTN;
        private System.Windows.Forms.DataGridView DgvCompras;
        private System.Windows.Forms.Button CrearCuentaBTN;
        private System.Windows.Forms.TextBox CantidadCompraTXT;
        private System.Windows.Forms.Label CantidadCompraLBL;
        private System.Windows.Forms.DateTimePicker FechaEntregaDT;
        private System.Windows.Forms.Label IDProveedorLBL;
        private System.Windows.Forms.Label IDProductoLBL;
        private System.Windows.Forms.Label FecaheEntregaDATE;
        private System.Windows.Forms.Button LimpiarBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox IDProductoCBM;
        private System.Windows.Forms.ComboBox IDProveedorCMB;
        private System.Windows.Forms.TextBox IDComprasTXT;
        private System.Windows.Forms.Label IDcomprasLBL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}