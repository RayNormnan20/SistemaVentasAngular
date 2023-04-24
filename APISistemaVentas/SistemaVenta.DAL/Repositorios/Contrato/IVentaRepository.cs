using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaVentas.Model;

namespace SistemaVenta.DAL.Repositorios.Contrato
{
    public interface IVentaRepository: IGenericRepository<Venta>
    {
        Task<Venta> Registar(Venta modelo);
    }
}
