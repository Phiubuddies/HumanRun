using UnityEngine;

public class HumanJump : MonoBehaviour
{
    public float jumpForce = 12f;
    private Rigidbody2D rb;
    private bool isGrounded = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Loncat saat tekan panah atas
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            isGrounded = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Deteksi nyentuh tanah (apa aja yang punya collider)
        isGrounded = true;
    }
}
