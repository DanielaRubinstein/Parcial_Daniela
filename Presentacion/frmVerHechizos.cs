using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class frmVerHechizos : Form
    {
        private List<Hechizo> listahechizos;
        public frmVerHechizos()
        {
            InitializeComponent();
        }

        private void frmVerHechizos_Load(object sender, EventArgs e)
        {
            HechizoNegocio hechizoNegocio = new HechizoNegocio();
            try
            {

                listahechizos = hechizoNegocio.listar();
                dgvHechizo.DataSource = listahechizos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }



    }
}
