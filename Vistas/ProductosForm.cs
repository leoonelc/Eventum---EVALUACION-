using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Eventum.Controladores;
using Eventum.Modelos;

namespace Eventum.Vistas
{
    public partial class ProductosForm : Form
    {
        private ProductoController _productoController;
        private List<Producto> _productos;

        public ProductosForm()
        {
            InitializeComponent();
            _productoController = new ProductoController();
        }

        private void ProductosForm_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            // Cargar productos disponibles desde la base de datos
            _productos = _productoController.ListarProductos();
            dgvProductos.DataSource = _productos; // Mostrar productos en el DataGridView
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text) || string.IsNullOrWhiteSpace(txtPrecioProducto.Text))
            {
                MessageBox.Show("Por favor, ingresa todos los datos correctamente.");
                return; // No continua con el proceso de agregar el producto
            }
            // Agregar un nuevo producto

            Producto nuevoProducto = new Producto
            {
                Nombre = txtNombreProducto.Text,
                Precio = Convert.ToDecimal(txtPrecioProducto.Text)
            };

            bool exito = _productoController.AgregarProducto(nuevoProducto);
            if (exito)
            {
                MessageBox.Show("Producto agregado con éxito.");
                CargarProductos();
            }
            else
            {
                MessageBox.Show("Hubo un error al agregar el producto.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Editar producto seleccionado
            if (dgvProductos.SelectedRows.Count > 0)
            {
                var fila = dgvProductos.SelectedRows[0];
                var productoId = Convert.ToInt32(fila.Cells["Id"].Value);
                Producto productoSeleccionado = _productos.Find(p => p.Id == productoId);

                productoSeleccionado.Nombre = txtNombreProducto.Text;
                productoSeleccionado.Precio = Convert.ToDecimal(txtPrecioProducto.Text);

                bool exito = _productoController.ActualizarProducto(productoSeleccionado);
                if (exito)
                {
                    MessageBox.Show("Producto actualizado con éxito.");
                    CargarProductos();
                }
                else
                {
                    MessageBox.Show("Hubo un error al actualizar el producto.");
                }
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            // Quitar producto seleccionado
            if (dgvProductos.SelectedRows.Count > 0)
            {
                var fila = dgvProductos.SelectedRows[0];
                var productoId = Convert.ToInt32(fila.Cells["Id"].Value);

                bool exito = _productoController.EliminarProducto(productoId);
                if (exito)
                {
                    MessageBox.Show("Producto eliminado con éxito.");
                    CargarProductos();
                }
                else
                {
                    MessageBox.Show("Hubo un error al eliminar el producto.");
                }
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerrar formulario actual
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Salir de la aplicación
        }
    }
}
