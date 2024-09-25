namespace RPG.Services.TemplateMethod.DuckSort;

public class Duck : IComparable<Duck>
{
    public string _name { get; }
    public int _weight { get; }

    public Duck(string name, int weight)
    {
        _name = name;
        _weight = weight;
    }

    public override string ToString()
    {
        return $"{_name} weights {_weight}";
    }

    public int CompareTo(Duck? other)
    {
        if (other == null)
        {
            return -1;
        }
        if (_weight < other._weight)
        {
            return -1;
        }
        else if (_weight == other._weight)
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }
}
