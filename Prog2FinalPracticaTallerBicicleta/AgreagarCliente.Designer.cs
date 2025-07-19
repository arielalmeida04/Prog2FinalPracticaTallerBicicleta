namespace Prog2FinalPracticaTallerBicicleta
{
    partial class AgreagarCliente
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
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbCuit = new System.Windows.Forms.TextBox();
            this.bttAceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(41, 12);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(166, 20);
            this.txbNombre.TabIndex = 3;
            this.txbNombre.Text = "Nombre";
            // 
            // txbCuit
            // 
            this.txbCuit.Location = new System.Drawing.Point(41, 38);
            this.txbCuit.Name = "txbCuit";
            this.txbCuit.Size = new System.Drawing.Size(166, 20);
            this.txbCuit.TabIndex = 2;
            this.txbCuit.Text = "Cuit";
            // 
            // bttAceptar
            // 
            this.bttAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bttAceptar.Location = new System.Drawing.Point(41, 72);
            this.bttAceptar.Name = "bttAceptar";
            this.bttAceptar.Size = new System.Drawing.Size(75, 23);
            this.bttAceptar.TabIndex = 4;
            this.bttAceptar.Text = "Aceptar";
            this.bttAceptar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(132, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AgreagarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 103);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bttAceptar);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbCuit);
            this.Name = "AgreagarCliente";
            this.Text = "AgreagarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttAceptar;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox txbNombre;
        public System.Windows.Forms.TextBox txbCuit;
    }
}