namespace RYSE.STOREONLINE.DAL.Core
{
    public abstract class Articulo:BaseEntity
    {
        
        public string? Name { get; set; }
        public int Cant { get; set; }
    }
}
