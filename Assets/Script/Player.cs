using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f; // �ړ����x
    public float jumpForce = 10f; // �W�����v��
    public GameObject bulletPrefab; // �e��Prefab
    public Transform firePoint; // �e�̔��ˈʒu
    public float fireRate = 0.2f; // ���ˊԊu
    private float nextFireTime = 0f; // ���ɒe�𔭎˂��鎞��

    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
        Jump();
        Fire();
    }

    // ���E�̈ړ�
    void Move()
    {
        float moveInput = Input.GetAxis("Horizontal");
        Vector2 moveVelocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
        rb.velocity = moveVelocity;
    }

    // �W�����v
    void Jump()
    {
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 1f, LayerMask.GetMask("Floor"));
        if (isGrounded && Input.GetKeyDown(KeyCode.V))  // W�L�[�ɕύX
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    // �e�̔���
    void Fire()
    {
        if (Time.time >= nextFireTime && Input.GetKeyDown(KeyCode.Space))
        {
            nextFireTime = Time.time + fireRate; // ���ˊԊu��ݒ�
            Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        }
    }
}
