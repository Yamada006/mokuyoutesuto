using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f; // 移動速度
    public float jumpForce = 10f; // ジャンプ力
    public GameObject bulletPrefab; // 弾のPrefab
    public Transform firePoint; // 弾の発射位置
    public float fireRate = 0.2f; // 発射間隔
    private float nextFireTime = 0f; // 次に弾を発射する時間

    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
        Jump();
        Fire();
    }

    // 左右の移動
    void Move()
    {
        float moveInput = Input.GetAxis("Horizontal");
        Vector2 moveVelocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
        rb.velocity = moveVelocity;
    }

    // ジャンプ
    void Jump()
    {
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 1f, LayerMask.GetMask("Floor"));
        if (isGrounded && Input.GetKeyDown(KeyCode.V))  // Wキーに変更
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    // 弾の発射
    void Fire()
    {
        if (Time.time >= nextFireTime && Input.GetKeyDown(KeyCode.Space))
        {
            nextFireTime = Time.time + fireRate; // 発射間隔を設定
            Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        }
    }
}
