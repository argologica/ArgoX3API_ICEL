using Custom.ArgoX3API.Core.Models;
using SageX3.ClientLib;
using SageX3.WebServiceTypes;

namespace Custom.SageX3.ClientLib.X3CustomManager
{
    public class X3CqRncManager : X3Manager
    {
        private X3Config config;

        public X3CqRncManager(X3Config config) : base(config) { }

        public X3CqRncManager(string authToken) : base(authToken) { }

        #region Azioni campo

        /// <summary>
        /// Azione-campo: Controllo Lotto CQRNC
        /// </summary>
        /// <returns></returns>
        public X3Result AM_LOTCQRN(CqRncYax3mresp yax3mresp)
        {
            return Run("AM_LOTCQRN", yax3mresp);
        }

        #endregion

        #region Azioni bottoni di finestra

        /// <summary>
        /// Azione: Registrazione CQRNC
        /// </summary>
        /// <returns></returns>
        public X3Result YREGCQRNC(CqRncYax3mresp yax3mresp)
        {
            return Run("YREGCQRNC", yax3mresp);
        }

        /// <summary>
        /// Azione: Cancellazione CQRNC
        /// </summary>
        /// <returns></returns>
        public X3Result YDELCQRNC(CqRncYax3mresp yax3mresp)
        {
            return Run("YDELCQRNC", yax3mresp);
        }

        #endregion

        #region Azioni globali

        /// <summary>
        /// Azione globale: Caricamento onload CQRNC
        /// </summary>
        /// <returns></returns>
        public X3Result YONLDCQRNC(CqRncYax3mresp yax3mresp)
        {
            return Run("YONLDCQRNC", yax3mresp);
        }

        /// <summary>
        /// Azione globale: Caricamento onload CQRNC
        /// </summary>
        /// <returns></returns>
        public X3Result YDELTCQRNC(CqRncYax3mresp yax3mresp)
        {
            return Run("YDELTCQRNC", yax3mresp);
        }

        #endregion

    }
}
