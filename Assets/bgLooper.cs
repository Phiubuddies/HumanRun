using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    public float speed = 2f;              // Kecepatan gerak
    public float backgroundWidth = 20f;   // Ukuran lebar gambar background

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        // Kalau sudah lewat batas kiri, reset posisi ke kanan
        if (transform.position.x <= -backgroundWidth)
        {
            transform.position += new Vector3(backgroundWidth * 2f, 0, 0);
        }
    }
}
