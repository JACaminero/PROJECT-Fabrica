using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROJECT_Fabrica.Data;

namespace PROJECT_Fabrica.Repo
{
    class RepArea
    {
        DataClassFabricaDataContext context = new DataClassFabricaDataContext();

        public void Insert(Area area)
        {
            context.Areas.InsertOnSubmit(area);
            context.SubmitChanges();
        }

        public void Insert(Almacen almacen)
        {
            context.Almacens.InsertOnSubmit(almacen);
            context.SubmitChanges();
        }  
        
        /// <summary>
        /// Gets a list of all the Areas that belong to an specific almacen.
        /// </summary>
        /// <param name="almacen"></param>
        /// <returns></returns>
        public List<Area> GetList(Almacen almacen)
        {
            var query = (from area in context.Areas
                         where area.Almacen == almacen
                         select area).ToList();

            return query;
        }
        public List<Almacen> GetListAlm()
        {
            var query = (from almacen in context.Almacens                 
                         select almacen).ToList();

            return query;
        }

        public List<Area> GetListArea(int ID_almacen)
        {
            var query = (from area in context.Areas
                         where area.ID_Almacen == ID_almacen
                         select area).ToList();
            return query;
        }
    }
}
