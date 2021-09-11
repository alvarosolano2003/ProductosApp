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
    public partial class FrmProductManage : Form
    {
        private ProductoModel productoModel;
        private Product[] arr;
        public FrmProductManage()
        {
            productoModel = new ProductoModel();
            InitializeComponent();
        }

        private void FrmProductManage_Load(object sender, EventArgs e)
        {
            cmbMeasureUnit.Items.AddRange(Enum.GetValues(typeof(UnidadDeMedida))
                                              .Cast<object>().ToArray()
                                         );
        }

        private void CmbFinder_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbFinder.SelectedIndex)
            {
                case 0:
                    pnlFinByID.Visible = true;
                    pnlCaducity.Visible = false;
                    pnlMeasurentUnit.Visible = false;
                    pnlPrice.Visible = false;
                    break;

                case 1:
                    pnlFinByID.Visible = false;
                    pnlCaducity.Visible = false;
                    pnlMeasurentUnit.Visible = true;
                    pnlPrice.Visible = false;
                    break;

                case 2:
                    pnlFinByID.Visible = false;
                    pnlCaducity.Visible = false;
                    pnlMeasurentUnit.Visible = false;
                    pnlPrice.Visible = true;
                    break;

                case 3:
                    pnlFinByID.Visible = false;
                    pnlCaducity.Visible = true;
                    pnlMeasurentUnit.Visible = false;
                    pnlPrice.Visible = false;
                    break;
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            string aux = string.Empty;
            FrmProducto frmProducto = new FrmProducto();
            frmProducto.pModel = productoModel;
            frmProducto.ShowDialog();

            arr = productoModel.GetAll();

            for (int i = 0; i < arr.Length; i++)
            {
                aux = $@"{aux}
                         {productoModel.GetProductosAsJson(arr[i])}
                         ";
            }

            rtbProductView.Text = aux;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmChange frmChange = new FrmChange();
            frmChange.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FrmChange frmChange = new FrmChange();
            frmChange.Show();
        }
    }
}
