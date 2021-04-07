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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            asterisco_nombre.Visible = false;
            asterisco_fecha.Visible = false;
            asterisco_mail.Visible = false;
            asterisco_provincia.Visible = false;
            asterisco_pass.Visible = false;
            lb_error.Visible = false;
            lb_correcto.Visible = false;
        }
    }
}
