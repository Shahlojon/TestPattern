namespace PrototypePattern.Service;

class ConcretePrototype2 : PrototypeService
{
    public ConcretePrototype2(int id) : base(id)
    {
    }

    public override PrototypeService Clone()
    {
        return new ConcretePrototype2(Id);
    }
}
