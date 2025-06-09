namespace cliente.Modelos
{
    public class Carrito
    {
        public Guid Id { get; set; }
        public List<ItemCarrito> Items { get; set; }
    }

    public class ItemCarrito
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public Guid CarritoId { get; set; }
    }
}