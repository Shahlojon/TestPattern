using System.Text;

namespace BuilderPattern.Service;

//мука
public class Flour
{
    // какого сорта мука
    public string Sort { get; set; }
}
// соль
public class Salt
{ }
// пищевые добавки
public class Additives
{
    public string Name { get; set; }
}

public class Bread
{
    // мука
    public Flour Flour { get; set; }
    // соль
    public Salt Salt { get; set; }
    // пищевые добавки
    public Additives Additives { get; set; }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        if (Flour != null)
            sb.Append(Flour.Sort + "\n");
        if (Salt != null)
            sb.Append("Соль \n");
        if (Additives != null)
            sb.Append("Добавки: " + Additives.Name + " \n");
        return sb.ToString();
    }
}
