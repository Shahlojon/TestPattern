namespace CommandPattern.ServicePattern.CommandPatternRealized;

public abstract class Command
{
    public abstract void Execute();
    public abstract void Undo();
}
