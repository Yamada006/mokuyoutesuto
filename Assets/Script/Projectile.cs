using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10f;  // ���̑��x

    void Update()
    {
        // �����E�ɂ܂�������΂�
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // �G�⑼�̃I�u�W�F�N�g�ƏՓ˂����Ƃ��̏���
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // �����Œe�ƓG�̏Փ˂���������
            Destroy(gameObject);  // �����폜
        }
    }
}