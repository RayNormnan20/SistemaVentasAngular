using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaVentas.DTO;

namespace SistemaVenta.BLL.Servicios.Contrato
{
    public interface IProductoService
    {
        Task<List<ProductoDTO>> Lista();
        Task<ProductoDTO> crear(ProductoDTO modelo);
        Task<bool> editar(ProductoDTO modelo);
        Task<bool> Eliminar(int id);
    }
}
