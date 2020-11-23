using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJECT_Fabrica.Resources;
using PROJECT_Fabrica.Data;
using PROJECT_Fabrica.Repo;

namespace PROJECT_Fabrica.View.StockView
{
    public partial class UCEntradaStock : UserControl
    {
        public UCEntradaStock()
        {
            InitializeComponent();
        }

        static RepRef repRef = new RepRef();
        static BindingList<DetalleReferencia> listDetalle = new BindingList<DetalleReferencia>();
        static Referencia referencia = new Referencia();
        static Stock stock = new Stock();
        static Trabajador supv = new Trabajador();

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            DetalleReferencia detref = new DetalleReferencia();

            if (TxtRoyoPeso.Value != 0 || TxtRoyoCant.Value != 0 || 
                !String.IsNullOrWhiteSpace(TxtDescripcion.Text))
            {
                detref.cantRoyo = Convert.ToInt32(TxtRoyoCant.Text);
                detref.pesoRoyo = Convert.ToInt32(TxtRoyoPeso.Text);
                detref.descripcionDis = TxtDescripcion.Text;
                //detref.fotoDesign = PBColor.ImageLocation;
                

                TxtRoyoPeso.Value = 0;
                TxtDescripcion.Clear();
                TxtRoyoCant.Value = 0;

                stock.cantRoyo = detref.cantRoyo;
                stock.inStock = true;
                FrmChooseArea frmChoose = new FrmChooseArea();
                frmChoose.FrmChooseArea_Load(sender, e, stock);
                frmChoose.ShowDialog();
                bool IsCanceled = FrmChooseArea.IsCancelled;

                if (IsCanceled == false)
                {
                    listDetalle.Add(detref);
                    DGVStock.DataSource = listDetalle;
                }
            }
            else
            {
                MessageBox.Show("Por favor complete todos los campos");
            }

        }

        private void BtnDetallarRef_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(TxtReferencia.Text))
            {
                referencia.referencia1 = TxtReferencia.Text;
                DGVStock.DataSource = listDetalle;
                TxtReferencia.ReadOnly =  true;
                panel1.Visible = true;
                DGVStock.Visible = true;
                BtnGuardar.Visible = true;
                BtnEliminiar.Visible = true;
            }
            
            else
            {
                MessageBox.Show("Introduzca una referencia");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            MessageBoxManager.Yes = "Si";
            MessageBoxManager.Register();
            if (!String.IsNullOrEmpty(TxtReferencia.Text) || !String.IsNullOrWhiteSpace(TxtReferencia.Text))
            {
                DialogResult dialog = MessageBox.Show("¿Está seguro que deseas cancelar esta operacion?", "Atencion", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    panel1.Visible = false;
                    DGVStock.Visible = false;
                    BtnGuardar.Visible = false;
                    BtnEliminiar.Visible = false;
                    ClearForm();
                }
            }
        }

        private void ClearForm()
        {
            TxtReferencia.Clear();
            TxtReferencia.ReadOnly = false;
            TxtDescripcion.Clear();
            TxtRoyoCant.Value = 0;
            TxtRoyoPeso.Value = 0;

            referencia = new Referencia();
            listDetalle = new BindingList<DetalleReferencia>();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            referencia.ID_Trabajador = supv.ID_Trabajador;
            repRef.Insert(referencia);

            if (listDetalle.Count >= 0)
            {
                foreach (DetalleReferencia detalle in listDetalle)
                {
                    detalle.ID_Referencia = referencia.ID_Referencia;
                    repRef.Insert(detalle);
                    
                    stock.ID_Detalle = detalle.ID_Detalle;
                    repRef.Insert(stock);
                }
            }
            else
            {
                MessageBox.Show("Inserte algun registro en la tabla");
            }
            panel1.Visible = false;
            DGVStock.Visible = false;
            BtnGuardar.Visible = false;
            BtnEliminiar.Visible = false;
            ClearForm();
        }

        private void BtnEliminiar_Click(object sender, EventArgs e)
        {
            if (listDetalle.Count >= 1)
            {
                DGVStock.Rows[0].Selected = true;
                DetalleReferencia dstock = (DetalleReferencia)DGVStock.CurrentRow.DataBoundItem;

                listDetalle.Remove(dstock);
                DGVStock.DataSource = listDetalle;
            }
        }

        public void UCEntradaStock_Load(object sender, EventArgs e, Trabajador trab)
        {
            supv = trab;
            TxtRoyoCant.Controls[0].Visible = false;
            TxtRoyoPeso.Controls[0].Visible = false;
            TxtRoyoPeso.Maximum = 2000000;
            TxtRoyoCant.Maximum = 2000000;
            //Image image = Image.FromFile(@"C:\Users\DELL\Desktop\FABRICA\PROJECT-Fabrica\PROJECT-Fabrica\DesignPhoto\ClickAqui.png");
            PBColor.Image = Resources.Resources.ClickAqui;
            PBColor.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void UCEntradaStock_Load(object sender, EventArgs e)
        {

        }

        private void DGVStock_DataSourceChanged(object sender, EventArgs e)
        {
            if (listDetalle.Count != 0)
            {
                DGVStock.Rows[0].Selected = true;
            }
                DGVStock.Columns[0].Visible = false;
                //DGVStock.Columns[6].Visible = false;
                //DGVStock.Columns[7].Visible = false;
                //DGVStock.Columns[8].Visible = false;
                //DGVStock.Columns[9].Visible = false;
                //DGVStock.Columns[10].Visible = false;

                DGVStock.Columns[1].HeaderText = "Cantidad";
                DGVStock.Columns[2].HeaderText = "Peso(libra)";
                DGVStock.Columns[3].HeaderText = "Descripcion";
        }

        private void PBColor_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                file.ShowDialog();
                string path = file.FileName;

                if (!string.IsNullOrWhiteSpace(path))
                {
                    Image image = Image.FromFile(path);
                    PBColor.Image = image;
                    PBColor.ImageLocation = path;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("$La imagen no pudo ser procesada.\n" +
                    "Presione el boton 'borrar imagen', e inserte el \n" +
                    "registro sin la imagen", "Error Fatal");
            }
        }
    }
}
    