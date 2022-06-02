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
        [StringLength(45, ErrorMessage = "El largo máximo es de 45 caracteres")]
        public string? Nombre { get; set; }
        [StringLength(45, ErrorMessage = "El Apellido deve contener como máximo 45 carcteres")]
        public string? Apellido { get; set; }
        [StringLength(8,MinimumLength = 7)]
        [RegularExpression(@"^[0-9]{7,8}$")]
        public string? NroDoc { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FechNac { get; set; }
        public Domicilio? Domicilio { get; set; }
        public int ProvinciaId { get; set; }
        public int LocalidadId { get; set; }
        [StringLength(14,MinimumLength = 8)]
        [RegularExpression(@"^[0-9]{8,14}$")]
        public string? NroTelefono { get; set; }
        public string? NroMovil { get; set; }
        [RegularExpression(@"^[a-zA-Z]+(\.[a-zA-Z]+)*(@[a-z]+\.[a-z]{3}){1}(\.[a-zA-Z]{2,3})*$")]
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