using UnityEngine;

using Random = UnityEngine.Random;

public class SpawnerPipes : MonoBehaviour
{
    [SerializeField] private GameObject _pipes;
    [SerializeField] private float _spawnRate = 1f;
    [SerializeField] private float minHeight = -1f;
    [SerializeField] private float maxHeight = 1f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), _spawnRate, _spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        GameObject pipes = Instantiate(_pipes, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minHeight,maxHeight);
    }
}