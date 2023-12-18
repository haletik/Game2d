using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _prefab;
    [SerializeField]
    private float _spawnRangeX;
    [SerializeField]
    private float _spawnSecondsInterval;

    public void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while(true)
        {
            float x = Random.Range(-_spawnRangeX, _spawnRangeX);
            Vector2 spawnPosition = new Vector2(x, transform.position.y);
            Instantiate(_prefab, spawnPosition, Quaternion.identity);
            
            yield return new WaitForSeconds(_spawnSecondsInterval);
        }
    }
}