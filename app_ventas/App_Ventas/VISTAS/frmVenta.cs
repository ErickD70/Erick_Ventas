using appventas.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appventas.VISTAS
{
    public partial class frmVenta : Form
    {
        public frmVenta()
        {
            InitializeComponent();
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities()){
                var consultaCliente = db.tb_cliente.ToList();
                cbx_Cliente.DataSource = consultaCliente;
                //Mostrar miembros de la db, mostramos los nombres de los clientes.
                cbx_Cliente.DisplayMember = "nombreCliente";
                cbx_Cliente.ValueMember = "iDCliente";

                var consultaDocumento = db.tb_documento.ToList();
                cbx_Cliente.DataSource = consultaDocumento;
                cbx_Cliente.DisplayMember = "nombreDocumento";
                cbx_Cliente.ValueMember = "iDDocumento";
            }
        }

        private void cbx_TipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
