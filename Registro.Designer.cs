
namespace Cinealdia
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.asterisco_pass = new System.Windows.Forms.Label();
            this.asterisco_nombre = new System.Windows.Forms.Label();
            this.tx_pass = new System.Windows.Forms.TextBox();
            this.tx_user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.asterisco_mail = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.asterisco_provincia = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.asterisco_fecha = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_registro = new System.Windows.Forms.Button();
            this.lb_error = new System.Windows.Forms.Label();
            this.lb_correcto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // asterisco_pass
            // 
            this.asterisco_pass.AutoSize = true;
            this.asterisco_pass.BackColor = System.Drawing.Color.Transparent;
            this.asterisco_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asterisco_pass.ForeColor = System.Drawing.Color.Red;
            this.asterisco_pass.Location = new System.Drawing.Point(355, 205);
            this.asterisco_pass.Name = "asterisco_pass";
            this.asterisco_pass.Size = new System.Drawing.Size(21, 25);
            this.asterisco_pass.TabIndex = 14;
            this.asterisco_pass.Text = "*";
            // 
            // asterisco_nombre
            // 
            this.asterisco_nombre.AutoSize = true;
            this.asterisco_nombre.BackColor = System.Drawing.Color.Transparent;
            this.asterisco_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asterisco_nombre.ForeColor = System.Drawing.Color.Red;
            this.asterisco_nombre.Location = new System.Drawing.Point(355, 50);
            this.asterisco_nombre.Name = "asterisco_nombre";
            this.asterisco_nombre.Size = new System.Drawing.Size(21, 25);
            this.asterisco_nombre.TabIndex = 13;
            this.asterisco_nombre.Text = "*";
            // 
            // tx_pass
            // 
            this.tx_pass.Location = new System.Drawing.Point(208, 205);
            this.tx_pass.Name = "tx_pass";
            this.tx_pass.PasswordChar = '*';
            this.tx_pass.Size = new System.Drawing.Size(141, 20);
            this.tx_pass.TabIndex = 12;
            // 
            // tx_user
            // 
            this.tx_user.Location = new System.Drawing.Point(208, 50);
            this.tx_user.Name = "tx_user";
            this.tx_user.Size = new System.Drawing.Size(141, 20);
            this.tx_user.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre de Usuario:";
            // 
            // asterisco_mail
            // 
            this.asterisco_mail.AutoSize = true;
            this.asterisco_mail.BackColor = System.Drawing.Color.Transparent;
            this.asterisco_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asterisco_mail.ForeColor = System.Drawing.Color.Red;
            this.asterisco_mail.Location = new System.Drawing.Point(355, 89);
            this.asterisco_mail.Name = "asterisco_mail";
            this.asterisco_mail.Size = new System.Drawing.Size(21, 25);
            this.asterisco_mail.TabIndex = 17;
            this.asterisco_mail.Text = "*";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(208, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Correo Electrónico:";
            // 
            // asterisco_provincia
            // 
            this.asterisco_provincia.AutoSize = true;
            this.asterisco_provincia.BackColor = System.Drawing.Color.Transparent;
            this.asterisco_provincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asterisco_provincia.ForeColor = System.Drawing.Color.Red;
            this.asterisco_provincia.Location = new System.Drawing.Point(355, 128);
            this.asterisco_provincia.Name = "asterisco_provincia";
            this.asterisco_provincia.Size = new System.Drawing.Size(21, 25);
            this.asterisco_provincia.TabIndex = 20;
            this.asterisco_provincia.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(121, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Provincia:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(209, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // asterisco_fecha
            // 
            this.asterisco_fecha.AutoSize = true;
            this.asterisco_fecha.BackColor = System.Drawing.Color.Transparent;
            this.asterisco_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asterisco_fecha.ForeColor = System.Drawing.Color.Red;
            this.asterisco_fecha.Location = new System.Drawing.Point(355, 168);
            this.asterisco_fecha.Name = "asterisco_fecha";
            this.asterisco_fecha.Size = new System.Drawing.Size(21, 25);
            this.asterisco_fecha.TabIndex = 23;
            this.asterisco_fecha.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(62, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Fecha Nacimiento:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(208, 167);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // btn_registro
            // 
            this.btn_registro.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_registro.Font = new System.Drawing.Font("Broadway", 12F);
            this.btn_registro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_registro.Location = new System.Drawing.Point(173, 272);
            this.btn_registro.Name = "btn_registro";
            this.btn_registro.Size = new System.Drawing.Size(107, 38);
            this.btn_registro.TabIndex = 25;
            this.btn_registro.Text = "REGISTRO";
            this.btn_registro.UseVisualStyleBackColor = true;
            // 
            // lb_error
            // 
            this.lb_error.AutoSize = true;
            this.lb_error.BackColor = System.Drawing.Color.Transparent;
            this.lb_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_error.ForeColor = System.Drawing.Color.Red;
            this.lb_error.Location = new System.Drawing.Point(148, 239);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(170, 16);
            this.lb_error.TabIndex = 26;
            this.lb_error.Text = "No deje campos en blanco";
            // 
            // lb_correcto
            // 
            this.lb_correcto.AutoSize = true;
            this.lb_correcto.BackColor = System.Drawing.Color.Transparent;
            this.lb_correcto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_correcto.ForeColor = System.Drawing.Color.ForestGreen;
            this.lb_correcto.Location = new System.Drawing.Point(108, 21);
            this.lb_correcto.Name = "lb_correcto";
            this.lb_correcto.Size = new System.Drawing.Size(230, 16);
            this.lb_correcto.TabIndex = 27;
            this.lb_correcto.Text = "El nombre de usuario está disponible";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(423, 476);
            this.Controls.Add(this.lb_correcto);
            this.Controls.Add(this.lb_error);
            this.Controls.Add(this.btn_registro);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.asterisco_fecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.asterisco_provincia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.asterisco_mail);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.asterisco_pass);
            this.Controls.Add(this.asterisco_nombre);
            this.Controls.Add(this.tx_pass);
            this.Controls.Add(this.tx_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinealdia";
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label asterisco_pass;
        private System.Windows.Forms.Label asterisco_nombre;
        private System.Windows.Forms.TextBox tx_pass;
        private System.Windows.Forms.TextBox tx_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label asterisco_mail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label asterisco_provincia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label asterisco_fecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_registro;
        private System.Windows.Forms.Label lb_error;
        private System.Windows.Forms.Label lb_correcto;
    }
}