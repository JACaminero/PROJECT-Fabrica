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

namespace PROJECT_Fabrica.View
{
    public partial class FrmStock : Form
    {
        public FrmStock()
        {
            InitializeComponent();
        }

        private void FrmStock_Load(object sender, EventArgs e)
        {

        }

        //static FrmStock frmStock = FrmStock.;-
        public void FrmStock_Load(object sender, EventArgs e, Trabajador supv)
        {
            string nombre = supv.nombre + " " + supv.apellido;
            TxtUsuario.Text = nombre;
            ucEntradaStock1.UCEntradaStock_Load(sender, e, supv);
            ucSalidaStock1.UCSalidaStock_Load(sender, e, supv);
        }


        private void BtnEntrada_Click(object sender, EventArgs e)
        {
            ucSalidaStock1.Visible = false;
            LBHeader.Text = "Entrada de Mercancia";
            ucEntradaStock1.Visible = true;
        }

        private void BtnSalida_Click(object sender, EventArgs e)
        {
            //foreach (UserControl UC in this.Controls)
            //{
            //    UC.Visible = false;
            //}
            ucEntradaStock1.Visible = false;
            LBHeader.Text = "Salida de Mercancia";
            ucSalidaStock1.Visible = true;
        }

        private void BtnCloseSession_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Inicio().Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
