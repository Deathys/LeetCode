using System;

namespace LeetCode.All;

public class LRUCache 
{
    private readonly Dictionary<int, LinkedListNode<(int key, int value)>> _cache;
    private readonly LinkedList<(int key, int value)> _lru;
    
    private readonly int _capacity;
    public LRUCache(int capacity) 
    {
        if(capacity <= 0)
            throw new ArgumentException("Capacity must be greater than zero.", nameof(capacity));

        if(capacity > 3000)
            throw new ArgumentException("Capacity must be less than or equal to 10000.", nameof(capacity));

        _capacity = capacity;
        _cache = new Dictionary<int, LinkedListNode<(int key, int value)>>(_capacity + 1);
        _lru = new LinkedList<(int key, int value)>();
    }
    
    public int Get(int key)
    {
        if (_cache.TryGetValue(key, out var node))
        {
            _lru.Remove(node);
            _lru.AddFirst(node);
            return node.Value.value;
        }
        return -1;
    }
    
    public void Put(int key, int value) 
    {
        if (_cache.ContainsKey(key))
        {
            _lru.Remove(_cache[key]);
            _cache.Remove(key);
        }
        var node = new LinkedListNode<(int key, int value)>((key, value));
        _cache.Add(key, node);
        _lru.AddFirst(node);

        if(_cache.Count > _capacity)
        {
            var last = _lru.Last;
            _cache.Remove(last.Value.key);
            _lru.RemoveLast();
        }
    }
}
