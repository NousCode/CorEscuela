namespace CoreEscuela.Entidades
{
    public abstract class EscuelaBase
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }

        public EscuelaBase()
        {
            UniqueId = Guid.NewGuid().ToString();
        }
    }
}