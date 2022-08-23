namespace MiPrimeraAPI.Model
{
    public class ProductoVendido
    {
        private int id;
        public int Id { get { return this.id; } set { this.id = value; } }
        private string idProducto;
        public string IdProducto { get { return this.idProducto; } set { this.idProducto = value; } }

        private bool stock;
        public bool Stock { get { return this.stock; } set { this.stock = value; } }

        private string idVenta;
        public string IdVenta { get { return this.idVenta; } set { this.idVenta = value; } }

    }
}
