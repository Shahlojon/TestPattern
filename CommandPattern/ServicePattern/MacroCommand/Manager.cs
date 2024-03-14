using CommandPattern.Interfaces;

namespace CommandPattern.ServicePattern.MacroCommand;

public class Manager
{
    ICommand command;

    public void SetCommand(ICommand com)
    {
        command = com;
    }

    public void StartProject()
    {
        if (command != null)
            command.Execute();
    }
    public void StopProject()
    {
        if (command != null)
            command.Undo();
    }
}
