using BlazorApp1.Modelos;

namespace BlazorApp1.Servicios
{
    public interface IProveedoresServicio
    {
        public List<Proveedores> Listar();
        public void AgregarProveedor(Proveedores proveedor);
    }
    public class ProveedoresServicio : IProveedoresServicio
    {
        private List<Proveedores> listaProveedores = new List<Proveedores>();
        public void AgregarProveedor(Proveedores proveedor)
        {
            listaProveedores.Add(proveedor);
        }

        public List<Proveedores> Listar()
        {
            return listaProveedores;
        }
    }
}
