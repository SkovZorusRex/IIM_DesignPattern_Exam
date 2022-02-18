using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Reference/PlayerReference")]
public class ControlShakeReferenceSetter : MonoBehaviour
{
    [SerializeField] ControlShake _csEntity;
    [SerializeField] ControlShakeReference _csRef;

    void Awake()
    {
        (_csRef as IReferenceSetter<ControlShake>).SetInstance(_csEntity);
    }
}
