using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;    // 移動速度
    public float jumpForce = 5f;    // ジャンプ力
    private Rigidbody2D rb;         // Rigidbody2Dの参照
    private bool isGrounded = true; // 地面にいるかどうか
    public string targetLayerName = "TargetLayer"; // 衝突を検出するレイヤー名
    public string Exit;

    public GameObject projectilePrefab;  // 発射する球のPrefab
    public float projectileSpeed = 10f;  // 球の発射速度

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Rigidbody2Dを取得
    }

    void Update()
    {
        // 左右移動
        float moveX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveX * moveSpeed, rb.velocity.y);

        // スペースキーでジャンプ
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
        }

        // Eキーで球を発射
        if (Input.GetKeyDown(KeyCode.E))
        {
            ShootProjectile();
        }
    }

    // 地面に接触したときに呼ばれる
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true; // 地面にいる場合はジャンプを許可
        }
    }

    // 球を発射するメソッド
    void ShootProjectile()
    {
        // プレイヤーが向いている方向で球を発射
        GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);

        // 球の向きと速度を設定
        Rigidbody2D projectileRb = projectile.GetComponent<Rigidbody2D>();
        if (projectileRb != null)
        {
            float direction = transform.localScale.x > 0 ? 1 : -1; // プレイヤーの向きに基づく
            projectileRb.velocity = new Vector2(direction * projectileSpeed, 0); // 水平方向に発射
        }
    }
}