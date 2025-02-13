using UnityEngine;
using UnityEngine.UI;  // UIのTextコンポーネントを使うために必要

public class GameManager : MonoBehaviour
{
    public Text scoreText;  // スコア表示用のUIテキスト
    public Text gameOverText;  // ゲームオーバー表示用のUIテキスト
    public GameObject player;  // プレイヤーオブジェクト

    private int score = 0;  // スコア

    void Start()
    {
        // ゲーム開始時の設定
        gameOverText.gameObject.SetActive(false);
        scoreText.text = "Score: " + score;  // 初期スコア表示
    }

    // スコアを増加させるメソッド
    public void IncreaseScore(int points)
    {
        score += points;  // ポイントを加算
        scoreText.text = "Score: " + score;  // スコア表示を更新
    }

    // ゲームオーバー処理
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        gameOverText.text = "Game Over!";  // ゲームオーバーテキストを表示
        player.SetActive(false);  // プレイヤーオブジェクトを非表示にする
    }
}