namespace BlazorApp1.Modelos
{
    public class Cliente
    {
        public string Id { get; set; }
        public string LocalidadC { get; set; }
        public string DireccionC { get; set; }
        public string NombreC { get; set; }
        public string TelefonoC { get; set; }
        public string CUIT { get; set; }
        public int CodigoPostalC { get; set; }
        public double Deuda { get; set; }
        public byte TIPIVAC { get; set; }
        public bool Reparto { get; set; }

        public Cliente()
        {
            Id = "C:" + Guid.NewGuid().ToString();
            LocalidadC = "";
            NombreC = "";
            Deuda = 0;
            TelefonoC = "";
        }
    }
}
