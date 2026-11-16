using Custom.ArgoX3API.Core.Models;
using SageX3.WebServiceTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom.ArgoX3API.Application.Interfaces
{
    public interface ICqRncRepository
    {
        #region Azioni campo
        Task<X3Result> AM_LOTCQRN(CqRncYax3mresp yax3mresp);
        #endregion

        #region Bottoni di Finestra
        Task<X3Result> YREGCQRNC(CqRncYax3mresp yax3mresp);
        Task<X3Result> YDELCQRNC(CqRncYax3mresp yax3mresp);
        #endregion

        #region Azioni globali
        Task<X3Result> YONLDCQRNC(CqRncYax3mresp yax3mresp);
        #endregion
    }
}