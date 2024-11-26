using UnityEngine;

public class BossMover : MonoBehaviour
{
    public float speed = 5f; // Speed of the enemy ship
    private float direction = 1f; // Direction of movement (1 = right, -1 = left)

    private float minX;
    private float maxX;

    void Start()
    {
        // Get the main camera
        Camera mainCamera = Camera.main;

        // Calculate the camera's visible boundaries in world space
        float camHeight = 2f * mainCamera.orthographicSize;
        float camWidth = camHeight * mainCamera.aspect;

        // Set the horizontal boundaries
        minX = mainCamera.transform.position.x - camWidth / 2;
        maxX = mainCamera.transform.position.x + camWidth / 2;
    }

    void Update()
    {
        // Move the ship
        transform.Translate(Vector3.right * speed * direction * Time.deltaTime);

        // Check boundaries and reverse direction if needed
        if (transform.position.x >= maxX)
        {
            direction = -1f; // Move left
            transform.position = new Vector3(maxX, transform.position.y, transform.position.z);
        }
        else if (transform.position.x <= minX)
        {
            direction = 1f; // Move right
            transform.position = new Vector3(minX, transform.position.y, transform.position.z);
        }
    }
}
