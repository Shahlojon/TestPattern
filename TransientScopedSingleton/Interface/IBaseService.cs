using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransientScopedSingleton.Interface;

public interface IBaseService
{
    Guid GetOperationID();
}
