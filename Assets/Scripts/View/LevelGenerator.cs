using System.ComponentModel;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private ChunkInfo[] _chunks;
    [SerializeField] private int _numberOfChunksPerLevel;
    [SerializeField] private int _firstChunkOffset;

    private void Awake()
    {
        ChunkInfo previousChunk = Instantiate(
            _chunks[Random.Range(0, _chunks.Length)],
            new Vector2(0, _firstChunkOffset),
            Quaternion.identity);

        for (int x = 1;  x < _numberOfChunksPerLevel; x++)
        {
            ChunkInfo chunk = Instantiate(
                _chunks[Random.Range(0, _chunks.Length)], 
                new Vector2(0, previousChunk.transform.position.y + previousChunk.ChunkHeight), 
                Quaternion.identity);
            
            previousChunk = chunk;
        }
    }
}
