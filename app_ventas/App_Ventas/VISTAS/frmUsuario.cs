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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        void Cargar() {
            dataGridView1.Rows.Clear();
            Cls_Usuario cls = new Cls_Usuario();

            List<tb_usuario> lista = cls.CargarDatos();

            foreach (var iteracion in lista){
                dataGridView1.Rows.Add(iteracion.iDUsuario, iteracion.email, iteracion.contrasena);
            }
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            Cargar();
            Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txt_Id.Text.Equals(""))
            {
                Cls_Usuario cls = new Cls_Usuario();
                tb_usuario tb = new tb_usuario();
                tb.email = txt_Email.Text;
                tb.contrasena = txt_Password.Text;
                cls.AgregarUsuario(tb);

            }
            else {
                Cls_Usuario cls = new Cls_Usuario();
                tb_usuario tb = new tb_usuario();
                tb.iDUsuario = Convert.ToInt32(txt_Id.Text);
                tb.email = txt_Email.Text;
                tb.contrasena = txt_Password.Text;
                cls.ModificarUsuario(tb);
            }

            Cargar();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cls_Usuario cls = new Cls_Usuario();
            tb_usuario tb = new tb_usuario();

            tb.iDUsuario = Convert.ToInt32(txt_Id.Text);
           
            cls.EliminarUsuario(tb);

            Cargar();
            Limpiar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_Email.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_Password.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        void Limpiar() {
            txt_Id.Clear();
            txt_Email.Clear();
            txt_Password.Clear();
        }
    }
}
