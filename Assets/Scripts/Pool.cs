using UnityEngine;
using System.Collections.Generic;

public class Pool : MonoBehaviour
{
    public GameObject baseObject;

    public int numberOfClones;

    internal List<GameObject> clones;

    void Awake()
    {
        InstantiateClones();
    }

    private void InstantiateClones()
    {
        clones = new List<GameObject>();

        for (int i = 0; i < numberOfClones; i++)
        {
            clones.Add(Instantiate(baseObject, transform));

            clones[i].SetActive(false);

            clones[i].GetComponent<PoolObject>()._pool = this;
        }
    }

    public GameObject Spawn(Vector3 position, Quaternion rotation)
    {
        GameObject cloneToSpawn = clones[0];

        cloneToSpawn.SetActive(true);

        cloneToSpawn.transform.position = position;

        cloneToSpawn.transform.rotation = rotation;

        clones.Add(cloneToSpawn);

        clones.RemoveAt(0);

        cloneToSpawn.GetComponent<PoolObject>().OnSpawn?.Invoke(cloneToSpawn);

        return cloneToSpawn;
    }

    public void Dispawn(GameObject gameObject)
    {
        for (int i = 0; i < numberOfClones; i++)
        {
            if (clones[i] != gameObject)
            {
                continue;
            }

            gameObject.SetActive(false);

            clones.RemoveAt(i);

            clones.Insert(0, gameObject);

            return;
        }
    }
}