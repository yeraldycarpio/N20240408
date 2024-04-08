using Microsoft.EntityFrameworkCore;
using N20240408.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N20240408.AccesoADatos
{
    public class PersonasDAL
    {
        readonly ApplicationDbContext _appDbContext;
        public PersonasDAL(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<int> Crear(PersonasN cliente)
        {
            _appDbContext.Add(cliente);
            return await _appDbContext.SaveChangesAsync();
        }
        public async Task<int> Modificar(PersonasN personasN)
        {
            var clienteData = await _appDbContext.PersonaN.FirstOrDefaultAsync(s => s.Id == personasN.Id);
            if (clienteData != null)
            {
                clienteData.NombreN = personasN.NombreN;
                clienteData.ApellidoN = personasN.ApellidoN;
                clienteData.FechaNacimientoN = personasN.FechaNacimientoN;
                _appDbContext.Update(clienteData);
            }
            return await _appDbContext.SaveChangesAsync();
        }
        public async Task<int> Eliminar(PersonasN personasN)
        {
            var clienteData = await _appDbContext.PersonaN.FirstOrDefaultAsync(s => s.Id == personasN.Id);
            if (clienteData != null)
                _appDbContext.Remove(clienteData);
            return await _appDbContext.SaveChangesAsync();
        }

        public async Task<PersonasN> ObtenerPorId(PersonasN personas)
        {
            var clienteData = await _appDbContext.PersonaN.FirstOrDefaultAsync(s => s.Id == personas.Id);
            if (clienteData != null)
                return clienteData;
            else
                return new PersonasN();
        }
        public async Task<List<PersonasN>> ObtenerTodos()
        {
            return await _appDbContext.PersonaN.ToListAsync();
        }
        public async Task<List<PersonasN>> Buscar(PersonasN cliente)
        {

            var query = _appDbContext.PersonaN.AsQueryable();
            if (!string.IsNullOrWhiteSpace(cliente.NombreN))
            {
                query = query.Where(s => s.NombreN.Contains(cliente.NombreN));
            }
            if (!string.IsNullOrWhiteSpace(cliente.ApellidoN))
            {
                query = query.Where(s => s.ApellidoN.Contains(cliente.ApellidoN));
            }
            return await query.ToListAsync();
        }
    }
}
