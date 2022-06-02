using Microsoft.EntityFrameworkCore;
using AppWebInstitute.DataAccess.Modelos;
namespace AppWebInstitute.DataAccess.Data
{
    public class InstituteContext : DbContext
    {
        public InstituteContext(DbContextOptions <InstituteContext> options)
            :base(options)
            {

            }
            //DbSet Establece la relacion entre la tabla de la DB
            //y el modelo utilizado en mi programa
        public DbSet<Alumno>? Alumnos { get; set; }
        public DbSet<Domicilio>? Domicilios { get; set; }
        public DbSet<Localidad>? Localidades { get; set; }
        public DbSet<Provincia>? Provincias { get; set; }

    }
}