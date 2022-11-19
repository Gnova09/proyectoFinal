

using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace RYSE.STOREONLINE.DAL.Entities
{
    public partial class Item : Core.Articulo
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public string? Tamano { get; set; }
    }
}
