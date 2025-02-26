using System.Collections.Generic;
using UnityEngine;

public class UpdateManager : MonoBehaviour
{
    public static UpdateManager Instance;

    private List<IUpdateable> _updateables = new List<IUpdateable>();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddUpdateable(IUpdateable updateable)
    {
        _updateables.Add(updateable);
    }

    private void Update()
    {
        foreach (var updateable in _updateables)
        {
            updateable.Update();
        }
    }
}

public interface IUpdateable
{
    void Update();
}