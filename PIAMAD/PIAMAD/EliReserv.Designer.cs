namespace PIAMAD
{
    partial class EliReserv
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
            this.textId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.cantPerHosp = new System.Windows.Forms.NumericUpDown();
            this.cantHabTipo = new System.Windows.Forms.NumericUpDown();
            this.comboPago = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.anticipoRes = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textId3 = new System.Windows.Forms.TextBox();
            this.textId2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantPerHosp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantHabTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anticipoRes)).BeginInit();
            this.SuspendLayout();
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(71, 220);
            this.textId.Name = "textId";
            this.textId.ReadOnly = true;
            this.textId.Size = new System.Drawing.Size(182, 20);
            this.textId.TabIndex = 110;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 109;
            this.label10.Text = "Código*:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 171);
            this.dataGridView1.TabIndex = 108;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 107;
            this.label9.Text = "Buscar por RFC:";
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(118, 12);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(129, 20);
            this.textBuscar.TabIndex = 106;
            this.textBuscar.TextChanged += new System.EventHandler(this.textBuscar_TextChanged);
            // 
            // cantPerHosp
            // 
            this.cantPerHosp.Location = new System.Drawing.Point(391, 90);
            this.cantPerHosp.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.cantPerHosp.Name = "cantPerHosp";
            this.cantPerHosp.ReadOnly = true;
            this.cantPerHosp.Size = new System.Drawing.Size(207, 20);
            this.cantPerHosp.TabIndex = 122;
            // 
            // cantHabTipo
            // 
            this.cantHabTipo.Location = new System.Drawing.Point(391, 64);
            this.cantHabTipo.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.cantHabTipo.Name = "cantHabTipo";
            this.cantHabTipo.ReadOnly = true;
            this.cantHabTipo.Size = new System.Drawing.Size(207, 20);
            this.cantHabTipo.TabIndex = 121;
            // 
            // comboPago
            // 
            this.comboPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPago.Enabled = false;
            this.comboPago.FormattingEnabled = true;
            this.comboPago.Items.AddRange(new object[] {
            "Crédito",
            "Débito",
            "Cheque",
            "Efectivo"});
            this.comboPago.Location = new System.Drawing.Point(392, 142);
            this.comboPago.Name = "comboPago";
            this.comboPago.Size = new System.Drawing.Size(206, 21);
            this.comboPago.TabIndex = 120;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 119;
            this.label7.Text = "Método de pago*:";
            // 
            // anticipoRes
            // 
            this.anticipoRes.DecimalPlaces = 2;
            this.anticipoRes.Location = new System.Drawing.Point(392, 116);
            this.anticipoRes.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.anticipoRes.Name = "anticipoRes";
            this.anticipoRes.ReadOnly = true;
            this.anticipoRes.Size = new System.Drawing.Size(207, 20);
            this.anticipoRes.TabIndex = 118;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 117;
            this.label6.Text = "Anticipo*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 116;
            this.label3.Text = "Cant. pers. a hospedar*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 115;
            this.label2.Text = "Cant. habit. por tipo*:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(264, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 114;
            this.label11.Text = "Final hospedaje*:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(391, 38);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(207, 20);
            this.dateTimePicker2.TabIndex = 113;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(391, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 20);
            this.dateTimePicker1.TabIndex = 112;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 111;
            this.label5.Text = "Inicio hospedaje*:";
            // 
            // textId3
            // 
            this.textId3.Location = new System.Drawing.Point(392, 221);
            this.textId3.Name = "textId3";
            this.textId3.ReadOnly = true;
            this.textId3.Size = new System.Drawing.Size(206, 20);
            this.textId3.TabIndex = 128;
            // 
            // textId2
            // 
            this.textId2.Location = new System.Drawing.Point(392, 195);
            this.textId2.Name = "textId2";
            this.textId2.ReadOnly = true;
            this.textId2.Size = new System.Drawing.Size(206, 20);
            this.textId2.TabIndex = 127;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(392, 169);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(207, 20);
            this.textBox1.TabIndex = 126;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 125;
            this.label1.Text = "ID de Habitación:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 124;
            this.label4.Text = "ID de Hotel:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(265, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 123;
            this.label8.Text = "RFC:";
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(524, 247);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 129;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // EliReserv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 280);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.textId3);
            this.Controls.Add(this.textId2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cantPerHosp);
            this.Controls.Add(this.cantHabTipo);
            this.Controls.Add(this.comboPago);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.anticipoRes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBuscar);
            this.Name = "EliReserv";
            this.Text = "Eliminar Reservacion";
            this.Load += new System.EventHandler(this.EliReserv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantPerHosp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantHabTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anticipoRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.NumericUpDown cantPerHosp;
        private System.Windows.Forms.NumericUpDown cantHabTipo;
        private System.Windows.Forms.ComboBox comboPago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown anticipoRes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textId3;
        private System.Windows.Forms.TextBox textId2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cancelar;
    }
}