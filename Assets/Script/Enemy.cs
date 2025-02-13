using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameManager gameManager;  // GameManager�̎Q��

    void OnCollisionEnter2D(Collision2D collision)
    {
        // �v���C���[�ƏՓ˂����Ƃ�
        if (collision.gameObject.CompareTag("Player"))
        {
            // �Q�[���I�[�o�[����
            if (gameManager != null)
            {
                gameManager.GameOver();  // �Q�[���I�[�o�[���Ăяo��
            }

            // �G���폜
            Destroy(gameObject);
        }

        // ���iProjectile�j�ƏՓ˂����Ƃ�
        if (collision.gameObject.CompareTag("Projectile"))
        {
            // �G���폜
            Destroy(gameObject);

            // �X�R�A�𑝉�������i1�|�C���g�j
            if (gameManager != null)
            {
                gameManager.IncreaseScore(1);  // �X�R�A��1����
            }
        }
    }
}