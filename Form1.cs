using Licorera.CapaDatos;
using Licorera.CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Licorera
{
    public partial class Form1 : Form
    {
        BLLProductos objetoCN = new BLLProductos();
        public Form1()
        {
            InitializeComponent();
        }

        private void VerListaProductos()
        {
            BLLProductos objetoCN = new BLLProductos();
            Listadedatos.DataSource = objetoCN.View();

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (camposVacios())
                return;

            objetoCN.Create(int.Parse(textBoxCod.Text), float.Parse(textBoxValor.Text), textBoxProd.Text, textBoxDescripcion.Text, int.Parse(txtCantidad.Text));
            MessageBox.Show("Producto guardado y archivo actualizado con éxito");
            VerListaProductos();
            Listadedatos.Refresh();
            textBoxCod.Clear();
            textBoxDescripcion.Clear();
            textBoxProd.Clear();
            textBoxValor.Clear();
            txtCantidad.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VerListaProductos();
            Listadedatos.Refresh();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (camposVacios())
                return;

            objetoCN.Delete(int.Parse(textBoxCod.Text));
            MessageBox.Show("Producto eliminado con éxito");
            VerListaProductos();
            textBoxCod.Clear();
            textBoxDescripcion.Clear();
            textBoxProd.Clear();
            textBoxValor.Clear();
            txtCantidad.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (camposVacios())
                return;

            objetoCN.Update(int.Parse(textBoxCod.Text), float.Parse(textBoxValor.Text), textBoxProd.Text, textBoxDescripcion.Text, int.Parse(txtCantidad.Text));
            MessageBox.Show("Se actualizo correctamente el producto");
            VerListaProductos();
            textBoxCod.Clear();
            textBoxDescripcion.Clear();
            textBoxProd.Clear();
            textBoxValor.Clear();
            txtCantidad.Clear();
        }

        
        private void btnVender_Click(object sender, EventArgs e)
        {


            if (Listadedatos.SelectedRows.Count != 0)
            {
               
                int cantidad = Convert.ToInt32(Listadedatos.SelectedRows[0].Cells[4].Value.ToString()); 


                if (Convert.ToInt32(cantidad) > 0)
                {
                    int cantfinal = cantidad - Convert.ToInt32(txtCantidad.Text);

                    if (cantfinal < 0)
                    {
                        MessageBox.Show($"Solo hay {cantidad} unidades disponibles");
                        return;
                    }
                    
                    DALProductos DAL = new DALProductos();
                    DAL.UpdateProduct(Convert.ToInt32(Listadedatos.SelectedRows[0].Cells[0].Value),
                        Convert.ToInt32(Listadedatos.SelectedRows[0].Cells[1].Value),
                        Listadedatos.SelectedRows[0].Cells[2].Value.ToString(),
                        Listadedatos.SelectedRows[0].Cells[3].Value.ToString(),
                        Convert.ToInt32(cantfinal));

                    VerListaProductos();
                    Listadedatos.Refresh();
                    
                    MessageBox.Show("Venta exitosa, inventario actualizado");

                    txtCantidad.Clear();
                    textBoxCod.Clear();
                    textBoxDescripcion.Clear();
                    textBoxProd.Clear();
                    textBoxValor.Clear();
                    
                }
                else
                {
                    MessageBox.Show("No hay unidades disponibles");
                }
            }
        }

        private void Listadedatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCantidad.Text = Listadedatos.SelectedRows[0].Cells[4].Value.ToString();
            textBoxCod.Text = Listadedatos.SelectedRows[0].Cells[0].Value.ToString();
            textBoxValor.Text = Listadedatos.SelectedRows[0].Cells[1].Value.ToString();
            textBoxProd.Text = Listadedatos.SelectedRows[0].Cells[2].Value.ToString();
            textBoxDescripcion.Text = Listadedatos.SelectedRows[0].Cells[3].Value.ToString();

        }

        private bool camposVacios()
        {
            if (String.IsNullOrEmpty(txtCantidad.Text) || (String.IsNullOrEmpty(textBoxCod.Text)) || (String.IsNullOrEmpty(textBoxValor.Text)) ||
                (String.IsNullOrEmpty(textBoxProd.Text)) || (String.IsNullOrEmpty(textBoxDescripcion.Text)))
            {
                return true;
            }
            return false;
        }
    }
}