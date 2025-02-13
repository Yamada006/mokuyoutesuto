using UnityEngine;

public class Square : MonoBehaviour
{
    public GameManager gameManager;  // �Q�[���}�l�[�W���[�̎Q��

    void OnCollisionEnter2D(Collision2D collision)
    {
        // �v���C���[�ƏՓ˂����ꍇ
        if (collision.gameObject.CompareTag("Player"))
        {
            // �Q�[���I�[�o�[�������Ăяo��
            if (gameManager != null)
            {
                gameManager.GameOver();  // �Q�[���I�[�o�[���Ăяo��
            }

            // �v���C���[���폜
            Destroy(collision.gameObject);
        }
    }
}