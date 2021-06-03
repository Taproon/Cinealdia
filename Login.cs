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
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

            asterisco_nombre.Visible = false;
            asterisco_pass.Visible = false;
            lb_error.Visible = false;

        }

        private void lb_registro_Click(object sender, EventArgs e)
        {
            Registro registrarse = new Registro();

            registrarse.Show();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            String usuarioLog = tx_user.Text;
            String contraseña = tx_pass.Text;

            MySqlConnection connect = new MySqlConnection("server=remotemysql.com;user id=5tueH5qnuV;password=d4mBVI8YSx;database=5tueH5qnuV");
            connect.Open();
            String query = "SELECT nombreuser, contraseña FROM usuarios WHERE nombreuser = '" + @usuarioLog + "' AND contraseña ='" + @contraseña + "'";
            MySql.Data.MySqlClient.MySqlCommand comando = new MySql.Data.MySqlClient.MySqlCommand(query, connect);

            DataTable dt = new DataTable();
            MySql.Data.MySqlClient.MySqlDataAdapter da = new MySql.Data.MySqlClient.MySqlDataAdapter(comando);

            da.Fill(dt);

            if (dt.Rows.Count == 1)
            {

                Principal principal = new Principal(usuarioLog);
                principal.Show();
                this.Hide();


            }
            else
            {

                lb_error.Visible = true;
                asterisco_nombre.Visible = true;
                asterisco_pass.Visible = true;

            }

        }
    }
}
