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
    }
}
