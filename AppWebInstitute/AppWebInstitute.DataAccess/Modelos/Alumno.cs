using System.ComponentModel.DataAnnotations;
namespace AppWebInstitute.DataAccess.Modelos
{
    public class Alumno
    {
        public int AlumnoId { get; set; }
        //El sign interrogacion despues de string indica
        //que la propiedad acepta valores nulos, otra forma
        //es indicar una asignacion de null seguido de ! a la
        //propiedad
        //Ej. public string? Nombre { get; set; }
        // public string Nombre { get; set; } = null!;
        [StringLength(50, ErrorMessage = "El largo máximo es de 50 caracteres")]
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? NroDoc { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FechNac { get; set; }
        public Domicilio? Domicilio { get; set; }
        public int ProvinciaId { get; set; }
        public int LocalidadId { get; set; }
        public string? NroTelefono { get; set; }
        public string? NroMovil { get; set; }
        public string? EMail { get; set; }
        public int Legajo { get; set; }
        public bool Eliminado { get; set; }
        public DateTime DateUpdate { get; set; }

        public string FullName()
        {
            return Apellido + ", " + Nombre;
        }
    }
}