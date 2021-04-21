using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretSpawnerBehaviour : MonoBehaviour
{
    [Tooltip("The object that will be instantiated.")]
    [SerializeField]
    private GameObject _spawnObject;
    [Tooltip("The amount of time in seconds between each spawn.")]
    [SerializeField]
    private float _timeBetweenSpawns;
    [Tooltip("If false, the spawner will stop instantiating clones of the reference.")]
    [SerializeField]
    private bool _canSpawn;
    [Tooltip("The Turret object's target.")]
    [SerializeField]
    private GameObject _target;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnObjects());
    }

    /// <summary>
    /// Spawns objects continuously while canSpawn is true.
    /// </summary>
    /// <returns></returns>
    public IEnumerator SpawnObjects()
    {
        while (_canSpawn)
        {
            //Creates a vector3 with a random x and z value;
            Vector3 randomPos = new Vector3(Random.Range(-36, 36), 1, Random.Range(-36, 36));
            //Create a new enemy in the scene
            GameObject spawnedTurret = Instantiate(_spawnObject, randomPos, new Quaternion());
            //Set the turret target to be the target the spawner was given
            spawnedTurret.GetComponent<TurretShootBehaviour>().Target = _target;
            //Pause for the given time in seconds before resuming the function
            yield return new WaitForSeconds(_timeBetweenSpawns);
        }
    }

    private void Update()
    {
        if (GameManagerBehaviour.GameOver)
            gameObject.SetActive(false);
    }
}
