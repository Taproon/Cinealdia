using MySql.Data.MySqlClient;
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
    public partial class perfil : Form
    {
        String user = "";
        public perfil(String usuario)
        {
            InitializeComponent();
            this.user = usuario;
            tx_nuevomail.Visible = false;
            lb_mail.Visible = true;
            tx_nuevapass.Visible = false;
            lb_pass.Visible = true;

        }

        private void perfil_Load(object sender, EventArgs e)
        {

            MySqlConnection connect = new MySqlConnection("server=localhost;user id=omar;password=1234;database=cinealdia");
            connect.Open();
            String query = "SELECT correo, provincia, fechanac, contraseña tipo FROM usuarios WHERE nombreuser ='" + user + "'";
            MySqlCommand comando = new MySqlCommand(query, connect);
            MySqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                lb_nombre.Text = user;
                lb_mail.Text = lector.GetString(0);
                lb_prov.Text = lector.GetString(1);
                lb_fecha.Text = lector.GetString(2);
                lb_pass.Text = lector.GetString(3);
            }
            connect.Close();

            connect.Open();
            String querypelis = "SELECT Count(*) FROM peliculas WHERE idusuario ='" + user + "'";
            MySqlCommand comandopelis = new MySqlCommand(querypelis, connect);
            MySqlDataReader lectorpelis = comandopelis.ExecuteReader();
            while (lectorpelis.Read())
            {
                lb_pelis.Text = lectorpelis.GetInt32(0).ToString();
               
            }

            connect.Close();

        }

        private void btn_mail_Click(object sender, EventArgs e)
        {
            tx_nuevomail.Visible = true;
            lb_mail.Visible = false;
        }

        private void btn_apli2_Click(object sender, EventArgs e)
        {
            String nuevocorreo = tx_nuevomail.Text;
            if (validarMail(nuevocorreo) == true)
            {

                MySqlConnection connect = new MySqlConnection("server=localhost;user id=omar;password=1234;database=cinealdia");
                connect.Open();
                String querypelicula = "UPDATE usuarios SET correo = '" + @nuevocorreo + "' WHERE  nombreuser = '" + @user + "'";
                MySqlCommand comandopelicula = new MySqlCommand(querypelicula, connect);
                comandopelicula.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Correo actualizado correctamente");
                tx_nuevomail.Visible = false;
                lb_mail.Visible = true;

                connect.Open();
                String query = "SELECT correo FROM usuarios WHERE nombreuser ='" + user + "'";
                MySqlCommand comando = new MySqlCommand(query, connect);
                MySqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {

                    lb_mail.Text = lector.GetString(0);

                }
                connect.Close();
            }
            else {

                MessageBox.Show("Correo con caracteres incorrectos");

            }
            
        }

        private Boolean validarMail(string mail)
        {

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

        private void btn_contraseña_Click(object sender, EventArgs e)
        {

            tx_nuevapass.Visible = true;
            lb_pass.Visible = false;

        }

        private void btn_apli3_Click(object sender, EventArgs e)
        {

            String nuevapass = tx_nuevapass.Text;
           

                MySqlConnection connect = new MySqlConnection("server=localhost;user id=omar;password=1234;database=cinealdia");
                connect.Open();
                String querypelicula = "UPDATE usuarios SET contraseña = '" + @nuevapass + "' WHERE  nombreuser = '" + @user + "'";
                MySqlCommand comandopelicula = new MySqlCommand(querypelicula, connect);
                comandopelicula.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Contraseña actualizada correctamente");
                tx_nuevapass.Visible = false;
                lb_pass.Visible = true;

                connect.Open();
                String query = "SELECT contraseña FROM usuarios WHERE nombreuser ='" + user + "'";
                MySqlCommand comando = new MySqlCommand(query, connect);
                MySqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {

                    lb_pass.Text = lector.GetString(0);

                }
                connect.Close();
            

        }
    }
}
