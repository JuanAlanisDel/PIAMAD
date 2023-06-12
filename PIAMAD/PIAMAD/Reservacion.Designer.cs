namespace PIAMAD
{
    partial class Reservacion
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.textBuscar2 = new System.Windows.Forms.TextBox();
            this.anticipoRes = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.comboPago = new System.Windows.Forms.ComboBox();
            this.cantHabTipo = new System.Windows.Forms.NumericUpDown();
            this.cantPerHosp = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.textId2 = new System.Windows.Forms.TextBox();
            this.textId3 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anticipoRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantHabTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantPerHosp)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(460, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 20);
            this.dateTimePicker1.TabIndex = 54;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Inicio hospedaje*:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Ciudad a visitar*:";
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(110, 13);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(201, 20);
            this.textBuscar.TabIndex = 43;
            this.textBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Cliente a buscar*:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(460, 39);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(207, 20);
            this.dateTimePicker2.TabIndex = 66;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(333, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 67;
            this.label11.Text = "Final hospedaje*:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(19, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 133);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes con el mismo nombre";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(286, 108);
            this.dataGridView1.TabIndex = 69;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(19, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 131);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hoteles ubicados en la ciudad";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(286, 108);
            this.dataGridView2.TabIndex = 70;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Cant. habit. por tipo*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "Cant. pers. a hospedar*:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 77;
            this.label6.Text = "Anticipo*:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView3);
            this.groupBox3.Location = new System.Drawing.Point(350, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 119);
            this.groupBox3.TabIndex = 79;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Habitaciones disponibles";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 17);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(286, 96);
            this.dataGridView3.TabIndex = 71;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(427, 305);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 23);
            this.button4.TabIndex = 84;
            this.button4.Text = "Hacer reservación";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBuscar2
            // 
            this.textBuscar2.Location = new System.Drawing.Point(110, 174);
            this.textBuscar2.Name = "textBuscar2";
            this.textBuscar2.Size = new System.Drawing.Size(201, 20);
            this.textBuscar2.TabIndex = 85;
            this.textBuscar2.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // anticipoRes
            // 
            this.anticipoRes.DecimalPlaces = 2;
            this.anticipoRes.Location = new System.Drawing.Point(460, 246);
            this.anticipoRes.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.anticipoRes.Name = "anticipoRes";
            this.anticipoRes.Size = new System.Drawing.Size(207, 20);
            this.anticipoRes.TabIndex = 86;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 87;
            this.label7.Text = "Método de pago*:";
            // 
            // comboPago
            // 
            this.comboPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPago.FormattingEnabled = true;
            this.comboPago.Items.AddRange(new object[] {
            "Crédito",
            "Débito",
            "Cheque",
            "Efectivo"});
            this.comboPago.Location = new System.Drawing.Point(460, 272);
            this.comboPago.Name = "comboPago";
            this.comboPago.Size = new System.Drawing.Size(206, 21);
            this.comboPago.TabIndex = 88;
            // 
            // cantHabTipo
            // 
            this.cantHabTipo.Location = new System.Drawing.Point(459, 194);
            this.cantHabTipo.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.cantHabTipo.Name = "cantHabTipo";
            this.cantHabTipo.Size = new System.Drawing.Size(207, 20);
            this.cantHabTipo.TabIndex = 89;
            // 
            // cantPerHosp
            // 
            this.cantPerHosp.Location = new System.Drawing.Point(459, 220);
            this.cantPerHosp.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.cantPerHosp.Name = "cantPerHosp";
            this.cantPerHosp.Size = new System.Drawing.Size(207, 20);
            this.cantPerHosp.TabIndex = 90;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 91;
            this.label8.Text = "RFC:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(213, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 92;
            this.label9.Text = "ID de Hotel:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(436, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 93;
            this.label10.Text = "ID de Habitación:";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(55, 341);
            this.textId.Name = "textId";
            this.textId.ReadOnly = true;
            this.textId.Size = new System.Drawing.Size(134, 20);
            this.textId.TabIndex = 94;
            // 
            // textId2
            // 
            this.textId2.Location = new System.Drawing.Point(281, 341);
            this.textId2.Name = "textId2";
            this.textId2.ReadOnly = true;
            this.textId2.Size = new System.Drawing.Size(134, 20);
            this.textId2.TabIndex = 95;
            // 
            // textId3
            // 
            this.textId3.Location = new System.Drawing.Point(532, 341);
            this.textId3.Name = "textId3";
            this.textId3.ReadOnly = true;
            this.textId3.Size = new System.Drawing.Size(134, 20);
            this.textId3.TabIndex = 96;
            // 
            // Reservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 375);
            this.Controls.Add(this.textId3);
            this.Controls.Add(this.textId2);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cantPerHosp);
            this.Controls.Add(this.cantHabTipo);
            this.Controls.Add(this.comboPago);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.anticipoRes);
            this.Controls.Add(this.textBuscar2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.label1);
            this.Name = "Reservacion";
            this.Text = "Reservaciones";
            this.Load += new System.EventHandler(this.Reservacion_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anticipoRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantHabTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantPerHosp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox textBuscar2;
        private System.Windows.Forms.NumericUpDown anticipoRes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboPago;
        private System.Windows.Forms.NumericUpDown cantHabTipo;
        private System.Windows.Forms.NumericUpDown cantPerHosp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textId2;
        private System.Windows.Forms.TextBox textId3;
    }
}