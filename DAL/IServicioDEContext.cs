using ServicioDE.DTO;
using ServicioDE.Objetos;
using System.Data;

namespace ServicioDE.DAL
{
    public interface IServicioDEContext
    {
        List<CabeceraEntity> TraerCabecera(DataTable dtCabecera);
        List<DetalleEntity> TraerDetalle(DataTable dtDetalle);
        List<ParametroEntity> TraerParametros(DataTable dtParametros);
    }
}