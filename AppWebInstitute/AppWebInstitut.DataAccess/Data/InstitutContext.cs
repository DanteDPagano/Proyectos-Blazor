using Microsoft.EntityFrameworkCore;
using AppWebInstitut.DataAccess.Modelos;
namespace AppWebInstitut.DataAccess.Data
{
    public class InstitutContext : DbContext
    {
        public InstitutContext(DbContextOptions <InstitutContext> options)
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