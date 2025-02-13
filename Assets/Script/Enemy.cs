using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameManager gameManager;  // GameManagerの参照

    void OnCollisionEnter2D(Collision2D collision)
    {
        // プレイヤーと衝突したとき
        if (collision.gameObject.CompareTag("Player"))
        {
            // ゲームオーバー処理
            if (gameManager != null)
            {
                gameManager.GameOver();  // ゲームオーバーを呼び出す
            }

            // 敵を削除
            Destroy(gameObject);
        }

        // 球（Projectile）と衝突したとき
        if (collision.gameObject.CompareTag("Projectile"))
        {
            // 敵を削除
            Destroy(gameObject);

            // スコアを増加させる（1ポイント）
            if (gameManager != null)
            {
                gameManager.IncreaseScore(1);  // スコアを1増加
            }
        }
    }
}