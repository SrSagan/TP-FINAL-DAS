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

        public Producto(int id, string nombre, float precio, int stock)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
        }
    }
}
