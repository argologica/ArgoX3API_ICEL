using Custom.ArgoX3API.Application.Interfaces;
using Custom.SageX3.ClientLib;
using Custom.SageX3.ClientLib.X3CustomManager;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using SageX3.ClientLib;
using SageX3.WebServiceTypes;
using ArgoX3API.Logging;

namespace Custom.ArgoX3API.Infrastructure.Repository
{
    public class ActionRepository : IActionRepository
    {
        private readonly IConfiguration configuration;
        private readonly X3Config x3Configuration;
        private Dictionary<string, object> paramsList;

        public ActionRepository(IConfiguration configuration, IOptions<X3Config> x3Configuration)
        {
            this.configuration = configuration;
            this.x3Configuration = x3Configuration.Value;
        }

        public Task<X3GridResult> SEL_OBJ(string objet, int page, int pageSize, string query = "")
        {
            return X3GridResult.SelectData(() => new X3Manager(x3Configuration).SEL_OBJ(objet, query.Trim()), page, pageSize);
        }
    }
}
