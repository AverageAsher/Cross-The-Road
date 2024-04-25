using UnityEngine;

public class CarAnimation : MonoBehaviour
{
    public float speed = 2f; // Speed of downward movement
    public float scaleSpeed = 0.02f; // Speed of scaling up
    public Vector3 originalPosition; // Store the original position of the car

    void Start()
    {
        originalPosition = transform.position; // Save the original position
    }

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime); // Move the car downwards
        transform.localScale += Vector3.one * scaleSpeed * Time.deltaTime; // Scale up the car
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("carRespawn")) // Replace "Obstacle" with the tag of your collider
        {
            // Reset position to original position
            transform.position = originalPosition;
            transform.localScale = Vector3.zero; // Reset scale to 1

            // Optionally, you can add additional logic here
        }
    }
}