using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    [SerializeField] List<GameObject> pooledObjects; //List des objets pool
    [SerializeField] GameObject objectToPool; //Objet à pool
    [SerializeField] int amountToPool; //Nombre à pool

    // Start is called before the first frame update
    void Start()
    {
        pooledObjects = new List<GameObject>();
        GameObject tmp;
        for (int i = 0; i < amountToPool; i++)
        {
            tmp = Instantiate(objectToPool);
            tmp.SetActive(false);
            pooledObjects.Add(tmp);
        }
    }

    //Renvoie un objet disponible de la pool
    public GameObject GetPooledObject()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            if(!pooledObjects[i].activeInHierarchy)
                return pooledObjects[i];
        }
        return null;
    }
}
