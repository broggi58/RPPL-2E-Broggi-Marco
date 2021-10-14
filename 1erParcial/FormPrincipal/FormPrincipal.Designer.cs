
namespace FormPrincipal
{
    partial class FormPrincipal
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.buttonAltaEmpledo = new System.Windows.Forms.Button();
            this.buttonBajaPersonal = new System.Windows.Forms.Button();
            this.buttonMostrarProductos = new System.Windows.Forms.Button();
            this.buttonMostrarPersonal = new System.Windows.Forms.Button();
            this.buttonVenta = new System.Windows.Forms.Button();
            this.buttonAltaProducto = new System.Windows.Forms.Button();
            this.buttonBajaProducto = new System.Windows.Forms.Button();
            this.buttonMostrarClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(64, 13);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(38, 15);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "label1";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(249, 12);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(38, 15);
            this.labelTipo.TabIndex = 1;
            this.labelTipo.Text = "label2";
            // 
            // buttonAltaEmpledo
            // 
            this.buttonAltaEmpledo.Location = new System.Drawing.Point(47, 88);
            this.buttonAltaEmpledo.Name = "buttonAltaEmpledo";
            this.buttonAltaEmpledo.Size = new System.Drawing.Size(89, 23);
            this.buttonAltaEmpledo.TabIndex = 2;
            this.buttonAltaEmpledo.Text = "Alta Personal";
            this.buttonAltaEmpledo.UseVisualStyleBackColor = true;
            // 
            // buttonBajaPersonal
            // 
            this.buttonBajaPersonal.Location = new System.Drawing.Point(212, 88);
            this.buttonBajaPersonal.Name = "buttonBajaPersonal";
            this.buttonBajaPersonal.Size = new System.Drawing.Size(99, 23);
            this.buttonBajaPersonal.TabIndex = 3;
            this.buttonBajaPersonal.Text = "Baja Personal";
            this.buttonBajaPersonal.UseVisualStyleBackColor = true;
            // 
            // buttonMostrarProductos
            // 
            this.buttonMostrarProductos.Location = new System.Drawing.Point(129, 173);
            this.buttonMostrarProductos.Name = "buttonMostrarProductos";
            this.buttonMostrarProductos.Size = new System.Drawing.Size(133, 23);
            this.buttonMostrarProductos.TabIndex = 4;
            this.buttonMostrarProductos.Text = "Mostrar Productos";
            this.buttonMostrarProductos.UseVisualStyleBackColor = true;
            // 
            // buttonMostrarPersonal
            // 
            this.buttonMostrarPersonal.Location = new System.Drawing.Point(129, 258);
            this.buttonMostrarPersonal.Name = "buttonMostrarPersonal";
            this.buttonMostrarPersonal.Size = new System.Drawing.Size(133, 23);
            this.buttonMostrarPersonal.TabIndex = 5;
            this.buttonMostrarPersonal.Text = "Mostrar Personal";
            this.buttonMostrarPersonal.UseVisualStyleBackColor = true;
            // 
            // buttonVenta
            // 
            this.buttonVenta.Location = new System.Drawing.Point(129, 299);
            this.buttonVenta.Name = "buttonVenta";
            this.buttonVenta.Size = new System.Drawing.Size(133, 23);
            this.buttonVenta.TabIndex = 6;
            this.buttonVenta.Text = "Hacer Venta";
            this.buttonVenta.UseVisualStyleBackColor = true;
            // 
            // buttonAltaProducto
            // 
            this.buttonAltaProducto.Location = new System.Drawing.Point(47, 130);
            this.buttonAltaProducto.Name = "buttonAltaProducto";
            this.buttonAltaProducto.Size = new System.Drawing.Size(89, 23);
            this.buttonAltaProducto.TabIndex = 7;
            this.buttonAltaProducto.Text = "Alta Producto";
            this.buttonAltaProducto.UseVisualStyleBackColor = true;
            // 
            // buttonBajaProducto
            // 
            this.buttonBajaProducto.Location = new System.Drawing.Point(212, 130);
            this.buttonBajaProducto.Name = "buttonBajaProducto";
            this.buttonBajaProducto.Size = new System.Drawing.Size(99, 23);
            this.buttonBajaProducto.TabIndex = 8;
            this.buttonBajaProducto.Text = "Baja Producto";
            this.buttonBajaProducto.UseVisualStyleBackColor = true;
            // 
            // buttonMostrarClientes
            // 
            this.buttonMostrarClientes.Location = new System.Drawing.Point(129, 215);
            this.buttonMostrarClientes.Name = "buttonMostrarClientes";
            this.buttonMostrarClientes.Size = new System.Drawing.Size(133, 23);
            this.buttonMostrarClientes.TabIndex = 9;
            this.buttonMostrarClientes.Text = "Mostrar Clientes";
            this.buttonMostrarClientes.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.Controls.Add(this.buttonMostrarClientes);
            this.Controls.Add(this.buttonBajaProducto);
            this.Controls.Add(this.buttonAltaProducto);
            this.Controls.Add(this.buttonVenta);
            this.Controls.Add(this.buttonMostrarPersonal);
            this.Controls.Add(this.buttonMostrarProductos);
            this.Controls.Add(this.buttonBajaPersonal);
            this.Controls.Add(this.buttonAltaEmpledo);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.labelNombre);
            this.Name = "FormPrincipal";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Button buttonAltaEmpledo;
        private System.Windows.Forms.Button buttonBajaPersonal;
        private System.Windows.Forms.Button buttonMostrarProductos;
        private System.Windows.Forms.Button buttonMostrarPersonal;
        private System.Windows.Forms.Button buttonVenta;
        private System.Windows.Forms.Button buttonAltaProducto;
        private System.Windows.Forms.Button buttonBajaProducto;
        private System.Windows.Forms.Button buttonMostrarClientes;
    }
}