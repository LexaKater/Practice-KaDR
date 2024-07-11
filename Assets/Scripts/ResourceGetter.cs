using UnityEngine;

public class ResourceGetter : Getter<Resource>
{
    private Resource _resource;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _resource = GetObject();
            _resource.ShowName();
        }
    }
}