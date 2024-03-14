using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransientScopedSingleton.Interface;

namespace TransientScopedSingleton;

public class OperationService(Guid id) : ITransientService, IScopedService, ISingletonService
{
    Guid _id=id;
    public Guid GetOperationID()
    {
        return _id;
    }
}
