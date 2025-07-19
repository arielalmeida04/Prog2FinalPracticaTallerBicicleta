namespace Prog2FinalPracticaTallerBicicleta
{
    partial class Form1
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
            this.bttCrearCliente = new System.Windows.Forms.Button();
            this.lbServicios = new System.Windows.Forms.ListBox();
            this.txbExtra = new System.Windows.Forms.TextBox();
            this.txbHoras = new System.Windows.Forms.TextBox();
            this.cbFeriado = new System.Windows.Forms.CheckBox();
            this.rbReparacion = new System.Windows.Forms.RadioButton();
            this.rbMantenimiento = new System.Windows.Forms.RadioButton();
            this.bttAgregarServicio = new System.Windows.Forms.Button();
            this.bttQuitarServicio = new System.Windows.Forms.Button();
            this.bttPrecioFinal = new System.Windows.Forms.Button();
            this.bttImporarServicios = new System.Windows.Forms.Button();
            this.bttExportarTickets = new System.Windows.Forms.Button();
            this.txbNroCodigo = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bttCrearCliente
            // 
            this.bttCrearCliente.Location = new System.Drawing.Point(31, 45);
            this.bttCrearCliente.Name = "bttCrearCliente";
            this.bttCrearCliente.Size = new System.Drawing.Size(128, 43);
            this.bttCrearCliente.TabIndex = 2;
            this.bttCrearCliente.Text = "Crear Ticket";
            this.bttCrearCliente.UseVisualStyleBackColor = true;
            this.bttCrearCliente.Click += new System.EventHandler(this.bttCrearCliente_Click);
            // 
            // lbServicios
            // 
            this.lbServicios.FormattingEnabled = true;
            this.lbServicios.Location = new System.Drawing.Point(251, 116);
            this.lbServicios.Name = "lbServicios";
            this.lbServicios.Size = new System.Drawing.Size(269, 95);
            this.lbServicios.TabIndex = 3;
            // 
            // txbExtra
            // 
            this.txbExtra.Location = new System.Drawing.Point(353, 78);
            this.txbExtra.Name = "txbExtra";
            this.txbExtra.Size = new System.Drawing.Size(100, 20);
            this.txbExtra.TabIndex = 4;
            this.txbExtra.Text = "Extra";
            // 
            // txbHoras
            // 
            this.txbHoras.Location = new System.Drawing.Point(353, 45);
            this.txbHoras.Name = "txbHoras";
            this.txbHoras.Size = new System.Drawing.Size(100, 20);
            this.txbHoras.TabIndex = 5;
            this.txbHoras.Text = "Horas";
            // 
            // cbFeriado
            // 
            this.cbFeriado.AutoSize = true;
            this.cbFeriado.Location = new System.Drawing.Point(459, 82);
            this.cbFeriado.Name = "cbFeriado";
            this.cbFeriado.Size = new System.Drawing.Size(61, 17);
            this.cbFeriado.TabIndex = 6;
            this.cbFeriado.Text = "Feriado";
            this.cbFeriado.UseVisualStyleBackColor = true;
            // 
            // rbReparacion
            // 
            this.rbReparacion.AutoSize = true;
            this.rbReparacion.Location = new System.Drawing.Point(251, 45);
            this.rbReparacion.Name = "rbReparacion";
            this.rbReparacion.Size = new System.Drawing.Size(80, 17);
            this.rbReparacion.TabIndex = 7;
            this.rbReparacion.TabStop = true;
            this.rbReparacion.Text = "Reparacion";
            this.rbReparacion.UseVisualStyleBackColor = true;
            // 
            // rbMantenimiento
            // 
            this.rbMantenimiento.AutoSize = true;
            this.rbMantenimiento.Location = new System.Drawing.Point(251, 81);
            this.rbMantenimiento.Name = "rbMantenimiento";
            this.rbMantenimiento.Size = new System.Drawing.Size(94, 17);
            this.rbMantenimiento.TabIndex = 8;
            this.rbMantenimiento.TabStop = true;
            this.rbMantenimiento.Text = "Mantenimiento";
            this.rbMantenimiento.UseVisualStyleBackColor = true;
            // 
            // bttAgregarServicio
            // 
            this.bttAgregarServicio.Location = new System.Drawing.Point(31, 116);
            this.bttAgregarServicio.Name = "bttAgregarServicio";
            this.bttAgregarServicio.Size = new System.Drawing.Size(128, 43);
            this.bttAgregarServicio.TabIndex = 9;
            this.bttAgregarServicio.Text = "Agregar Servicio";
            this.bttAgregarServicio.UseVisualStyleBackColor = true;
            this.bttAgregarServicio.Click += new System.EventHandler(this.bttAgregarServicio_Click);
            // 
            // bttQuitarServicio
            // 
            this.bttQuitarServicio.Location = new System.Drawing.Point(31, 179);
            this.bttQuitarServicio.Name = "bttQuitarServicio";
            this.bttQuitarServicio.Size = new System.Drawing.Size(128, 43);
            this.bttQuitarServicio.TabIndex = 10;
            this.bttQuitarServicio.Text = "Quitar Servicio";
            this.bttQuitarServicio.UseVisualStyleBackColor = true;
            this.bttQuitarServicio.Click += new System.EventHandler(this.bttQuitarServicio_Click);
            // 
            // bttPrecioFinal
            // 
            this.bttPrecioFinal.Location = new System.Drawing.Point(31, 291);
            this.bttPrecioFinal.Name = "bttPrecioFinal";
            this.bttPrecioFinal.Size = new System.Drawing.Size(128, 43);
            this.bttPrecioFinal.TabIndex = 11;
            this.bttPrecioFinal.Text = "Precio Final";
            this.bttPrecioFinal.UseVisualStyleBackColor = true;
            this.bttPrecioFinal.Click += new System.EventHandler(this.bttPrecioFinal_Click);
            // 
            // bttImporarServicios
            // 
            this.bttImporarServicios.Location = new System.Drawing.Point(617, 43);
            this.bttImporarServicios.Name = "bttImporarServicios";
            this.bttImporarServicios.Size = new System.Drawing.Size(153, 71);
            this.bttImporarServicios.TabIndex = 12;
            this.bttImporarServicios.Text = "Imporar Servicios";
            this.bttImporarServicios.UseVisualStyleBackColor = true;
            this.bttImporarServicios.Click += new System.EventHandler(this.bttImporarServicios_Click);
            // 
            // bttExportarTickets
            // 
            this.bttExportarTickets.Location = new System.Drawing.Point(617, 140);
            this.bttExportarTickets.Name = "bttExportarTickets";
            this.bttExportarTickets.Size = new System.Drawing.Size(153, 71);
            this.bttExportarTickets.TabIndex = 13;
            this.bttExportarTickets.Text = "Exportar Tickets";
            this.bttExportarTickets.UseVisualStyleBackColor = true;
            this.bttExportarTickets.Click += new System.EventHandler(this.bttExportarTickets_Click);
            // 
            // txbNroCodigo
            // 
            this.txbNroCodigo.Location = new System.Drawing.Point(31, 228);
            this.txbNroCodigo.Name = "txbNroCodigo";
            this.txbNroCodigo.Size = new System.Drawing.Size(128, 20);
            this.txbNroCodigo.TabIndex = 14;
            this.txbNroCodigo.Text = "Nro Cod";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(579, 217);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(209, 199);
            this.listBox1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txbNroCodigo);
            this.Controls.Add(this.bttExportarTickets);
            this.Controls.Add(this.bttImporarServicios);
            this.Controls.Add(this.bttPrecioFinal);
            this.Controls.Add(this.bttQuitarServicio);
            this.Controls.Add(this.bttAgregarServicio);
            this.Controls.Add(this.rbMantenimiento);
            this.Controls.Add(this.rbReparacion);
            this.Controls.Add(this.cbFeriado);
            this.Controls.Add(this.txbHoras);
            this.Controls.Add(this.txbExtra);
            this.Controls.Add(this.lbServicios);
            this.Controls.Add(this.bttCrearCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttCrearCliente;
        private System.Windows.Forms.ListBox lbServicios;
        private System.Windows.Forms.TextBox txbExtra;
        private System.Windows.Forms.TextBox txbHoras;
        private System.Windows.Forms.CheckBox cbFeriado;
        private System.Windows.Forms.RadioButton rbReparacion;
        private System.Windows.Forms.RadioButton rbMantenimiento;
        private System.Windows.Forms.Button bttAgregarServicio;
        private System.Windows.Forms.Button bttQuitarServicio;
        private System.Windows.Forms.Button bttPrecioFinal;
        private System.Windows.Forms.Button bttImporarServicios;
        private System.Windows.Forms.Button bttExportarTickets;
        private System.Windows.Forms.TextBox txbNroCodigo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

