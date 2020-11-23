using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROJECT_Fabrica.Data;
using System.Data.SqlClient;

namespace PROJECT_Fabrica.Repo
{
    class RepRef
    {
        DataClassFabricaDataContext context = new DataClassFabricaDataContext();

        public void Insert(Referencia referencia)
        {
            context.Referencias.InsertOnSubmit(referencia);
            context.SubmitChanges();
        }

        public void Insert(DetalleReferencia detalleref)
        {
            context.DetalleReferencias.InsertOnSubmit(detalleref);
            context.SubmitChanges();
        }

        public void Insert(Stock stock)
        {
            context.Stocks.InsertOnSubmit(stock);
            context.SubmitChanges();
        }

        public List<Stock> GetStock()
        {
            var query = (from stock in context.Stocks
                         where stock.inStock == true && stock.cantRoyo >= 1
                         select stock).ToList();
            return query;
        }

        public List<Stock> GetStock(int ID_area)
        {
            var query = (from stock in context.Stocks
                         where stock.inStock == false && stock.Area.ID_Area == ID_area
                         select stock).ToList();
            return query;
        }
    }
}
