namespace PIAMAD
{
    partial class Principal
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
            this.registrarHotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarHotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarHotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hotelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hotelToolStripMenuItem
            // 
            this.hotelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarHotelToolStripMenuItem,
            this.modificarHotelToolStripMenuItem,
            this.eliminarHotelToolStripMenuItem});
            this.hotelToolStripMenuItem.Name = "hotelToolStripMenuItem";
            this.hotelToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.hotelToolStripMenuItem.Text = "Hotel";
            // 
            // registrarHotelToolStripMenuItem
            // 
            this.registrarHotelToolStripMenuItem.Name = "registrarHotelToolStripMenuItem";
            this.registrarHotelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarHotelToolStripMenuItem.Text = "Registrar hotel";
            // 
            // modificarHotelToolStripMenuItem
            // 
            this.modificarHotelToolStripMenuItem.Name = "modificarHotelToolStripMenuItem";
            this.modificarHotelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarHotelToolStripMenuItem.Text = "Modificar hotel";
            // 
            // eliminarHotelToolStripMenuItem
            // 
            this.eliminarHotelToolStripMenuItem.Name = "eliminarHotelToolStripMenuItem";
            this.eliminarHotelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarHotelToolStripMenuItem.Text = "Eliminar hotel";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Principal";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hotelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarHotelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarHotelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarHotelToolStripMenuItem;
    }
}