namespace AppWebInstitute.DataAccess.Modelos
{
    public class Domicilio
    {
        public int DomicilioId { get; set; }
        public string? Calle { get; set; }
        public int Numero { get; set; }
        public string? Departamento { get; set; }
        public int Piso { get; set; }
        public string? Barrio { get; set; }
        public string? Manzana { get; set; }
        public int Casa { get; set; }
        public DateTime DateUpdate { get; set; }
    }
}