using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;    // �ړ����x
    public float jumpForce = 5f;    // �W�����v��
    private Rigidbody2D rb;         // Rigidbody2D�̎Q��
    private bool isGrounded = true; // �n�ʂɂ��邩�ǂ���
    public string targetLayerName = "TargetLayer"; // �Փ˂����o���郌�C���[��
    public string Exit;

    public GameObject projectilePrefab;  // ���˂��鋅��Prefab
    public float projectileSpeed = 10f;  // ���̔��ˑ��x

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Rigidbody2D���擾
    }

    void Update()
    {
        // ���E�ړ�
        float moveX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveX * moveSpeed, rb.velocity.y);

        // �X�y�[�X�L�[�ŃW�����v
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
        }

        // E�L�[�ŋ��𔭎�
        if (Input.GetKeyDown(KeyCode.E))
        {
            ShootProjectile();
        }
    }

    // �n�ʂɐڐG�����Ƃ��ɌĂ΂��
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true; // �n�ʂɂ���ꍇ�̓W�����v������
        }
    }

    // ���𔭎˂��郁�\�b�h
    void ShootProjectile()
    {
        // �v���C���[�������Ă�������ŋ��𔭎�
        GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);

        // ���̌����Ƒ��x��ݒ�
        Rigidbody2D projectileRb = projectile.GetComponent<Rigidbody2D>();
        if (projectileRb != null)
        {
            float direction = transform.localScale.x > 0 ? 1 : -1; // �v���C���[�̌����Ɋ�Â�
            projectileRb.velocity = new Vector2(direction * projectileSpeed, 0); // ���������ɔ���
        }
    }
}