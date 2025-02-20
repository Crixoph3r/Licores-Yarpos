namespace CapaPresentacion
{
    partial class Producto
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
            this.TipoLBL = new System.Windows.Forms.Label();
            this.CancelarBTN = new System.Windows.Forms.Button();
            this.DgvProdcuto = new System.Windows.Forms.DataGridView();
            this.ImportarProductosBTN = new System.Windows.Forms.Button();
            this.ModificarProductoBTN = new System.Windows.Forms.Button();
            this.AgregarProductoBTN = new System.Windows.Forms.Button();
            this.EstadoCOMBO = new System.Windows.Forms.ComboBox();
            this.EstadoLBL = new System.Windows.Forms.Label();
            this.NombreProductoTXT = new System.Windows.Forms.TextBox();
            this.NombreProductoLBL = new System.Windows.Forms.Label();
            this.PrecioLBL = new System.Windows.Forms.Label();
            this.PrecioTXT = new System.Windows.Forms.TextBox();
            this.TipoCOMBO = new System.Windows.Forms.ComboBox();
            this.LimpiarBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDprodcutoTXT = new System.Windows.Forms.TextBox();
            this.IDprodcutoLBL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdcuto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TipoLBL
            // 
            this.TipoLBL.AutoSize = true;
            this.TipoLBL.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoLBL.Location = new System.Drawing.Point(479, 106);
            this.TipoLBL.Name = "TipoLBL";
            this.TipoLBL.Size = new System.Drawing.Size(40, 16);
            this.TipoLBL.TabIndex = 36;
            this.TipoLBL.Text = "Tipo";
            // 
            // CancelarBTN
            // 
            this.CancelarBTN.BackColor = System.Drawing.Color.Black;
            this.CancelarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelarBTN.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.CancelarBTN.ForeColor = System.Drawing.Color.White;
            this.CancelarBTN.Location = new System.Drawing.Point(514, 466);
            this.CancelarBTN.Name = "CancelarBTN";
            this.CancelarBTN.Size = new System.Drawing.Size(115, 40);
            this.CancelarBTN.TabIndex = 34;
            this.CancelarBTN.Text = "Salir";
            this.CancelarBTN.UseVisualStyleBackColor = false;
            this.CancelarBTN.Click += new System.EventHandler(this.CancelarBTN_Click);
            // 
            // DgvProdcuto
            // 
            this.DgvProdcuto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvProdcuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProdcuto.Location = new System.Drawing.Point(215, 278);
            this.DgvProdcuto.Name = "DgvProdcuto";
            this.DgvProdcuto.Size = new System.Drawing.Size(722, 150);
            this.DgvProdcuto.TabIndex = 32;
            this.DgvProdcuto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProdcuto_CellContentClick);
            this.DgvProdcuto.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProdcuto_CellContentDoubleClick);
            // 
            // ImportarProductosBTN
            // 
            this.ImportarProductosBTN.BackColor = System.Drawing.Color.Black;
            this.ImportarProductosBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportarProductosBTN.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.ImportarProductosBTN.ForeColor = System.Drawing.Color.White;
            this.ImportarProductosBTN.Location = new System.Drawing.Point(767, 222);
            this.ImportarProductosBTN.Name = "ImportarProductosBTN";
            this.ImportarProductosBTN.Size = new System.Drawing.Size(170, 40);
            this.ImportarProductosBTN.TabIndex = 31;
            this.ImportarProductosBTN.Text = "Imprimir Producto";
            this.ImportarProductosBTN.UseVisualStyleBackColor = false;
            // 
            // ModificarProductoBTN
            // 
            this.ModificarProductoBTN.BackColor = System.Drawing.Color.Black;
            this.ModificarProductoBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModificarProductoBTN.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.ModificarProductoBTN.ForeColor = System.Drawing.Color.White;
            this.ModificarProductoBTN.Location = new System.Drawing.Point(407, 222);
            this.ModificarProductoBTN.Name = "ModificarProductoBTN";
            this.ModificarProductoBTN.Size = new System.Drawing.Size(170, 40);
            this.ModificarProductoBTN.TabIndex = 30;
            this.ModificarProductoBTN.Text = "Modificar Producto";
            this.ModificarProductoBTN.UseVisualStyleBackColor = false;
            this.ModificarProductoBTN.Click += new System.EventHandler(this.ModificarProductoBTN_Click);
            // 
            // AgregarProductoBTN
            // 
            this.AgregarProductoBTN.BackColor = System.Drawing.Color.Black;
            this.AgregarProductoBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarProductoBTN.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.AgregarProductoBTN.ForeColor = System.Drawing.Color.White;
            this.AgregarProductoBTN.Location = new System.Drawing.Point(217, 222);
            this.AgregarProductoBTN.Name = "AgregarProductoBTN";
            this.AgregarProductoBTN.Size = new System.Drawing.Size(170, 40);
            this.AgregarProductoBTN.TabIndex = 28;
            this.AgregarProductoBTN.Text = "Agregar Producto";
            this.AgregarProductoBTN.UseVisualStyleBackColor = false;
            this.AgregarProductoBTN.Click += new System.EventHandler(this.AgregarProductoBTN_Click);
            // 
            // EstadoCOMBO
            // 
            this.EstadoCOMBO.FormattingEnabled = true;
            this.EstadoCOMBO.Location = new System.Drawing.Point(816, 160);
            this.EstadoCOMBO.Name = "EstadoCOMBO";
            this.EstadoCOMBO.Size = new System.Drawing.Size(121, 21);
            this.EstadoCOMBO.TabIndex = 27;
            // 
            // EstadoLBL
            // 
            this.EstadoLBL.AutoSize = true;
            this.EstadoLBL.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstadoLBL.Location = new System.Drawing.Point(756, 160);
            this.EstadoLBL.Name = "EstadoLBL";
            this.EstadoLBL.Size = new System.Drawing.Size(55, 16);
            this.EstadoLBL.TabIndex = 26;
            this.EstadoLBL.Text = "Estado";
            // 
            // NombreProductoTXT
            // 
            this.NombreProductoTXT.Location = new System.Drawing.Point(515, 159);
            this.NombreProductoTXT.MaxLength = 30;
            this.NombreProductoTXT.Name = "NombreProductoTXT";
            this.NombreProductoTXT.Size = new System.Drawing.Size(135, 20);
            this.NombreProductoTXT.TabIndex = 25;
            // 
            // NombreProductoLBL
            // 
            this.NombreProductoLBL.AutoSize = true;
            this.NombreProductoLBL.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreProductoLBL.Location = new System.Drawing.Point(390, 162);
            this.NombreProductoLBL.Name = "NombreProductoLBL";
            this.NombreProductoLBL.Size = new System.Drawing.Size(133, 16);
            this.NombreProductoLBL.TabIndex = 24;
            this.NombreProductoLBL.Text = "Nombre Producto";
            // 
            // PrecioLBL
            // 
            this.PrecioLBL.AutoSize = true;
            this.PrecioLBL.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioLBL.Location = new System.Drawing.Point(755, 108);
            this.PrecioLBL.Name = "PrecioLBL";
            this.PrecioLBL.Size = new System.Drawing.Size(57, 16);
            this.PrecioLBL.TabIndex = 22;
            this.PrecioLBL.Text = "Precio ";
            // 
            // PrecioTXT
            // 
            this.PrecioTXT.Location = new System.Drawing.Point(816, 105);
            this.PrecioTXT.MaxLength = 10;
            this.PrecioTXT.Name = "PrecioTXT";
            this.PrecioTXT.Size = new System.Drawing.Size(121, 20);
            this.PrecioTXT.TabIndex = 21;
            this.PrecioTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecioTXT_KeyPress);
            // 
            // TipoCOMBO
            // 
            this.TipoCOMBO.FormattingEnabled = true;
            this.TipoCOMBO.Location = new System.Drawing.Point(529, 105);
            this.TipoCOMBO.Name = "TipoCOMBO";
            this.TipoCOMBO.Size = new System.Drawing.Size(121, 21);
            this.TipoCOMBO.TabIndex = 37;
            // 
            // LimpiarBTN
            // 
            this.LimpiarBTN.BackColor = System.Drawing.Color.Black;
            this.LimpiarBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LimpiarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LimpiarBTN.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpiarBTN.ForeColor = System.Drawing.Color.White;
            this.LimpiarBTN.Location = new System.Drawing.Point(599, 222);
            this.LimpiarBTN.Name = "LimpiarBTN";
            this.LimpiarBTN.Size = new System.Drawing.Size(150, 40);
            this.LimpiarBTN.TabIndex = 55;
            this.LimpiarBTN.Text = "Limpiar";
            this.LimpiarBTN.UseVisualStyleBackColor = false;
            this.LimpiarBTN.Click += new System.EventHandler(this.LimpiarBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(670, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 69;
            this.label1.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(943, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 70;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(943, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(656, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 72;
            this.label2.Text = "*";
            // 
            // IDprodcutoTXT
            // 
            this.IDprodcutoTXT.Location = new System.Drawing.Point(262, 108);
            this.IDprodcutoTXT.Name = "IDprodcutoTXT";
            this.IDprodcutoTXT.Size = new System.Drawing.Size(88, 20);
            this.IDprodcutoTXT.TabIndex = 77;
            // 
            // IDprodcutoLBL
            // 
            this.IDprodcutoLBL.AutoSize = true;
            this.IDprodcutoLBL.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDprodcutoLBL.Location = new System.Drawing.Point(162, 112);
            this.IDprodcutoLBL.Name = "IDprodcutoLBL";
            this.IDprodcutoLBL.Size = new System.Drawing.Size(94, 16);
            this.IDprodcutoLBL.TabIndex = 76;
            this.IDprodcutoLBL.Text = "Producto ID";
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
            this.panel1.TabIndex = 78;
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
            this.label11.Location = new System.Drawing.Point(481, -1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 43);
            this.label11.TabIndex = 58;
            this.label11.Text = "&Producto";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 509);
            this.panel2.TabIndex = 79;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1124, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 509);
            this.panel3.TabIndex = 80;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Location = new System.Drawing.Point(482, 541);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(165, 10);
            this.panel6.TabIndex = 83;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(646, 541);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(478, 10);
            this.panel5.TabIndex = 82;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(9, 541);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(478, 10);
            this.panel4.TabIndex = 81;
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1134, 551);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.IDprodcutoTXT);
            this.Controls.Add(this.IDprodcutoLBL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LimpiarBTN);
            this.Controls.Add(this.TipoCOMBO);
            this.Controls.Add(this.TipoLBL);
            this.Controls.Add(this.CancelarBTN);
            this.Controls.Add(this.DgvProdcuto);
            this.Controls.Add(this.ImportarProductosBTN);
            this.Controls.Add(this.ModificarProductoBTN);
            this.Controls.Add(this.AgregarProductoBTN);
            this.Controls.Add(this.EstadoCOMBO);
            this.Controls.Add(this.EstadoLBL);
            this.Controls.Add(this.NombreProductoTXT);
            this.Controls.Add(this.NombreProductoLBL);
            this.Controls.Add(this.PrecioLBL);
            this.Controls.Add(this.PrecioTXT);
            this.Name = "Producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdcuto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TipoLBL;
        private System.Windows.Forms.Button CancelarBTN;
        private System.Windows.Forms.DataGridView DgvProdcuto;
        private System.Windows.Forms.Button ImportarProductosBTN;
        private System.Windows.Forms.Button ModificarProductoBTN;
        private System.Windows.Forms.Button AgregarProductoBTN;
        private System.Windows.Forms.ComboBox EstadoCOMBO;
        private System.Windows.Forms.Label EstadoLBL;
        private System.Windows.Forms.TextBox NombreProductoTXT;
        private System.Windows.Forms.Label NombreProductoLBL;
        private System.Windows.Forms.Label PrecioLBL;
        private System.Windows.Forms.TextBox PrecioTXT;
        private System.Windows.Forms.ComboBox TipoCOMBO;
        private System.Windows.Forms.Button LimpiarBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDprodcutoTXT;
        private System.Windows.Forms.Label IDprodcutoLBL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
    }
}