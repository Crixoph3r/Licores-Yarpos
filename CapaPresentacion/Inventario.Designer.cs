namespace CapaPresentacion
{
    partial class Inventario
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
            this.ImprimirInventarioBTN = new System.Windows.Forms.Button();
            this.EditarProductosBTN = new System.Windows.Forms.Button();
            this.DgvInventario = new System.Windows.Forms.DataGridView();
            this.StockSerguridadTXT = new System.Windows.Forms.TextBox();
            this.StockSeguridadLBL = new System.Windows.Forms.Label();
            this.StockMinimoTXT = new System.Windows.Forms.TextBox();
            this.StockMinimoLBL = new System.Windows.Forms.Label();
            this.AjusteTXT = new System.Windows.Forms.TextBox();
            this.AjuteLBL = new System.Windows.Forms.Label();
            this.LimpiarBTN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.IDInvnetarioTXT = new System.Windows.Forms.TextBox();
            this.IDinventarioLBL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CITXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInventario)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelarBTN
            // 
            this.CancelarBTN.BackColor = System.Drawing.Color.Black;
            this.CancelarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelarBTN.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.CancelarBTN.ForeColor = System.Drawing.Color.White;
            this.CancelarBTN.Location = new System.Drawing.Point(510, 465);
            this.CancelarBTN.Name = "CancelarBTN";
            this.CancelarBTN.Size = new System.Drawing.Size(115, 40);
            this.CancelarBTN.TabIndex = 52;
            this.CancelarBTN.Text = "Salir";
            this.CancelarBTN.UseVisualStyleBackColor = false;
            this.CancelarBTN.Click += new System.EventHandler(this.CancelarBTN_Click);
            // 
            // ImprimirInventarioBTN
            // 
            this.ImprimirInventarioBTN.BackColor = System.Drawing.Color.Black;
            this.ImprimirInventarioBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImprimirInventarioBTN.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.ImprimirInventarioBTN.ForeColor = System.Drawing.Color.White;
            this.ImprimirInventarioBTN.Location = new System.Drawing.Point(660, 223);
            this.ImprimirInventarioBTN.Name = "ImprimirInventarioBTN";
            this.ImprimirInventarioBTN.Size = new System.Drawing.Size(170, 40);
            this.ImprimirInventarioBTN.TabIndex = 50;
            this.ImprimirInventarioBTN.Text = "Imprimir Inventario";
            this.ImprimirInventarioBTN.UseVisualStyleBackColor = false;
            // 
            // EditarProductosBTN
            // 
            this.EditarProductosBTN.BackColor = System.Drawing.Color.Black;
            this.EditarProductosBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditarProductosBTN.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.EditarProductosBTN.ForeColor = System.Drawing.Color.White;
            this.EditarProductosBTN.Location = new System.Drawing.Point(307, 223);
            this.EditarProductosBTN.Name = "EditarProductosBTN";
            this.EditarProductosBTN.Size = new System.Drawing.Size(170, 40);
            this.EditarProductosBTN.TabIndex = 48;
            this.EditarProductosBTN.Text = "Editar Productos";
            this.EditarProductosBTN.UseVisualStyleBackColor = false;
            this.EditarProductosBTN.Click += new System.EventHandler(this.EditarProductosBTN_Click);
            // 
            // DgvInventario
            // 
            this.DgvInventario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInventario.Location = new System.Drawing.Point(158, 287);
            this.DgvInventario.Name = "DgvInventario";
            this.DgvInventario.Size = new System.Drawing.Size(845, 150);
            this.DgvInventario.TabIndex = 47;
            this.DgvInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvInventario_CellContentClick);
            this.DgvInventario.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvInventario_CellContentDoubleClick);
            // 
            // StockSerguridadTXT
            // 
            this.StockSerguridadTXT.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockSerguridadTXT.Location = new System.Drawing.Point(853, 141);
            this.StockSerguridadTXT.Name = "StockSerguridadTXT";
            this.StockSerguridadTXT.Size = new System.Drawing.Size(75, 25);
            this.StockSerguridadTXT.TabIndex = 44;
            this.StockSerguridadTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StockSerguridadTXT_KeyPress);
            // 
            // StockSeguridadLBL
            // 
            this.StockSeguridadLBL.AutoSize = true;
            this.StockSeguridadLBL.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockSeguridadLBL.Location = new System.Drawing.Point(727, 145);
            this.StockSeguridadLBL.Name = "StockSeguridadLBL";
            this.StockSeguridadLBL.Size = new System.Drawing.Size(120, 17);
            this.StockSeguridadLBL.TabIndex = 43;
            this.StockSeguridadLBL.Text = "Stock Seguridad";
            // 
            // StockMinimoTXT
            // 
            this.StockMinimoTXT.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockMinimoTXT.Location = new System.Drawing.Point(589, 139);
            this.StockMinimoTXT.Name = "StockMinimoTXT";
            this.StockMinimoTXT.Size = new System.Drawing.Size(75, 25);
            this.StockMinimoTXT.TabIndex = 42;
            this.StockMinimoTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StockMinimoTXT_KeyPress);
            // 
            // StockMinimoLBL
            // 
            this.StockMinimoLBL.AutoSize = true;
            this.StockMinimoLBL.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockMinimoLBL.Location = new System.Drawing.Point(480, 144);
            this.StockMinimoLBL.Name = "StockMinimoLBL";
            this.StockMinimoLBL.Size = new System.Drawing.Size(103, 17);
            this.StockMinimoLBL.TabIndex = 41;
            this.StockMinimoLBL.Text = "Stock Minimo";
            // 
            // AjusteTXT
            // 
            this.AjusteTXT.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjusteTXT.Location = new System.Drawing.Point(339, 139);
            this.AjusteTXT.Name = "AjusteTXT";
            this.AjusteTXT.Size = new System.Drawing.Size(75, 25);
            this.AjusteTXT.TabIndex = 38;
            this.AjusteTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AjusteTXT_KeyPress);
            // 
            // AjuteLBL
            // 
            this.AjuteLBL.AutoSize = true;
            this.AjuteLBL.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjuteLBL.Location = new System.Drawing.Point(281, 145);
            this.AjuteLBL.Name = "AjuteLBL";
            this.AjuteLBL.Size = new System.Drawing.Size(52, 17);
            this.AjuteLBL.TabIndex = 37;
            this.AjuteLBL.Text = "Ajuste";
            // 
            // LimpiarBTN
            // 
            this.LimpiarBTN.BackColor = System.Drawing.Color.Black;
            this.LimpiarBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LimpiarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LimpiarBTN.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpiarBTN.ForeColor = System.Drawing.Color.White;
            this.LimpiarBTN.Location = new System.Drawing.Point(492, 223);
            this.LimpiarBTN.Name = "LimpiarBTN";
            this.LimpiarBTN.Size = new System.Drawing.Size(150, 40);
            this.LimpiarBTN.TabIndex = 58;
            this.LimpiarBTN.Text = "Limpiar";
            this.LimpiarBTN.UseVisualStyleBackColor = false;
            this.LimpiarBTN.Click += new System.EventHandler(this.LimpiarBTN_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(420, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 17);
            this.label5.TabIndex = 64;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(670, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 17);
            this.label6.TabIndex = 65;
            this.label6.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(934, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 17);
            this.label9.TabIndex = 67;
            this.label9.Text = "*";
            // 
            // IDInvnetarioTXT
            // 
            this.IDInvnetarioTXT.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDInvnetarioTXT.Location = new System.Drawing.Point(158, 69);
            this.IDInvnetarioTXT.Name = "IDInvnetarioTXT";
            this.IDInvnetarioTXT.Size = new System.Drawing.Size(75, 25);
            this.IDInvnetarioTXT.TabIndex = 69;
            // 
            // IDinventarioLBL
            // 
            this.IDinventarioLBL.AutoSize = true;
            this.IDinventarioLBL.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDinventarioLBL.Location = new System.Drawing.Point(55, 69);
            this.IDinventarioLBL.Name = "IDinventarioLBL";
            this.IDinventarioLBL.Size = new System.Drawing.Size(97, 17);
            this.IDinventarioLBL.TabIndex = 68;
            this.IDinventarioLBL.Text = "InventarioID";
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
            this.panel1.TabIndex = 70;
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
            this.label11.Location = new System.Drawing.Point(467, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 43);
            this.label11.TabIndex = 58;
            this.label11.Text = "&Inventario";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Location = new System.Drawing.Point(466, 541);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(198, 10);
            this.panel6.TabIndex = 73;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 541);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(466, 10);
            this.panel4.TabIndex = 71;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(660, 541);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(474, 10);
            this.panel3.TabIndex = 72;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 509);
            this.panel5.TabIndex = 75;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(1124, 42);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 509);
            this.panel7.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 17);
            this.label1.TabIndex = 79;
            this.label1.Text = "*";
            // 
            // CITXT
            // 
            this.CITXT.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CITXT.Location = new System.Drawing.Point(158, 141);
            this.CITXT.Name = "CITXT";
            this.CITXT.Size = new System.Drawing.Size(75, 25);
            this.CITXT.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 77;
            this.label2.Text = "Cantidad Inicial";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1134, 551);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CITXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.IDInvnetarioTXT);
            this.Controls.Add(this.IDinventarioLBL);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LimpiarBTN);
            this.Controls.Add(this.CancelarBTN);
            this.Controls.Add(this.ImprimirInventarioBTN);
            this.Controls.Add(this.EditarProductosBTN);
            this.Controls.Add(this.DgvInventario);
            this.Controls.Add(this.StockSerguridadTXT);
            this.Controls.Add(this.StockSeguridadLBL);
            this.Controls.Add(this.StockMinimoTXT);
            this.Controls.Add(this.StockMinimoLBL);
            this.Controls.Add(this.AjusteTXT);
            this.Controls.Add(this.AjuteLBL);
            this.Name = "Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvInventario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelarBTN;
        private System.Windows.Forms.Button ImprimirInventarioBTN;
        private System.Windows.Forms.Button EditarProductosBTN;
        private System.Windows.Forms.DataGridView DgvInventario;
        private System.Windows.Forms.TextBox StockSerguridadTXT;
        private System.Windows.Forms.Label StockSeguridadLBL;
        private System.Windows.Forms.TextBox StockMinimoTXT;
        private System.Windows.Forms.Label StockMinimoLBL;
        private System.Windows.Forms.TextBox AjusteTXT;
        private System.Windows.Forms.Label AjuteLBL;
        private System.Windows.Forms.Button LimpiarBTN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox IDInvnetarioTXT;
        private System.Windows.Forms.Label IDinventarioLBL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CITXT;
        private System.Windows.Forms.Label label2;
    }
}