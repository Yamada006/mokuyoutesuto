using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;

    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.right * speed; // �E�ɐi��
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject); // �Փ˂�����e������
    }
}