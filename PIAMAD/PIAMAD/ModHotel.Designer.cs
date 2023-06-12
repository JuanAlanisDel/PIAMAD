namespace PIAMAD
{
    partial class ModHotel
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
            this.modificar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textZonaTur = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.inioper = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textDomicilio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textPais = new System.Windows.Forms.TextBox();
            this.textEstado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textCiudad = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.cantHab = new System.Windows.Forms.NumericUpDown();
            this.noPisos = new System.Windows.Forms.NumericUpDown();
            this.textId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantHab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noPisos)).BeginInit();
            this.SuspendLayout();
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(514, 302);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(75, 23);
            this.modificar.TabIndex = 75;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(285, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 42);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servicios adicionales";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(210, 19);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(84, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Restaurante";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(144, 19);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(60, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Masaje";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(69, 19);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(69, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Gimnasio";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Wi-Fi";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textZonaTur
            // 
            this.textZonaTur.Location = new System.Drawing.Point(389, 200);
            this.textZonaTur.Name = "textZonaTur";
            this.textZonaTur.Size = new System.Drawing.Size(200, 20);
            this.textZonaTur.TabIndex = 73;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(287, 203);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 72;
            this.label13.Text = "Zona turística*:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 71;
            this.label8.Text = "Cant. habitaciones*:";
            // 
            // inioper
            // 
            this.inioper.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inioper.Location = new System.Drawing.Point(389, 274);
            this.inioper.Name = "inioper";
            this.inioper.Size = new System.Drawing.Size(200, 20);
            this.inioper.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 68;
            this.label7.Text = "Número de pisos*:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Domicilio*:";
            // 
            // textDomicilio
            // 
            this.textDomicilio.Location = new System.Drawing.Point(389, 122);
            this.textDomicilio.Name = "textDomicilio";
            this.textDomicilio.Size = new System.Drawing.Size(200, 20);
            this.textDomicilio.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Inicio Operaciones*:";
            // 
            // textPais
            // 
            this.textPais.Location = new System.Drawing.Point(389, 96);
            this.textPais.Name = "textPais";
            this.textPais.Size = new System.Drawing.Size(200, 20);
            this.textPais.TabIndex = 63;
            // 
            // textEstado
            // 
            this.textEstado.Location = new System.Drawing.Point(389, 70);
            this.textEstado.Name = "textEstado";
            this.textEstado.Size = new System.Drawing.Size(200, 20);
            this.textEstado.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "País*:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Estado*:";
            // 
            // textCiudad
            // 
            this.textCiudad.Location = new System.Drawing.Point(389, 44);
            this.textCiudad.Name = "textCiudad";
            this.textCiudad.Size = new System.Drawing.Size(200, 20);
            this.textCiudad.TabIndex = 59;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(389, 18);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(200, 20);
            this.textNombre.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Ciudad*:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Nombre*:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 171);
            this.dataGridView1.TabIndex = 78;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 77;
            this.label9.Text = "Buscar por nombre:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(127, 18);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(129, 20);
            this.textBuscar.TabIndex = 76;
            this.textBuscar.TextChanged += new System.EventHandler(this.textBuscar_TextChanged);
            // 
            // cantHab
            // 
            this.cantHab.Location = new System.Drawing.Point(389, 174);
            this.cantHab.Name = "cantHab";
            this.cantHab.Size = new System.Drawing.Size(200, 20);
            this.cantHab.TabIndex = 80;
            // 
            // noPisos
            // 
            this.noPisos.Location = new System.Drawing.Point(389, 148);
            this.noPisos.Name = "noPisos";
            this.noPisos.Size = new System.Drawing.Size(200, 20);
            this.noPisos.TabIndex = 79;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(79, 224);
            this.textId.Name = "textId";
            this.textId.ReadOnly = true;
            this.textId.Size = new System.Drawing.Size(182, 20);
            this.textId.TabIndex = 82;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 81;
            this.label10.Text = "ID*:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // ModHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 338);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cantHab);
            this.Controls.Add(this.noPisos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textZonaTur);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.inioper);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textDomicilio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textPais);
            this.Controls.Add(this.textEstado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textCiudad);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModHotel";
            this.Text = "ModHotel";
            this.Load += new System.EventHandler(this.ModHotel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantHab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noPisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textZonaTur;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker inioper;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textDomicilio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPais;
        private System.Windows.Forms.TextBox textEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textCiudad;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.NumericUpDown cantHab;
        private System.Windows.Forms.NumericUpDown noPisos;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label10;
    }
}