using MySql.Data.MySqlClient;
using System;
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
    public partial class ListaPeliculas : Form
    {
        private DataTable dt;
        String user = "";
        String titulo = "";
        public ListaPeliculas(String usuario)
        {
            InitializeComponent();
            this.user = usuario;
           

        }

        public void llenarGrid(DataGridView grid) {

            MySqlConnection connect = new MySqlConnection("server=remotemysql.com;user id=5tueH5qnuV;password=d4mBVI8YSx;database=5tueH5qnuV");
            connect.Open();
            String query = "SELECT titulo, estudio, año, puntuacion, duracion, estado, generos, publico, tipo FROM peliculas WHERE idusuario ='"+user+"'";
            MySqlCommand comando = new MySqlCommand(query, connect);
            MySqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                titulo = lector.GetString(0).ToString();
                datagridPeliculas.Rows.Add(lector.GetString(0), lector.GetString(1), lector.GetInt32(2), lector.GetInt32(3), lector.GetInt32(4), lector.GetString(5), lector.GetString(6), lector.GetString(7), lector.GetString(8));
            }
            connect.Close();
            
        }
        
        private void ListaPeliculas_Load(object sender, EventArgs e)
        {

            llenarGrid(datagridPeliculas);
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("¿Seguro que quiere eliminar esta pelicula?", "Eliminar Registro", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {
                MySqlConnection connect = new MySqlConnection("server=remotemysql.com;user id=5tueH5qnuV;password=d4mBVI8YSx;database=5tueH5qnuV");
                connect.Open();
                string borrar = "DELETE FROM peliculas WHERE titulo LIKE '" + datagridPeliculas.CurrentRow.Cells[0].Value.ToString() + "' AND idusuario = '" + user + "'";
                MySqlCommand comando = new MySqlCommand(borrar, connect);
                comando.ExecuteNonQuery();
                datagridPeliculas.Refresh();
                connect.Close();
  
            }

            datagridPeliculas.Rows.Clear();
            llenarGrid(datagridPeliculas);
            datagridPeliculas.Refresh();

        }

        private void datagridPeliculas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            PeliculaDetalles pelidetalles = new PeliculaDetalles(datagridPeliculas, user,titulo);
            pelidetalles.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String titulo = datagridPeliculas.CurrentRow.Cells[0].Value.ToString();
            String estudio = datagridPeliculas.CurrentRow.Cells[1].Value.ToString();
            int año = Convert.ToInt32(datagridPeliculas.CurrentRow.Cells[2].Value);
            int puntuacion = Convert.ToInt32(datagridPeliculas.CurrentRow.Cells[3].Value);
            int duracion = Convert.ToInt32(datagridPeliculas.CurrentRow.Cells[4].Value);
            String estado = datagridPeliculas.CurrentRow.Cells[5].Value.ToString();
            String genero = datagridPeliculas.CurrentRow.Cells[6].Value.ToString();
            String publico = datagridPeliculas.CurrentRow.Cells[7].Value.ToString();
            String tipo = datagridPeliculas.CurrentRow.Cells[8].Value.ToString();

            modificarPeli mod = new modificarPeli(titulo, estudio, año, puntuacion, duracion, estado, genero, publico, tipo, user);
            mod.Show();
            

        }

    }
}
