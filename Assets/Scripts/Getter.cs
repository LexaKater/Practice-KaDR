using UnityEngine;

public class Getter<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField] private T[] _objects;

    private int _index = 0;

    protected T GetObject()
    {
        if (_index == _objects.Length)
            _index = 0;

        return _objects[_index++];
    }
}