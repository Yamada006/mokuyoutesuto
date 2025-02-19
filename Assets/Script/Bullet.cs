using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;

    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.right * speed; // 右に進む
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject); // 衝突したら弾を消す
    }
}