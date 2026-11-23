using Custom.ArgoX3API.Core.Models;
using Custom.SageX3.ClientLib.X3CustomManager;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using SageX3.WebServiceTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Custom.ArgoX3API.Application.Interfaces;

namespace Custom.ArgoX3API.Infrastructure.Repository
{
    public class CqRncRepository : ICqRncRepository
    {
        private readonly IConfiguration configuration;
        private readonly X3Config x3Configuration;

        public CqRncRepository(IConfiguration configuration, IOptions<X3Config> x3Configuration)
        {
            this.configuration = configuration;
            this.x3Configuration = x3Configuration.Value;
        }

        #region Azioni-campo
        //Lotto CQRNC - AM_LOTCQRN
        public Task<X3Result> AM_LOTCQRN(CqRncYax3mresp yax3mresp)
        {
            var x3Manager = new X3CqRncManager(x3Configuration);
            return Task.FromResult(x3Manager.AM_LOTCQRN(yax3mresp));
        }
        #endregion

        #region Azioni Bottoni di finestra
        //Registra RNC - YREGCQRNC
        public Task<X3Result> YREGCQRNC(CqRncYax3mresp yax3mresp)
        {
            var x3Manager = new X3CqRncManager(x3Configuration);
            return Task.FromResult(x3Manager.YREGCQRNC(yax3mresp));
        }

        //Cancella RNC - YDELCQRNC
        public Task<X3Result> YDELCQRNC(CqRncYax3mresp yax3mresp)
        {
            var x3Manager = new X3CqRncManager(x3Configuration);
            return Task.FromResult(x3Manager.YDELCQRNC(yax3mresp));
        }
        #endregion

        #region Azioni globali
        //Caricamento online RNC - YONLDCQRNC
        public Task<X3Result> YONLDCQRNC(CqRncYax3mresp yax3mresp)
        {
            var x3Manager = new X3CqRncManager(x3Configuration);
            return Task.FromResult(x3Manager.YONLDCQRNC(yax3mresp));
        }

        //Cancellazione richiamata - YDELTCQRNC
        public Task<X3Result> YDELTCQRNC(CqRncYax3mresp yax3mresp)
        {
            var x3Manager = new X3CqRncManager(x3Configuration);
            return Task.FromResult(x3Manager.YDELTCQRNC(yax3mresp));
        }
        #endregion
    }
}