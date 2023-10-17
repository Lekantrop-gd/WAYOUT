using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private ChunkInfo[] _chunksInfo;
    [SerializeField] private int _numberOfChunks;

    private void Awake()
    {
        ChunkInfo previousChunk = Instantiate(_chunksInfo[Random.Range(0, _chunksInfo.Length)], new Vector2(0, 10), Quaternion.identity);
        for (int x = 1;  x < _numberOfChunks; x++)
        {
            ChunkInfo chunk = Instantiate(_chunksInfo[Random.Range(0, _chunksInfo.Length)], new Vector2(0, previousChunk.transform.position.y + previousChunk.ChunkHeight), Quaternion.identity);
            previousChunk = chunk;
        }
    }
}
