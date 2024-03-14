using TransientScopedSingletonMVC.Interface;

namespace TransientScopedSingleton;

public class OperationService : ITransientService, IScopedService, ISingletonService
{
    Guid _id;

    public OperationService()
    {
        _id = Guid.NewGuid();
    }
    public Guid GetOperationID()
    {
        return _id;
    }
}
