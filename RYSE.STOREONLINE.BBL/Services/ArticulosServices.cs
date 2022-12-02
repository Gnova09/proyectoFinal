using System;

using Microsoft.Extensions.Logging;
using RYSE.STOREONLINE.DAL.Core;
using RYSE.STOREONLINE.DAL.Interfaces;
using RYSE.STOREONLINE.DAL.Repositories;
using RYSE.STOREONLINE.SERVICE.Contracts;
using RYSE.STOREONLINE.SERVICE.Core;
using RYSE.STOREONLINE.SERVICE.Dtos;
using RYSE.STOREONLINE.SERVICE.Responses;
using RYSE.STOREONLINE.SERVICE.Validations;


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
                var Articulos = itemRepository.GetEntities();
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
            ServiceResult resultSave= new ServiceResult();
                        
            try
            {
                //validamos que los campos no esten vacios
                ArticulosValidation.SaveArticulosValidation(articulosSaveDto, resultSave);
                 
            }
            catch (Exception e)
            {
                resultSave.Success = false;
                resultSave.Message = "Error al Guardar los articulos";
                this.logger.LogError($"{resultSave.Message}", e.ToString());

            }
            return (ArticuloResponses)resultSave;
        }

        public ArticuloResponses UpdateArticulos(ArticulosUpdateDto articulosUpdateDto)
        {
            ServiceResult resultUpdate = new ServiceResult();

            try
            {
                //validamos que los campos no esten vacios
                ArticulosValidation.UpdateArticulosValidation(articulosUpdateDto, resultUpdate);

            }
            catch (Exception e)
            {
                resultUpdate.Success = false;
                resultUpdate.Message = "Error al Actualizar los articulos";
                this.logger.LogError($"{resultUpdate.Message}", e.ToString());

            }
            return (ArticuloResponses)resultUpdate;
        }
    }
}
