namespace MiPrimeraAPI.Model
{
    public class Producto
    {
        private int id;
        public int Id { get { return this.id; } set { this.id = value; } }
        private string descripciones;
        public string Descripciones { get { return this.descripciones; } set { this.descripciones = value; } }

        private double costo;
        public double Costo { get { return this.costo; } set { this.costo = value; } }

        private double precioVenta;
        public double PrecioVenta { get { return this.precioVenta; } set { this.precioVenta = value; } }

        private int stock;
        public int Stock { get { return this.stock; } set { this.stock = value; } }

        private int idUsuario;
        public int IdUsuario { get { return this.idUsuario; } set { this.idUsuario = value; } }
    }
}
