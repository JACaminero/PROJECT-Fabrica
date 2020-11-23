using System;
using System.Windows.Forms;
using PROJECT_Fabrica.View;
using PROJECT_Fabrica.Data;

namespace PROJECT_Fabrica
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
       
        public static Trabajador usuarioConectado { get; set; }
        public void FrmAdmin_Load(object sender, EventArgs e, Trabajador admin)
        {
            usuarioConectado = admin;
            TxtUsuario.Text = admin.nombre + " " + admin.apellido;
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            UCRegistrar.Visible = true;
            
            //FrmRegistrar frmreg = new FrmRegistrar();
            //frmreg.Show();
            //frmreg.FrmRegistrar_Load(sender, e, usuarioConectado);
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            new Inicio().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UCRegistrar_Load(object sender, EventArgs e)
        {

        }
    }
}
