namespace BE
{
    public sealed class UsuarioActual
    {
        private static readonly UsuarioActual instance = new UsuarioActual();
        private UsuarioActual() { }
        public static UsuarioActual Instance => instance;
        private Usuario data;
        public Usuario Data { get => data; set => data = value; }
        public bool IsAuthenticated() => Data != null;
        public void SetUser(Usuario user)
        {
            Data = user;
        }
        public void Clear()
        {
            Data = null;
        }
    }
}
