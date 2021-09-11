using Domain.Entitys;
using Domain.Enums;
using Infraestructura.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductosAppM1.Forms
{
    public partial class FrmProducto : Form
    {
        public ProductoModel pModel { get; set; }
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Product p = new Product()
            {
                Id = pModel.GetLastProductId() + 1,
                Nombre = txtName.Text,
                Descripcion = txtDes.Text,
                Existencia = (int)nudExistence.Value,
                Precio = nudPrice.Value,
                FechaDeVencimiento = dtpCaducity.Value,
                UnidadDeMedida = (UnidadDeMedida)cmbMeasurent.SelectedIndex
            };

            pModel.Add(p);

            Dispose();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            cmbMeasurent.Items.AddRange(Enum.GetValues(typeof(UnidadDeMedida))
                                              .Cast<object>().ToArray()
                                         );
        }
    }
}
