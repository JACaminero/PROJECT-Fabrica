﻿using PROJECT_Fabrica.Data;
using PROJECT_Fabrica.Repo;
using PROJECT_Fabrica.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PROJECT_Fabrica.View
{
    public partial class FrmRegistrar : FrmAdmin
    {
        public FrmRegistrar()
        {
            InitializeComponent();
        }
        private static RepoTrabajador repoTrabajador = new RepoTrabajador();
        private static RepAdmin repAdmin = new RepAdmin();
        private static List<Rol> listRol = repoTrabajador.GetRols();
        private static List<Departamento> listDepart = repoTrabajador.GetDepart();
        
        public void FrmRegistrar_Load(object sender, EventArgs e)
        {
            DataGVTrabajador.DataSource = repoTrabajador.Get();
            TxtUsuario.Visible = true;
            TxtUsuario.Text = usuarioConectado.Administrativo.usuario;
            RBTrabajador.Checked = true;
            List<string> listnombreRol = new List<string>();
            foreach (var rol in listRol)
            {
                listnombreRol.Add(rol.nombreRol);
            }
            CBRol.DataSource = listnombreRol;

            List<string> listnombreDepart = new List<string>();
            foreach (var depart in listDepart)
            {
                listnombreDepart.Add(depart.nombreDep);
            }
            CBDepart.DataSource = listnombreDepart;

            DataGVTrabajador.Columns[0].Visible = false;
            DataGVTrabajador.Columns[5].Visible = false;
            DataGVTrabajador.Columns[4].Visible = false;
            DataGVTrabajador.Columns[6].Visible = false;
            DataGVTrabajador.Columns[7].Visible = false;
            DataGVTrabajador.Columns[10].Visible = false;
            DataGVTrabajador.Columns[12].Visible = false;
            DataGVTrabajador.Columns[13].Visible = false;
            DataGVTrabajador.Columns[14].Visible = false;
            DataGVTrabajador.Columns[15].Visible = false;

            DataGVTrabajador.Columns[8].DisplayIndex = 3;
            DataGVTrabajador.Columns[9].DisplayIndex = 0;

            DataGVTrabajador.Columns[1].HeaderText = "Nombre";
            DataGVTrabajador.Columns[2].HeaderText = "Apellidos";
            DataGVTrabajador.Columns[3].HeaderText = "Telefono";
            DataGVTrabajador.Columns[8].HeaderText = "Cedula";
            DataGVTrabajador.Columns[9].HeaderText = "Codigo";
            DataGVTrabajador.Columns[11].HeaderText = "Cargo";

            TxtNombre.MaxLength = 50;
            TxtApellido.MaxLength = 60;
            TxtConfirmar.MaxLength = 30;
            TxtContrasena.MaxLength = 30;
            TxtUser.MaxLength = 30;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (MTxtCedula.Text != "   -       - " || MTxtCedula.Text != "" 
                || !string.IsNullOrEmpty(TxtApellido.Text) || !string.IsNullOrEmpty(TxtNombre.Text))
            {
                Trabajador trabajador = new Trabajador();
                string nombre = TxtNombre.Text.Trim();
                string apellido = TxtApellido.Text.Trim();
                trabajador.telefono = TxtTelefono.Text;
                List<string> uniquecedula = (from empleado in repoTrabajador.Get()
                                             select empleado.cedula).ToList();
                if (uniquecedula.Count != 0)
                {
                    foreach (string cedula in uniquecedula)
                    {
                        if (cedula == MTxtCedula.Text)
                        {
                            MessageBox.Show("La cedula ingresada ya existe en el sistema.\n" +
                                " Verifique que la cedula es correcta y reintente la operacion");
                            return;
                        }
                        else
                        {
                            if (MTxtCedula.Text.Trim().Length == 13)
                            {
                                trabajador.cedula = MTxtCedula.Text;
                            }
                            else
                            {
                                MessageBox.Show("La cedula insertada esta incompleta");
                                return;
                            }
                        }
                    }
                }
                else
                {
                    trabajador.cedula = MTxtCedula.Text;
                }

                trabajador.nombre = char.ToUpper(nombre[0]) + nombre.Substring(1);
                trabajador.apellido = char.ToUpper(apellido[0]) + apellido.Substring(1);
                var idrol = (from rol in listRol
                             where rol.nombreRol == CBRol.Text
                             select rol.ID_Rol).SingleOrDefault();
                trabajador.Rol = idrol;

                var idDep = (from depart in listDepart
                             where depart.nombreDep == CBDepart.Text
                             select depart.ID_Departamento).SingleOrDefault();
                trabajador.ID_Departamento = idDep;
                CBRol.Visible = true;

                if (RBTrabajador.Checked == true)
                {
                    trabajador.permiso = "Trabajador";
                }

                else if (RBAdmin.Checked == true)
                {
                    Administrativo admin = new Administrativo();
                    List<Administrativo> uniqueuseradmin = repAdmin.Get();
                    if (uniqueuseradmin.Count != 0)
                    {
                        foreach (var usuario in repAdmin.Get())
                        {

                            if (usuario.usuario == TxtUser.Text)
                            {
                                MessageBox.Show("El usuario ya existe. Intente otro nombre");
                                return;
                            }
                            else
                            {
                                admin.usuario = TxtUser.Text;
                            }
                        }
                    }
                    else
                        admin.usuario = TxtUser.Text;

                    if (TxtConfirmar.Text == TxtContrasena.Text && TxtContrasena.TextLength >= 5)
                    {
                        admin.contrasena = TxtContrasena.Text;
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden o son muy cortas " +
                            "(5 caracteres como minimo), intente denuevo");
                    }

                    trabajador.permiso = "Administrador";
                    repAdmin.Registrar(admin);
                    trabajador.ID_Departamento = null;
                    trabajador.Rol = null;
                    CBRol.Visible = false;
                    trabajador.ID_Admin = admin.ID_Admin;
                }
                else if (RBSuperv.Checked == true)
                {
                    //Supervisor superv = new Supervisor();
                    //List<Supervisor> uniqueusersuperv = repsuperv.Get();
                    //if (uniqueusersuperv.Count != 0)
                    //{
                    //    foreach (var usuario in repsuperv.Get())
                    //    {
                    //        if (usuario.usuario == TxtUser.Text)
                    //        {
                    //            MessageBox.Show("El usuario ya existe. Intente otra vez");
                    //            return;
                    //        }
                    //        else
                    //            superv.usuario = TxtUser.Text;
                    //    }
                }
                
                DataGVTrabajador.DataSource = repoTrabajador.Get();
                MessageBox.Show("Operacion completada exitosamente");
            }
            else
            {
                MessageBox.Show("Los campos 'Nombre', 'Apellido' y 'Cedula' no pueden estar vacios");
            }
        }

        private void BtnQueryID_Click(object sender, EventArgs e)
        {
            if (repoTrabajador.Get(TxtQueryID.Text.ToLower()) == null)
            {
                MessageBox.Show("No existe ningun trabajador que posea ese codigo");
                DataGVTrabajador.DataSource = repoTrabajador.Get();
            }
            else
                DataGVTrabajador.DataSource = repoTrabajador.Get(TxtQueryID.Text.ToLower());
        }

        private void TxtQueryNombre_TextChanged(object sender, EventArgs e)
        {
            DataGVTrabajador.DataSource = repoTrabajador.GetWithNom(TxtQueryNombre.Text.ToLower());
        }

        private void BtnQueryNombre_Click(object sender, EventArgs e)
        {
            if (repoTrabajador.Get(TxtQueryID.Text.ToLower()) == null)
            {
                MessageBox.Show("No existe ningun trabajador que posea ese nombre o apellido");
                DataGVTrabajador.DataSource = repoTrabajador.Get();
            }
            else
                DataGVTrabajador.DataSource = repoTrabajador.GetWithNom(TxtQueryNombre.Text.ToLower());
        }

        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            DataGVTrabajador.DataSource = repoTrabajador.Get();
            TxtQueryID.Clear();
            TxtQueryNombre.Clear();
            DataGVTrabajador.Columns[8].DisplayIndex = 3;
        }

        private void RBAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (RBAdmin.Checked == true)
            {
                LBConfirm.Visible = true;
                LbContra.Visible = true;
                LBUser.Visible = true;
                TxtUser.Visible = true;
                TxtContrasena.Visible = true;
                TxtConfirmar.Visible = true;
                LBDepart.Visible = false;
                CBDepart.Visible = false;
                CBRol.Visible = false;
                lbRol.Visible = false;
            }
        }

        private void RBSuperv_CheckedChanged(object sender, EventArgs e)
        {
            if (RBSuperv.Checked == true)
            {
                LBConfirm.Visible = true;
                LbContra.Visible = true;
                LBUser.Visible = true;
                TxtUser.Visible = true;
                TxtContrasena.Visible = true;
                TxtConfirmar.Visible = true;
                LBDepart.Visible = true;
                CBDepart.Visible = true;
                CBRol.Visible = false;
                lbRol.Visible = false;
            }            
        }

        private void RBTrabajador_CheckedChanged(object sender, EventArgs e)
        {
            if (RBTrabajador.Checked == true)
            {
                LBConfirm.Visible = false;
                LbContra.Visible = false;
                LBUser.Visible = false;
                TxtUser.Visible = false;
                TxtContrasena.Visible = false;
                TxtConfirmar.Visible = false;
                LBDepart.Visible = true;
                CBDepart.Visible = true;
                CBRol.Visible = true;
                lbRol.Visible = true;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string message = ($"¿Estas seguro que deseas " +
                         $"desactivar al usuario {TxtNombre.Text} {TxtApellido.Text}  del sistema?");
            DialogResult result = MessageBox.Show(message,
                         "Confirmar", MessageBoxButtons.YesNo);

            Resources.MessageBoxManager.Yes = "Si";
            MessageBoxManager.No = "No";

            if (result == DialogResult.Yes)
            {
                if (MTxtCedula.Text != "   -       - " || MTxtCedula.Text != ""
                || !string.IsNullOrEmpty(TxtApellido.Text) || !string.IsNullOrEmpty(TxtNombre.Text))
                {
                    repoTrabajador.Eliminate(TxtCodigo.Text);
                }
                else
                {
                    MessageBox.Show("Seleccione el empleado que desea eliminar");
                }
            }
            BtnShowAll_Click(sender, e);
        }

        private void DataGVTrabajador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Trabajador selected = (Trabajador)DataGVTrabajador.CurrentRow.DataBoundItem;

            MTxtCedula.ReadOnly = true;
            TxtCodigo.Text = selected.codigo;
            TxtNombre.Text = selected.nombre;
            TxtApellido.Text = selected.apellido;
            TxtTelefono.Text = selected.telefono;
            MTxtCedula.Text = selected.cedula;

            if (selected.permiso == "Administrador")
            {
                LBConfirm.Visible = false;
                LbContra.Visible = false;
                LBUser.Visible = false;
                TxtUser.Visible = false;
                TxtContrasena.Visible = false;
                TxtConfirmar.Visible = false;
                LBDepart.Visible = false;
                CBDepart.Visible = false;
                CBRol.Visible = false;
                lbRol.Visible = false;
            }
            else if (selected.permiso == "Supervisor")
            {
                CBDepart.Text = selected.Departamento.nombreDep;
                LBConfirm.Visible = false;
                LbContra.Visible = false;
                LBUser.Visible = false;
                TxtUser.Visible = false;
                TxtContrasena.Visible = false;
                TxtConfirmar.Visible = false;
                LBDepart.Visible = true;
                CBDepart.Visible = true;
                CBRol.Visible = false;
                lbRol.Visible = false;
            }
            else if (selected.permiso == "Trabajador")
            {
                CBDepart.Text = selected.Departamento.nombreDep;
                CBRol.Text = selected.Rol1.nombreRol;
                CBRol.Visible = true;
                CBDepart.Visible = true;
                LBDepart.Visible = true;
                lbRol.Visible = true;
                LBConfirm.Visible = false;
                LbContra.Visible = false;
                LBUser.Visible = false;
                TxtUser.Visible = false;
                TxtContrasena.Visible = false;
                TxtConfirmar.Visible = false;
            }    
        }

        private void BtnModif_Click(object sender, EventArgs e)
        {

            if (MTxtCedula.Text != "   -       - " || MTxtCedula.Text != ""
                || !string.IsNullOrEmpty(TxtApellido.Text) || !string.IsNullOrEmpty(TxtNombre.Text))
            {
                Trabajador trabajador = (Trabajador)DataGVTrabajador.CurrentRow.DataBoundItem;
                //Trabajador trab = repoTrabajador.GetSingle(TxtCodigo.Text);
                //Trabajador trab = new Trabajador();
                string nombre = TxtNombre.Text.Trim();
                string apellido = TxtApellido.Text.Trim();
                trabajador.telefono = TxtTelefono.Text;
                trabajador.nombre = char.ToUpper(nombre[0]) + nombre.Substring(1);
                trabajador.apellido = char.ToUpper(apellido[0]) + apellido.Substring(1);

                if (TxtCodigo.Text != "")
                {
                    if (trabajador.permiso == "Administrador")
                    {
                        trabajador.Departamento = null;
                        trabajador.Rol = null;
                        repoTrabajador.Modificar(trabajador);
                    }
                    else if (trabajador.permiso == "Supevisor")
                    {
                        trabajador.Rol = null;
                        var idDep = (from depart in listDepart
                                     where depart.nombreDep == CBDepart.Text
                                     select depart.ID_Departamento).SingleOrDefault();
                        trabajador.ID_Departamento = idDep;

                        repoTrabajador.Modificar(trabajador);                      
                    }
                    else if (trabajador.permiso == "Trabajador")
                    {
                        var idrol = (from rol in listRol
                                     where rol.nombreRol == CBRol.Text
                                     select rol.ID_Rol).SingleOrDefault();
                        trabajador.Rol = idrol;

                        var idDep = (from depart in listDepart
                                     where depart.nombreDep == CBDepart.Text
                                     select depart.ID_Departamento).SingleOrDefault();
                        trabajador.ID_Departamento = idDep;

                        repoTrabajador.Modificar(trabajador);
                    }

                    MessageBox.Show("Operacion de modificacion completada exitosamente");
                    BtnShowAll_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Seleccione el empleado que desea modificar");
                }
            }
            else
            {
                MessageBox.Show("Los campos 'Nombre', 'Apellido' y 'Cedula' no pueden estar vacios");
            }
        }   

        private void BtnLimpia_Click(object sender, EventArgs e)
        {
            TxtApellido.Clear();
            TxtQueryID.Clear();
            MTxtCedula.Clear();
            TxtCodigo.Clear();
            TxtNombre.Clear();
            TxtUser.Clear();
            TxtQueryNombre.Clear();
            TxtTelefono.Clear();
            TxtUser.Clear();
            TxtConfirmar.Clear();
            TxtContrasena.Clear();

        }

        private void TxtQueryID_TextChanged(object sender, EventArgs e)
        {
            DataGVTrabajador.DataSource = repoTrabajador.Get(TxtQueryID.Text.ToLower());
        }
    }
}
