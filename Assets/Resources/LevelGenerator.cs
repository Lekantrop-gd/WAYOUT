using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private ChunkInfo[] _chunks;
    [SerializeField] private int _numberOfChunksOnLevel;

    private void Awake()
    {
        ChunkInfo previousChunk = Instantiate(_chunks[Random.Range(0, _chunks.Length)], new Vector2(0, 10), Quaternion.identity);
        for (int x = 1;  x < _numberOfChunksOnLevel; x++)
        {
            ChunkInfo chunk = Instantiate(_chunks[Random.Range(0, _chunks.Length)], new Vector2(0, previousChunk.transform.position.y + previousChunk.ChunkHeight), Quaternion.identity);
            previousChunk = chunk;
        }
    }
}
