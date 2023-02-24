using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ServicioDE.DTO;
using ServicioDE.Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;


namespace ServicioDE.DAL
{
    public class ServicioDEContext : DbContext
    {
  
        DbSet<ParametroEntity> Parametros { get; set; }
        DbSet<CabeceraEntity> Cabecera { get; set; }
        DbSet<DetalleEntity> Detalle { get; set; }
        private string ConectionString;

        public List<DetalleEntity> TraerDetalle(DataTable dtDetalle)
        {
            var r = new List<DetalleEntity>();
            r = DataTableToList<DetalleEntity>(dtDetalle).ToList();
            return r;
        }

        public List<CabeceraEntity> TraerCabecera(DataTable dtCabecera)
        {
            var r = new List<CabeceraEntity>();
            r = DataTableToList<CabeceraEntity>(dtCabecera).ToList();
            return r;
        }

        public List<ParametroEntity> TraerParametros(DataTable dtParametros)
        {
            var r = new List<ParametroEntity>();
            r = DataTableToList<ParametroEntity>(dtParametros).ToList();
            return r;
        }
       
        public List<T> DataTableToList<T>(DataTable table) 
        {
            try
            {
                List<T> list = new List<T>();

                foreach (var row in table.AsEnumerable())
                {
                    T obj = (T)Activator.CreateInstance(typeof(T));

                    foreach (var prop in obj.GetType().GetProperties())
                    {
                        try
                        {
                            PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                            propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);
                        }
                        catch
                        {
                            continue;
                        }
                    }

                    list.Add(obj);
                }

                return list;
            }
            catch
            {
                return null;
            }
        }
    }
}
