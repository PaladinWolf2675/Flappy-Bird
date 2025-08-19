using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float pipeSpawnRate = 1.0f;
    public float minHeight = -1.0f;
    public float maxHeight = 1.0f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(SpawnPipe), pipeSpawnRate, pipeSpawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(SpawnPipe));
    }

    private void SpawnPipe()
    {
       GameObject pipes = Instantiate(pipePrefab, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }
}
