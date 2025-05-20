using UnityEngine;
using UnityEngine.SceneManagement;


public class BatuGerak1 : MonoBehaviour
{
    public float speed = 2f;
    public float leftBound = -10f;
    public float rightStartX = 10f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // Kasih kecepatan ke kiri
        rb.linearVelocity = new Vector2(-speed, rb.linearVelocity.y);

        // Reset posisi kalau udah lewat batas kiri
        if (transform.position.x < leftBound)
        {
            Vector3 pos = transform.position;
            pos.x = rightStartX;
            transform.position = pos;

            // Reset velocity biar gak nge-bug
            rb.linearVelocity = new Vector2(-speed, rb.linearVelocity.y);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("GameOver"); // ganti nama sesuai scene lo
        }
    }
}

