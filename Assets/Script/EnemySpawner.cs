using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;  // 生成する敵のプレハブ
    public float spawnInterval = 2f; // 敵を生成する間隔（秒）

    void Start()
    {
        // 初回の敵生成を遅延させてスタート
        InvokeRepeating("SpawnEnemy", 0f, spawnInterval);
    }

    void SpawnEnemy()
    {
        // 画面内に敵を生成
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
    }
}