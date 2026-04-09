using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 7f;
    public Transform ground;
    public float groundRadius = 0.2f;
    public LayerMask groundLayer;

    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private bool isGrounded;
    private int jumpCount;
    public int maxJump = 2;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        Debug.Log("Script ini jalan wok");
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(ground.position, groundRadius, groundLayer);
        if (isGrounded)
        {
            jumpCount = 0;
        }

        // Ambil input kiri kanan
        float move = Input.GetAxis("Horizontal");

            // Gerakkan player
            rb.linearVelocity = new Vector2(move * speed, rb.linearVelocity.y);

        // Kirim nilai ke Animator
        animator.SetFloat("Speed", Mathf.Abs(move));

        if (move > 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (move < 0)
        {
            spriteRenderer.flipX = true;
        }

        // Lompat
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < maxJump)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            jumpCount++;
        }
    }
}