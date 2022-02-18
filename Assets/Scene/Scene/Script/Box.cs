using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour, ITouchable
{
    [SerializeField] GameObject _loot;
    [SerializeField][Range(0f,1f)] float _spawnChance = 0.75f;
    public void Touch(int power)
    {
        float randValue = Random.Range(0, 1f);
        if(randValue <= _spawnChance)
        {
            Instantiate(_loot, this.transform.position, Quaternion.identity, null);
        }
        Destroy(gameObject);
    }
}
