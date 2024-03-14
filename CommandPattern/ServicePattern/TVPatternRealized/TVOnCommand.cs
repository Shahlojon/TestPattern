
using CommandPattern.Interfaces;

namespace CommandPattern.ServicePattern.TVPatternRealized;

public class TVOnCommand : ICommand
{
    private readonly TV tV;

    public TVOnCommand(TV _tvSet)
    {
        tV = _tvSet;
    }


    public void Execute()
    {
        tV.On();
    }

    public void Undo()
    {
       tV.Off();
    }
}
