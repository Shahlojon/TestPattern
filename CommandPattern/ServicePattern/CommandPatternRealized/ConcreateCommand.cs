using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.ServicePattern.CommandPatternRealized;

public class ConcreateCommand : Command
{
    Receiver receiver;
    public ConcreateCommand(Receiver r)
    {
        receiver = r;
    }
    public override void Execute()
    {
        receiver.Operation();
    }

    public override void Undo()
    {
        throw new NotImplementedException();
    }
}
