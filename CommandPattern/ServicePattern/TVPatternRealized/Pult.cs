
using CommandPattern.Interfaces;

namespace CommandPattern.ServicePattern.TVPatternRealized;
// Invoker - инициатор
public class Pult
{
    ICommand command;

    public Pult()
    {
        
    }

    public void SetCommand(ICommand com)
    {
        command = com;
    }

    public void PreesButton()
    {
        if(command!=null)
            command.Execute();
    }
    public void PreesUndo()
    {
        if (command != null)
            command.Undo();
    }
}
