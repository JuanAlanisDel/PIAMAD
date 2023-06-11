using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;
using Capa_Entidad;
using System.Security.Permissions;

namespace PIAMAD
{
    partial class RegUsu
    {

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
            this.registrar = new System.Windows.Forms.Button();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textNomina = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textDomicilio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fechaNac = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.comboRol = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // registrar
            // 
            this.registrar.Location = new System.Drawing.Point(245, 226);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(75, 23);
            this.registrar.TabIndex = 11;
            this.registrar.Text = "Registrar";
            this.registrar.UseVisualStyleBackColor = true;
            this.registrar.Click += new System.EventHandler(this.registrar_Click_1);
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(116, 42);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(200, 20);
            this.textPassword.TabIndex = 10;
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(116, 16);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(200, 20);
            this.textCorreo.TabIndex = 9;
            this.textCorreo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contraseña*:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Correo electrónico*:";
            // 
            // textNomina
            // 
            this.textNomina.Location = new System.Drawing.Point(116, 94);
            this.textNomina.MaxLength = 5;
            this.textNomina.Name = "textNomina";
            this.textNomina.Size = new System.Drawing.Size(200, 20);
            this.textNomina.TabIndex = 15;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(116, 68);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(200, 20);
            this.textNombre.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "No. de Nómina*:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nombre completo*:";
            // 
            // textDomicilio
            // 
            this.textDomicilio.Location = new System.Drawing.Point(116, 120);
            this.textDomicilio.Name = "textDomicilio";
            this.textDomicilio.Size = new System.Drawing.Size(200, 20);
            this.textDomicilio.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Fecha nacimiento*:";
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(116, 146);
            this.textTelefono.MaxLength = 10;
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(200, 20);
            this.textTelefono.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Domicilio*:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Teléfono celular*:";
            // 
            // fechaNac
            // 
            this.fechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaNac.Location = new System.Drawing.Point(116, 200);
            this.fechaNac.MaxDate = new System.DateTime(2023, 6, 11, 0, 0, 0, 0);
            this.fechaNac.MinDate = new System.DateTime(1923, 1, 1, 0, 0, 0, 0);
            this.fechaNac.Name = "fechaNac";
            this.fechaNac.Size = new System.Drawing.Size(200, 20);
            this.fechaNac.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Rol*:";
            // 
            // comboRol
            // 
            this.comboRol.DisplayMember = "Administrador";
            this.comboRol.FormattingEnabled = true;
            this.comboRol.Items.AddRange(new object[] {
            "Administrador",
            "Operativo"});
            this.comboRol.Location = new System.Drawing.Point(116, 172);
            this.comboRol.Name = "comboRol";
            this.comboRol.Size = new System.Drawing.Size(200, 21);
            this.comboRol.TabIndex = 24;
            this.comboRol.ValueMember = "Administrador";
            this.comboRol.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // RegUsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 258);
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
            this.Controls.Add(this.registrar);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textCorreo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegUsu";
            this.Text = "Registro de Usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registrar;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNomina;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textDomicilio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker fechaNac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboRol;
    }
}