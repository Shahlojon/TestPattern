namespace PrototypePattern.Service;

abstract class PrototypeService
{
    public int Id {  get; private set; }

    public PrototypeService(int id)
    {
        this.Id = id;
    }
    public abstract PrototypeService Clone();
}
