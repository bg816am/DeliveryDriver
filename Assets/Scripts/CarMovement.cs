using UnityEngine;

public class CarMovement : MonoBehaviour
{
    // TODO: Have packages and power ups show up randomly
    // TODO: Have boost and slowdown work on a timer
    // TODO: Create a score screen
    [SerializeField] float steerSpeed = 20;
    [SerializeField] float driveSpeed = 100f;
    [SerializeField] float slowSpeed = 1f;
    [SerializeField] float speedUp = 1f;
    [SerializeField] float powerUpDelay = .5f;
    
    // Speed Boost 
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Boost")
        {
            driveSpeed = speedUp;
            Destroy(other.gameObject, powerUpDelay);
        }
    }
    // Slow Down
    private void OnCollisionEnter2D(Collision2D other) 
    {
        driveSpeed = slowSpeed;
    }

    void Update()
    {
        // Movement Scripting
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * driveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
