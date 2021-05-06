
namespace Cinealdia
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_user = new System.Windows.Forms.TextBox();
            this.tx_pass = new System.Windows.Forms.TextBox();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_registro = new System.Windows.Forms.Label();
            this.asterisco_nombre = new System.Windows.Forms.Label();
            this.asterisco_pass = new System.Windows.Forms.Label();
            this.lb_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // tx_user
            // 
            this.tx_user.Location = new System.Drawing.Point(332, 74);
            this.tx_user.Name = "tx_user";
            this.tx_user.Size = new System.Drawing.Size(165, 20);
            this.tx_user.TabIndex = 2;
            // 
            // tx_pass
            // 
            this.tx_pass.Location = new System.Drawing.Point(332, 114);
            this.tx_pass.Name = "tx_pass";
            this.tx_pass.PasswordChar = '*';
            this.tx_pass.Size = new System.Drawing.Size(165, 20);
            this.tx_pass.TabIndex = 3;
            // 
            // btn_entrar
            // 
            this.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_entrar.Font = new System.Drawing.Font("Broadway", 12F);
            this.btn_entrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_entrar.Location = new System.Drawing.Point(346, 188);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(91, 38);
            this.btn_entrar.TabIndex = 4;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "¿Aún no tienes usuario? Registrate";
            // 
            // lb_registro
            // 
            this.lb_registro.AutoSize = true;
            this.lb_registro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_registro.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lb_registro.Location = new System.Drawing.Point(464, 284);
            this.lb_registro.Name = "lb_registro";
            this.lb_registro.Size = new System.Drawing.Size(39, 15);
            this.lb_registro.TabIndex = 6;
            this.lb_registro.Text = "AQUÍ";
            this.lb_registro.Click += new System.EventHandler(this.lb_registro_Click);
            // 
            // asterisco_nombre
            // 
            this.asterisco_nombre.AutoSize = true;
            this.asterisco_nombre.BackColor = System.Drawing.Color.Transparent;
            this.asterisco_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asterisco_nombre.ForeColor = System.Drawing.Color.Red;
            this.asterisco_nombre.Location = new System.Drawing.Point(504, 75);
            this.asterisco_nombre.Name = "asterisco_nombre";
            this.asterisco_nombre.Size = new System.Drawing.Size(21, 25);
            this.asterisco_nombre.TabIndex = 7;
            this.asterisco_nombre.Text = "*";
            // 
            // asterisco_pass
            // 
            this.asterisco_pass.AutoSize = true;
            this.asterisco_pass.BackColor = System.Drawing.Color.Transparent;
            this.asterisco_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asterisco_pass.ForeColor = System.Drawing.Color.Red;
            this.asterisco_pass.Location = new System.Drawing.Point(504, 115);
            this.asterisco_pass.Name = "asterisco_pass";
            this.asterisco_pass.Size = new System.Drawing.Size(21, 25);
            this.asterisco_pass.TabIndex = 8;
            this.asterisco_pass.Text = "*";
            // 
            // lb_error
            // 
            this.lb_error.AutoSize = true;
            this.lb_error.BackColor = System.Drawing.Color.Transparent;
            this.lb_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_error.ForeColor = System.Drawing.Color.Red;
            this.lb_error.Location = new System.Drawing.Point(292, 146);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(205, 16);
            this.lb_error.TabIndex = 9;
            this.lb_error.Text = "Usuario o contraseña incorrectos";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 414);
            this.Controls.Add(this.lb_error);
            this.Controls.Add(this.asterisco_pass);
            this.Controls.Add(this.asterisco_nombre);
            this.Controls.Add(this.lb_registro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.tx_pass);
            this.Controls.Add(this.tx_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinealdia";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_user;
        private System.Windows.Forms.TextBox tx_pass;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_registro;
        private System.Windows.Forms.Label asterisco_nombre;
        private System.Windows.Forms.Label asterisco_pass;
        private System.Windows.Forms.Label lb_error;
    }
}

