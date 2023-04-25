using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaVentas.DTO;

namespace SistemaVenta.BLL.Servicios.Contrato
{
    public  interface IDashBoardService
    {
        // Creacion del metodo
        Task<DashBoardDTO> Resumen();
    }
}
