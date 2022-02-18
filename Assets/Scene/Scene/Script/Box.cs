using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour, ITouchable
{
    [SerializeField] GameObject _loot; //Objet à spawn
    [SerializeField][Range(0f,1f)] float _spawnChance = 0.33f; //chance de spawn [0,1] (1 = 100%)

    //Appeler lors de dégats reçu
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
