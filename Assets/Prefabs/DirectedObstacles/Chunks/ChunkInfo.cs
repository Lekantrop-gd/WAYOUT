using UnityEngine;

public class ChunkInfo : MonoBehaviour
{
    [SerializeField] private int _chunkHeight;

    public int ChunkHeight { get { return _chunkHeight; } }
}
