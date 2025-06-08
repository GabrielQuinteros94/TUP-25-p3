namespace servidor.Modelos
{
    public class Carrito
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public List<ItemCarrito> Items { get; set; } = new();
    }

    public class ItemCarrito
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
    }
}