using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SistemaVenta.BLL.Servicios.Contrato;
using SistemaVenta.DAL.Repositorios.Contrato;
using SistemaVentas.DTO;
using SistemaVentas.Model;

namespace SistemaVenta.BLL.Servicios
{
    public class UsuarioService: IUsuarioServices
    {
        private readonly IGenericRepository<Usuario> _usuarioRepositorio;
        private readonly IMapper _mapper;

        public UsuarioService(IGenericRepository<Usuario> usuarioRepositorio, IMapper mapper)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _mapper = mapper;
        }
        public async Task<List<UsuarioDTO>> Lista()
        {
            try
            {
                var queryusuario = await _usuarioRepositorio.Consultar();
                var listausuarios = queryusuario.Include(rol => rol.IdRolNavigation).ToList();

                return _mapper.Map<List<UsuarioDTO>>(listausuarios);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<SesionDTO> validarCredenciales(string correo, string clave)
        {
            try
            {
                var queryUsuario = await _usuarioRepositorio.Consultar(u =>
                u.Correo == correo &&
                u.Clave == clave);

                if  (queryUsuario.FirstOrDefault() == null)
                    throw new TaskCanceledException("El usuario no existe");

                Usuario devolverUsuario = queryUsuario.Include( rol => rol.IdRolNavigation).First();
                return _mapper.Map<SesionDTO>(devolverUsuario);

            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<UsuarioDTO> crear(UsuarioDTO modelo)
        {
            try
            {
                var usuarioCreado = await _usuarioRepositorio.Crear(_mapper.Map<Usuario>(modelo));
                if(usuarioCreado.IdUsuario == 0)
                    throw new TaskCanceledException("No se `pudo crear");

            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<bool> editar(UsuarioDTO modelo)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<bool> Eliminar(int id)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
        
    }
}
