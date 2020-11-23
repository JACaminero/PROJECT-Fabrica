using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROJECT_Fabrica.Data;
using System.Data.SqlClient;

namespace PROJECT_Fabrica.Repo
{
    class RepAdmin
    {
        DataClassFabricaDataContext context = new DataClassFabricaDataContext();

        public void Registrar(Administrativo admin)
        {
                context.Administrativos.InsertOnSubmit(admin);
                context.SubmitChanges();
        }
        public List<Administrativo> Get()
        {
            var query = (from admin in context.Administrativos
                         where admin.IsDeleted == false || admin.IsDeleted == null
                         select admin).ToList();
            return query;
        }
    }
}
