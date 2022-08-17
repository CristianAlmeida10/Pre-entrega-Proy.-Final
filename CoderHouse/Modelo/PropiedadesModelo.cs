using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderHouse
{
    public class PropiedadesModelo
    {
        public class Usuario
        {
            private int id;
            public int Id { get { return this.id; } set { this.id = value; } }

            private string nombre;
            public string Nombre { get { return this.nombre; } set { this.nombre = value; } }

            private string apellido;
            public string Apellido { get { return this.apellido; } set { this.apellido = value; } }

            private string nombreUsuario;
            public string NombreUsuario { get { return this.nombreUsuario; } set { this.nombreUsuario = value; } }

            private string contraseña;
            public string Contraseña { get { return this.contraseña; } set { this.contraseña = value; } }

            private string email;
            public string Email { get { return this.email; } set { this.email = value; } }

        }

        public class Producto
        {
            private int id;
            public int Id { get { return this.id; } set { this.id = value; } }
            private string descripcion;
            public string Descripcion { get { return this.descripcion; } set { this.descripcion = value; } }

            private double costo;
            public double Costo { get { return this.costo; } set { this.costo = value; } }

            private double precioVenta;
            public double PrecioVenta { get { return this.precioVenta; } set { this.precioVenta = value; } }

            private int stock;
            public int Stock { get { return this.stock; } set { this.stock = value; } }

            private int idUsuario;
            public int IdUsuario { get { return this.idUsuario; } set { this.idUsuario = value; } }
        }

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

        public class Venta
        {
            private int id;
            public int Id { get { return this.id; } set { this.id = value; } }

            private string comentarios;
            public string Comentarios { get { return this.comentarios; } set { this.comentarios = value; } }

        }
    }
}
