using StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.PatternRealized.Strategy;

public class Context
{
    public IStrategy ContextStrategy { get; set; }

    public Context(IStrategy strategy)
    {
        ContextStrategy = strategy;
    }

    public void ExecuteAlgorithm()
    {
        ContextStrategy.Algorithm();
    }
}
