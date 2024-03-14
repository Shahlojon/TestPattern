using CommandPattern.Interfaces;

namespace CommandPattern.ServicePattern.MacroCommand.Command;

public class AdvertizeCommand : ICommand
{
    Marketolog _marketolog;

    public AdvertizeCommand(Marketolog marketolog)
    {
        _marketolog = marketolog;
    }
    public void Execute()
    {
        _marketolog.StartAdvertize();
    }

    public void Undo()
    {
        _marketolog.StopAdvertize();
    }
}
