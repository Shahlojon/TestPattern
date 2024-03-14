using CommandPattern.Interfaces;

namespace CommandPattern.ServicePattern.MacroCommand.Command;

public class CodeCommand : ICommand
{
    Programmer _programmer;

    public CodeCommand(Programmer programmer)
    {
        _programmer = programmer;
    }
    public void Execute()
    {
        _programmer.StartCoding();
    }

    public void Undo()
    {
        _programmer.StopCoding();
    }
}
