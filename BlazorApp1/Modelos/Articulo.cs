namespace BlazorApp1.Modelos
{
    public class Articulo
    {
        public string Id { get; set; }
        public string Descripcion { get; set; }
        public Articulo()
        {
            Id = "A:" + Guid.NewGuid().ToString();
            Descripcion = "";
        }
    }
}
