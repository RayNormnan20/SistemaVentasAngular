using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaVentas.DAL.DBContext;
using SistemaVenta.DAL.Repositorios.Contrato;
using SistemaVentas.Model;

namespace SistemaVenta.DAL.Repositorios
{
    public class VentaRepository: GenericRepository<Venta>, IVentaRepository
    {
        private readonly DbventaContext _dbContext;

        public VentaRepository(DbventaContext dbContext): base(dbContext) 
        {
            _dbContext = dbContext;
        }



        public Task<Venta> Registar(Venta modelo)
        {
            throw new NotImplementedException();
        }
    }
}
