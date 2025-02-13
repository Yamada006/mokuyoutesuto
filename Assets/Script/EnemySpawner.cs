using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;  // ��������G�̃v���n�u
    public float spawnInterval = 2f; // �G�𐶐�����Ԋu�i�b�j

    void Start()
    {
        // ����̓G������x�������ăX�^�[�g
        InvokeRepeating("SpawnEnemy", 0f, spawnInterval);
    }

    void SpawnEnemy()
    {
        // ��ʓ��ɓG�𐶐�
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
    }
}