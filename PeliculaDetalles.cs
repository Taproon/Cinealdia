using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinealdia
{
    public partial class PeliculaDetalles : Form
    {
        string usuario = "";
        string title = "";
        string url = "";
        DataGridView dtv;
        public PeliculaDetalles(DataGridView datagrid, String user, String titulo)
        {
            InitializeComponent();
            this.usuario = user;
            this.dtv = datagrid;
            this.title = titulo;
            
        }

        private void PeliculaDetalles_Load(object sender, EventArgs e)
        {
            lb_titulo.Text = dtv.CurrentRow.Cells[0].Value.ToString();
            lb_estudio.Text = dtv.CurrentRow.Cells[1].Value.ToString();
            lb_año.Text = dtv.CurrentRow.Cells[2].Value.ToString();
            lb_puntuacion.Text = dtv.CurrentRow.Cells[3].Value.ToString();
            lb_duracion.Text = dtv.CurrentRow.Cells[4].Value.ToString();
            lb_estado.Text = dtv.CurrentRow.Cells[5].Value.ToString();
            lb_genero.Text = dtv.CurrentRow.Cells[6].Value.ToString();
            lb_publico.Text = dtv.CurrentRow.Cells[7].Value.ToString();
            lb_tipo.Text = dtv.CurrentRow.Cells[8].Value.ToString();

            //Consulta para obtener la ID de la pelicula
            
            int idpelicula = 0;
            MySqlConnection connect = new MySqlConnection("server=remotemysql.com;user id=5tueH5qnuV;password=d4mBVI8YSx;database=5tueH5qnuV");
            connect.Open();
            String query = "SELECT idpelicula, urlTrailer FROM peliculas WHERE idusuario ='" + usuario + "' AND titulo = '"+ dtv.CurrentRow.Cells[0].Value.ToString() +"'";
            MySqlCommand comando = new MySqlCommand(query, connect);
            MySqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                url = lector.GetString(1);
                idpelicula = Convert.ToInt32(lector.GetInt32(0));
            }

            connect.Close();


            //Obtener director
            connect.Open();
            String director = "";
            String consultadirector = "SELECT nombre FROM directores WHERE idpelicula ='" + idpelicula + "'";
            MySqlCommand comandodirector = new MySqlCommand(consultadirector, connect);
            MySqlDataReader lectordirector = comandodirector.ExecuteReader();
            while (lectordirector.Read())
            {
                director = lectordirector.GetString(0);
            }

            lb_director.Text = director;

            connect.Close();

            //Obtener guionista
            connect.Open();
            String guionista = "";
            String consultaguionista = "SELECT nombre FROM guionistas WHERE idpelicula ='" + idpelicula + "'";
            MySqlCommand comandoguionista = new MySqlCommand(consultaguionista, connect);
            MySqlDataReader lectorguionista = comandoguionista.ExecuteReader();
            while (lectorguionista.Read())
            {
                guionista = lectorguionista.GetString(0);
            }

            lb_guionista.Text = guionista;

            connect.Close();

            //Obtener banda sonora
            connect.Open();
            String bso = "";
            String consultabso = "SELECT nombre FROM bso WHERE idpelicula ='" + idpelicula + "'";
            MySqlCommand comandobso = new MySqlCommand(consultabso, connect);
            MySqlDataReader lectorbso = comandobso.ExecuteReader();
            while (lectorbso.Read())
            {
                bso = lectorbso.GetString(0);
            }

            lb_bso.Text = bso;

            connect.Close();


            //Obtener comentario
            connect.Open();
            String comentario = "";
            String consultacomentario = "SELECT comentario FROM peliculas WHERE idpelicula ='" + idpelicula + "'";
            MySqlCommand comandocomentario = new MySqlCommand(consultacomentario, connect);
            MySqlDataReader lectorcomentario = comandocomentario.ExecuteReader();
            while (lectorcomentario.Read())
            {
                comentario = lectorcomentario.GetString(0);
            }

            lb_comentario.Text = comentario;

            connect.Close();

            //Cargar Portada

            //Cargar Actores
            connect.Open();
            String queryactores = "SELECT nombre, apellidos, personaje FROM actores WHERE idpelicula = "+idpelicula+"";
            MySqlCommand comandoactores = new MySqlCommand(queryactores, connect);
            MySqlDataReader lectoractores = comandoactores.ExecuteReader();
            while (lectoractores.Read())
            {
                gridactores.Rows.Add(lectoractores.GetString(0), lectoractores.GetString(1), lectoractores.GetString(2));
            }

            
            connect.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Process.Start(url);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
