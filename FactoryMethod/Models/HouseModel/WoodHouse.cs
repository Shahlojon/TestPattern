using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Models.HouseModel;

public class WoodHouse:House
{
    public WoodHouse()
    {
        Console.WriteLine("Кирпичный дом построен");
    }
}
