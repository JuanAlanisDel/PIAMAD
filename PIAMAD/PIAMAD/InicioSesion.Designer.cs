namespace PIAMAD
{
    partial class InicioSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.registrar = new System.Windows.Forms.Button();
            this.ingresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correo*:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña*:";
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(85, 81);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(159, 20);
            this.textCorreo.TabIndex = 2;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(85, 107);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(159, 20);
            this.textPassword.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "¡Bienvenido!";
            // 
            // registrar
            // 
            this.registrar.Location = new System.Drawing.Point(15, 158);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(75, 23);
            this.registrar.TabIndex = 5;
            this.registrar.Text = "Registrar";
            this.registrar.UseVisualStyleBackColor = true;
            this.registrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // ingresar
            // 
            this.ingresar.Location = new System.Drawing.Point(169, 158);
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(75, 23);
            this.ingresar.TabIndex = 6;
            this.ingresar.Text = "Ingresar";
            this.ingresar.UseVisualStyleBackColor = true;
            this.ingresar.Click += new System.EventHandler(this.ingresar_Click_1);
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 203);
            this.Controls.Add(this.ingresar);
            this.Controls.Add(this.registrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textCorreo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InicioSesion";
            this.Text = "Inicio Sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registrar;
        private System.Windows.Forms.Button ingresar;
    }
}

