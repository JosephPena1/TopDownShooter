using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbSpawnerBehaviour : MonoBehaviour
{
    [Tooltip("The game manager to pass on to an orb")]
    [SerializeField]
    private GameManagerBehaviour _gameManager;
    [Tooltip("The object that will be instantiated.")]
    [SerializeField]
    private GameObject _spawnObject;
    [Tooltip("The amount of time in seconds between each spawn.")]
    [SerializeField]
    private float _timeBetweenSpawns;
    [Tooltip("If false, the spawner will stop instantiating clones of the reference.")]
    [SerializeField]
    private bool _canSpawn;

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
            Vector3 randomPos = new Vector3(Random.Range(-36, 36), 0, Random.Range(-36, 36));
            //Create a new orb in the scene
            GameObject spawnedOrb = Instantiate(_spawnObject, randomPos, new Quaternion());
            //Set the enemy target to be the target the spawner was given
            spawnedOrb.GetComponent<OrbBehaviour>().Point = _gameManager;
            //Pause for the given time in seconds before resuming the function
            yield return new WaitForSeconds(_timeBetweenSpawns);
        }
    }
}
