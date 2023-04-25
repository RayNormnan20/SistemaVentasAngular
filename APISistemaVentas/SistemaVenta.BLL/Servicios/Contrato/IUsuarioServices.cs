﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaVentas.DTO;

namespace SistemaVenta.BLL.Servicios.Contrato
{
    public interface IUsuarioServices
    {
        Task<List<UsuarioDTO>> Lista();
        Task<SesionDTO> validarCredenciales(string correo, string clave);
        Task<UsuarioDTO> Crear(UsuarioDTO modelo);
        Task<bool> Editar(UsuarioDTO modelo);
        Task<bool>Eliminar(int id);
    }
}
