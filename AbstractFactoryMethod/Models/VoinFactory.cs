using AbstractFactoryMethod.Models.BaseModels;

namespace AbstractFactoryMethod.Models;

// Фабрика создания бегущего героя с мечом
class VoinFactory : HeroFactory
{
    public override Movement CreateMovement()
    {
        return new RunMovement();
    }

    public override Weapon CreateWeapon()
    {
        return new Sword();
    }
}
