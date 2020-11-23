using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROJECT_Fabrica.Repo;
using PROJECT_Fabrica.Data;

namespace PROJECT_Fabrica.Repo
{
    class RepLote
    {
        DataClassFabricaDataContext context = new DataClassFabricaDataContext();

        public void Insert(Lote lote)
        {
            context.Lotes.InsertOnSubmit(lote);
            context.SubmitChanges();
        }

        public Lote GetLast()
        {
            var query = (from lote in context.Lotes
                         orderby lote.numLote descending
                         select lote).FirstOrDefault();

            return query;
        }
    }
}
