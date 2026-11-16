using ArgoX3API.Core.Models.Type;
using Custom.ArgoX3API.Application.Interfaces;
using Custom.ArgoX3API.Core.Models;
using ArgoX3API.WebAPI.Attributes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SageX3.WebServiceTypes;

namespace Custom.ArgoX3API.WebAPI.Controllers
{
    [Authorize]
    [GlobalLog]
    [Route("api/[controller]")]
    [ApiController]
    public class CqRncController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CqRncController(IUnitOfWork unitOfWork, IOptions<X3Config> x3Configuration)
        {
            this._unitOfWork = unitOfWork;
        }

        #region Azioni SEL

        /// <summary>
        /// Metodo per azioni di tipo selezione per campi di tipo oggetto
        /// </summary>      
        /// <param name="object">Oggetto</param>             
        /// <returns></returns>

        [HttpGet("SEL_OBJ")]
        public async Task<ApiResponse<X3GridResult>> SEL_OBJ(string objet, int page, int pageSize, string query = "")
        {
            var data = await _unitOfWork.Azione.SEL_OBJ(objet, page, pageSize, query);
            return new ApiResponse<X3GridResult>
            {
                Success = true,
                Result = data
            };
        }

        #endregion

        #region Azioni CAMPO
        /// <summary>
        /// Azione-campo: controllo LOT (Lotto) CQRNC
        /// </summary>
        /// <returns></returns>
        [HttpPost("AM_LOTCQRN")]
        public async Task<ApiResponse<X3Result>> AM_LOTCQRN([FromBody] CqRncYax3mresp yax3mresp)
        {
            var data = await _unitOfWork.CqRnc.AM_LOTCQRN(yax3mresp);
            return new ApiResponse<X3Result>
            {
                Success = true,
                Result = data
            };
        }
        #endregion

        #region Azioni Bottoni di finestra
        /// <summary>
        /// Azione bottone di finestra: Registra RNC
        /// </summary>
        /// <returns></returns>
        [HttpPost("YREGCQRNC")]
        public async Task<ApiResponse<X3Result>> YREGCQRNC([FromBody] CqRncYax3mresp yax3mresp)
        {
            var data = await _unitOfWork.CqRnc.YREGCQRNC(yax3mresp);
            return new ApiResponse<X3Result>
            {
                Success = true,
                Result = data
            };
        }

        /// <summary>
        /// Azione bottone di finestra: Cancella RNC
        /// </summary>
        /// <returns></returns>
        [HttpPost("YDELCQRNC")]
        public async Task<ApiResponse<X3Result>> YDELCQRNC([FromBody] CqRncYax3mresp yax3mresp)
        {
            var data = await _unitOfWork.CqRnc.YDELCQRNC(yax3mresp);
            return new ApiResponse<X3Result>
            {
                Success = true,
                Result = data
            };
        }
        #endregion

        #region Azioni Globali
        /// <summary>
        /// Azione globale: Caricamento online RNC
        /// </summary>
        /// <returns></returns>
        [HttpPost("YONLDCQRNC")]
        public async Task<ApiResponse<X3Result>> YONLDCQRNC([FromBody] CqRncYax3mresp yax3mresp)
        {
            var data = await _unitOfWork.CqRnc.YONLDCQRNC(yax3mresp);
            return new ApiResponse<X3Result>
            {
                Success = true,
                Result = data
            };
        }
        #endregion
    }
}