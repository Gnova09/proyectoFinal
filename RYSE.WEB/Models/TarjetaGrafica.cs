namespace RYSE.WEB.Models
{
    public class TarjetaGrafica:Articulos
    {
        public string? DispositivoCompatible { get; set; }

        public int? TamañoGraficosRam { get; set; }

        public int VelocidadRelojGPU { get; set; }

        public string? InterfazDsalida { get; set; }
    }
}
