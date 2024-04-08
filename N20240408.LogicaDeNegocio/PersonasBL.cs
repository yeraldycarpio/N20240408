using N20240408.AccesoADatos;
using N20240408.EntidadesDeNegocio;

namespace N20240408.LogicaDeNegocio
{
    public class PersonasBL
    {
        readonly PersonasDAL _personasDAL;
        public PersonasBL(PersonasDAL PersonasDAL)
        {
            _personasDAL = PersonasDAL;
        }
        public async Task<int> Crear(PersonasN personas)
        {
            return await _personasDAL.Crear(personas);
        }
        public async Task<int> Modificar(PersonasN personas)
        {
            return await _personasDAL.Modificar(personas);
        }
        public async Task<int> Eliminar(PersonasN personas)
        {
            return await _personasDAL.Eliminar(personas);
        }
        public async Task<PersonasN> ObtenerPorId(PersonasN personas)
        {
            return await _personasDAL.ObtenerPorId(personas);
        }
        public async Task<List<PersonasN>> ObtenerTodos()
        {
            return await _personasDAL.ObtenerTodos();
        }
        public async Task<List<PersonasN>> Buscar(PersonasN personas)
        {
            return await _personasDAL.Buscar(personas);
        }
    }
}
