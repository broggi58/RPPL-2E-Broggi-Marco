
namespace FormPrincipal
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonLogEmpleado = new System.Windows.Forms.Button();
            this.buttonLogAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(110, 46);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(51, 15);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Nombre";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(110, 98);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 15);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(219, 46);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 23);
            this.textBoxNombre.TabIndex = 2;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(219, 90);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 23);
            this.textBoxID.TabIndex = 3;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(110, 142);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(286, 142);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 5;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            // 
            // buttonLogEmpleado
            // 
            this.buttonLogEmpleado.Location = new System.Drawing.Point(12, 12);
            this.buttonLogEmpleado.Name = "buttonLogEmpleado";
            this.buttonLogEmpleado.Size = new System.Drawing.Size(94, 23);
            this.buttonLogEmpleado.TabIndex = 6;
            this.buttonLogEmpleado.Text = "LogEmpleado";
            this.buttonLogEmpleado.UseVisualStyleBackColor = true;
            // 
            // buttonLogAdmin
            // 
            this.buttonLogAdmin.Location = new System.Drawing.Point(335, 12);
            this.buttonLogAdmin.Name = "buttonLogAdmin";
            this.buttonLogAdmin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogAdmin.TabIndex = 7;
            this.buttonLogAdmin.Text = "LogAdmin";
            this.buttonLogAdmin.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 207);
            this.Controls.Add(this.buttonLogAdmin);
            this.Controls.Add(this.buttonLogEmpleado);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonLogEmpleado;
        private System.Windows.Forms.Button buttonLogAdmin;
    }
}

