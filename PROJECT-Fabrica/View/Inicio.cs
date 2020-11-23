using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJECT_Fabrica.Repo;
using PROJECT_Fabrica.Data;

namespace PROJECT_Fabrica.View
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        RepoTrabajador repTrabajador = new RepoTrabajador();

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Trabajador account = repTrabajador.Authentication(TxtUsuario.Text, MTxtPassword.Text);

            if (account != null)
            {
                if (account.ID_Admin != null)
                {
                    FrmAdmin frmadmin = new FrmAdmin();
                    frmadmin.Show();
                    frmadmin.FrmAdmin_Load(sender, e, account);
                }
                //else if (account.ID_Supervisor != null)
                //{
                //    FrmStock frmStock = new FrmStock();
                //    frmStock.Show();
                //    frmStock.FrmStock_Load(sender, e, account);
                //}
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta. \nIntente de nuevo");
            }
        }
    }   
}
