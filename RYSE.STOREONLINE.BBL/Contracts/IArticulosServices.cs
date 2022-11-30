using RYSE.STOREONLINE.SERVICE.Core;
using RYSE.STOREONLINE.SERVICE.Dtos;
using RYSE.STOREONLINE.SERVICE.Responses;


namespace RYSE.STOREONLINE.SERVICE.Contracts
{
    public interface IArticulosServices
    {
        ArticuloResponses SaveArticulos(ArticulosSaveDto articulosSaveDto);
        ArticuloResponses UpdateArticulos(ArticulosUpdateDto articulosUpdateDto);
        ServiceResult DeleteArticulos(ArticulosDeleteDto articulosDeleteDto);
        ServiceResult GetArticulos();
    }
}
