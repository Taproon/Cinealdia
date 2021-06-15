﻿using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinealdia
{   
   
    public partial class añadirPelicula : Form
    {
        OpenFileDialog getImage = new OpenFileDialog();
        private String Path;
        
        public añadirPelicula(String usuario)
        {
            InitializeComponent();
            lb_usuario.Visible = true;
            lb_usuario.Text = usuario;
            lb_error.Visible = false;
           

        }
        public void llenarGrid(DataGridView grid)
        {
            MySqlConnection connect = new MySqlConnection("server=remotemysql.com;user id=5tueH5qnuV;password=d4mBVI8YSx;database=5tueH5qnuV");
            connect.Open();
            string titulo = tx_titulo.Text;
            int idpelicula = 0;

            String querypelicula = "SELECT idpelicula FROM peliculas WHERE titulo = '" + titulo + "' AND idusuario = '" + lb_usuario.Text + "'";
            MySqlCommand comandopelicula = new MySqlCommand(querypelicula, connect);
            comandopelicula.ExecuteNonQuery();

            DataTable dtpelicula = new DataTable();
            MySql.Data.MySqlClient.MySqlDataAdapter dapèlicula = new MySql.Data.MySqlClient.MySqlDataAdapter(comandopelicula);

            dapèlicula.Fill(dtpelicula);

            if (dtpelicula.Rows.Count == 1)
            {

                idpelicula = Convert.ToInt32(comandopelicula.ExecuteScalar());

            }
            connect.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            getImage.Filter = "Imagenes|*.jpg; *.png";
            getImage.InitialDirectory = "C:\\";
            getImage.Title = "Seleccionar Imagen";
            try
            {
                if (getImage.ShowDialog() == DialogResult.OK)
                {
                    imagen.ImageLocation = getImage.FileName;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            String titulo = tx_titulo.Text;
            String estudio = tx_estudio.Text;
            String año = tx_año.Text;
            String comentario = tx_comment.Text;
            int puntacion = Convert.ToInt32(numeric_puntuacion.Value.ToString());
            int duracion = Convert.ToInt32(numeric_duracion.Value.ToString());
            ArrayList str = new ArrayList();

            //GUARDAR IMAGEN
            byte[] aByte = null;
            if (imagen.Image == null)
                MessageBox.Show("Debe indicar una imagen.");
            else
            {
                MemoryStream ms = new MemoryStream();
                imagen.Image.Save(ms, ImageFormat.Jpeg);
                aByte = ms.ToArray();
                //COMPROBAR CHECKBOX

                StringBuilder st = new StringBuilder();

                if (ch_coleccion.Checked)
                {
                    str.Add("En coleccion");
                }
                if (ch_quiero.Checked)
                {
                    str.Add("La quiero");
                }
                if (ch_vista.Checked)
                {
                    str.Add("Vista");
                }
                if (ch_venta.Checked)
                {
                    str.Add("En venta");
                }

                for (int i = 0; i < str.Count; i++)
                {

                    st.Append(str[i]);
                    st.Append(", ");
                }

                String posesion = st.ToString();


                // COMPROBAR GENEROS
                ArrayList ArrayGeneros = new ArrayList();
                StringBuilder stGeneros = new StringBuilder();
                foreach (string s in checked_generos.CheckedItems)
                {
                    stGeneros.Append(s);
                    stGeneros.Append(", ");
                }

                String generos = stGeneros.ToString();

                // COMPROBAR PLANTILLA


                //COMPROBAR TIPO
                String tipo = cb_tipo.Text;
                String publico = cb_edad.Text;

                //COMPROBAR PLANTILLA
                String director = tx_director.Text;
                String guionistas = tx_guionistas.Text;
                String bso = tx_bso.Text;


                // CONEXION CON BD Y SUBIDA DE DATOS CON COMPROBACION DE EXISTENCIA POR USUARIO

                MySqlConnection connect = new MySqlConnection("server=remotemysql.com;user id=5tueH5qnuV;password=d4mBVI8YSx;database=5tueH5qnuV");
                connect.Open();


                String query = "SELECT titulo FROM peliculas WHERE titulo = '" + titulo + "' AND idusuario = '" + lb_usuario.Text + "'";
                MySql.Data.MySqlClient.MySqlCommand comando = new MySql.Data.MySqlClient.MySqlCommand(query, connect);
                comando.ExecuteNonQuery();

                DataTable dt = new DataTable();
                MySql.Data.MySqlClient.MySqlDataAdapter da = new MySql.Data.MySqlClient.MySqlDataAdapter(comando);

                da.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Esta pelicula ya existe para este usuario. No se puede repetir");
                    tx_titulo.Clear();

                }
                else
                {
                    String ruta = getImage.FileName.Replace("\\", "\\\\");
                    String query1 = "INSERT INTO peliculas (titulo, estudio, año, puntuacion, duracion, estado, generos, publico, tipo, portada, comentario, urlTrailer, idusuario) VALUES ('" + titulo + "','" + estudio + "'," + año + "," + puntacion + "," + duracion + ",'" + posesion + "','" + generos + "','"+publico+"' ,'" + tipo + "','" + @ruta + "','"+ comentario +"' , '"+tx_trailer.Text +"','" + lb_usuario.Text + "');";
                    MySqlCommand comando1 = new MySqlCommand(query1, connect);
                    comando1.ExecuteNonQuery();

                    int idpelicula = 0;

                    String querypelicula = "SELECT idpelicula FROM peliculas WHERE titulo = '" + titulo + "' AND idusuario = '" + lb_usuario.Text + "'";
                    MySql.Data.MySqlClient.MySqlCommand comandopelicula = new MySql.Data.MySqlClient.MySqlCommand(querypelicula, connect);
                    comandopelicula.ExecuteNonQuery();

                    DataTable dtpelicula = new DataTable();
                    MySql.Data.MySqlClient.MySqlDataAdapter dapèlicula = new MySql.Data.MySqlClient.MySqlDataAdapter(comandopelicula);

                    dapèlicula.Fill(dtpelicula);

                    if (dtpelicula.Rows.Count == 1)
                    {

                        idpelicula = Convert.ToInt32(comandopelicula.ExecuteScalar());

                    }

                    String queryDirector = "INSERT INTO directores (nombre, idpelicula) VALUES ('" + director + "', "+ idpelicula + ")";
                    MySqlCommand comandoDirector = new MySqlCommand(queryDirector, connect);
                    comandoDirector.ExecuteNonQuery();

                    String querybso = "INSERT INTO bso (nombre, idpelicula) VALUES ('" + bso + "', "+ idpelicula + ")";
                    MySqlCommand comandobso = new MySqlCommand(querybso, connect);
                    comandobso.ExecuteNonQuery();

                    String queryguion = "INSERT INTO guionistas (nombre, idpelicula) VALUES ('" + guionistas + "', "+ idpelicula + ")";
                    MySqlCommand comandoguion = new MySqlCommand(queryguion, connect);
                    comandoguion.ExecuteNonQuery();

                    connect.Close();
                    MessageBox.Show("Datos introducidos correctamente");

                }

            }

        }

        private void añadirPelicula_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_5tueH5qnuVDataSet2.peliculas' Puede moverla o quitarla según sea necesario.
            this.peliculasTableAdapter1.Fill(this._5tueH5qnuVDataSet2.peliculas);

        }

        private void btn_añadir_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("server=remotemysql.com;user id=5tueH5qnuV;password=d4mBVI8YSx;database=5tueH5qnuV");
            connect.Open();
            string titulo = tx_titulo.Text;
            string nombre = tx_nombre.Text;
            string apellidos = tx_apellidos.Text;
            string personaje = tx_personaje.Text;

            int idpelicula = 0;

            String querypelicula = "SELECT idpelicula FROM peliculas WHERE titulo = '" + titulo + "' AND idusuario = '" + lb_usuario.Text + "'";
            MySqlCommand comandopelicula = new MySqlCommand(querypelicula, connect);
            comandopelicula.ExecuteNonQuery();

            DataTable dtpelicula = new DataTable();
            MySqlDataAdapter dapèlicula = new MySqlDataAdapter(comandopelicula);

            dapèlicula.Fill(dtpelicula);

            if (dtpelicula.Rows.Count == 1)
            {

                idpelicula = Convert.ToInt32(comandopelicula.ExecuteScalar());

            }
            connect.Close();


            connect.Open();
            String query = "SELECT nombre, apellidos, idpelicula FROM actores WHERE nombre = '" + nombre + "' AND apellidos = '" + apellidos + "' AND idpelicula = "+comboBox1.SelectedValue+"";
            MySqlCommand comando = new MySqlCommand(query, connect);
            comando.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(comando);

            da.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Este actor ya existe para esta pelicula");
                tx_nombre.Clear();
                tx_apellidos.Clear();
                tx_personaje.Clear();

            }
            else
            {
                
                String queryactor = "INSERT INTO actores (nombre, apellidos, personaje, idpelicula) VALUES ('" + nombre + "', '" + apellidos + "', '" + personaje + "', " + comboBox1.SelectedValue + ")";
                MySqlCommand comandoactor = new MySqlCommand(queryactor, connect);
                comandoactor.ExecuteNonQuery();
                MessageBox.Show("Datos introducidos correctamente");
               
            }
            connect.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
