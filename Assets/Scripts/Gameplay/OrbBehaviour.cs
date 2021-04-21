using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbBehaviour : MonoBehaviour
{
    private GameManagerBehaviour _point;

    public GameManagerBehaviour Point
    {
        set { _point = value; }
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy();
            _point.Point += 1;
        }
    }
}
