using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed = 5f; 

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < -10)
        {
            Destroy(gameObject);
            GameManager.instance.ObstaclePassed();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.GameOver();
        }
    }
}
