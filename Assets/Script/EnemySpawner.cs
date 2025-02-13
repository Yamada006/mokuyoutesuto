using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;  // ¶¬‚·‚é“G‚ÌƒvƒŒƒnƒu
    public float spawnInterval = 2f; // “G‚ğ¶¬‚·‚éŠÔŠui•bj

    void Start()
    {
        // ‰‰ñ‚Ì“G¶¬‚ğ’x‰„‚³‚¹‚ÄƒXƒ^[ƒg
        InvokeRepeating("SpawnEnemy", 0f, spawnInterval);
    }

    void SpawnEnemy()
    {
        // ‰æ–Ê“à‚É“G‚ğ¶¬
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
    }
}