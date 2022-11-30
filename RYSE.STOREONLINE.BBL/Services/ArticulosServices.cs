using System;

using Microsoft.Extensions.Logging;
using RYSE.STOREONLINE.DAL.Interfaces;
using RYSE.STOREONLINE.DAL.Repositories;
using RYSE.STOREONLINE.SERVICE.Contracts;
using RYSE.STOREONLINE.SERVICE.Core;
using RYSE.STOREONLINE.SERVICE.Dtos;
using RYSE.STOREONLINE.SERVICE.Responses;

namespace RYSE.STOREONLINE.SERVICE.Services
{
    public class ArticulosServices : IArticulosServices
    {
        private readonly IItemRepository itemRepository;
        private readonly ILogger<ArticulosServices> logger;

        public ArticulosServices(IItemRepository itemRepository, ILogger<ArticulosServices> logger) {
            this.itemRepository = itemRepository;
            this.logger = logger;
            //constructor
        }
        public ServiceResult DeleteArticulos(ArticulosDeleteDto articulosDeleteDto)
        {
            ServiceResult response = new ServiceResult();

            try
            {
                DAL.Entities.Item itemToDelete = itemRepository.GetEntity(articulosDeleteDto.Id);
                //<-----Articulo que sera eliminado------>//
                itemToDelete.Id = articulosDeleteDto.Id;
                itemToDelete.UserDelete=articulosDeleteDto.UserDelete;
                itemToDelete.DeleteDate = DateTime.Now;
                itemToDelete.Deleted = true;

                itemRepository.Remove(itemToDelete);
            }
            catch (Exception e)
            {
                response.Success = false;
                response.Message = "Error al remover el articulo";
                this.logger.LogError($"{response.Message}", e.ToString());
            }
            return response;
        }

        public ServiceResult GetArticulos()
        {
         ServiceResult article= new ServiceResult();

            try 
            {
                var Articulos = itemRepository.GetAll();
                article.Data= Articulos.Select(art=> new Models.ArticulosModel()
                {
                    Id=art.Id,
                    Name=art.Name,
                    Description=art.Description, 
                    Cant=art.Cant,
                });
                article.Success = true;
            } catch(Exception e) {
                article.Success= false;
                article.Message= "Error al obtener los articulos";
                this.logger.LogError($"{article.Message}", e.ToString());
            
            }
            return (ArticuloResponses)article;
        }

        public ArticuloResponses SaveArticulos(ArticulosSaveDto articulosSaveDto)
        {
            throw new NotImplementedException();
        }

        public ArticuloResponses UpdateArticulos(ArticulosUpdateDto articulosUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
