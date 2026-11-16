using ArgoX3API.Application.Interfaces;
using Custom.ArgoX3API.Application.Interfaces;

namespace Custom.ArgoX3API.Infrastructure.Repository
{
    /// <summary>
    /// UnitOfWork del cliente: i repository base li gestisce il UnitOfWork del core, qui solo quelli custom.
    /// </summary>
    public class UnitOfWork : global::ArgoX3API.Infrastructure.Repository.UnitOfWork, Application.Interfaces.IUnitOfWork
    {
        public UnitOfWork(IMenuRepository menuRepository,
                          IProtocolRepository protocolRepository,
                          IJwtRepository jwtRepository,
                          IKeyStoreRepository keyStoreRepository,
                          IUserRepository userRepository,
                          IQrRepository qrRepository,
                          IEmailRepository emailRepository,
                          IDemoRepository demoRepository,
                          IActionRepository azioneRepository, ICqRncRepository cqRncRepository)
            : base(menuRepository, protocolRepository, jwtRepository, keyStoreRepository, userRepository, qrRepository, emailRepository, demoRepository)
        {
            Azione = azioneRepository;
            CqRnc = cqRncRepository;
        }

        // Esempio: public IMioRepository Mio { get; set; }
        // Funzioni custom
        public IActionRepository Azione { get; set; }
        public ICqRncRepository CqRnc { get; set; }
    }
}