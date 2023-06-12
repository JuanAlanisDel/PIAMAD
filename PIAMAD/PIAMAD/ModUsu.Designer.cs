namespace PIAMAD
{
    partial class ModUsu
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
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboRol = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fechaNac = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textDomicilio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.modificar = new System.Windows.Forms.Button();
            this.comboEstatus = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNomina = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(124, 22);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(129, 20);
            this.textBuscar.TabIndex = 0;
            this.textBuscar.TextChanged += new System.EventHandler(this.textBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar por nómina:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 171);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboRol
            // 
            this.comboRol.DisplayMember = "Administrador";
            this.comboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRol.FormattingEnabled = true;
            this.comboRol.Items.AddRange(new object[] {
            "Administrador",
            "Operativo"});
            this.comboRol.Location = new System.Drawing.Point(382, 178);
            this.comboRol.Name = "comboRol";
            this.comboRol.Size = new System.Drawing.Size(200, 21);
            this.comboRol.TabIndex = 40;
            this.comboRol.ValueMember = "Administrador";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Rol*:";
            // 
            // fechaNac
            // 
            this.fechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaNac.Location = new System.Drawing.Point(382, 232);
            this.fechaNac.MaxDate = new System.DateTime(2023, 6, 12, 0, 0, 0, 0);
            this.fechaNac.MinDate = new System.DateTime(1923, 1, 1, 0, 0, 0, 0);
            this.fechaNac.Name = "fechaNac";
            this.fechaNac.Size = new System.Drawing.Size(200, 20);
            this.fechaNac.TabIndex = 38;
            this.fechaNac.Value = new System.DateTime(2023, 6, 11, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Teléfono celular*:";
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(382, 152);
            this.textTelefono.MaxLength = 10;
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(200, 20);
            this.textTelefono.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Domicilio*:";
            // 
            // textDomicilio
            // 
            this.textDomicilio.Location = new System.Drawing.Point(382, 126);
            this.textDomicilio.Name = "textDomicilio";
            this.textDomicilio.Size = new System.Drawing.Size(200, 20);
            this.textDomicilio.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Fecha nacimiento*:";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(382, 74);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(200, 20);
            this.textNombre.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Nombre completo*:";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(382, 48);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(200, 20);
            this.textPassword.TabIndex = 28;
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(382, 22);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(200, 20);
            this.textCorreo.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Contraseña*:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(281, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Correo electrónico*:";
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(507, 258);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(75, 23);
            this.modificar.TabIndex = 41;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // comboEstatus
            // 
            this.comboEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstatus.FormattingEnabled = true;
            this.comboEstatus.Items.AddRange(new object[] {
            "Bloqueado",
            "Desbloqueado"});
            this.comboEstatus.Location = new System.Drawing.Point(382, 205);
            this.comboEstatus.Name = "comboEstatus";
            this.comboEstatus.Size = new System.Drawing.Size(200, 21);
            this.comboEstatus.TabIndex = 43;
            this.comboEstatus.ValueMember = "Administrador";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(280, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "No. de Nómina*:";
            // 
            // textNomina
            // 
            this.textNomina.Location = new System.Drawing.Point(382, 100);
            this.textNomina.MaxLength = 5;
            this.textNomina.Name = "textNomina";
            this.textNomina.ReadOnly = true;
            this.textNomina.Size = new System.Drawing.Size(200, 20);
            this.textNomina.TabIndex = 32;
            // 
            // ModUsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 296);
            this.Controls.Add(this.comboEstatus);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.comboRol);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.fechaNac);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textDomicilio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textNomina);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textCorreo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBuscar);
            this.Name = "ModUsu";
            this.Text = "ModUsu";
            this.Load += new System.EventHandler(this.ModUsu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboRol;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker fechaNac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textDomicilio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.ComboBox comboEstatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNomina;
    }
}