using UnityEngine;

public class Square : MonoBehaviour
{
    public GameManager gameManager;  // ゲームマネージャーの参照

    void OnCollisionEnter2D(Collision2D collision)
    {
        // プレイヤーと衝突した場合
        if (collision.gameObject.CompareTag("Player"))
        {
            // ゲームオーバー処理を呼び出す
            if (gameManager != null)
            {
                gameManager.GameOver();  // ゲームオーバーを呼び出す
            }

            // プレイヤーを削除
            Destroy(collision.gameObject);
        }
    }
}