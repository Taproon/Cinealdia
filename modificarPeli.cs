using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class modificarPeli : Form
    {
        String title = "";
        String studio = "";
        int year;
        int score;
        int lenght;
        String status = "";
        String genere = "";
        String publ = "";
        String type = "";
        String user = "";
        public modificarPeli(String titulo, String estudio, int año, int puntuacion, int duracion, String estado, String genero, String publico, String tipo, String usuario)
        {
            InitializeComponent();
            this.title = titulo;
            this.studio = estudio;
            this.year = año;
            this.score = puntuacion;
            this.lenght = duracion;
            this.status = estado;
            this.genere = genero;
            this.publ = publico;
            this.type = tipo;
            this.user = usuario;

        }

        private void modificarPeli_Load(object sender, EventArgs e)
        {
            tx_titulo.Text = title;
            tx_estudio.Text = studio;
            tx_año.Text = year.ToString();
            tx_puntuacion.Value = score;
            tx_duracion.Value = lenght;
            cb_tipo.Text = type;
            cb_edad.Text = publ;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("server=remotemysql.com;user id=5tueH5qnuV;password=d4mBVI8YSx;database=5tueH5qnuV");
            connect.Open();

            StringBuilder st = new StringBuilder();
            ArrayList str = new ArrayList();

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

            ArrayList ArrayGeneros = new ArrayList();
            StringBuilder stGeneros = new StringBuilder();
            foreach (string s in checked_generos.CheckedItems)
            {
                stGeneros.Append(s);
                stGeneros.Append(", ");
            }

            String generos = stGeneros.ToString();

            String query1 = "UPDATE peliculas SET titulo = '" + tx_titulo.Text + "', estudio = '" + tx_estudio.Text + "', año = '" + Convert.ToInt32(tx_año.Text) + "', puntuacion = '" + Convert.ToInt32(tx_puntuacion.Value) + "', duracion = '" + Convert.ToInt32(tx_duracion.Value) + "', estado = '" + posesion + "', generos = '" + generos + "', tipo = '" + cb_tipo.Text + "', publico = '" + cb_edad.Text + "' WHERE idusuario = '" + user + "'";
            MySql.Data.MySqlClient.MySqlCommand comando1 = new MySql.Data.MySqlClient.MySqlCommand(query1, connect);

            comando1.ExecuteNonQuery();

            MessageBox.Show("Pelicula actualizada correctamente");
            connect.Close();
            this.Close();
        }

        private void modificarPeli_Deactivate(object sender, EventArgs e)
        {

        }
    }
}
