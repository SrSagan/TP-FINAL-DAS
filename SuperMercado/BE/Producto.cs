namespace BE
{
    public class Producto
    {
        private int id;
        private string nombre;
        private float precio;
        private int stock;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public Producto(string nombre, float precio, int stock)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
        }
        public Producto()
        {

        }

    }
}
