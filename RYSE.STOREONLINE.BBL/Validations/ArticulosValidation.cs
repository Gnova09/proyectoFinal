using RYSE.STOREONLINE.SERVICE.Core;
using RYSE.STOREONLINE.SERVICE.Dtos;
using RYSE.STOREONLINE.SERVICE.Responses;
using RYSE.STOREONLINE.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYSE.STOREONLINE.SERVICE.Validations
{
    public class ArticulosValidation
    {
        public static ServiceResult SaveArticulosValidation(ArticulosSaveDto articulosSaveDto, ServiceResult resultSave)
        {
                      
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
            return resultSave;
        }
        public static ServiceResult UpdateArticulosValidation(ArticulosUpdateDto articulosUpdateDto, ServiceResult resultUpdate)
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
            
            return resultUpdate;
        }
        //para otras validaciones de articulos se crea un metodo debajo
    }
}
