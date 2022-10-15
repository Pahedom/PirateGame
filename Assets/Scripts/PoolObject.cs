using UnityEngine;
using UnityEngine.Events;

public class PoolObject : MonoBehaviour
{
    internal Pool _pool;

    public UnityAction<GameObject> OnSpawn;

    public void Dispawn()
    {
        _pool.Dispawn(gameObject);
    }
}