using appventas.DAO;
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
    public partial class frmDocumento : Form
    {
        public frmDocumento()
        {
            InitializeComponent();
        }
        void Limpiar()
        {
            TxT_Id.Clear();
            TxT_NombredeDocumento.Clear();

        }
        void Cargar()
        {
            dataGridView1.Rows.Clear();
            Cls_Documento cls = new Cls_Documento();

            List<tb_documento> lista = cls.CargarDatos();

            foreach (var iteracion in lista)
            {
                dataGridView1.Rows.Add(iteracion.iDDocumento,iteracion.nombreDocumento);
            }
        }

        private void frmDocumento_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (TxT_Id.Text.Equals(""))
            {
                Cls_Documento cls = new Cls_Documento();
                tb_documento tb = new tb_documento();
                tb.nombreDocumento = TxT_NombredeDocumento.Text;
                cls.AgregarDocumento(tb);

            }
            else
            {
                Cls_Documento cls = new Cls_Documento();
                tb_documento tb = new tb_documento();
                tb.iDDocumento = Convert.ToInt32(TxT_Id.Text);
                tb.nombreDocumento = TxT_NombredeDocumento.Text;
                cls.ModificarDocumento(tb);
            }

            Cargar();
            Limpiar();
        }
        private void TxT_NombredeDocumento_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cls_Documento cls = new Cls_Documento();
            tb_documento tb = new tb_documento();

            tb.iDDocumento = Convert.ToInt32(TxT_Id.Text);

            cls.EliminarDocumento(tb);

            Cargar();
            Limpiar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxT_Id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TxT_NombredeDocumento.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
