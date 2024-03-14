using CommandPattern.Interfaces;

namespace CommandPattern.ServicePattern.TVPatternRealized;

public class MicrowaveCommand : ICommand
{
    private readonly Microwave _mc;
    int time;
    public MicrowaveCommand(Microwave mc, int t)
    {
        time = t;
        _mc = mc;

    }
    public void Execute()
    {
        _mc.StartCooking(time);
        _mc.StopCooking();
    }

    public void Undo()
    {
        _mc.StopCooking();
    }
}
