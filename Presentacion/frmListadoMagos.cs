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
    public partial class frmListadoMagos : Form
    {

        private List<Mago> listaMago;

        public frmListadoMagos()
        {
            InitializeComponent();
        }

        public void listadoMagos_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            MagoNegocio magoNegocio = new MagoNegocio();
            try
            {

                listaMago = magoNegocio.listar();
                dgvMagos.DataSource = listaMago;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnVerHechizos_Click(object sender, EventArgs e)
        {
            Mago mago;
            mago = (Mago)dgvMagos.CurrentRow.DataBoundItem;
            frmVerHechizos hechizos = new frmVerHechizos(mago);
            hechizos.ShowDialog();
        }

        private void dgvMagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
