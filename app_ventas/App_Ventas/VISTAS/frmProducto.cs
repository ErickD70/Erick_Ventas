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
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }
        void Limpiar()
        {
            txt_Id.Clear();
            txt_Nombre.Clear();
            txt_Precio.Clear();
            txt_Estado.Clear();
        }

        void Cargar()
        {
            dataGridView1.Rows.Clear();
            Cls_Producto cls = new Cls_Producto();

            List<tb_producto> lista = cls.CargarDatos();

            foreach (var iteracion in lista)
            {
                dataGridView1.Rows.Add(iteracion.idProducto, iteracion.nombreProducto, iteracion.precioProducto, iteracion.estadoProducto);
            }
        }

       
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            Cargar();
            Limpiar();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            Cargar();
            Limpiar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txt_Id.Text.Equals(""))
            {
                Cls_Producto cls = new Cls_Producto();
                tb_producto tb = new tb_producto();
                tb.nombreProducto = txt_Nombre.Text;
                tb.precioProducto = txt_Precio.Text;
                tb.estadoProducto = txt_Estado.Text;
                cls.AgregarProducto(tb);

            }
            else
            {
                Cls_Producto cls = new Cls_Producto();
                tb_producto tb = new tb_producto();
                tb.idProducto = Convert.ToInt32(txt_Id.Text);
                tb.nombreProducto = txt_Nombre.Text;
                tb.precioProducto = txt_Precio.Text;
                tb.estadoProducto = txt_Estado.Text;
                cls.ModificarProducto(tb);
            }

            Cargar();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cls_Producto cls = new Cls_Producto();
            tb_producto tb = new tb_producto();

            tb.idProducto = Convert.ToInt32(txt_Id.Text);

            cls.EliminarProducto(tb);

            Cargar();
            Limpiar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_Nombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_Precio.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_Estado.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
