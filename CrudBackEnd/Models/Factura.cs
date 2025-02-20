namespace CrudBackEnd.Models
{
    public class Factura
    {
        public int Id { get; set; }
        public required string Cliente { get; set; }
        public required string Fecha { get; set; }
        public required string Total { get; set; }
    }
}
