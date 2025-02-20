namespace CrudBackEnd.Models
{
    public class DetalleFactura
    {
        public int Id { get; set; }
        public required int FacturaId { get; set; }
        public required int Producto { get; set; }
        public required int Cantidad { get; set; }
        public required int PrecioUnitario { get; set; }
        public required int Subtotal { get; set; }

    }
}
