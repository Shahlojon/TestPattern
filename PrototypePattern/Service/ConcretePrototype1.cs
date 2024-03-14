namespace PrototypePattern.Service;

class ConcretePrototype1 : PrototypeService
{
    public ConcretePrototype1(int id) : base(id)
    {
    }

    public override PrototypeService Clone()
    {
        return new ConcretePrototype1(Id);
    }
}
