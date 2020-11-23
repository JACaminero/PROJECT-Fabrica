using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJECT_Fabrica.Data;
using PROJECT_Fabrica.Repo;

namespace PROJECT_Fabrica.View.StockView
{
    public partial class FrmChooseArea : Form
    {
        public FrmChooseArea()
        {
            InitializeComponent();
        }

        private void FrmChooseArea_Load(object sender, EventArgs e)
        {

        }
        public static bool IsCancelled { get; set; }

        static RepArea repArea = new RepArea();
        static Stock stock = new Stock();

        public void FrmChooseArea_Load(object sender, EventArgs e, Stock detStock)
        {
            stock = detStock;
            List<Almacen> listAlmacen = repArea.GetListAlm();

            CBAlmacen.ValueMember = "ID_Almacen";
            CBAlmacen.DisplayMember = "nombreAlmacen";
            CBAlmacen.DataSource = listAlmacen;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            
            stock.ID_Area = Convert.ToInt32(CBArea.SelectedValue);
            IsCancelled = false;
            this.Close();
        }

        private void CBAlmacen_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Area> listArea = repArea.GetListArea((int)CBAlmacen.SelectedValue);

            CBArea.ValueMember = "ID_Area";
            CBArea.DisplayMember = "nombreArea";
            CBArea.DataSource = listArea;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            IsCancelled = true;
        }
    }
}
