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
    public partial class frmCliente : Form
    {
        void Limpiar()
        {
            txt_Id.Clear();
            txt_Nombre.Clear();
            txt_Direccion.Clear();
            txt_Dui.Clear();

        }
        public frmCliente()
        {
            InitializeComponent();
        }

        void Cargar()
        {
            dataGridView1.Rows.Clear();
            Cls_Cliente cls = new Cls_Cliente();

            List<tb_cliente> lista = cls.CargarDatos();

            foreach (var iteracion in lista)
            {
                dataGridView1.Rows.Add(iteracion.iDCliente, iteracion.nombreCliente, iteracion.direccionCliente, iteracion.duiCliente);
            }
        }
        private void frmCliente_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txt_Id.Text.Equals(""))
            {
                Cls_Cliente cls = new Cls_Cliente();
                tb_cliente tb = new tb_cliente();
                tb.nombreCliente = txt_Nombre.Text;
                tb.direccionCliente = txt_Direccion.Text;
                tb.duiCliente = txt_Dui.Text;
                cls.AgregarCliente(tb);

            }
            else
            {
                Cls_Cliente cls = new Cls_Cliente();
                tb_cliente tb = new tb_cliente();
                tb.iDCliente = Convert.ToInt32(txt_Id.Text);
                tb.nombreCliente = txt_Nombre.Text;
                tb.direccionCliente = txt_Direccion.Text;
                tb.duiCliente = txt_Dui.Text;
                cls.ModificarCliente(tb);
            }

            Cargar();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cls_Cliente cls = new Cls_Cliente();
            tb_cliente tb = new tb_cliente();

            tb.iDCliente = Convert.ToInt32(txt_Id.Text);

            cls.EliminarCliente(tb);

            Cargar();
            Limpiar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_Nombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_Direccion.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_Dui.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
    
}
