using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check_player : MonoBehaviour
{
    [SerializeField] BoxCollider _player;

    private void OnTriggerStay(Collider other)
    {
        Debug.Log(other);
        if(_player == other)
        {
            Debug.Log(0);
        }
    }
}
