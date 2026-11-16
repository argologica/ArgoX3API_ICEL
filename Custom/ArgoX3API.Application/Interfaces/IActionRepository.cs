using SageX3.WebServiceTypes;

namespace Custom.ArgoX3API.Application.Interfaces
{
    public interface IActionRepository
    {
        Task<X3GridResult> SEL_OBJ(string objet, int page, int pageSize, string query = "");

        #region YAX3MCQRNC
        #endregion
    }
}
