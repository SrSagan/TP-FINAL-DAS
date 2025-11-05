namespace BE
{
    public class Producto
    {
        private int id;
        private string nombre;
        private float precio;

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
    }
}
