using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinealdia
{
    public partial class Registro : Form
    {
    
            int idpelicula = 0;
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proviDataSet.provincias' Puede moverla o quitarla según sea necesario.
            this.provinciasTableAdapter.Fill(this.proviDataSet.provincias);
            // TODO: esta línea de código carga datos en la tabla 'pROVINCIASDataSet.provincias' Puede moverla o quitarla según sea necesario.

            asterisco_nombre.Visible = false;
            asterisco_fecha.Visible = false;
            asterisco_mail.Visible = false;
            asterisco_provincia.Visible = false;
            asterisco_pass.Visible = false;
            lb_error.Visible = false;
            lb_correcto.Visible = false;
            lb_error_ocupado.Visible = false;
        }

        public bool vacio; //CONTROLADOR

        private void validar(Form Registro) {

            foreach (Control oControls in Registro.Controls) {

                if (oControls is TextBox & oControls.Text == String.Empty)
                {
                    vacio =  true;
                }
                else {

                    vacio = false;
                }
            }

        
        }

        private Boolean validarMail(string mail) {

            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(mail, expresion))
            {
                if (Regex.Replace(mail, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        private void btn_registro_Click(object sender, EventArgs e)
        {
            // DATOS USUARIO
            String nombre = tx_user.Text;
            String password = tx_pass.Text;
            String provincia = cb_prov.Text;
            String mail = tx_mail.Text;
            String fecha = date_fecha.Value.ToString();
            idpelicula++;

            //CONTROL DE ERRORES

            validar(this);

            if (vacio == true)
            {

                asterisco_nombre.Visible = true;
                asterisco_mail.Visible = true;
                asterisco_provincia.Visible = true;
                asterisco_fecha.Visible = true;
                asterisco_pass.Visible = true;
                lb_error.Visible = true;
            }
            else {

                if (validarMail(mail) == true)
                {

                    // CONEXION MYSQL
                    MySql.Data.MySqlClient.MySqlConnection connect = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;user id=omar;password=1234;database=cinealdia");
                    connect.Open();
                    String query = "INSERT INTO usuarios (nombreuser, correo, provincia, fechanac, contraseña, idusuario) VALUES ('" + nombre + "','" + mail + "','" + provincia + "','" + fecha + "','" + password + "'," + idpelicula + ");";
                    MySql.Data.MySqlClient.MySqlCommand comando = new MySql.Data.MySqlClient.MySqlCommand(query, connect);

                    comando.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Datos introducidos correctamente");
                    this.Close();

                }
                else {

                    asterisco_mail.Visible = true;

                }

               

            }

        }

        private void tx_user_TextChanged(object sender, EventArgs e)
        {
            String nombre = tx_user.Text;

            MySql.Data.MySqlClient.MySqlConnection connect = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;user id=omar;password=1234;database=cinealdia");
            connect.Open();
            String query = "SELECT nombreuser FROM usuarios WHERE nombreuser = '" + nombre + "'";
            MySql.Data.MySqlClient.MySqlCommand comando = new MySql.Data.MySqlClient.MySqlCommand(query, connect);

            comando.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySql.Data.MySqlClient.MySqlDataAdapter da = new MySql.Data.MySqlClient.MySqlDataAdapter(comando);

            da.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                lb_correcto.Visible = false;
                lb_error_ocupado.Visible = true;

            }
            else {

                lb_error_ocupado.Visible = false;
                lb_correcto.Visible = true;
            
            }
        }
    }
}
