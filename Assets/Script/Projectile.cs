using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10f;  // 球の速度

    void Update()
    {
        // 球を右にまっすぐ飛ばす
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // 敵や他のオブジェクトと衝突したときの処理
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // ここで弾と敵の衝突を処理する
            Destroy(gameObject);  // 球を削除
        }
    }
}