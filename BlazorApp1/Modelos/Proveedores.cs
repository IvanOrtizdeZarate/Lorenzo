namespace BlazorApp1.Modelos
{
    public class Proveedores
    {
        public string Id { get; set; }
        public int CodigoPostalP { get; set; }
        public string LocalidadP { get; set; }
        public string DireccionP { get; set; }
        public string NombreP { get; set; }
        public string CUIL { get; set; }
        public string TelefonoP { get; set; }
        public byte TIPIVAP { get; set; }

        public Proveedores()
        {
            Id = "P:" + Guid.NewGuid().ToString();
            LocalidadP = "";
            NombreP = "";
            TelefonoP = "";


        }
    }
}
