namespace RYSE.WEB.Models
{
    public class Computadoras : Articulos
    {
        public int TamañoDiscoDuro { get; set; }

        public string? ModeloCPU { get; set; }

        public string? RAM { get; set; }

        public string? ModeloGPU { get; set; }

        public string? OSW { get; set; }

    }
}
