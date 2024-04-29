namespace LeetCodeTopInterview150.ArrayString.Medium.InsertDeleteGetRandom;

public class RandomizedSet
{
    private readonly Dictionary<int, int> _map;
    private readonly IList<int> _values;
    private readonly Random _random;
    
    public RandomizedSet()
    {
        _map = new Dictionary<int, int>();
        _values = new List<int>();
        _random = new Random();
    }
    
    public bool Insert(int val) {
        if (_map.ContainsKey(val))
        {
            return false;
        }
        
        _values.Add(val);
        var index = _values.Count - 1;
        _map.Add(val, index);

        return true;
    }
    
    public bool Remove(int val) {
        if (!_map.TryGetValue(val, out var valIndex))
        {
            return false;
        }

        var lastVal = _values[^1];

        _values[valIndex] = lastVal;
        _map[lastVal] = valIndex;
        
        _values.RemoveAt(_values.Count - 1);
        _map.Remove(val);

        return true;
    }

    public int GetRandom()
    {
        var randomIndex = _random.Next(_values.Count);
        return _values[randomIndex];
    }   
}