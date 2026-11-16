namespace Custom.ArgoX3API.Application.Interfaces
{
    /// <summary>
    /// UnitOfWork del cliente: eredita i repository base (Menu, Protocol, Jwt, ...) e aggiunge solo quelli custom.
    /// </summary>
    public interface IUnitOfWork : global::ArgoX3API.Application.Interfaces.IUnitOfWork
    {
        // Esempio: IMioRepository Mio { get; }
        IActionRepository Azione { get; }
        ICqRncRepository ControlloQualità { get; }
    }
}