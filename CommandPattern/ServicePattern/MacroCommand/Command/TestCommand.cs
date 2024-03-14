using CommandPattern.Interfaces;

namespace CommandPattern.ServicePattern.MacroCommand.Command;

public class TestCommand : ICommand
{
    Tester _test;

    public TestCommand(Tester test)
    {
        _test = test;
    }
    public void Execute()
    {
        _test.StartTesting();
    }

    public void Undo()
    {
        _test.StopTesting();
    }
}
