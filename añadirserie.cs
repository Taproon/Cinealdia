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
    public partial class añadirserie : Form
    {
        public añadirserie()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            String titulo = tx_titulo.Text;
            String estudio = tx_estudio.Text;
            String año = tx_año.Text;
            StringBuilder sb = new StringBuilder();
            foreach (string s in listbox_genero.Items)
                sb.Append(s);
            String checkbox = "";

            if (ch_coleccion.Checked)
            {

                checkbox = "En Coleccion";

            }
            else if (ch_quiero.Checked)
            {

                checkbox = "La quiero";

            }
            else if (ch_vista.Checked)
            {

                checkbox = "Vista";

            }
            else if (ch_venta.Checked) {

                checkbox = "En venta";

            }
            


        }
    }
}
