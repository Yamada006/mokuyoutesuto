using UnityEngine;
using UnityEngine.UI;  // UI��Text�R���|�[�l���g���g�����߂ɕK�v

public class GameManager : MonoBehaviour
{
    public Text scoreText;  // �X�R�A�\���p��UI�e�L�X�g
    public Text gameOverText;  // �Q�[���I�[�o�[�\���p��UI�e�L�X�g
    public GameObject player;  // �v���C���[�I�u�W�F�N�g

    private int score = 0;  // �X�R�A

    void Start()
    {
        // �Q�[���J�n���̐ݒ�
        gameOverText.gameObject.SetActive(false);
        scoreText.text = "Score: " + score;  // �����X�R�A�\��
    }

    // �X�R�A�𑝉������郁�\�b�h
    public void IncreaseScore(int points)
    {
        score += points;  // �|�C���g�����Z
        scoreText.text = "Score: " + score;  // �X�R�A�\�����X�V
    }

    // �Q�[���I�[�o�[����
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        gameOverText.text = "Game Over!";  // �Q�[���I�[�o�[�e�L�X�g��\��
        player.SetActive(false);  // �v���C���[�I�u�W�F�N�g���\���ɂ���
    }
}