using BlazorApp1.Modelos;

namespace BlazorApp1.Servicios
{
    public interface IArticulosServicio
    {
        public List<Articulo> Listar();
        public void AgregarArticulo(Articulo articulo);
    }
    public class ArticulosServicio : IArticulosServicio
    {
        private List<Articulo> listaArticulos = new List<Articulo>();
        public void AgregarArticulo(Articulo articulo)
        {
            listaArticulos.Add(articulo);
        }

        public List<Articulo> Listar()
        {
            return listaArticulos;
        }
    }
}
