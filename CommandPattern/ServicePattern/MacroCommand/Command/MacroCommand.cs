using CommandPattern.Interfaces;

namespace CommandPattern.ServicePattern.MacroCommand.Command;

//класс макрокоманды
public class MacroCommand : ICommand
{
    List<ICommand> commands;
    public MacroCommand(List<ICommand> coms)
    {
        commands = coms;
    }
    public void Execute()
    {
        foreach (ICommand c in commands)
            c.Execute();
    }

    public void Undo()
    {
        foreach (ICommand c in commands)
            c.Undo();
    }
}
