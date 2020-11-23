using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROJECT_Fabrica.Data;
using System.Data.SqlClient;

namespace PROJECT_Fabrica.Repo
{
    class RepoTrabajador
    {
        DataClassFabricaDataContext context = new DataClassFabricaDataContext();

        public void Registrar(Trabajador trabajador)
        {
                context.Trabajadors.InsertOnSubmit(trabajador);
                context.SubmitChanges();
        }
        public Trabajador GetSingle(string codigo)
        {
            var query = (from trabajador in context.Trabajadors
                         where trabajador.codigo == codigo
                         && trabajador.IsDeleted == false
                         select trabajador).SingleOrDefault();
            return query;
        }

        public void Modificar(Trabajador trabajador)
        {
            Trabajador Updated = trabajador;
            context.SubmitChanges();
        }

        public void Eliminate(string codigo)
        {
            Trabajador trabajador = GetSingle(codigo);

            trabajador.IsDeleted = true;
            
            //if (trabajador.Supervisor != null)
            //{
            //    trabajador.Supervisor.IsDeleted = true;
            //}
            //else if (trabajador.Administrativo.IsDeleted != null)
            //{
            //    trabajador.Administrativo.IsDeleted = true;
            //}
            
            context.SubmitChanges();
        }
        public List<Rol> GetRols()
        {
            var query = (from rol in context.Rols
                         select rol).ToList();
            return query;
        }
        public List<Departamento> GetDepart()
        {
            var query = (from depart in context.Departamentos
                         select depart).ToList();
            return query;
        }

        public List<Trabajador> Get()
        {
            var query = (from trab in context.Trabajadors
                         where trab.IsDeleted == false
                         select trab).ToList();
            return query;
        }

        public bool IsUniqueCedula(string cedula)
        {
            List<string> uniquecedula = (from empleado in Get()
                                         select empleado.cedula).ToList();
            if (uniquecedula.Count != 0)
            {
                foreach (string item in uniquecedula)
                {
                    if (cedula == item)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        public List<Trabajador> Get(string codigo)
        {
            var query = (from trabajador in context.Trabajadors
                         where trabajador.codigo.Contains(codigo.Trim().ToLower())
                         && (trabajador.IsDeleted == false)
                         select trabajador).ToList();
            return query;
        }

        public List<Trabajador> GetWithNom(string nomapel)
        {
            var query = (from trabajador in context.Trabajadors
                         where trabajador.apellido.Contains(nomapel.Trim().ToLower())
                         || trabajador.nombre.Contains(nomapel.Trim().ToLower())
                         && trabajador.IsDeleted == false
                         select trabajador).ToList();
            return query;
        }

        public Trabajador Authentication(string usuario, string contra)
        {
            var worker = (from empleado in context.Trabajadors
                          where (empleado.Administrativo.usuario == usuario && empleado.Administrativo.contrasena == contra)
                          && empleado.IsDeleted == false && empleado.Administrativo.IsDeleted == false
                          select empleado).SingleOrDefault();
            return worker;
        }
    }
}
