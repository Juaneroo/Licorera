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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objetoCN.Create(int.Parse(textBoxCod.Text), float.Parse(textBoxValor.Text), textBoxProd.Text, textBoxDescripcion.Text);
            MessageBox.Show("Producto guardado con éxito");
            
        }
    }
}