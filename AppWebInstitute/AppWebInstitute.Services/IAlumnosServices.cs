using AppWebInstitute.DataAccess.Modelos;
namespace AppWebInstitute.Services
{
    public interface IAlumnosServices
    {
        Task<RespuestaService<List<Alumno>>> Listar();
        Task<RespuestaService<Alumno>> BuscarPorId(int id);
        Task<RespuestaService<Alumno>> Guardar(Alumno alumno);
        Task<RespuestaService<Alumno>> Actualizar(Alumno alumno);
        Task<RespuestaService<bool>> Eliminar(int id);
    }
}

