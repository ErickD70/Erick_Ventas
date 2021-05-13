
namespace appventas.VISTAS
{
    partial class frmVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbx_TipoDocumento = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TXT_Documento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_Cliente = new System.Windows.Forms.ComboBox();
            this.TXT_Buscar_Producto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Codigo_Producto = new System.Windows.Forms.TextBox();
            this.txt_Nombre_Producto = new System.Windows.Forms.TextBox();
            this.txt_Precio_Producto = new System.Windows.Forms.TextBox();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de documento";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(267, 132);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 32);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // cbx_TipoDocumento
            // 
            this.cbx_TipoDocumento.FormattingEnabled = true;
            this.cbx_TipoDocumento.Location = new System.Drawing.Point(544, 51);
            this.cbx_TipoDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_TipoDocumento.Name = "cbx_TipoDocumento";
            this.cbx_TipoDocumento.Size = new System.Drawing.Size(182, 21);
            this.cbx_TipoDocumento.TabIndex = 3;
            this.cbx_TipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cbx_TipoDocumento_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 289);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(792, 177);
            this.dataGridView1.TabIndex = 4;
            // 
            // TXT_Documento
            // 
            this.TXT_Documento.Location = new System.Drawing.Point(169, 56);
            this.TXT_Documento.Margin = new System.Windows.Forms.Padding(2);
            this.TXT_Documento.Name = "TXT_Documento";
            this.TXT_Documento.Size = new System.Drawing.Size(183, 20);
            this.TXT_Documento.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo de documento";
            // 
            // cbx_Cliente
            // 
            this.cbx_Cliente.FormattingEnabled = true;
            this.cbx_Cliente.Location = new System.Drawing.Point(544, 96);
            this.cbx_Cliente.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_Cliente.Name = "cbx_Cliente";
            this.cbx_Cliente.Size = new System.Drawing.Size(182, 21);
            this.cbx_Cliente.TabIndex = 7;
            // 
            // TXT_Buscar_Producto
            // 
            this.TXT_Buscar_Producto.Location = new System.Drawing.Point(169, 94);
            this.TXT_Buscar_Producto.Margin = new System.Windows.Forms.Padding(2);
            this.TXT_Buscar_Producto.Name = "TXT_Buscar_Producto";
            this.TXT_Buscar_Producto.Size = new System.Drawing.Size(183, 20);
            this.TXT_Buscar_Producto.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Buscar producto";
            // 
            // txt_Codigo_Producto
            // 
            this.txt_Codigo_Producto.Location = new System.Drawing.Point(53, 253);
            this.txt_Codigo_Producto.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Codigo_Producto.Name = "txt_Codigo_Producto";
            this.txt_Codigo_Producto.Size = new System.Drawing.Size(183, 20);
            this.txt_Codigo_Producto.TabIndex = 11;
            // 
            // txt_Nombre_Producto
            // 
            this.txt_Nombre_Producto.Location = new System.Drawing.Point(249, 253);
            this.txt_Nombre_Producto.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Nombre_Producto.Name = "txt_Nombre_Producto";
            this.txt_Nombre_Producto.Size = new System.Drawing.Size(183, 20);
            this.txt_Nombre_Producto.TabIndex = 12;
            // 
            // txt_Precio_Producto
            // 
            this.txt_Precio_Producto.Location = new System.Drawing.Point(456, 253);
            this.txt_Precio_Producto.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Precio_Producto.Name = "txt_Precio_Producto";
            this.txt_Precio_Producto.Size = new System.Drawing.Size(183, 20);
            this.txt_Precio_Producto.TabIndex = 13;
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(663, 253);
            this.txt_Cantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(183, 20);
            this.txt_Cantidad.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(660, 227);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 227);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Precio de Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 227);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nombre de Producto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 227);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Codigo de Producto";
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 477);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.txt_Precio_Producto);
            this.Controls.Add(this.txt_Nombre_Producto);
            this.Controls.Add(this.txt_Codigo_Producto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXT_Buscar_Producto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbx_Cliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXT_Documento);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbx_TipoDocumento);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVenta";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbx_TipoDocumento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TXT_Documento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_Cliente;
        private System.Windows.Forms.TextBox TXT_Buscar_Producto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Codigo_Producto;
        private System.Windows.Forms.TextBox txt_Nombre_Producto;
        private System.Windows.Forms.TextBox txt_Precio_Producto;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}