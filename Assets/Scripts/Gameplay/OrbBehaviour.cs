using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbBehaviour : MonoBehaviour
{
    private GameManagerBehaviour _point;

    //Sets _point for GameManager
    public GameManagerBehaviour Point
    {
        set { _point = value; }
    }

    //Detroys the gameObject that called it
    public void Destroy()
    {
        Destroy(gameObject);
    }

    //Checks if an object enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        //Checks if other has [Player] tag
        if (other.CompareTag("Player"))
        {
            Destroy();
            //Increases point
            _point.Point += 1;
        }
    }
}
