namespace AppWebInstitut.DataAccess.Modelos
{
    public class Localidad
    {
        public int LocalidadId { get; set; }
        public string? LocalidadName { get; set; }
        public string? CodPost { get; set; }
        public int ProvinciaId { get; set; }
        public DateTime DateUpdate { get; set; }
    }
}