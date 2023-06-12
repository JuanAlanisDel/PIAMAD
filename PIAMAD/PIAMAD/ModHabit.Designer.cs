namespace PIAMAD
{
    partial class ModHabit
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
            this.textAmen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.noCamas = new System.Windows.Forms.NumericUpDown();
            this.cantPer = new System.Windows.Forms.NumericUpDown();
            this.preNocPer = new System.Windows.Forms.NumericUpDown();
            this.comboTipos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.modificar = new System.Windows.Forms.Button();
            this.comboNivel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textCarac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noCamas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantPer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preNocPer)).BeginInit();
            this.SuspendLayout();
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(70, 220);
            this.textId.Name = "textId";
            this.textId.ReadOnly = true;
            this.textId.Size = new System.Drawing.Size(182, 20);
            this.textId.TabIndex = 107;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 106;
            this.label10.Text = "ID*:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 171);
            this.dataGridView1.TabIndex = 105;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 104;
            this.label9.Text = "Buscar por ID:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(118, 14);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(129, 20);
            this.textBuscar.TabIndex = 103;
            this.textBuscar.TextChanged += new System.EventHandler(this.textBuscar_TextChanged);
            // 
            // textAmen
            // 
            this.textAmen.Location = new System.Drawing.Point(427, 70);
            this.textAmen.Name = "textAmen";
            this.textAmen.Size = new System.Drawing.Size(200, 20);
            this.textAmen.TabIndex = 102;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 101;
            this.label7.Text = "Amenidades:";
            // 
            // noCamas
            // 
            this.noCamas.Location = new System.Drawing.Point(429, 97);
            this.noCamas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.noCamas.Name = "noCamas";
            this.noCamas.Size = new System.Drawing.Size(199, 20);
            this.noCamas.TabIndex = 100;
            // 
            // cantPer
            // 
            this.cantPer.Location = new System.Drawing.Point(429, 178);
            this.cantPer.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.cantPer.Name = "cantPer";
            this.cantPer.Size = new System.Drawing.Size(199, 20);
            this.cantPer.TabIndex = 99;
            // 
            // preNocPer
            // 
            this.preNocPer.DecimalPlaces = 2;
            this.preNocPer.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.preNocPer.Location = new System.Drawing.Point(429, 152);
            this.preNocPer.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.preNocPer.Name = "preNocPer";
            this.preNocPer.Size = new System.Drawing.Size(199, 20);
            this.preNocPer.TabIndex = 98;
            // 
            // comboTipos
            // 
            this.comboTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipos.FormattingEnabled = true;
            this.comboTipos.Items.AddRange(new object[] {
            "Individual",
            "Matrimonial",
            "Queen Size",
            "King Size"});
            this.comboTipos.Location = new System.Drawing.Point(429, 124);
            this.comboTipos.Name = "comboTipos";
            this.comboTipos.Size = new System.Drawing.Size(199, 21);
            this.comboTipos.TabIndex = 97;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 96;
            this.label5.Text = "Tipos de camas*:";
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(553, 225);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(75, 23);
            this.modificar.TabIndex = 95;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // comboNivel
            // 
            this.comboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNivel.FormattingEnabled = true;
            this.comboNivel.Items.AddRange(new object[] {
            "Estándar",
            "De lujo",
            "Suite"});
            this.comboNivel.Location = new System.Drawing.Point(429, 15);
            this.comboNivel.Name = "comboNivel";
            this.comboNivel.Size = new System.Drawing.Size(199, 21);
            this.comboNivel.TabIndex = 94;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 93;
            this.label6.Text = "Cant. máx. personas*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 92;
            this.label3.Text = "Precio por noche por persona:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 91;
            this.label4.Text = "No. de camas*:";
            // 
            // textCarac
            // 
            this.textCarac.Location = new System.Drawing.Point(428, 42);
            this.textCarac.Name = "textCarac";
            this.textCarac.Size = new System.Drawing.Size(200, 20);
            this.textCarac.TabIndex = 90;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 89;
            this.label2.Text = "Características:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 88;
            this.label1.Text = "Nivel*:";
            // 
            // ModHabit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 259);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.textAmen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.noCamas);
            this.Controls.Add(this.cantPer);
            this.Controls.Add(this.preNocPer);
            this.Controls.Add(this.comboTipos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.comboNivel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textCarac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModHabit";
            this.Text = "Modificar Habitación";
            this.Load += new System.EventHandler(this.ModHabit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noCamas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantPer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preNocPer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.TextBox textAmen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown noCamas;
        private System.Windows.Forms.NumericUpDown cantPer;
        private System.Windows.Forms.NumericUpDown preNocPer;
        private System.Windows.Forms.ComboBox comboTipos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.ComboBox comboNivel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textCarac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}