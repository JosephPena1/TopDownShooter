using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject _gameObject;

    // Update is called once per frame
    void Update()
    {
        if (_gameObject)
            transform.position = new Vector3(_gameObject.transform.position.x, transform.position.y, _gameObject.transform.position.z);
    }
}
