namespace PIAMAD
{
    partial class EliClientes
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
            this.eliminar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textEstadoCivil = new System.Windows.Forms.TextBox();
            this.fechaNac = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.textReferencia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.textRfc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textDomicilio = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.textBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(499, 224);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 23);
            this.eliminar.TabIndex = 57;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Estado civil*:";
            // 
            // textEstadoCivil
            // 
            this.textEstadoCivil.Location = new System.Drawing.Point(374, 168);
            this.textEstadoCivil.Name = "textEstadoCivil";
            this.textEstadoCivil.ReadOnly = true;
            this.textEstadoCivil.Size = new System.Drawing.Size(200, 20);
            this.textEstadoCivil.TabIndex = 55;
            // 
            // fechaNac
            // 
            this.fechaNac.Enabled = false;
            this.fechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaNac.Location = new System.Drawing.Point(374, 196);
            this.fechaNac.Name = "fechaNac";
            this.fechaNac.Size = new System.Drawing.Size(200, 20);
            this.fechaNac.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(272, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Referencia conoc.*:";
            // 
            // textReferencia
            // 
            this.textReferencia.Location = new System.Drawing.Point(374, 142);
            this.textReferencia.Name = "textReferencia";
            this.textReferencia.ReadOnly = true;
            this.textReferencia.Size = new System.Drawing.Size(200, 20);
            this.textReferencia.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Teléfono celular*:";
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(374, 116);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.ReadOnly = true;
            this.textTelefono.Size = new System.Drawing.Size(200, 20);
            this.textTelefono.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Fecha nacimiento*:";
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(374, 90);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.ReadOnly = true;
            this.textCorreo.Size = new System.Drawing.Size(200, 20);
            this.textCorreo.TabIndex = 48;
            // 
            // textRfc
            // 
            this.textRfc.Location = new System.Drawing.Point(374, 64);
            this.textRfc.Name = "textRfc";
            this.textRfc.ReadOnly = true;
            this.textRfc.Size = new System.Drawing.Size(200, 20);
            this.textRfc.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Correo electrónico*:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "RFC*:";
            // 
            // textDomicilio
            // 
            this.textDomicilio.Location = new System.Drawing.Point(374, 38);
            this.textDomicilio.Name = "textDomicilio";
            this.textDomicilio.ReadOnly = true;
            this.textDomicilio.Size = new System.Drawing.Size(200, 20);
            this.textDomicilio.TabIndex = 44;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(374, 12);
            this.textNombre.Name = "textNombre";
            this.textNombre.ReadOnly = true;
            this.textNombre.Size = new System.Drawing.Size(200, 20);
            this.textNombre.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Domicilio completo*:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nombre completo*:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 171);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 59;
            this.label9.Text = "Buscar por RFC:";
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(117, 12);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(129, 20);
            this.textBuscar.TabIndex = 58;
            this.textBuscar.TextChanged += new System.EventHandler(this.textBuscar_TextChanged);
            // 
            // EliClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 261);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textEstadoCivil);
            this.Controls.Add(this.fechaNac);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textReferencia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textCorreo);
            this.Controls.Add(this.textRfc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textDomicilio);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EliClientes";
            this.Text = "Eliminar Clientes";
            this.Load += new System.EventHandler(this.EliClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textEstadoCivil;
        private System.Windows.Forms.DateTimePicker fechaNac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textReferencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.TextBox textRfc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textDomicilio;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBuscar;
    }
}