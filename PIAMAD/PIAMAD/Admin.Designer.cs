namespace PIAMAD
{
    partial class Admin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarHotel = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarHotel = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarHotel = new System.Windows.Forms.ToolStripMenuItem();
            this.habitaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarHabit = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarHabit = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarHabit = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarReserv = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desbloquearUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hotelToolStripMenuItem,
            this.habitaciónToolStripMenuItem,
            this.reservaciónToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(361, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hotelToolStripMenuItem
            // 
            this.hotelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarHotel,
            this.modificarHotel,
            this.eliminarHotel});
            this.hotelToolStripMenuItem.Name = "hotelToolStripMenuItem";
            this.hotelToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.hotelToolStripMenuItem.Text = "Hotel";
            // 
            // registrarHotel
            // 
            this.registrarHotel.Name = "registrarHotel";
            this.registrarHotel.Size = new System.Drawing.Size(155, 22);
            this.registrarHotel.Text = "Registrar hotel";
            this.registrarHotel.Click += new System.EventHandler(this.registrarHotel_Click);
            // 
            // modificarHotel
            // 
            this.modificarHotel.Name = "modificarHotel";
            this.modificarHotel.Size = new System.Drawing.Size(155, 22);
            this.modificarHotel.Text = "Modificar hotel";
            this.modificarHotel.Click += new System.EventHandler(this.modificarHotel_Click);
            // 
            // eliminarHotel
            // 
            this.eliminarHotel.Name = "eliminarHotel";
            this.eliminarHotel.Size = new System.Drawing.Size(155, 22);
            this.eliminarHotel.Text = "Eliminar hotel";
            this.eliminarHotel.Click += new System.EventHandler(this.eliminarHotel_Click);
            // 
            // habitaciónToolStripMenuItem
            // 
            this.habitaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarHabit,
            this.modificarHabit,
            this.eliminarHabit});
            this.habitaciónToolStripMenuItem.Name = "habitaciónToolStripMenuItem";
            this.habitaciónToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.habitaciónToolStripMenuItem.Text = "Habitación";
            // 
            // registrarHabit
            // 
            this.registrarHabit.Name = "registrarHabit";
            this.registrarHabit.Size = new System.Drawing.Size(158, 22);
            this.registrarHabit.Text = "Registrar habit.";
            this.registrarHabit.Click += new System.EventHandler(this.registrarHabit_Click);
            // 
            // modificarHabit
            // 
            this.modificarHabit.Name = "modificarHabit";
            this.modificarHabit.Size = new System.Drawing.Size(158, 22);
            this.modificarHabit.Text = "Modificar habit.";
            this.modificarHabit.Click += new System.EventHandler(this.modificarHabit_Click);
            // 
            // eliminarHabit
            // 
            this.eliminarHabit.Name = "eliminarHabit";
            this.eliminarHabit.Size = new System.Drawing.Size(158, 22);
            this.eliminarHabit.Text = "Eliminar habit.";
            this.eliminarHabit.Click += new System.EventHandler(this.eliminarHabit_Click);
            // 
            // reservaciónToolStripMenuItem
            // 
            this.reservaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelarReserv});
            this.reservaciónToolStripMenuItem.Name = "reservaciónToolStripMenuItem";
            this.reservaciónToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.reservaciónToolStripMenuItem.Text = "Reservación";
            // 
            // cancelarReserv
            // 
            this.cancelarReserv.Name = "cancelarReserv";
            this.cancelarReserv.Size = new System.Drawing.Size(157, 22);
            this.cancelarReserv.Text = "Cancelar reserv.";
            this.cancelarReserv.Click += new System.EventHandler(this.cancelarReserv_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desbloquearUsuario,
            this.modificarUsuarioToolStripMenuItem,
            this.eliminarUsuarioToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // desbloquearUsuario
            // 
            this.desbloquearUsuario.Name = "desbloquearUsuario";
            this.desbloquearUsuario.Size = new System.Drawing.Size(182, 22);
            this.desbloquearUsuario.Text = "Desbloquear usuario";
            this.desbloquearUsuario.Click += new System.EventHandler(this.desbloquearUsuario_Click);
            // 
            // modificarUsuarioToolStripMenuItem
            // 
            this.modificarUsuarioToolStripMenuItem.Name = "modificarUsuarioToolStripMenuItem";
            this.modificarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.modificarUsuarioToolStripMenuItem.Text = "Modificar usuario";
            this.modificarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.modificarUsuarioToolStripMenuItem_Click);
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            this.eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            this.eliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.eliminarUsuarioToolStripMenuItem.Text = "Eliminar usuario";
            this.eliminarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.eliminarUsuarioToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elija una opción del menú";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 139);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Admin";
            this.Text = "Administrador";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hotelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarHotel;
        private System.Windows.Forms.ToolStripMenuItem modificarHotel;
        private System.Windows.Forms.ToolStripMenuItem eliminarHotel;
        private System.Windows.Forms.ToolStripMenuItem habitaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarHabit;
        private System.Windows.Forms.ToolStripMenuItem modificarHabit;
        private System.Windows.Forms.ToolStripMenuItem eliminarHabit;
        private System.Windows.Forms.ToolStripMenuItem reservaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarReserv;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desbloquearUsuario;
        private System.Windows.Forms.ToolStripMenuItem modificarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}