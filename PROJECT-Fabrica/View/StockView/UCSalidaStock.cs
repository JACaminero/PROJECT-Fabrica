using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJECT_Fabrica.Data;
using PROJECT_Fabrica.Repo;

namespace PROJECT_Fabrica.View
{
    public partial class UCSalidaStock : UserControl
    {
        public UCSalidaStock()
        {
            InitializeComponent();
        }

        static RepRef repref = new RepRef();
        static RepArea repArea = new RepArea();
        static RepLote repLote = new RepLote();
        static Stock stock = new Stock();

        private void TxtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void UCSalidaStock_Load(object sender, EventArgs e)
        {
            List<Almacen> listAlmacen = repArea.GetListAlm();

            CBAlmacen.ValueMember = "ID_Almacen";
            CBAlmacen.DisplayMember = "nombreAlmacen";
            CBAlmacen.DataSource = listAlmacen;
            //CBAlmacen.Items.Insert(0, "");

            DGVStock.DataSource = repref.GetStock();

            if (repLote.GetLast() != null)
            {
                Lote lote = repLote.GetLast();
                TxtLote.Text = lote.numLote++.ToString();
            }
            else
            {
                TxtLote.Text = "1";
            }
        }

        public void UCSalidaStock_Load(object sender, EventArgs e, Trabajador trab)
        {
            List<Almacen> listAlmacen = repArea.GetListAlm();

            CBAlmacen.ValueMember = "ID_Almacen";
            CBAlmacen.DisplayMember = "nombreAlmacen";
            CBAlmacen.DataSource = listAlmacen;

            DGVStock.DataSource = repref.GetStock();

            if (repLote.GetLast() != null)
            {
                Lote lote = repLote.GetLast();
                TxtLote.Text = lote.numLote++.ToString();
            }
            else
            {
                TxtLote.Text = "1";
            }
        }

        private void DGVStock_DataSourceChanged(object sender, EventArgs e)
        {
            if (DGVStock.RowCount != 0)
            {
                DGVStock.Rows[0].Selected = true;
            }
        }

        private void CBAlmacen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBAlmacen.Text != "")
            {
                List<Area> listArea = repArea.GetListArea((int)CBAlmacen.SelectedValue);

                CBArea.ValueMember = "ID_Area";
                CBArea.DisplayMember = "nombreArea";
                CBArea.DataSource = listArea;
                //CBArea.Items.Insert(0, "");
            }
        }

        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            DGVStock.DataSource = repref.GetStock();
            CBArea.SelectedIndex = 0;
            CBAlmacen.SelectedIndex = 0;
        }

        private void DGVStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            stock = (Stock)DGVStock.CurrentRow.DataBoundItem;

            TxtRef.Text = stock.DetalleReferencia.Referencia.referencia1;
            TxtExistencia.Text = stock.cantRoyo.ToString();
            TxtDescrip.Text = stock.DetalleReferencia.descripcionDis;
            LBAlmacen.Text = "Almacen: " + stock.Area.Almacen.nombreAlmacen;
            LBArea.Text = "Area: " + stock.Area.nombreArea;
        }

        private void CBArea_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CBArea.Text != "")
            {
                DGVStock.DataSource = repref.GetStock((int)CBArea.SelectedValue);
            }
        }

        private void DGVStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnLote_Click(object sender, EventArgs e)
        {
            Lote lote = new Lote();

            if (stock.cantRoyo > 0)
            {
                lote.cantLote = Convert.ToInt32(TxtRoyoCant.Value);
                lote.ID_Detalle = stock.DetalleReferencia.ID_Detalle;
                lote.numLote = Convert.ToInt32(TxtLote.Text);
                //lote.ID_Trabajador
            }
            else
            {
                MessageBox.Show($"Actualmente solo existen {stock.cantRoyo} en existencia");
            }
        }
    }
}
