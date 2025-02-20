namespace CapaPresentacion
{
    partial class CLientes
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
            this.NombreClientetxt = new System.Windows.Forms.TextBox();
            this.DireccionClienteTXT = new System.Windows.Forms.TextBox();
            this.TelClienteTXT = new System.Windows.Forms.TextBox();
            this.AgregarClienteBTN = new System.Windows.Forms.Button();
            this.ModificarClienteBTN = new System.Windows.Forms.Button();
            this.SalirBTN = new System.Windows.Forms.Button();
            this.NombreClienteLB = new System.Windows.Forms.Label();
            this.DireccionLB = new System.Windows.Forms.Label();
            this.TelefonoLB = new System.Windows.Forms.Label();
            this.ImprimirClienteBTN = new System.Windows.Forms.Button();
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            this.LimpiarBTN = new System.Windows.Forms.Button();
            this.IDClienteTXT = new System.Windows.Forms.TextBox();
            this.idcleitneLBL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NombreClientetxt
            // 
            this.NombreClientetxt.Location = new System.Drawing.Point(414, 113);
            this.NombreClientetxt.MaxLength = 35;
            this.NombreClientetxt.Name = "NombreClientetxt";
            this.NombreClientetxt.Size = new System.Drawing.Size(100, 20);
            this.NombreClientetxt.TabIndex = 2;
            // 
            // DireccionClienteTXT
            // 
            this.DireccionClienteTXT.Location = new System.Drawing.Point(682, 113);
            this.DireccionClienteTXT.MaxLength = 65;
            this.DireccionClienteTXT.Name = "DireccionClienteTXT";
            this.DireccionClienteTXT.Size = new System.Drawing.Size(100, 20);
            this.DireccionClienteTXT.TabIndex = 3;
            // 
            // TelClienteTXT
            // 
            this.TelClienteTXT.Location = new System.Drawing.Point(950, 113);
            this.TelClienteTXT.MaxLength = 15;
            this.TelClienteTXT.Name = "TelClienteTXT";
            this.TelClienteTXT.Size = new System.Drawing.Size(100, 20);
            this.TelClienteTXT.TabIndex = 4;
            this.TelClienteTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelClienteTXT_KeyPress);
            // 
            // AgregarClienteBTN
            // 
            this.AgregarClienteBTN.BackColor = System.Drawing.Color.Black;
            this.AgregarClienteBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgregarClienteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarClienteBTN.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarClienteBTN.ForeColor = System.Drawing.Color.White;
            this.AgregarClienteBTN.Location = new System.Drawing.Point(237, 181);
            this.AgregarClienteBTN.Name = "AgregarClienteBTN";
            this.AgregarClienteBTN.Size = new System.Drawing.Size(150, 40);
            this.AgregarClienteBTN.TabIndex = 5;
            this.AgregarClienteBTN.Text = "Agregar Cliente";
            this.AgregarClienteBTN.UseVisualStyleBackColor = false;
            this.AgregarClienteBTN.Click += new System.EventHandler(this.AgregarClienteBTN_Click);
            // 
            // ModificarClienteBTN
            // 
            this.ModificarClienteBTN.BackColor = System.Drawing.Color.Black;
            this.ModificarClienteBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModificarClienteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModificarClienteBTN.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.ModificarClienteBTN.ForeColor = System.Drawing.Color.White;
            this.ModificarClienteBTN.Location = new System.Drawing.Point(434, 181);
            this.ModificarClienteBTN.Name = "ModificarClienteBTN";
            this.ModificarClienteBTN.Size = new System.Drawing.Size(150, 40);
            this.ModificarClienteBTN.TabIndex = 6;
            this.ModificarClienteBTN.Text = "Modificar Cliente";
            this.ModificarClienteBTN.UseVisualStyleBackColor = false;
            this.ModificarClienteBTN.Click += new System.EventHandler(this.ModificarClienteBTN_Click);
            // 
            // SalirBTN
            // 
            this.SalirBTN.BackColor = System.Drawing.Color.Black;
            this.SalirBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalirBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalirBTN.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.SalirBTN.ForeColor = System.Drawing.Color.White;
            this.SalirBTN.Location = new System.Drawing.Point(536, 483);
            this.SalirBTN.Name = "SalirBTN";
            this.SalirBTN.Size = new System.Drawing.Size(115, 40);
            this.SalirBTN.TabIndex = 7;
            this.SalirBTN.Text = "Salir";
            this.SalirBTN.UseVisualStyleBackColor = false;
            this.SalirBTN.Click += new System.EventHandler(this.SalirBTN_Click);
            // 
            // NombreClienteLB
            // 
            this.NombreClienteLB.AutoSize = true;
            this.NombreClienteLB.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreClienteLB.Location = new System.Drawing.Point(292, 116);
            this.NombreClienteLB.Name = "NombreClienteLB";
            this.NombreClienteLB.Size = new System.Drawing.Size(116, 17);
            this.NombreClienteLB.TabIndex = 9;
            this.NombreClienteLB.Text = "Nombre Cliente";
            // 
            // DireccionLB
            // 
            this.DireccionLB.AutoSize = true;
            this.DireccionLB.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DireccionLB.Location = new System.Drawing.Point(551, 117);
            this.DireccionLB.Name = "DireccionLB";
            this.DireccionLB.Size = new System.Drawing.Size(128, 17);
            this.DireccionLB.TabIndex = 10;
            this.DireccionLB.Text = "Direccion Cliente";
            // 
            // TelefonoLB
            // 
            this.TelefonoLB.AutoSize = true;
            this.TelefonoLB.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonoLB.Location = new System.Drawing.Point(826, 117);
            this.TelefonoLB.Name = "TelefonoLB";
            this.TelefonoLB.Size = new System.Drawing.Size(125, 17);
            this.TelefonoLB.TabIndex = 11;
            this.TelefonoLB.Text = " Telefono Cliente";
            // 
            // ImprimirClienteBTN
            // 
            this.ImprimirClienteBTN.BackColor = System.Drawing.Color.Black;
            this.ImprimirClienteBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImprimirClienteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImprimirClienteBTN.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.ImprimirClienteBTN.ForeColor = System.Drawing.Color.White;
            this.ImprimirClienteBTN.Location = new System.Drawing.Point(788, 181);
            this.ImprimirClienteBTN.Name = "ImprimirClienteBTN";
            this.ImprimirClienteBTN.Size = new System.Drawing.Size(150, 40);
            this.ImprimirClienteBTN.TabIndex = 51;
            this.ImprimirClienteBTN.Text = "Imprimir Cliente";
            this.ImprimirClienteBTN.UseVisualStyleBackColor = false;
            // 
            // DgvClientes
            // 
            this.DgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientes.Location = new System.Drawing.Point(201, 238);
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.Size = new System.Drawing.Size(751, 219);
            this.DgvClientes.TabIndex = 1;
            this.DgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClientes_CellClick);
            this.DgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClientes_CellContentClick);
            this.DgvClientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClientes_CellContentDoubleClick);
            // 
            // LimpiarBTN
            // 
            this.LimpiarBTN.BackColor = System.Drawing.Color.Black;
            this.LimpiarBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LimpiarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LimpiarBTN.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpiarBTN.ForeColor = System.Drawing.Color.White;
            this.LimpiarBTN.Location = new System.Drawing.Point(609, 181);
            this.LimpiarBTN.Name = "LimpiarBTN";
            this.LimpiarBTN.Size = new System.Drawing.Size(150, 40);
            this.LimpiarBTN.TabIndex = 52;
            this.LimpiarBTN.Text = "Limpiar";
            this.LimpiarBTN.UseVisualStyleBackColor = false;
            this.LimpiarBTN.Click += new System.EventHandler(this.LimpiarBTN_Click);
            // 
            // IDClienteTXT
            // 
            this.IDClienteTXT.Location = new System.Drawing.Point(174, 113);
            this.IDClienteTXT.Name = "IDClienteTXT";
            this.IDClienteTXT.Size = new System.Drawing.Size(75, 20);
            this.IDClienteTXT.TabIndex = 71;
            // 
            // idcleitneLBL
            // 
            this.idcleitneLBL.AutoSize = true;
            this.idcleitneLBL.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idcleitneLBL.Location = new System.Drawing.Point(97, 116);
            this.idcleitneLBL.Name = "idcleitneLBL";
            this.idcleitneLBL.Size = new System.Drawing.Size(76, 17);
            this.idcleitneLBL.TabIndex = 70;
            this.idcleitneLBL.Text = "Cliente ID";
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
            this.panel1.TabIndex = 81;
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
            this.label11.Location = new System.Drawing.Point(498, -1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 43);
            this.label11.TabIndex = 58;
            this.label11.Text = "&Cliente";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Location = new System.Drawing.Point(495, 541);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(138, 10);
            this.panel6.TabIndex = 84;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(633, 541);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(501, 10);
            this.panel5.TabIndex = 83;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 541);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(498, 10);
            this.panel4.TabIndex = 82;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 509);
            this.panel2.TabIndex = 85;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1124, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 509);
            this.panel3.TabIndex = 86;
            // 
            // CLientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1134, 551);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.IDClienteTXT);
            this.Controls.Add(this.idcleitneLBL);
            this.Controls.Add(this.LimpiarBTN);
            this.Controls.Add(this.ImprimirClienteBTN);
            this.Controls.Add(this.TelefonoLB);
            this.Controls.Add(this.DireccionLB);
            this.Controls.Add(this.NombreClienteLB);
            this.Controls.Add(this.SalirBTN);
            this.Controls.Add(this.ModificarClienteBTN);
            this.Controls.Add(this.AgregarClienteBTN);
            this.Controls.Add(this.TelClienteTXT);
            this.Controls.Add(this.DireccionClienteTXT);
            this.Controls.Add(this.NombreClientetxt);
            this.Controls.Add(this.DgvClientes);
            this.Name = "CLientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.CLientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NombreClientetxt;
        private System.Windows.Forms.TextBox DireccionClienteTXT;
        private System.Windows.Forms.TextBox TelClienteTXT;
        private System.Windows.Forms.Button AgregarClienteBTN;
        private System.Windows.Forms.Button ModificarClienteBTN;
        private System.Windows.Forms.Button SalirBTN;
        private System.Windows.Forms.Label NombreClienteLB;
        private System.Windows.Forms.Label DireccionLB;
        private System.Windows.Forms.Label TelefonoLB;
        private System.Windows.Forms.Button ImprimirClienteBTN;
        private System.Windows.Forms.DataGridView DgvClientes;
        private System.Windows.Forms.Button LimpiarBTN;
        private System.Windows.Forms.TextBox IDClienteTXT;
        private System.Windows.Forms.Label idcleitneLBL;
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