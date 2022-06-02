using AppWebInstitute.DataAccess.Data;
using AppWebInstitute.DataAccess.Modelos;
using Microsoft.EntityFrameworkCore;
namespace AppWebInstitute.Services;

public class AlumnosServices : IAlumnosServices
{
    private InstituteContext _context;
    public AlumnosServices(InstituteContext context)
    {
        _context = context;
    }
    public Task<RespuestaService<Alumno>> Actualizar(Alumno alumno)
    {
        throw new NotImplementedException();
    }

    public Task<RespuestaService<Alumno>> BuscarPorId(int id)
    {
        throw new NotImplementedException();
    }

    public Task<RespuestaService<bool>> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<RespuestaService<Alumno>> Guardar(Alumno alumno)
    {
        throw new NotImplementedException();
    }

    public async Task<RespuestaService<List<Alumno>>> Listar()
    {
        var respuesta = new RespuestaService<List<Alumno>>();
        var lista = await _context.Alumnos.ToListAsync();
        

        if (lista != null)
            respuesta.Objeto=lista;
        else
            respuesta.AddInternalServerError("Se encontro un error");
        
        return respuesta;
    }
}
