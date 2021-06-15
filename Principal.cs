﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinealdia
{
    public partial class Principal : Form
    {
        private Form activeForm;
        
        public Principal(String usuario)
        {
            InitializeComponent();
            lb_usuario.Text = usuario;
           
        }
        
        private void Principal_Load(object sender, EventArgs e)
        {
            esconderSubmenu();
            OpenChildForm(new Bienvenida(), sender);
        }

        private void esconderSubmenu() {

            panelMoviesSelect.Visible = false;
            
        }

        private void mostrarSubmenu(Panel submenu) {

            if (submenu.Visible == false)
            {
                esconderSubmenu();
                submenu.Visible = true;
            }
            else {
                submenu.Visible = false;
            }

        }

        private void btn_movies_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelMoviesSelect);
        }


        private void OpenChildForm(Form childForm, object btnSender) {

            if (activeForm != null) {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_principal.Controls.Add(childForm);
            this.panel_principal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lb_title.Text = childForm.Text;

        }

        private void btn_addmovie_Click(object sender, EventArgs e)
        {
            String user = lb_usuario.Text;
            OpenChildForm(new añadirPelicula(user), sender);
        }

        private void panelLogo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Bienvenida(), sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new añadirserie(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String user = lb_usuario.Text;
            OpenChildForm(new ListaPeliculas(user), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            String user = lb_usuario.Text;
            perfil perf = new perfil(user);
            perf.Show();
        }

        private void panel_principal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
