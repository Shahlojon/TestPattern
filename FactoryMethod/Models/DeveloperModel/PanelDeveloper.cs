using FactoryMethod.Models.HouseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Models.DeveloperModel;

class PanelDeveloper : Developer
{
    public PanelDeveloper(string n) : base(n)
    {
    }

    public override House Create()
    {
       return new PanelHouse();
    }
}
