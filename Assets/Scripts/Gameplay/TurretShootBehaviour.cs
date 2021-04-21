using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretShootBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject _target;
    [SerializeField]
    private BulletEmitterBehaviour _bulletEmitter;
    [SerializeField]
    private float _shotSpeed = 1;
    [SerializeField]
    private float _range = 10;

    private float _coolDown = 100;

    private Vector3 _direction;

    public GameObject Target
    {
        get { return _target; }
        set { _target = value; }
    }

    // Update is called once per frame
    void Update()
    {
        //Gets the distance from the turret to the target
        float targetDistance = (_target.transform.position - transform.position).magnitude;

        //if the gameobject has an [Player] tag and target is in range, lookat target
        if (_target.CompareTag("Player") && targetDistance < _range && _bulletEmitter && _target)
        {
            transform.LookAt(_target.transform);

            if (_coolDown <= 0)
            {
                _bulletEmitter.Fire(transform.forward * _shotSpeed);
                _coolDown = 100;
            }
        }

        if (_coolDown < 0)
            _coolDown = 0;
        else
            _coolDown--;
    }
}
