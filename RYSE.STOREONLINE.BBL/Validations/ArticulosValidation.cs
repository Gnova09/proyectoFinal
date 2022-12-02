using RYSE.STOREONLINE.SERVICE.Core;
using RYSE.STOREONLINE.SERVICE.Dtos;
using RYSE.STOREONLINE.SERVICE.Responses;
using RYSE.STOREONLINE.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RYSE.STOREONLINE.DAL.Interfaces;

namespace RYSE.STOREONLINE.SERVICE.Validations
{
    public class ArticulosValidation
    {
        

        public static ServiceResult SaveArticulosValidation(ArticulosSaveDto articulosSaveDto, ServiceResult resultSave, ItemRepository itemRepository)
        {
                //validamos campos vacios             
                if (articulosSaveDto.Name == "" ? true : false)
                {
                    resultSave.Success = false;
                    resultSave.Message = "Name Error";
                    return resultSave;
                }
                if(articulosSaveDto.Description == "" ? true : false)
                {
                    resultSave.Success = false;
                    resultSave.Message = "Description Error";
                    return resultSave;
                }
                if (articulosSaveDto.Tamano == "" ? true : false)
                {
                    resultSave.Success = false;
                    resultSave.Message = "Description Error";
                    return resultSave;
                }
                //validamos que exista el usuario
            if(itemRepository.Exists(art => 
            art.Name == articulosSaveDto.Name &&
            art.CreationDate == articulosSaveDto.CreationDate
            ))
            {
                resultSave.Success = false;
                resultSave.Message = "Article Not Found";
                return resultSave;
            }
            return resultSave;
        }
        public static ServiceResult UpdateArticulosValidation(ArticulosUpdateDto articulosUpdateDto, ServiceResult resultUpdate, ItemRepository itemRepository)
        {

            if (articulosUpdateDto.Name == "" ? true : false)
            {
                resultUpdate.Success = false;
                resultUpdate.Message = "Name Error";
                return resultUpdate;
            }
            if (articulosUpdateDto.Description == "" ? true : false)
            {
                resultUpdate.Success = false;
                resultUpdate.Message = "Description Error";
                return resultUpdate;
            }
            if (articulosUpdateDto.Tamano == "" ? true : false)
            {
                resultUpdate.Success = false;
                resultUpdate.Message = "Description Error";
                return resultUpdate;
            }
            //validamos que exista el usuario
            if (itemRepository.Exists(art =>
            art.Name == articulosUpdateDto.Name &&
            art.CreationDate == articulosUpdateDto.CreationDate
            ))
            {
                resultUpdate.Success = false;
                resultUpdate.Message = "Article Not Found";
                return resultUpdate;
            }

            return resultUpdate;
        }
        //para otras validaciones de articulos se crea un metodo debajo
    }
}
